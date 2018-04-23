using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraEditors;
using System.ComponentModel;

namespace EditorDescendant
{
    [System.ComponentModel.DesignerCategory("")]
    public class MyRadioGroup : RadioGroup
    {

        #region Service
        static MyRadioGroup()
        {
            MyRepositoryItemRadioGroup.Register();
        }

        public MyRadioGroup()
        { }

        public override string EditorTypeName
        { get { return MyRepositoryItemRadioGroup.EditorName; } }
        
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new MyRepositoryItemRadioGroup Properties
        { get { return base.Properties as MyRepositoryItemRadioGroup; } }


     #endregion
    }
}
