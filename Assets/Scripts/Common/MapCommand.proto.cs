//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: MapCommand.proto
// Note: requires additional types generated from: Common.proto
namespace Cmd
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Map")]
  public partial class Map : global::ProtoBuf.IExtensible
  {
    public Map() {}
    
    [global::ProtoBuf.ProtoContract(Name=@"Param")]
    public enum Param
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"FirstMainUserDataAndPosMapUserCmd_S", Value=1)]
      FirstMainUserDataAndPosMapUserCmd_S = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"AddMapUserDataAndPosMapUserCmd_S", Value=2)]
      AddMapUserDataAndPosMapUserCmd_S = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"RemoveMapUserMapUserCmd_S", Value=3)]
      RemoveMapUserMapUserCmd_S = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"AddMapNpcDataAndPosMapUserCmd_S", Value=4)]
      AddMapNpcDataAndPosMapUserCmd_S = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"RemoveMapNpcMapUserCmd_S", Value=5)]
      RemoveMapNpcMapUserCmd_S = 5
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"FirstMainUserDataAndPosMapUserCmd_S")]
  public partial class FirstMainUserDataAndPosMapUserCmd_S : global::ProtoBuf.IExtensible
  {
    public FirstMainUserDataAndPosMapUserCmd_S() {}
    
    private Cmd.MainUserData _data;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public Cmd.MainUserData data
    {
      get { return _data; }
      set { _data = value; }
    }
    private Cmd.Pos _pos;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"pos", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public Cmd.Pos pos
    {
      get { return _pos; }
      set { _pos = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"AddMapUserDataAndPosMapUserCmd_S")]
  public partial class AddMapUserDataAndPosMapUserCmd_S : global::ProtoBuf.IExtensible
  {
    public AddMapUserDataAndPosMapUserCmd_S() {}
    
    private Cmd.MapUserData _data;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public Cmd.MapUserData data
    {
      get { return _data; }
      set { _data = value; }
    }
    private Cmd.Pos _pos;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"pos", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public Cmd.Pos pos
    {
      get { return _pos; }
      set { _pos = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RemoveMapUserMapUserCmd_S")]
  public partial class RemoveMapUserMapUserCmd_S : global::ProtoBuf.IExtensible
  {
    public RemoveMapUserMapUserCmd_S() {}
    
    private ulong _charid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"charid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ulong charid
    {
      get { return _charid; }
      set { _charid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"MapNpcData")]
  public partial class MapNpcData : global::ProtoBuf.IExtensible
  {
    public MapNpcData() {}
    
    private ulong _tempid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"tempid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ulong tempid
    {
      get { return _tempid; }
      set { _tempid = value; }
    }
    private int _hp;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"hp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int hp
    {
      get { return _hp; }
      set { _hp = value; }
    }
    private int _maxhp;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"maxhp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int maxhp
    {
      get { return _maxhp; }
      set { _maxhp = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"AddMapNpcDataAndPosMapUserCmd_S")]
  public partial class AddMapNpcDataAndPosMapUserCmd_S : global::ProtoBuf.IExtensible
  {
    public AddMapNpcDataAndPosMapUserCmd_S() {}
    
    private Cmd.MapNpcData _data;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public Cmd.MapNpcData data
    {
      get { return _data; }
      set { _data = value; }
    }
    private Cmd.Pos _pos;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"pos", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public Cmd.Pos pos
    {
      get { return _pos; }
      set { _pos = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RemoveMapNpcMapUserCmd_S")]
  public partial class RemoveMapNpcMapUserCmd_S : global::ProtoBuf.IExtensible
  {
    public RemoveMapNpcMapUserCmd_S() {}
    
    private ulong _tempid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"tempid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ulong tempid
    {
      get { return _tempid; }
      set { _tempid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}