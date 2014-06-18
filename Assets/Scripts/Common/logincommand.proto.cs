//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: logincommand.proto
namespace Pmd
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Login")]
  public partial class Login : global::ProtoBuf.IExtensible
  {
    public Login() {}
    
    [global::ProtoBuf.ProtoContract(Name=@"Param")]
    public enum Param
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"AccountTokenVerifyLoginUserPmd_CS", Value=1)]
      AccountTokenVerifyLoginUserPmd_CS = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"AccountTokenVerifyReturnLoginUserPmd_S", Value=2)]
      AccountTokenVerifyReturnLoginUserPmd_S = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ZoneInfoListLoginUserPmd_S", Value=3)]
      ZoneInfoListLoginUserPmd_S = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"UserLoginRequestLoginUserPmd_C", Value=4)]
      UserLoginRequestLoginUserPmd_C = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"UserLoginReturnFailLoginUserPmd_S", Value=5)]
      UserLoginReturnFailLoginUserPmd_S = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"UserLoginReturnOkLoginUserPmd_S", Value=6)]
      UserLoginReturnOkLoginUserPmd_S = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"UserLoginTokenLoginUserPmd_C", Value=7)]
      UserLoginTokenLoginUserPmd_C = 7,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ClientLogUrlLoginUserPmd_S", Value=8)]
      ClientLogUrlLoginUserPmd_S = 8,
            
      [global::ProtoBuf.ProtoEnum(Name=@"MessageBoxLoginUserPmd_S", Value=9)]
      MessageBoxLoginUserPmd_S = 9
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"AccountTokenVerifyLoginUserPmd_CS")]
  public partial class AccountTokenVerifyLoginUserPmd_CS : global::ProtoBuf.IExtensible
  {
    public AccountTokenVerifyLoginUserPmd_CS() {}
    
    private string _account;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"account", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string account
    {
      get { return _account; }
      set { _account = value; }
    }
    private string _token;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"token", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string token
    {
      get { return _token; }
      set { _token = value; }
    }
    private uint _version;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"version", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint version
    {
      get { return _version; }
      set { _version = value; }
    }
    private uint _gameid = default(uint);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"gameid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint gameid
    {
      get { return _gameid; }
      set { _gameid = value; }
    }
    private string _mid = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"mid", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"AccountTokenVerifyReturnLoginUserPmd_S")]
  public partial class AccountTokenVerifyReturnLoginUserPmd_S : global::ProtoBuf.IExtensible
  {
    public AccountTokenVerifyReturnLoginUserPmd_S() {}
    
    private Pmd.VerifyReturnReason _retcode;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"retcode", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public Pmd.VerifyReturnReason retcode
    {
      get { return _retcode; }
      set { _retcode = value; }
    }
    private string _desc = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"desc", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string desc
    {
      get { return _desc; }
      set { _desc = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ZoneInfo")]
  public partial class ZoneInfo : global::ProtoBuf.IExtensible
  {
    public ZoneInfo() {}
    
    private uint _zoneid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"zoneid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint zoneid
    {
      get { return _zoneid; }
      set { _zoneid = value; }
    }
    private string _zonename;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"zonename", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string zonename
    {
      get { return _zonename; }
      set { _zonename = value; }
    }
    private Pmd.ZoneState _state = Pmd.ZoneState.Shutdown;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"state", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Pmd.ZoneState.Shutdown)]
    public Pmd.ZoneState state
    {
      get { return _state; }
      set { _state = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ZoneInfoListLoginUserPmd_S")]
  public partial class ZoneInfoListLoginUserPmd_S : global::ProtoBuf.IExtensible
  {
    public ZoneInfoListLoginUserPmd_S() {}
    
    private string _gamename;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"gamename", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string gamename
    {
      get { return _gamename; }
      set { _gamename = value; }
    }
    private uint _gameid;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"gameid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint gameid
    {
      get { return _gameid; }
      set { _gameid = value; }
    }
    private readonly global::System.Collections.Generic.List<Pmd.ZoneInfo> _zonelist = new global::System.Collections.Generic.List<Pmd.ZoneInfo>();
    [global::ProtoBuf.ProtoMember(3, Name=@"zonelist", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Pmd.ZoneInfo> zonelist
    {
      get { return _zonelist; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"UserLoginRequestLoginUserPmd_C")]
  public partial class UserLoginRequestLoginUserPmd_C : global::ProtoBuf.IExtensible
  {
    public UserLoginRequestLoginUserPmd_C() {}
    
    private uint _gameid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"gameid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint gameid
    {
      get { return _gameid; }
      set { _gameid = value; }
    }
    private uint _zoneid;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"zoneid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint zoneid
    {
      get { return _zoneid; }
      set { _zoneid = value; }
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
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"UserLoginReturnFailLoginUserPmd_S")]
  public partial class UserLoginReturnFailLoginUserPmd_S : global::ProtoBuf.IExtensible
  {
    public UserLoginReturnFailLoginUserPmd_S() {}
    
    private Pmd.LoginReturnFailReason _retcode;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"retcode", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public Pmd.LoginReturnFailReason retcode
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
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"UserLoginReturnOkLoginUserPmd_S")]
  public partial class UserLoginReturnOkLoginUserPmd_S : global::ProtoBuf.IExtensible
  {
    public UserLoginReturnOkLoginUserPmd_S() {}
    
    private ulong _accountid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"accountid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ulong accountid
    {
      get { return _accountid; }
      set { _accountid = value; }
    }
    private ulong _logintempid;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"logintempid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ulong logintempid
    {
      get { return _logintempid; }
      set { _logintempid = value; }
    }
    private ulong _tokenid;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"tokenid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ulong tokenid
    {
      get { return _tokenid; }
      set { _tokenid = value; }
    }
    private string _gatewayurl;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"gatewayurl", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string gatewayurl
    {
      get { return _gatewayurl; }
      set { _gatewayurl = value; }
    }
    private uint _gameid;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"gameid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint gameid
    {
      get { return _gameid; }
      set { _gameid = value; }
    }
    private uint _zoneid;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"zoneid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint zoneid
    {
      get { return _zoneid; }
      set { _zoneid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"UserLoginTokenLoginUserPmd_C")]
  public partial class UserLoginTokenLoginUserPmd_C : global::ProtoBuf.IExtensible
  {
    public UserLoginTokenLoginUserPmd_C() {}
    
    private uint _gameid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"gameid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint gameid
    {
      get { return _gameid; }
      set { _gameid = value; }
    }
    private uint _zoneid;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"zoneid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint zoneid
    {
      get { return _zoneid; }
      set { _zoneid = value; }
    }
    private ulong _accountid;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"accountid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ulong accountid
    {
      get { return _accountid; }
      set { _accountid = value; }
    }
    private ulong _logintempid;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"logintempid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ulong logintempid
    {
      get { return _logintempid; }
      set { _logintempid = value; }
    }
    private uint _timestamp;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"timestamp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint timestamp
    {
      get { return _timestamp; }
      set { _timestamp = value; }
    }
    private string _tokenmd5;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"tokenmd5", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string tokenmd5
    {
      get { return _tokenmd5; }
      set { _tokenmd5 = value; }
    }
    private string _mid = "";
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"mid", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ClientLogUrlLoginUserPmd_S")]
  public partial class ClientLogUrlLoginUserPmd_S : global::ProtoBuf.IExtensible
  {
    public ClientLogUrlLoginUserPmd_S() {}
    
    private string _loglevel;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"loglevel", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string loglevel
    {
      get { return _loglevel; }
      set { _loglevel = value; }
    }
    private string _logurl;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"logurl", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string logurl
    {
      get { return _logurl; }
      set { _logurl = value; }
    }
    private bool _distinct;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"distinct", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool distinct
    {
      get { return _distinct; }
      set { _distinct = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"MessageBoxLoginUserPmd_S")]
  public partial class MessageBoxLoginUserPmd_S : global::ProtoBuf.IExtensible
  {
    public MessageBoxLoginUserPmd_S() {}
    
    private string _btnleft = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"btnleft", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string btnleft
    {
      get { return _btnleft; }
      set { _btnleft = value; }
    }
    private string _btnmiddle = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"btnmiddle", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string btnmiddle
    {
      get { return _btnmiddle; }
      set { _btnmiddle = value; }
    }
    private string _btnright = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"btnright", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string btnright
    {
      get { return _btnright; }
      set { _btnright = value; }
    }
    private string _info = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string info
    {
      get { return _info; }
      set { _info = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    [global::ProtoBuf.ProtoContract(Name=@"VerifyReturnReason")]
    public enum VerifyReturnReason
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"LoginOk", Value=0)]
      LoginOk = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"TokenFindError", Value=1)]
      TokenFindError = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"TokenDiffError", Value=2)]
      TokenDiffError = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"VersionError", Value=3)]
      VersionError = 3
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"ZoneState")]
    public enum ZoneState
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"Shutdown", Value=0)]
      Shutdown = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Normal", Value=1)]
      Normal = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Fullly", Value=2)]
      Fullly = 2
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"LoginReturnFailReason")]
    public enum LoginReturnFailReason
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
      UserTokenTimeOut = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"LoginDulicate", Value=7)]
      LoginDulicate = 7
    }
  
}