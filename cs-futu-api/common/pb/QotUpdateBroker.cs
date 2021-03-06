// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Qot_UpdateBroker.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace QotUpdateBroker {

  /// <summary>Holder for reflection information generated from Qot_UpdateBroker.proto</summary>
  public static partial class QotUpdateBrokerReflection {

    #region Descriptor
    /// <summary>File descriptor for Qot_UpdateBroker.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static QotUpdateBrokerReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZRb3RfVXBkYXRlQnJva2VyLnByb3RvEhBRb3RfVXBkYXRlQnJva2VyGgxD",
            "b21tb24ucHJvdG8aEFFvdF9Db21tb24ucHJvdG8igwEKA1MyQxImCghzZWN1",
            "cml0eRgBIAEoCzIULlFvdF9Db21tb24uU2VjdXJpdHkSKQoNYnJva2VyQXNr",
            "TGlzdBgCIAMoCzISLlFvdF9Db21tb24uQnJva2VyEikKDWJyb2tlckJpZExp",
            "c3QYAyADKAsyEi5Rb3RfQ29tbW9uLkJyb2tlciJgCghSZXNwb25zZRIPCgdy",
            "ZXRUeXBlGAEgASgFEg4KBnJldE1zZxgCIAEoCRIPCgdlcnJDb2RlGAMgASgF",
            "EiIKA3MyYxgEIAEoCzIVLlFvdF9VcGRhdGVCcm9rZXIuUzJDYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Common.CommonReflection.Descriptor, global::QotCommon.QotCommonReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::QotUpdateBroker.S2C), global::QotUpdateBroker.S2C.Parser, new[]{ "Security", "BrokerAskList", "BrokerBidList" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::QotUpdateBroker.Response), global::QotUpdateBroker.Response.Parser, new[]{ "RetType", "RetMsg", "ErrCode", "S2C" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class S2C : pb::IMessage<S2C> {
    private static readonly pb::MessageParser<S2C> _parser = new pb::MessageParser<S2C>(() => new S2C());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<S2C> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::QotUpdateBroker.QotUpdateBrokerReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public S2C() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public S2C(S2C other) : this() {
      security_ = other.security_ != null ? other.security_.Clone() : null;
      brokerAskList_ = other.brokerAskList_.Clone();
      brokerBidList_ = other.brokerBidList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public S2C Clone() {
      return new S2C(this);
    }

    /// <summary>Field number for the "security" field.</summary>
    public const int SecurityFieldNumber = 1;
    private global::QotCommon.Security security_;
    /// <summary>
    ///股票
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::QotCommon.Security Security {
      get { return security_; }
      set {
        security_ = value;
      }
    }

    /// <summary>Field number for the "brokerAskList" field.</summary>
    public const int BrokerAskListFieldNumber = 2;
    private static readonly pb::FieldCodec<global::QotCommon.Broker> _repeated_brokerAskList_codec
        = pb::FieldCodec.ForMessage(18, global::QotCommon.Broker.Parser);
    private readonly pbc::RepeatedField<global::QotCommon.Broker> brokerAskList_ = new pbc::RepeatedField<global::QotCommon.Broker>();
    /// <summary>
    ///经纪Ask(卖)盘
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::QotCommon.Broker> BrokerAskList {
      get { return brokerAskList_; }
    }

    /// <summary>Field number for the "brokerBidList" field.</summary>
    public const int BrokerBidListFieldNumber = 3;
    private static readonly pb::FieldCodec<global::QotCommon.Broker> _repeated_brokerBidList_codec
        = pb::FieldCodec.ForMessage(26, global::QotCommon.Broker.Parser);
    private readonly pbc::RepeatedField<global::QotCommon.Broker> brokerBidList_ = new pbc::RepeatedField<global::QotCommon.Broker>();
    /// <summary>
    ///经纪Bid(买)盘
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::QotCommon.Broker> BrokerBidList {
      get { return brokerBidList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as S2C);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(S2C other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Security, other.Security)) return false;
      if(!brokerAskList_.Equals(other.brokerAskList_)) return false;
      if(!brokerBidList_.Equals(other.brokerBidList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (security_ != null) hash ^= Security.GetHashCode();
      hash ^= brokerAskList_.GetHashCode();
      hash ^= brokerBidList_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (security_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Security);
      }
      brokerAskList_.WriteTo(output, _repeated_brokerAskList_codec);
      brokerBidList_.WriteTo(output, _repeated_brokerBidList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (security_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Security);
      }
      size += brokerAskList_.CalculateSize(_repeated_brokerAskList_codec);
      size += brokerBidList_.CalculateSize(_repeated_brokerBidList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(S2C other) {
      if (other == null) {
        return;
      }
      if (other.security_ != null) {
        if (security_ == null) {
          Security = new global::QotCommon.Security();
        }
        Security.MergeFrom(other.Security);
      }
      brokerAskList_.Add(other.brokerAskList_);
      brokerBidList_.Add(other.brokerBidList_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (security_ == null) {
              Security = new global::QotCommon.Security();
            }
            input.ReadMessage(Security);
            break;
          }
          case 18: {
            brokerAskList_.AddEntriesFrom(input, _repeated_brokerAskList_codec);
            break;
          }
          case 26: {
            brokerBidList_.AddEntriesFrom(input, _repeated_brokerBidList_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class Response : pb::IMessage<Response> {
    private static readonly pb::MessageParser<Response> _parser = new pb::MessageParser<Response>(() => new Response());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Response> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::QotUpdateBroker.QotUpdateBrokerReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Response() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Response(Response other) : this() {
      retType_ = other.retType_;
      retMsg_ = other.retMsg_;
      errCode_ = other.errCode_;
      s2C_ = other.s2C_ != null ? other.s2C_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Response Clone() {
      return new Response(this);
    }

    /// <summary>Field number for the "retType" field.</summary>
    public const int RetTypeFieldNumber = 1;
    private int retType_;
    /// <summary>
    ///RetType,返回结果
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int RetType {
      get { return retType_; }
      set {
        retType_ = value;
      }
    }

    /// <summary>Field number for the "retMsg" field.</summary>
    public const int RetMsgFieldNumber = 2;
    private string retMsg_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string RetMsg {
      get { return retMsg_; }
      set {
        retMsg_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "errCode" field.</summary>
    public const int ErrCodeFieldNumber = 3;
    private int errCode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ErrCode {
      get { return errCode_; }
      set {
        errCode_ = value;
      }
    }

    /// <summary>Field number for the "s2c" field.</summary>
    public const int S2CFieldNumber = 4;
    private global::QotUpdateBroker.S2C s2C_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::QotUpdateBroker.S2C S2C {
      get { return s2C_; }
      set {
        s2C_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Response);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Response other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (RetType != other.RetType) return false;
      if (RetMsg != other.RetMsg) return false;
      if (ErrCode != other.ErrCode) return false;
      if (!object.Equals(S2C, other.S2C)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (RetType != 0) hash ^= RetType.GetHashCode();
      if (RetMsg.Length != 0) hash ^= RetMsg.GetHashCode();
      if (ErrCode != 0) hash ^= ErrCode.GetHashCode();
      if (s2C_ != null) hash ^= S2C.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (RetType != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(RetType);
      }
      if (RetMsg.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(RetMsg);
      }
      if (ErrCode != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(ErrCode);
      }
      if (s2C_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(S2C);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (RetType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(RetType);
      }
      if (RetMsg.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RetMsg);
      }
      if (ErrCode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ErrCode);
      }
      if (s2C_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(S2C);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Response other) {
      if (other == null) {
        return;
      }
      if (other.RetType != 0) {
        RetType = other.RetType;
      }
      if (other.RetMsg.Length != 0) {
        RetMsg = other.RetMsg;
      }
      if (other.ErrCode != 0) {
        ErrCode = other.ErrCode;
      }
      if (other.s2C_ != null) {
        if (s2C_ == null) {
          S2C = new global::QotUpdateBroker.S2C();
        }
        S2C.MergeFrom(other.S2C);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            RetType = input.ReadInt32();
            break;
          }
          case 18: {
            RetMsg = input.ReadString();
            break;
          }
          case 24: {
            ErrCode = input.ReadInt32();
            break;
          }
          case 34: {
            if (s2C_ == null) {
              S2C = new global::QotUpdateBroker.S2C();
            }
            input.ReadMessage(S2C);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
