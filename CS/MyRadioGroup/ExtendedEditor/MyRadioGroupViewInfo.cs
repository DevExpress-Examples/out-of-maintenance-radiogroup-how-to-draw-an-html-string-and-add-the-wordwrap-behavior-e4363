using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors.Controls;
using System.Drawing;
using System.Windows.Forms;

namespace EditorDescendant
{
    public class MyRadioGroupViewInfo : RadioGroupViewInfo
    {
        public MyRadioGroupViewInfo(RepositoryItem item)
            : base(item)
        {}



        protected override RadioGroupItemViewInfo CreateItemInfo(DevExpress.XtraEditors.Controls.RadioGroupItem item)
        {
            CheckObjectInfoArgs info = ((CheckObjectInfoArgs)base.CreateItemInfo(item));
            info.AllowHtmlString = ((MyRepositoryItemRadioGroup)OwnerEdit.Properties).AllowHtmlString;

            return (RadioGroupItemViewInfo)info;
        }


        protected override int MinItemHeight
        {
            get
            {
                int heght = ((MyRepositoryItemRadioGroup)OwnerEdit.Properties).MinItemHeight;
                return heght;
            }
        }
    }
}
