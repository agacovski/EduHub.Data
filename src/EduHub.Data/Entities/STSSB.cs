using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// School Saving Bonus Vouchers
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class STSSB : EduHubEntity
    {

        #region Navigation Property Cache

        private ST Cache_SKEY_ST;

        #endregion

        /// <inheritdoc />
        public override DateTime? EntityLastModified
        {
            get
            {
                return null;
            }
        }

        #region Field Properties

        /// <summary>
        /// Student key
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string SKEY { get; internal set; }

        /// <summary>
        /// Voucher Type
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string VOUCHER_TYPE { get; internal set; }

        /// <summary>
        /// Activities Balance
        /// </summary>
        public decimal? ACTIVITIES_BAL { get; internal set; }

        #endregion

        #region Navigation Properties

        /// <summary>
        /// ST (Students) related entity by [STSSB.SKEY]-&gt;[ST.STKEY]
        /// Student key
        /// </summary>
        public ST SKEY_ST
        {
            get
            {
                if (Cache_SKEY_ST == null)
                {
                    Cache_SKEY_ST = Context.ST.FindBySTKEY(SKEY);
                }

                return Cache_SKEY_ST;
            }
        }

        #endregion

    }
}
