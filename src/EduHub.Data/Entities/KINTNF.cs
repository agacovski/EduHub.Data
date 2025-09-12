#if !EduHubScoped
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Expelled International Students
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KINTNF : EduHubEntity
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
        /// Prime Key
        /// </summary>
        public int TID { get; internal set; }

        /// <summary>
        /// First Name
        /// [Alphanumeric (20)]
        /// </summary>
        public string FIRST_NAME { get; internal set; }

        /// <summary>
        /// Surname
        /// [Alphanumeric (30)]
        /// </summary>
        public string SURNAME { get; internal set; }

        /// <summary>
        /// Paid Flag
        /// [Alphanumeric (1)]
        /// </summary>
        public string PAID_FLAG { get; internal set; }

        /// <summary>
        /// Payment Plan
        /// [Alphanumeric (1)]
        /// </summary>
        public string PAYMENT_PLAN { get; internal set; }

        /// <summary>
        /// Birth Date
        /// </summary>
        public DateTime? BIRTHDATE { get; internal set; }

        /// <summary>
        /// Y/N field. See CP-3858
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string DELETE_FLAG { get; internal set; }

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

    }
}
#endif
