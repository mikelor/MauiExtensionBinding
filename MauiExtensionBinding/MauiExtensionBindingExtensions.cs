using System;
using System.Collections.Generic;
using System.Text;

namespace MauiExtensionBinding;

static public class MauiExtensionBindingExtensions
{
    extension(ExtensionModel model)
    {
        public string StatusColor
        {
            get
            {
                return model.Status switch
                {
                    StatusType.Active => "Green",
                    StatusType.Inactive => "Gray",
                    StatusType.Suspended => "Red",
                    _ => throw new ArgumentOutOfRangeException()
                };
            }
        }
    }

    extension(ExtensionModelViewModel model)
    {
        public string StatusViewModelColor
        {
            get
            {
                return model.Status switch
                {
                    StatusType.Active => "Green",
                    StatusType.Inactive => "Gray",
                    StatusType.Suspended => "Red",
                    _ => throw new ArgumentOutOfRangeException()
                };
            }
        }
    }
}
