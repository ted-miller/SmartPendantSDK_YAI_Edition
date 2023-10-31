/**
 * <auto-generated>
 * Autogenerated by Thrift Compiler (0.17.0)
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 * </auto-generated>
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Thrift;
using Thrift.Collections;
using Thrift.Protocol;
using Thrift.Protocol.Entities;
using Thrift.Protocol.Utilities;
using Thrift.Transport;
using Thrift.Transport.Client;
using Thrift.Transport.Server;
using Thrift.Processor;


#pragma warning disable IDE0079  // remove unnecessary pragmas
#pragma warning disable IDE0017  // object init can be simplified
#pragma warning disable IDE0028  // collection init can be simplified
#pragma warning disable IDE1006  // parts of the code use IDL spelling
#pragma warning disable CA1822   // empty DeepCopy() methods still non-static
#pragma warning disable IDE0083  // pattern matching "that is not SomeType" requires net5.0 but we still support earlier versions

namespace Yaskawa.Ext.API
{

  public partial class GaugeSensorSpec : TBase
  {
    private sbyte _flag;
    private double _gain;
    private double _offset;
    private double _currentPos;
    private double _currentVolt;
    private double _firstPos;
    private double _firstVolt;
    private double _secondPos;
    private double _secondVolt;

    public sbyte Flag
    {
      get
      {
        return _flag;
      }
      set
      {
        __isset.flag = true;
        this._flag = value;
      }
    }

    public double Gain
    {
      get
      {
        return _gain;
      }
      set
      {
        __isset.gain = true;
        this._gain = value;
      }
    }

    public double Offset
    {
      get
      {
        return _offset;
      }
      set
      {
        __isset.offset = true;
        this._offset = value;
      }
    }

    public double CurrentPos
    {
      get
      {
        return _currentPos;
      }
      set
      {
        __isset.currentPos = true;
        this._currentPos = value;
      }
    }

    public double CurrentVolt
    {
      get
      {
        return _currentVolt;
      }
      set
      {
        __isset.currentVolt = true;
        this._currentVolt = value;
      }
    }

    public double FirstPos
    {
      get
      {
        return _firstPos;
      }
      set
      {
        __isset.firstPos = true;
        this._firstPos = value;
      }
    }

    public double FirstVolt
    {
      get
      {
        return _firstVolt;
      }
      set
      {
        __isset.firstVolt = true;
        this._firstVolt = value;
      }
    }

    public double SecondPos
    {
      get
      {
        return _secondPos;
      }
      set
      {
        __isset.secondPos = true;
        this._secondPos = value;
      }
    }

    public double SecondVolt
    {
      get
      {
        return _secondVolt;
      }
      set
      {
        __isset.secondVolt = true;
        this._secondVolt = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool flag;
      public bool gain;
      public bool offset;
      public bool currentPos;
      public bool currentVolt;
      public bool firstPos;
      public bool firstVolt;
      public bool secondPos;
      public bool secondVolt;
    }

    public GaugeSensorSpec()
    {
    }

    public GaugeSensorSpec DeepCopy()
    {
      var tmp225 = new GaugeSensorSpec();
      if(__isset.flag)
      {
        tmp225.Flag = this.Flag;
      }
      tmp225.__isset.flag = this.__isset.flag;
      if(__isset.gain)
      {
        tmp225.Gain = this.Gain;
      }
      tmp225.__isset.gain = this.__isset.gain;
      if(__isset.offset)
      {
        tmp225.Offset = this.Offset;
      }
      tmp225.__isset.offset = this.__isset.offset;
      if(__isset.currentPos)
      {
        tmp225.CurrentPos = this.CurrentPos;
      }
      tmp225.__isset.currentPos = this.__isset.currentPos;
      if(__isset.currentVolt)
      {
        tmp225.CurrentVolt = this.CurrentVolt;
      }
      tmp225.__isset.currentVolt = this.__isset.currentVolt;
      if(__isset.firstPos)
      {
        tmp225.FirstPos = this.FirstPos;
      }
      tmp225.__isset.firstPos = this.__isset.firstPos;
      if(__isset.firstVolt)
      {
        tmp225.FirstVolt = this.FirstVolt;
      }
      tmp225.__isset.firstVolt = this.__isset.firstVolt;
      if(__isset.secondPos)
      {
        tmp225.SecondPos = this.SecondPos;
      }
      tmp225.__isset.secondPos = this.__isset.secondPos;
      if(__isset.secondVolt)
      {
        tmp225.SecondVolt = this.SecondVolt;
      }
      tmp225.__isset.secondVolt = this.__isset.secondVolt;
      return tmp225;
    }

    public async global::System.Threading.Tasks.Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        TField field;
        await iprot.ReadStructBeginAsync(cancellationToken);
        while (true)
        {
          field = await iprot.ReadFieldBeginAsync(cancellationToken);
          if (field.Type == TType.Stop)
          {
            break;
          }

          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.Byte)
              {
                Flag = await iprot.ReadByteAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.Double)
              {
                Gain = await iprot.ReadDoubleAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.Double)
              {
                Offset = await iprot.ReadDoubleAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 4:
              if (field.Type == TType.Double)
              {
                CurrentPos = await iprot.ReadDoubleAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 5:
              if (field.Type == TType.Double)
              {
                CurrentVolt = await iprot.ReadDoubleAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 6:
              if (field.Type == TType.Double)
              {
                FirstPos = await iprot.ReadDoubleAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 7:
              if (field.Type == TType.Double)
              {
                FirstVolt = await iprot.ReadDoubleAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 8:
              if (field.Type == TType.Double)
              {
                SecondPos = await iprot.ReadDoubleAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 9:
              if (field.Type == TType.Double)
              {
                SecondVolt = await iprot.ReadDoubleAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            default: 
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              break;
          }

          await iprot.ReadFieldEndAsync(cancellationToken);
        }

        await iprot.ReadStructEndAsync(cancellationToken);
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public async global::System.Threading.Tasks.Task WriteAsync(TProtocol oprot, CancellationToken cancellationToken)
    {
      oprot.IncrementRecursionDepth();
      try
      {
        var tmp226 = new TStruct("GaugeSensorSpec");
        await oprot.WriteStructBeginAsync(tmp226, cancellationToken);
        var tmp227 = new TField();
        if(__isset.flag)
        {
          tmp227.Name = "flag";
          tmp227.Type = TType.Byte;
          tmp227.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp227, cancellationToken);
          await oprot.WriteByteAsync(Flag, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.gain)
        {
          tmp227.Name = "gain";
          tmp227.Type = TType.Double;
          tmp227.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp227, cancellationToken);
          await oprot.WriteDoubleAsync(Gain, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.offset)
        {
          tmp227.Name = "offset";
          tmp227.Type = TType.Double;
          tmp227.ID = 3;
          await oprot.WriteFieldBeginAsync(tmp227, cancellationToken);
          await oprot.WriteDoubleAsync(Offset, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.currentPos)
        {
          tmp227.Name = "currentPos";
          tmp227.Type = TType.Double;
          tmp227.ID = 4;
          await oprot.WriteFieldBeginAsync(tmp227, cancellationToken);
          await oprot.WriteDoubleAsync(CurrentPos, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.currentVolt)
        {
          tmp227.Name = "currentVolt";
          tmp227.Type = TType.Double;
          tmp227.ID = 5;
          await oprot.WriteFieldBeginAsync(tmp227, cancellationToken);
          await oprot.WriteDoubleAsync(CurrentVolt, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.firstPos)
        {
          tmp227.Name = "firstPos";
          tmp227.Type = TType.Double;
          tmp227.ID = 6;
          await oprot.WriteFieldBeginAsync(tmp227, cancellationToken);
          await oprot.WriteDoubleAsync(FirstPos, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.firstVolt)
        {
          tmp227.Name = "firstVolt";
          tmp227.Type = TType.Double;
          tmp227.ID = 7;
          await oprot.WriteFieldBeginAsync(tmp227, cancellationToken);
          await oprot.WriteDoubleAsync(FirstVolt, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.secondPos)
        {
          tmp227.Name = "secondPos";
          tmp227.Type = TType.Double;
          tmp227.ID = 8;
          await oprot.WriteFieldBeginAsync(tmp227, cancellationToken);
          await oprot.WriteDoubleAsync(SecondPos, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.secondVolt)
        {
          tmp227.Name = "secondVolt";
          tmp227.Type = TType.Double;
          tmp227.ID = 9;
          await oprot.WriteFieldBeginAsync(tmp227, cancellationToken);
          await oprot.WriteDoubleAsync(SecondVolt, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        await oprot.WriteFieldStopAsync(cancellationToken);
        await oprot.WriteStructEndAsync(cancellationToken);
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override bool Equals(object that)
    {
      if (!(that is GaugeSensorSpec other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.flag == other.__isset.flag) && ((!__isset.flag) || (global::System.Object.Equals(Flag, other.Flag))))
        && ((__isset.gain == other.__isset.gain) && ((!__isset.gain) || (global::System.Object.Equals(Gain, other.Gain))))
        && ((__isset.offset == other.__isset.offset) && ((!__isset.offset) || (global::System.Object.Equals(Offset, other.Offset))))
        && ((__isset.currentPos == other.__isset.currentPos) && ((!__isset.currentPos) || (global::System.Object.Equals(CurrentPos, other.CurrentPos))))
        && ((__isset.currentVolt == other.__isset.currentVolt) && ((!__isset.currentVolt) || (global::System.Object.Equals(CurrentVolt, other.CurrentVolt))))
        && ((__isset.firstPos == other.__isset.firstPos) && ((!__isset.firstPos) || (global::System.Object.Equals(FirstPos, other.FirstPos))))
        && ((__isset.firstVolt == other.__isset.firstVolt) && ((!__isset.firstVolt) || (global::System.Object.Equals(FirstVolt, other.FirstVolt))))
        && ((__isset.secondPos == other.__isset.secondPos) && ((!__isset.secondPos) || (global::System.Object.Equals(SecondPos, other.SecondPos))))
        && ((__isset.secondVolt == other.__isset.secondVolt) && ((!__isset.secondVolt) || (global::System.Object.Equals(SecondVolt, other.SecondVolt))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if(__isset.flag)
        {
          hashcode = (hashcode * 397) + Flag.GetHashCode();
        }
        if(__isset.gain)
        {
          hashcode = (hashcode * 397) + Gain.GetHashCode();
        }
        if(__isset.offset)
        {
          hashcode = (hashcode * 397) + Offset.GetHashCode();
        }
        if(__isset.currentPos)
        {
          hashcode = (hashcode * 397) + CurrentPos.GetHashCode();
        }
        if(__isset.currentVolt)
        {
          hashcode = (hashcode * 397) + CurrentVolt.GetHashCode();
        }
        if(__isset.firstPos)
        {
          hashcode = (hashcode * 397) + FirstPos.GetHashCode();
        }
        if(__isset.firstVolt)
        {
          hashcode = (hashcode * 397) + FirstVolt.GetHashCode();
        }
        if(__isset.secondPos)
        {
          hashcode = (hashcode * 397) + SecondPos.GetHashCode();
        }
        if(__isset.secondVolt)
        {
          hashcode = (hashcode * 397) + SecondVolt.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp228 = new StringBuilder("GaugeSensorSpec(");
      int tmp229 = 0;
      if(__isset.flag)
      {
        if(0 < tmp229++) { tmp228.Append(", "); }
        tmp228.Append("Flag: ");
        Flag.ToString(tmp228);
      }
      if(__isset.gain)
      {
        if(0 < tmp229++) { tmp228.Append(", "); }
        tmp228.Append("Gain: ");
        Gain.ToString(tmp228);
      }
      if(__isset.offset)
      {
        if(0 < tmp229++) { tmp228.Append(", "); }
        tmp228.Append("Offset: ");
        Offset.ToString(tmp228);
      }
      if(__isset.currentPos)
      {
        if(0 < tmp229++) { tmp228.Append(", "); }
        tmp228.Append("CurrentPos: ");
        CurrentPos.ToString(tmp228);
      }
      if(__isset.currentVolt)
      {
        if(0 < tmp229++) { tmp228.Append(", "); }
        tmp228.Append("CurrentVolt: ");
        CurrentVolt.ToString(tmp228);
      }
      if(__isset.firstPos)
      {
        if(0 < tmp229++) { tmp228.Append(", "); }
        tmp228.Append("FirstPos: ");
        FirstPos.ToString(tmp228);
      }
      if(__isset.firstVolt)
      {
        if(0 < tmp229++) { tmp228.Append(", "); }
        tmp228.Append("FirstVolt: ");
        FirstVolt.ToString(tmp228);
      }
      if(__isset.secondPos)
      {
        if(0 < tmp229++) { tmp228.Append(", "); }
        tmp228.Append("SecondPos: ");
        SecondPos.ToString(tmp228);
      }
      if(__isset.secondVolt)
      {
        if(0 < tmp229++) { tmp228.Append(", "); }
        tmp228.Append("SecondVolt: ");
        SecondVolt.ToString(tmp228);
      }
      tmp228.Append(')');
      return tmp228.ToString();
    }
  }

}
