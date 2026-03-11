namespace EduHub.Data.SchemaParser.Db
{
    public class SysIndexColumn
    {
        public int ObjectId { get; set; }
        public int IndexId { get; set; }
        public int ColumnId { get; set; }
        public byte? KeyOrdinal { get; set; }
    }
}
