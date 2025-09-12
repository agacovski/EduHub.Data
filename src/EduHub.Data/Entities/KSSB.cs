#if !EduHubScoped
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// School Saving Bonus Trns
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KSSB : EduHubEntity
    {

        #region Navigation Property Cache

        private CR Cache_CRKEY_CR;
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
        /// Prime Key
        /// </summary>
        public int TID { get; internal set; }

        /// <summary>
        /// Transaction ID
        /// [Alphanumeric (20)]
        /// </summary>
        public string TRAN_ID { get; internal set; }

        /// <summary>
        /// Transaction Key to CR table
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string CRKEY { get; internal set; }

        /// <summary>
        /// Student Key
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string SKEY { get; internal set; }

        /// <summary>
        /// Date of voucher issuance/redemption???
        /// </summary>
        public DateTime? TRDATE { get; internal set; }

        /// <summary>
        /// The transaction id for the online redemption of a voucher
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string ONLINE_VOUCHER { get; internal set; }

        /// <summary>
        /// The voucher key
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string VOUCHER_CODE { get; internal set; }

        /// <summary>
        /// Item Category
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string ITEM_CATEGORY { get; internal set; }

        /// <summary>
        /// Transaction Type
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string TRAN_TYPE { get; internal set; }

        /// <summary>
        /// Transaction Amount
        /// </summary>
        public decimal? TRAN_AMT { get; internal set; }

        /// <summary>
        /// Tid of related DFF transaction
        /// </summary>
        public int? DFF_TID { get; internal set; }

        /// <summary>
        /// Tid of related CRF transaction
        /// </summary>
        public int? CRF_TID { get; internal set; }

        /// <summary>
        /// Y/N Flag. Y means school intends to create creditor invoice for this now.
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string TO_INVOICE { get; internal set; }

        /// <summary>
        /// Last write date
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }

        /// <summary>
        /// Last write time
        /// </summary>
        public short? LW_TIME { get; internal set; }

        /// <summary>
        /// Last operator
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string LW_USER { get; internal set; }

        #endregion

        #region Navigation Properties

        /// <summary>
        /// CR (Accounts Payable) related entity by [KSSB.CRKEY]-&gt;[CR.CRKEY]
        /// Transaction Key to CR table
        /// </summary>
        public CR CRKEY_CR
        {
            get
            {
                if (CRKEY == null)
                {
                    return null;
                }
                if (Cache_CRKEY_CR == null)
                {
                    Cache_CRKEY_CR = Context.CR.FindByCRKEY(CRKEY);
                }

                return Cache_CRKEY_CR;
            }
        }

        /// <summary>
        /// ST (Students) related entity by [KSSB.SKEY]-&gt;[ST.STKEY]
        /// Student Key
        /// </summary>
        public ST SKEY_ST
        {
            get
            {
                if (SKEY == null)
                {
                    return null;
                }
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
