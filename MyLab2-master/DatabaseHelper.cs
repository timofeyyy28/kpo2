using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public static class DatabaseHelper
{
    private static string ConnectionString => ConfigurationManager.ConnectionStrings["PerfumeShopDB"].ConnectionString;

    // ============= Brands =============
    public static DataTable GetBrands()
    {
        using (var conn = new SqlConnection(ConnectionString))
        {
            var cmd = new SqlCommand("SELECT * FROM Brands", conn);
            var adapter = new SqlDataAdapter(cmd);
            var dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }

    public static int AddBrand(string name)
    {
        using (var conn = new SqlConnection(ConnectionString))
        {
            conn.Open();
            var cmd = new SqlCommand(
                "INSERT INTO Brands (Name) VALUES (@Name); SELECT SCOPE_IDENTITY();",
                conn);
            cmd.Parameters.AddWithValue("@Name", name);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }
    }

    public static bool UpdateBrand(int id, string newName)
    {
        using (var conn = new SqlConnection(ConnectionString))
        {
            conn.Open();
            var cmd = new SqlCommand(
                "UPDATE Brands SET Name = @Name WHERE Id = @Id",
                conn);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.Parameters.AddWithValue("@Name", newName);
            return cmd.ExecuteNonQuery() > 0;
        }
    }

    public static bool DeleteBrand(int id)
    {
        using (var conn = new SqlConnection(ConnectionString))
        {
            conn.Open();
            var cmd = new SqlCommand("DELETE FROM Brands WHERE Id = @Id", conn);
            cmd.Parameters.AddWithValue("@Id", id);
            return cmd.ExecuteNonQuery() > 0;
        }
    }

    // ============= Perfumes =============
    public static DataTable GetPerfumesByBrand(int brandId)
    {
        using (var conn = new SqlConnection(ConnectionString))
        {
            var cmd = new SqlCommand(
                "SELECT Id, Name, BrandId, Season, Description FROM Perfumes WHERE BrandId = @BrandId",
                conn);
            cmd.Parameters.AddWithValue("@BrandId", brandId);
            var adapter = new SqlDataAdapter(cmd);
            var dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }

    public static DataTable GetPerfumeById(int id)
    {
        using (var conn = new SqlConnection(ConnectionString))
        {
            var cmd = new SqlCommand(
                "SELECT * FROM Perfumes WHERE Id = @Id",
                conn);
            cmd.Parameters.AddWithValue("@Id", id);
            var adapter = new SqlDataAdapter(cmd);
            var dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }

    public static int AddPerfume(string name, int brandId, string season, string description)
    {
        using (var conn = new SqlConnection(ConnectionString))
        {
            conn.Open();
            var cmd = new SqlCommand(
                @"INSERT INTO Perfumes (Name, BrandId, Season, Description) 
                VALUES (@Name, @BrandId, @Season, @Description); 
                SELECT SCOPE_IDENTITY();",
                conn);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@BrandId", brandId);
            cmd.Parameters.AddWithValue("@Season", season ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Description", description ?? (object)DBNull.Value);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }
    }

    public static bool UpdatePerfume(int id, string name, int brandId, string season, string description)
    {
        using (var conn = new SqlConnection(ConnectionString))
        {
            conn.Open();
            var cmd = new SqlCommand(
                @"UPDATE Perfumes 
                SET Name = @Name, BrandId = @BrandId, 
                    Season = @Season, Description = @Description
                WHERE Id = @Id",
                conn);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@BrandId", brandId);
            cmd.Parameters.AddWithValue("@Season", season ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Description", description ?? (object)DBNull.Value);
            return cmd.ExecuteNonQuery() > 0;
        }
    }

    public static bool DeletePerfume(int id)
    {
        using (var conn = new SqlConnection(ConnectionString))
        {
            conn.Open();
            var cmd = new SqlCommand("DELETE FROM Perfumes WHERE Id = @Id", conn);
            cmd.Parameters.AddWithValue("@Id", id);
            return cmd.ExecuteNonQuery() > 0;
        }
    }

    // ============= Notes =============
    public static DataTable GetAllNotes()
    {
        using (var conn = new SqlConnection(ConnectionString))
        {
            var cmd = new SqlCommand("SELECT * FROM Notes", conn);
            var adapter = new SqlDataAdapter(cmd);
            var dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }

    // ============= PerfumeNotes =============
    public static DataTable GetNotesByPerfume(int perfumeId)
    {
        using (var conn = new SqlConnection(ConnectionString))
        {
            var cmd = new SqlCommand(
                @"SELECT n.Id, n.Name, pn.NoteType 
                FROM Notes n
                JOIN PerfumeNotes pn ON n.Id = pn.NoteId
                WHERE pn.PerfumeId = @PerfumeId",
                conn);
            cmd.Parameters.AddWithValue("@PerfumeId", perfumeId);
            var adapter = new SqlDataAdapter(cmd);
            var dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }

    public static bool AddNoteToPerfume(int perfumeId, int noteId, string noteType)
    {
        using (var conn = new SqlConnection(ConnectionString))
        {
            conn.Open();
            var cmd = new SqlCommand(
                "INSERT INTO PerfumeNotes (PerfumeId, NoteId, NoteType) VALUES (@PerfumeId, @NoteId, @NoteType)",
                conn);
            cmd.Parameters.AddWithValue("@PerfumeId", perfumeId);
            cmd.Parameters.AddWithValue("@NoteId", noteId);
            cmd.Parameters.AddWithValue("@NoteType", noteType);
            return cmd.ExecuteNonQuery() > 0;
        }
    }

    public static bool DeletePerfumeNote(int perfumeId, int noteId)
    {
        using (var conn = new SqlConnection(ConnectionString))
        {
            conn.Open();
            var cmd = new SqlCommand(
                "DELETE FROM PerfumeNotes WHERE PerfumeId = @PerfumeId AND NoteId = @NoteId",
                conn);
            cmd.Parameters.AddWithValue("@PerfumeId", perfumeId);
            cmd.Parameters.AddWithValue("@NoteId", noteId);
            return cmd.ExecuteNonQuery() > 0;
        }
    }

    // ============= Utility Methods =============
    public static DataTable GetSeasons()
    {
        using (var conn = new SqlConnection(ConnectionString))
        {
            var cmd = new SqlCommand("SELECT * FROM Seasons", conn);
            var adapter = new SqlDataAdapter(cmd);
            var dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }

    public static DataTable GetNoteTypes()
    {
        var dt = new DataTable();
        dt.Columns.Add("Type");
        dt.Rows.Add("Top");
        dt.Rows.Add("Middle");
        dt.Rows.Add("Base");
        return dt;
    }
}