/**
 * <auto-generated>
 * Autogenerated by Thrift Compiler (0.17.0)
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 * </auto-generated>
 */

#pragma warning disable IDE0079  // remove unnecessary pragmas
#pragma warning disable IDE0017  // object init can be simplified
#pragma warning disable IDE0028  // collection init can be simplified
#pragma warning disable IDE1006  // parts of the code use IDL spelling
#pragma warning disable CA1822   // empty DeepCopy() methods still non-static
#pragma warning disable IDE0083  // pattern matching "that is not SomeType" requires net5.0 but we still support earlier versions

namespace Yaskawa.Ext.API
{
  /// <summary>
  /// Variable address space
  /// </summary>
  public enum AddressSpace
  {
    Unified = 0,
    Byte = 1,
    Int = 2,
    DoubleInt = 3,
    Real = 4,
    String = 5,
    Position = 6,
    BasePosition = 7,
    StationPosition = 8,
  }
}
