using System;

namespace EduHub.Data.SchemaParser.Db
{
    public class SysIndex
    {
        public int ObjectId { get; set; }
        public string Name { get; set; }
        public int IndexId { get; set; }
        public int TypeId { private get; set; }
        public string TypeDesc { private get; set; }
        public bool? IsUnique { get; set; }
        public bool? IsPrimaryKey { get; set; }

        public SysIndexType Type => TypeId >= 0 ? (SysIndexType)TypeId : (SysIndexType)Enum.Parse(typeof(SysIndexType), TypeDesc, true);
    }

    public enum SysIndexType
    {
        Heap = 0,
        Clustered = 1,
        NonClustered = 2,
    }
}
