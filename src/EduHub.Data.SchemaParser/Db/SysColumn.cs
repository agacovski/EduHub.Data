namespace EduHub.Data.SchemaParser.Db
{
    public class SysColumn
    {
        public int ObjectId { get; set; }
        public string Name { get; set; }
        public int ColumnId { get; set; }
        public int UserTypeId { get; set; }
        public int MaxLength { get; set; }
        public bool? IsNullable { get; set; }
        public bool? IsIdentity { get; set; }
    }
}
