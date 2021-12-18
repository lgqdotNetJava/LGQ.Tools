using LGQ.Tools.Share;
using System;

namespace OAModule.Entities
{
    /// <summary>
    /// 工单
    /// </summary>
    public class WorkOrder : NotifyPropertyChangedEntity
    {
        private int m_ID;
        /// <summary>
        /// ID
        /// </summary>
        public int ID
        {
            get { return m_ID; }
            set { m_ID = value; OnPropertyChanged(); }
        }

        private int m_OA_ID;
        /// <summary>
        /// OA关联表ID
        /// </summary>
        public int OA_ID
        {
            get { return m_OA_ID; }
            set { m_OA_ID = value; OnPropertyChanged(); }
        }

        private string m_OrderName;
        /// <summary>
        /// 工单名称
        /// </summary>
        public string OrderName
        {
            get { return m_OrderName; }
            set { m_OrderName = value; OnPropertyChanged(); }
        }

        private string m_OrderDesc;
        /// <summary>
        /// 工单详细
        /// </summary>
        public string OrderDesc
        {
            get { return m_OrderDesc; }
            set { m_OrderDesc = value; OnPropertyChanged(); }
        }

        private DateTime m_BeginDate;
        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime BeginDate
        {
            get { return m_BeginDate; }
            set { m_BeginDate = value; OnPropertyChanged(); }
        }

        private DateTime m_EndDate;
        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime EndDate
        {
            get { return m_EndDate; }
            set { m_EndDate = value; OnPropertyChanged(); }
        }

        private int m_OrderStatus;
        /// <summary>
        /// 工单状态
        /// </summary>
        public int OrderStatus
        {
            get { return m_OrderStatus; }
            set { m_OrderStatus = value; OnPropertyChanged(); }
        }

        private int m_PublishStatus;
        /// <summary>
        /// 工单发布状态
        /// </summary>
        public int publishStatus
        {
            get { return m_PublishStatus; }
            set { m_PublishStatus = value; OnPropertyChanged(); }
        }
    }
}
