//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: ScriptCommand.proto
// Note: requires additional types generated from: Common.proto
namespace Cmd
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Script")]
  public partial class Script : global::ProtoBuf.IExtensible
  {
    public Script() {}
    
    [global::ProtoBuf.ProtoContract(Name=@"Param")]
    public enum Param
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"SelectSceneEntryScriptUserCmd_CS", Value=1)]
      SelectSceneEntryScriptUserCmd_CS = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"RequestNpcDialogScriptUserCmd_C", Value=2)]
      RequestNpcDialogScriptUserCmd_C = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ReturnNpcDialogScriptUserCmd_S", Value=3)]
      ReturnNpcDialogScriptUserCmd_S = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SelectNpcDialogScriptUserCmd_C", Value=4)]
      SelectNpcDialogScriptUserCmd_C = 4
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SelectSceneEntryScriptUserCmd_CS")]
  public partial class SelectSceneEntryScriptUserCmd_CS : global::ProtoBuf.IExtensible
  {
    public SelectSceneEntryScriptUserCmd_CS() {}
    
    private Cmd.SceneEntryUid _entry;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"entry", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public Cmd.SceneEntryUid entry
    {
      get { return _entry; }
      set { _entry = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RequestNpcDialogScriptUserCmd_C")]
  public partial class RequestNpcDialogScriptUserCmd_C : global::ProtoBuf.IExtensible
  {
    public RequestNpcDialogScriptUserCmd_C() {}
    
    private ulong _tempid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"tempid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ulong tempid
    {
      get { return _tempid; }
      set { _tempid = value; }
    }
    private uint _baseid;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"baseid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint baseid
    {
      get { return _baseid; }
      set { _baseid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ReturnNpcDialogScriptUserCmd_S")]
  public partial class ReturnNpcDialogScriptUserCmd_S : global::ProtoBuf.IExtensible
  {
    public ReturnNpcDialogScriptUserCmd_S() {}
    
    private ulong _tempid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"tempid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ulong tempid
    {
      get { return _tempid; }
      set { _tempid = value; }
    }
    private string _script;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"script", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string script
    {
      get { return _script; }
      set { _script = value; }
    }
    private string _token;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"token", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string token
    {
      get { return _token; }
      set { _token = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SelectNpcDialogScriptUserCmd_C")]
  public partial class SelectNpcDialogScriptUserCmd_C : global::ProtoBuf.IExtensible
  {
    public SelectNpcDialogScriptUserCmd_C() {}
    
    private ulong _tempid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"tempid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ulong tempid
    {
      get { return _tempid; }
      set { _tempid = value; }
    }
    private string _token;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"token", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string token
    {
      get { return _token; }
      set { _token = value; }
    }
    private ulong _index;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"index", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ulong index
    {
      get { return _index; }
      set { _index = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}