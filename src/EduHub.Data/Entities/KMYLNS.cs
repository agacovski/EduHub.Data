#if !EduHubScoped
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// MYLNS Funding
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KMYLNS : EduHubEntity
    {

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
        /// Prime key
        /// </summary>
        public int KMYLNSKEY { get; internal set; }

        /// <summary>
        /// Six digit School/campus ID
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string SCHOOL { get; internal set; }

        /// <summary>
        /// Four Digit Department-defined school ID
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string SCHOOL_ID { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// [Alphanumeric (50)]
        /// </summary>
        public string SCHOOL_NAME { get; internal set; }

        /// <summary>
        /// Active/Inactive (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ACTIVE { get; internal set; }

        /// <summary>
        /// Last write date
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }

        /// <summary>
        /// Last write time
        /// </summary>
        public short? LW_TIME { get; internal set; }

        /// <summary>
        /// Last write user
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string LW_USER { get; internal set; }

        #endregion

    }
}
#endif
