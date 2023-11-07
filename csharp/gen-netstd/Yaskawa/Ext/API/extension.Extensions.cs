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


#pragma warning disable IDE0079  // remove unnecessary pragmas
#pragma warning disable IDE0017  // object init can be simplified
#pragma warning disable IDE0028  // collection init can be simplified
#pragma warning disable IDE1006  // parts of the code use IDL spelling
#pragma warning disable CA1822   // empty DeepCopy() methods still non-static
#pragma warning disable IDE0083  // pattern matching "that is not SomeType" requires net5.0 but we still support earlier versions

namespace Yaskawa.Ext.API
{
  public static class extensionExtensions
  {
    public static bool Equals(this Dictionary<int, string> instance, object that)
    {
      if (!(that is Dictionary<int, string> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this Dictionary<int, string> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static Dictionary<int, string> DeepCopy(this Dictionary<int, string> source)
    {
      if (source == null)
        return null;

      var tmp4020 = new Dictionary<int, string>(source.Count);
      foreach (var pair in source)
        tmp4020.Add(pair.Key, (pair.Value != null) ? pair.Value : null);
      return tmp4020;
    }


    public static bool Equals(this Dictionary<string, global::Yaskawa.Ext.API.Any> instance, object that)
    {
      if (!(that is Dictionary<string, global::Yaskawa.Ext.API.Any> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this Dictionary<string, global::Yaskawa.Ext.API.Any> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static Dictionary<string, global::Yaskawa.Ext.API.Any> DeepCopy(this Dictionary<string, global::Yaskawa.Ext.API.Any> source)
    {
      if (source == null)
        return null;

      var tmp4021 = new Dictionary<string, global::Yaskawa.Ext.API.Any>(source.Count);
      foreach (var pair in source)
        tmp4021.Add((pair.Key != null) ? pair.Key : null, (pair.Value != null) ? pair.Value.DeepCopy() : null);
      return tmp4021;
    }


    public static bool Equals(this Dictionary<string, global::Yaskawa.Ext.API.Data> instance, object that)
    {
      if (!(that is Dictionary<string, global::Yaskawa.Ext.API.Data> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this Dictionary<string, global::Yaskawa.Ext.API.Data> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static Dictionary<string, global::Yaskawa.Ext.API.Data> DeepCopy(this Dictionary<string, global::Yaskawa.Ext.API.Data> source)
    {
      if (source == null)
        return null;

      var tmp4022 = new Dictionary<string, global::Yaskawa.Ext.API.Data>(source.Count);
      foreach (var pair in source)
        tmp4022.Add((pair.Key != null) ? pair.Key : null, (pair.Value != null) ? pair.Value.DeepCopy() : null);
      return tmp4022;
    }


    public static bool Equals(this HashSet<global::Yaskawa.Ext.API.ControllerEventType> instance, object that)
    {
      if (!(that is HashSet<global::Yaskawa.Ext.API.ControllerEventType> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this HashSet<global::Yaskawa.Ext.API.ControllerEventType> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static HashSet<global::Yaskawa.Ext.API.ControllerEventType> DeepCopy(this HashSet<global::Yaskawa.Ext.API.ControllerEventType> source)
    {
      if (source == null)
        return null;

      var tmp4023 = new HashSet<global::Yaskawa.Ext.API.ControllerEventType>(source.Count);
      foreach (var elem in source)
        tmp4023.Add(elem);
      return tmp4023;
    }


    public static bool Equals(this HashSet<global::Yaskawa.Ext.API.PendantEventType> instance, object that)
    {
      if (!(that is HashSet<global::Yaskawa.Ext.API.PendantEventType> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this HashSet<global::Yaskawa.Ext.API.PendantEventType> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static HashSet<global::Yaskawa.Ext.API.PendantEventType> DeepCopy(this HashSet<global::Yaskawa.Ext.API.PendantEventType> source)
    {
      if (source == null)
        return null;

      var tmp4024 = new HashSet<global::Yaskawa.Ext.API.PendantEventType>(source.Count);
      foreach (var elem in source)
        tmp4024.Add(elem);
      return tmp4024;
    }


    public static bool Equals(this HashSet<string> instance, object that)
    {
      if (!(that is HashSet<string> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this HashSet<string> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static HashSet<string> DeepCopy(this HashSet<string> source)
    {
      if (source == null)
        return null;

      var tmp4025 = new HashSet<string>(source.Count);
      foreach (var elem in source)
        tmp4025.Add((elem != null) ? elem : null);
      return tmp4025;
    }


    public static bool Equals(this List<List<double>> instance, object that)
    {
      if (!(that is List<List<double>> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this List<List<double>> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static List<List<double>> DeepCopy(this List<List<double>> source)
    {
      if (source == null)
        return null;

      var tmp4026 = new List<List<double>>(source.Count);
      foreach (var elem in source)
        tmp4026.Add((elem != null) ? elem.DeepCopy() : null);
      return tmp4026;
    }


    public static bool Equals(this List<double> instance, object that)
    {
      if (!(that is List<double> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this List<double> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static List<double> DeepCopy(this List<double> source)
    {
      if (source == null)
        return null;

      var tmp4027 = new List<double>(source.Count);
      foreach (var elem in source)
        tmp4027.Add(elem);
      return tmp4027;
    }


    public static bool Equals(this List<global::Yaskawa.Ext.API.Any> instance, object that)
    {
      if (!(that is List<global::Yaskawa.Ext.API.Any> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this List<global::Yaskawa.Ext.API.Any> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static List<global::Yaskawa.Ext.API.Any> DeepCopy(this List<global::Yaskawa.Ext.API.Any> source)
    {
      if (source == null)
        return null;

      var tmp4028 = new List<global::Yaskawa.Ext.API.Any>(source.Count);
      foreach (var elem in source)
        tmp4028.Add((elem != null) ? elem.DeepCopy() : null);
      return tmp4028;
    }


    public static bool Equals(this List<global::Yaskawa.Ext.API.ControlGroup> instance, object that)
    {
      if (!(that is List<global::Yaskawa.Ext.API.ControlGroup> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this List<global::Yaskawa.Ext.API.ControlGroup> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static List<global::Yaskawa.Ext.API.ControlGroup> DeepCopy(this List<global::Yaskawa.Ext.API.ControlGroup> source)
    {
      if (source == null)
        return null;

      var tmp4029 = new List<global::Yaskawa.Ext.API.ControlGroup>(source.Count);
      foreach (var elem in source)
        tmp4029.Add((elem != null) ? elem.DeepCopy() : null);
      return tmp4029;
    }


    public static bool Equals(this List<global::Yaskawa.Ext.API.ControllerEvent> instance, object that)
    {
      if (!(that is List<global::Yaskawa.Ext.API.ControllerEvent> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this List<global::Yaskawa.Ext.API.ControllerEvent> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static List<global::Yaskawa.Ext.API.ControllerEvent> DeepCopy(this List<global::Yaskawa.Ext.API.ControllerEvent> source)
    {
      if (source == null)
        return null;

      var tmp4030 = new List<global::Yaskawa.Ext.API.ControllerEvent>(source.Count);
      foreach (var elem in source)
        tmp4030.Add((elem != null) ? elem.DeepCopy() : null);
      return tmp4030;
    }


    public static bool Equals(this List<global::Yaskawa.Ext.API.DataPoint> instance, object that)
    {
      if (!(that is List<global::Yaskawa.Ext.API.DataPoint> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this List<global::Yaskawa.Ext.API.DataPoint> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static List<global::Yaskawa.Ext.API.DataPoint> DeepCopy(this List<global::Yaskawa.Ext.API.DataPoint> source)
    {
      if (source == null)
        return null;

      var tmp4031 = new List<global::Yaskawa.Ext.API.DataPoint>(source.Count);
      foreach (var elem in source)
        tmp4031.Add((elem != null) ? elem.DeepCopy() : null);
      return tmp4031;
    }


    public static bool Equals(this List<global::Yaskawa.Ext.API.GaugeSensorSpec> instance, object that)
    {
      if (!(that is List<global::Yaskawa.Ext.API.GaugeSensorSpec> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this List<global::Yaskawa.Ext.API.GaugeSensorSpec> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static List<global::Yaskawa.Ext.API.GaugeSensorSpec> DeepCopy(this List<global::Yaskawa.Ext.API.GaugeSensorSpec> source)
    {
      if (source == null)
        return null;

      var tmp4032 = new List<global::Yaskawa.Ext.API.GaugeSensorSpec>(source.Count);
      foreach (var elem in source)
        tmp4032.Add((elem != null) ? elem.DeepCopy() : null);
      return tmp4032;
    }


    public static bool Equals(this List<global::Yaskawa.Ext.API.JointType> instance, object that)
    {
      if (!(that is List<global::Yaskawa.Ext.API.JointType> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this List<global::Yaskawa.Ext.API.JointType> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static List<global::Yaskawa.Ext.API.JointType> DeepCopy(this List<global::Yaskawa.Ext.API.JointType> source)
    {
      if (source == null)
        return null;

      var tmp4033 = new List<global::Yaskawa.Ext.API.JointType>(source.Count);
      foreach (var elem in source)
        tmp4033.Add(elem);
      return tmp4033;
    }


    public static bool Equals(this List<global::Yaskawa.Ext.API.LoggingEvent> instance, object that)
    {
      if (!(that is List<global::Yaskawa.Ext.API.LoggingEvent> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this List<global::Yaskawa.Ext.API.LoggingEvent> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static List<global::Yaskawa.Ext.API.LoggingEvent> DeepCopy(this List<global::Yaskawa.Ext.API.LoggingEvent> source)
    {
      if (source == null)
        return null;

      var tmp4034 = new List<global::Yaskawa.Ext.API.LoggingEvent>(source.Count);
      foreach (var elem in source)
        tmp4034.Add((elem != null) ? elem.DeepCopy() : null);
      return tmp4034;
    }


    public static bool Equals(this List<global::Yaskawa.Ext.API.PendantEvent> instance, object that)
    {
      if (!(that is List<global::Yaskawa.Ext.API.PendantEvent> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this List<global::Yaskawa.Ext.API.PendantEvent> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static List<global::Yaskawa.Ext.API.PendantEvent> DeepCopy(this List<global::Yaskawa.Ext.API.PendantEvent> source)
    {
      if (source == null)
        return null;

      var tmp4035 = new List<global::Yaskawa.Ext.API.PendantEvent>(source.Count);
      foreach (var elem in source)
        tmp4035.Add((elem != null) ? elem.DeepCopy() : null);
      return tmp4035;
    }


    public static bool Equals(this List<global::Yaskawa.Ext.API.PropValues> instance, object that)
    {
      if (!(that is List<global::Yaskawa.Ext.API.PropValues> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this List<global::Yaskawa.Ext.API.PropValues> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static List<global::Yaskawa.Ext.API.PropValues> DeepCopy(this List<global::Yaskawa.Ext.API.PropValues> source)
    {
      if (source == null)
        return null;

      var tmp4036 = new List<global::Yaskawa.Ext.API.PropValues>(source.Count);
      foreach (var elem in source)
        tmp4036.Add((elem != null) ? elem.DeepCopy() : null);
      return tmp4036;
    }


    public static bool Equals(this List<global::Yaskawa.Ext.API.SimpleControlGroup> instance, object that)
    {
      if (!(that is List<global::Yaskawa.Ext.API.SimpleControlGroup> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this List<global::Yaskawa.Ext.API.SimpleControlGroup> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static List<global::Yaskawa.Ext.API.SimpleControlGroup> DeepCopy(this List<global::Yaskawa.Ext.API.SimpleControlGroup> source)
    {
      if (source == null)
        return null;

      var tmp4037 = new List<global::Yaskawa.Ext.API.SimpleControlGroup>(source.Count);
      foreach (var elem in source)
        tmp4037.Add((elem != null) ? elem.DeepCopy() : null);
      return tmp4037;
    }


    public static bool Equals(this List<global::Yaskawa.Ext.API.storageInfo> instance, object that)
    {
      if (!(that is List<global::Yaskawa.Ext.API.storageInfo> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this List<global::Yaskawa.Ext.API.storageInfo> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static List<global::Yaskawa.Ext.API.storageInfo> DeepCopy(this List<global::Yaskawa.Ext.API.storageInfo> source)
    {
      if (source == null)
        return null;

      var tmp4038 = new List<global::Yaskawa.Ext.API.storageInfo>(source.Count);
      foreach (var elem in source)
        tmp4038.Add((elem != null) ? elem.DeepCopy() : null);
      return tmp4038;
    }


    public static bool Equals(this List<long> instance, object that)
    {
      if (!(that is List<long> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this List<long> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static List<long> DeepCopy(this List<long> source)
    {
      if (source == null)
        return null;

      var tmp4039 = new List<long>(source.Count);
      foreach (var elem in source)
        tmp4039.Add(elem);
      return tmp4039;
    }


    public static bool Equals(this List<string> instance, object that)
    {
      if (!(that is List<string> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this List<string> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static List<string> DeepCopy(this List<string> source)
    {
      if (source == null)
        return null;

      var tmp4040 = new List<string>(source.Count);
      foreach (var elem in source)
        tmp4040.Add((elem != null) ? elem : null);
      return tmp4040;
    }


  }
}
