//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: SaveData.proto
// Note: requires additional types generated from: Common.proto
namespace Cmd
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SaveCharBase")]
  public partial class SaveCharBase : global::ProtoBuf.IExtensible
  {
    public SaveCharBase() {}
    
    private ulong _id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ulong id
    {
      get { return _id; }
      set { _id = value; }
    }
    private string _name;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }
    private bool _sexman;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"sexman", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool sexman
    {
      get { return _sexman; }
      set { _sexman = value; }
    }
    private uint _level;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint level
    {
      get { return _level; }
      set { _level = value; }
    }
    private Cmd.Profession _profession;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"profession", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public Cmd.Profession profession
    {
      get { return _profession; }
      set { _profession = value; }
    }
    private Cmd.Pos _pos;
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"pos", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public Cmd.Pos pos
    {
      get { return _pos; }
      set { _pos = value; }
    }
    private uint _mapid;
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"mapid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint mapid
    {
      get { return _mapid; }
      set { _mapid = value; }
    }
    private int _hp;
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"hp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int hp
    {
      get { return _hp; }
      set { _hp = value; }
    }
    private int _sp;
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"sp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int sp
    {
      get { return _sp; }
      set { _sp = value; }
    }
    private long _exp;
    [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name=@"exp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long exp
    {
      get { return _exp; }
      set { _exp = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SaveItem")]
  public partial class SaveItem : global::ProtoBuf.IExtensible
  {
    public SaveItem() {}
    
    private uint _thisid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"thisid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint thisid
    {
      get { return _thisid; }
      set { _thisid = value; }
    }
    private uint _baseid;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"baseid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint baseid
    {
      get { return _baseid; }
      set { _baseid = value; }
    }
    private int _num;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"num", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int num
    {
      get { return _num; }
      set { _num = value; }
    }
    private Cmd.ItemLocation _loc;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"loc", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public Cmd.ItemLocation loc
    {
      get { return _loc; }
      set { _loc = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SaveSkill")]
  public partial class SaveSkill : global::ProtoBuf.IExtensible
  {
    public SaveSkill() {}
    
    private uint _skillid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"skillid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint skillid
    {
      get { return _skillid; }
      set { _skillid = value; }
    }
    private uint _level;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint level
    {
      get { return _level; }
      set { _level = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SaveBuff")]
  public partial class SaveBuff : global::ProtoBuf.IExtensible
  {
    public SaveBuff() {}
    
    private uint _buffid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"buffid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint buffid
    {
      get { return _buffid; }
      set { _buffid = value; }
    }
    private uint _level;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint level
    {
      get { return _level; }
      set { _level = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SaveQuest")]
  public partial class SaveQuest : global::ProtoBuf.IExtensible
  {
    public SaveQuest() {}
    
    private uint _questid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"questid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint questid
    {
      get { return _questid; }
      set { _questid = value; }
    }
    private uint _operate;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"operate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint operate
    {
      get { return _operate; }
      set { _operate = value; }
    }
    private uint _state;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"state", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint state
    {
      get { return _state; }
      set { _state = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SaveDataAll")]
  public partial class SaveDataAll : global::ProtoBuf.IExtensible
  {
    public SaveDataAll() {}
    
    private Cmd.SaveCharBase _charbase;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"charbase", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public Cmd.SaveCharBase charbase
    {
      get { return _charbase; }
      set { _charbase = value; }
    }
    private readonly global::System.Collections.Generic.List<Cmd.SaveItem> _itemlist = new global::System.Collections.Generic.List<Cmd.SaveItem>();
    [global::ProtoBuf.ProtoMember(2, Name=@"itemlist", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Cmd.SaveItem> itemlist
    {
      get { return _itemlist; }
    }
  
    private readonly global::System.Collections.Generic.List<Cmd.SaveSkill> _skilllist = new global::System.Collections.Generic.List<Cmd.SaveSkill>();
    [global::ProtoBuf.ProtoMember(3, Name=@"skilllist", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Cmd.SaveSkill> skilllist
    {
      get { return _skilllist; }
    }
  
    private readonly global::System.Collections.Generic.List<Cmd.SaveBuff> _bufflist = new global::System.Collections.Generic.List<Cmd.SaveBuff>();
    [global::ProtoBuf.ProtoMember(4, Name=@"bufflist", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Cmd.SaveBuff> bufflist
    {
      get { return _bufflist; }
    }
  
    private readonly global::System.Collections.Generic.List<Cmd.SaveQuest> _questlist = new global::System.Collections.Generic.List<Cmd.SaveQuest>();
    [global::ProtoBuf.ProtoMember(5, Name=@"questlist", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Cmd.SaveQuest> questlist
    {
      get { return _questlist; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}