using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class PeopleModel
    {
        /// <summary>
        /// 编号
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// 名字
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// 联系电话
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string BeiZ { get; set; }

    }
    public class ProductSystem : DbContext
    {
        public ProductSystem()
            : base("ProductSystem")
        {
            this.Configuration.ProxyCreationEnabled = true;
        }
        //    public DbSet<HuopeModel> HuopeModels{get;eset;}
        public DbSet<PeopleModel> People { get; set; }
    }
}