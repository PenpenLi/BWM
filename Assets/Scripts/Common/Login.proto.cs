//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Common/login/Login.proto
namespace Cmd.Login
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"MSGTYPE")]
  public partial class MSGTYPE : global::ProtoBuf.IExtensible
  {
    public MSGTYPE() {}
    
    [global::ProtoBuf.ProtoContract(Name=@"Param")]
    public enum Param
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"VersionVerify_CS", Value=1)]
      VersionVerify_CS = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"UserLoginRequest_C", Value=2)]
      UserLoginRequest_C = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"UserLoginReturnFail_S", Value=3)]
      UserLoginReturnFail_S = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"UserLoginReturnOk_S", Value=4)]
      UserLoginReturnOk_S = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"UserLoginToken_C", Value=5)]
      UserLoginToken_C = 5
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"VersionVerify_CS")]
  public partial class VersionVerify_CS : global::ProtoBuf.IExtensible
  {
    public VersionVerify_CS() {}
    
    private uint _version;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"version", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint version
    {
      get { return _version; }
      set { _version = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"UserLoginRequest_C")]
  public partial class UserLoginRequest_C : global::ProtoBuf.IExtensible
  {
    public UserLoginRequest_C() {}
    
    private string _username;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"username", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string username
    {
      get { return _username; }
      set { _username = value; }
    }
    private uint _gamezone;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"gamezone", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint gamezone
    {
      get { return _gamezone; }
      set { _gamezone = value; }
    }
    private uint _gameversion;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"gameversion", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint gameversion
    {
      get { return _gameversion; }
      set { _gameversion = value; }
    }
    private string _mid = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"mid", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string mid
    {
      get { return _mid; }
      set { _mid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"UserLoginReturnFail_S")]
  public partial class UserLoginReturnFail_S : global::ProtoBuf.IExtensible
  {
    public UserLoginReturnFail_S() {}
    
    private int _retcode;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"retcode", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int retcode
    {
      get { return _retcode; }
      set { _retcode = value; }
    }
    private string _desc;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"desc", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string desc
    {
      get { return _desc; }
      set { _desc = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"UserLoginReturnOk_S")]
  public partial class UserLoginReturnOk_S : global::ProtoBuf.IExtensible
  {
    public UserLoginReturnOk_S() {}
    
    private ulong _userid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"userid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ulong userid
    {
      get { return _userid; }
      set { _userid = value; }
    }
    private ulong _logintempid;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"logintempid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ulong logintempid
    {
      get { return _logintempid; }
      set { _logintempid = value; }
    }
    private string _gatewayurl;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"gatewayurl", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string gatewayurl
    {
      get { return _gatewayurl; }
      set { _gatewayurl = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"UserLoginToken_C")]
  public partial class UserLoginToken_C : global::ProtoBuf.IExtensible
  {
    public UserLoginToken_C() {}
    
    private ulong _userid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"userid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ulong userid
    {
      get { return _userid; }
      set { _userid = value; }
    }
    private ulong _logintempid;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"logintempid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ulong logintempid
    {
      get { return _logintempid; }
      set { _logintempid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    [global::ProtoBuf.ProtoContract(Name=@"UserLoginReturnFail")]
    public enum UserLoginReturnFail
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"Password", Value=1)]
      Password = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ServerShutdown", Value=2)]
      ServerShutdown = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"VersionTooLow", Value=3)]
      VersionTooLow = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"UserTokenFind", Value=4)]
      UserTokenFind = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"UserTokenTempId", Value=5)]
      UserTokenTempId = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"UserTokenTimeOut", Value=6)]
      UserTokenTimeOut = 6
    }
  
}