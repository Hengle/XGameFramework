//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: protofiles/UIFrame.proto
namespace dbc
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"UIFrameTable")]
  public partial class UIFrameTable : global::ProtoBuf.IExtensible
  {
    public UIFrameTable() {}
    
    private string _tname = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"tname", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string tname
    {
      get { return _tname; }
      set { _tname = value; }
    }
    private readonly global::System.Collections.Generic.List<dbc.UIFrame> _tlist = new global::System.Collections.Generic.List<dbc.UIFrame>();
    [global::ProtoBuf.ProtoMember(2, Name=@"tlist", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<dbc.UIFrame> tlist
    {
      get { return _tlist; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"UIFrame")]
  public partial class UIFrame : global::ProtoBuf.IExtensible
  {
    public UIFrame() {}
    
    private int _ID = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"ID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int ID
    {
      get { return _ID; }
      set { _ID = value; }
    }
    private string _WindowID = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"WindowID", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string WindowID
    {
      get { return _WindowID; }
      set { _WindowID = value; }
    }
    private string _Name = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Name
    {
      get { return _Name; }
      set { _Name = value; }
    }
    private int _FrameType = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"FrameType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int FrameType
    {
      get { return _FrameType; }
      set { _FrameType = value; }
    }
    private string _BarContent = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"BarContent", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string BarContent
    {
      get { return _BarContent; }
      set { _BarContent = value; }
    }
    private string _JumpWndID = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"JumpWndID", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string JumpWndID
    {
      get { return _JumpWndID; }
      set { _JumpWndID = value; }
    }
    private string _JumpWndType = "";
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"JumpWndType", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string JumpWndType
    {
      get { return _JumpWndType; }
      set { _JumpWndType = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}