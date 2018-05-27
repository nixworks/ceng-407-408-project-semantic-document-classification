﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

public partial class admın
{
    public int AdminID { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public Nullable<bool> IsActive { get; set; }
}

public partial class Classification
{
    public int CLASSIFICATIONID { get; set; }
}

public partial class CLUSTER
{
    public int ClusterID { get; set; }
    public Nullable<int> DataSetID { get; set; }
    public string Name { get; set; }
}

public partial class DATASET
{
    public int DatasetID { get; set; }
    public string Name { get; set; }
    public string URL { get; set; }
    public Nullable<bool> IsActive { get; set; }
}

public partial class DOCUMENT
{
    public int DocumentID { get; set; }
    public Nullable<int> ClusterID { get; set; }
    public string Name { get; set; }
    public string Detail { get; set; }
    public Nullable<System.DateTime> Date { get; set; }
    public Nullable<int> FILEID { get; set; }
}

public partial class FILE
{
    public int FILEID { get; set; }
    public string Name { get; set; }
    public Nullable<int> DocumentID { get; set; }
    public string Path { get; set; }
}

public partial class sysdiagrams
{
    public string name { get; set; }
    public int principal_id { get; set; }
    public int diagram_id { get; set; }
    public Nullable<int> version { get; set; }
    public byte[] definition { get; set; }
}

public partial class USER
{
    public int UserID { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string Password { get; set; }
    public Nullable<bool> IsActive { get; set; }
}
