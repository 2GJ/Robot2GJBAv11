using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotBA2GJv11.cls
{
    public class FileEntity
    {
        public Int64 Id { get; set; }
        public string NameEntity { get; set; }
        public List<ColFileEntity> ColumnsEntity { get; set; }
        public List<RowsFileEntity> RowsEntity { get; set; }

        public FileEntity(string NameIn)
        {
            this.Id = 1;
            this.NameEntity = NameIn;
            this.ColumnsEntity = new List<ColFileEntity>();
            this.RowsEntity = new List<RowsFileEntity>();
        }
    }

    public class ColFileEntity
    {
        public Int16 Id { get; set; }
        public string NameCol { get; set; }
        //public List<RowFileEntity> Rows { get; set; }

        public ColFileEntity(Int16 IdIn, string NameIn)
        {
            this.Id = IdIn;
            this.NameCol = NameIn;
        }
    }

    public class RowsFileEntity
    {
        public Int64 Id { get; set; } 
        public List<RowColFileEntity> Values { get; set; }
   
        public RowsFileEntity(Int64 IdIn)
        {
            this.Id = IdIn;
            this.Values = new List<RowColFileEntity>();
        }
    }

    public class RowColFileEntity
    {
        public Int16 Id { get; set; }
        public String Value { get; set; }

        public RowColFileEntity(Int16 IdIn, String ValueIn)
        {
            this.Id = IdIn;
            this.Value = ValueIn;
        }
    }
}
