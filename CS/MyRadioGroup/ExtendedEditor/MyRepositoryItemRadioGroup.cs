using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Drawing;

namespace EditorDescendant
{
    [System.ComponentModel.DesignerCategory("")]
    public class MyRepositoryItemRadioGroup : RepositoryItemRadioGroup
    {
        #region Service

        static MyRepositoryItemRadioGroup()
        {
            Register();
        }

        public MyRepositoryItemRadioGroup()
        {
            MinItemHeight = 20;
            AllowHtmlString = true;
        }
        internal const string EditorName = "MyRadioGroup";

        public static void Register()
        {
            EditorRegistrationInfo.Default.Editors.Add(
                new EditorClassInfo(EditorName, typeof(MyRadioGroup),
                typeof(MyRepositoryItemRadioGroup),
                typeof(MyRadioGroupViewInfo),
                new RadioGroupPainter(), true,
                EditImageIndexes.RadioGroup, typeof(DevExpress.Accessibility.BaseEditAccessible)));
        }

        public override string EditorTypeName
        {

            get { return EditorName; }

        }

        #endregion



        public int MinItemHeight { get; set; }


        public bool AllowHtmlString { get; set; }
        
        
    }
}
