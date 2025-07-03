using System;
using System.Collections.Generic;
using System.Text;

namespace MauiExtensionBinding;

public enum StatusType
{
    Active,
    Inactive,
    Suspended
}

public class ExtensionModel
{
    public StatusType Status { get; set; }
}




