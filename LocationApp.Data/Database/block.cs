
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace LocationApp.Data.Database
{

using System;
    using System.Collections.Generic;
    
public partial class block
{

    public int BlockID { get; set; }

    public Nullable<int> BuildID { get; set; }

    public string Name { get; set; }

    public string Gps { get; set; }



    public virtual build build { get; set; }

}

}