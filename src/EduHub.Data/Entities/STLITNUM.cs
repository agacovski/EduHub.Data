#if !EduHubScoped
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Literacy and Numeracy Programs
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class STLITNUM : EduHubEntity
    {

        #region Navigation Property Cache

        private ST Cache_SKEY_ST;

        #endregion

        /// <inheritdoc />
        public override DateTime? EntityLastModified
        {
            get
            {
                return LW_DATE;
            }
        }

        #region Field Properties

        /// <summary>
        /// Transaction ID (internal)
        /// </summary>
        public int TID { get; internal set; }

        /// <summary>
        /// Student ID
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string SKEY { get; internal set; }

        /// <summary>
        /// Focus Type
        /// [Alphanumeric (30)]
        /// </summary>
        public string FOCUS { get; internal set; }

        /// <summary>
        /// Practice model
        /// [Alphanumeric (15)]
        /// </summary>
        public string DEL_MODEL { get; internal set; }

        /// <summary>
        /// Session Length
        /// [Alphanumeric (20)]
        /// </summary>
        public string SESSION_LENGTH { get; internal set; }

        /// <summary>
        /// Session Frequency
        /// [Alphanumeric (30)]
        /// </summary>
        public string SESSION_FREQ { get; internal set; }

        /// <summary>
        /// Last write date
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }

        /// <summary>
        /// Last write time
        /// </summary>
        public short? LW_TIME { get; internal set; }

        /// <summary>
        /// Last write operator
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string LW_USER { get; internal set; }

        #endregion

        #region Navigation Properties

        /// <summary>
        /// ST (Students) related entity by [STLITNUM.SKEY]-&gt;[ST.STKEY]
        /// Student ID
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
#endif
