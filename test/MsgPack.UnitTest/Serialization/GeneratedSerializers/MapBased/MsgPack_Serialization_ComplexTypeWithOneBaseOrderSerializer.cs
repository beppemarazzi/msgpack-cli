﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.34011
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MsgPack.Serialization.GeneratedSerializers.MapBased {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MsgPack.Serialization.CodeDomSerializers.CodeDomSerializerBuilder", "0.5.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class MsgPack_Serialization_ComplexTypeWithOneBaseOrderSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.ComplexTypeWithOneBaseOrder> {
        
        private MsgPack.Serialization.MessagePackSerializer<string> _serializer0;
        
        private MsgPack.Serialization.MessagePackSerializer<int> _serializer1;
        
        public MsgPack_Serialization_ComplexTypeWithOneBaseOrderSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(MsgPack_Serialization_ComplexTypeWithOneBaseOrderSerializer.@__Conditional((context != null), context, MsgPack.Serialization.SerializationContext.Default).CompatibilityOptions.PackerCompatibilityOptions) {
            MsgPack.Serialization.SerializationContext safeContext = MsgPack_Serialization_ComplexTypeWithOneBaseOrderSerializer.@__Conditional((context != null), context, MsgPack.Serialization.SerializationContext.Default);
            this._serializer0 = safeContext.GetSerializer<string>();
            this._serializer1 = safeContext.GetSerializer<int>();
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.ComplexTypeWithOneBaseOrder objectTree) {
            packer.PackMapHeader(2);
            this._serializer0.PackTo(packer, "One");
            this._serializer1.PackTo(packer, objectTree.One);
            this._serializer0.PackTo(packer, "Two");
            this._serializer1.PackTo(packer, objectTree.Two);
        }
        
        protected internal override MsgPack.Serialization.ComplexTypeWithOneBaseOrder UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.ComplexTypeWithOneBaseOrder result = default(MsgPack.Serialization.ComplexTypeWithOneBaseOrder);
            result = new MsgPack.Serialization.ComplexTypeWithOneBaseOrder();
            if (unpacker.IsArrayHeader) {
                int unpacked = default(int);
                int itemsCount = default(int);
                itemsCount = MsgPack.Serialization.UnpackHelpers.GetItemsCount(unpacker);
                unpacker.Read();
                System.Nullable<int> nullable = default(System.Nullable<int>);
                if ((unpacked < itemsCount)) {
                    nullable = MsgPack.Serialization.UnpackHelpers.UnpackNullableInt32Value(unpacker, typeof(MsgPack.Serialization.ComplexTypeWithOneBaseOrder), "Int32 One");
                }
                if (nullable.HasValue) {
                    result.One = nullable.Value;
                }
                unpacked = (unpacked + 1);
                System.Nullable<int> nullable0 = default(System.Nullable<int>);
                if ((unpacked < itemsCount)) {
                    nullable0 = MsgPack.Serialization.UnpackHelpers.UnpackNullableInt32Value(unpacker, typeof(MsgPack.Serialization.ComplexTypeWithOneBaseOrder), "Int32 Two");
                }
                if (nullable0.HasValue) {
                    result.Two = nullable0.Value;
                }
                unpacked = (unpacked + 1);
            }
            else {
                int itemsCount0 = default(int);
                itemsCount0 = MsgPack.Serialization.UnpackHelpers.GetItemsCount(unpacker);
                for (int i = 0; (i < itemsCount0); i = (i + 1)) {
                    string key = default(string);
                    string nullable1 = default(string);
                    nullable1 = MsgPack.Serialization.UnpackHelpers.UnpackStringValue(unpacker, typeof(MsgPack.Serialization.ComplexTypeWithOneBaseOrder), "MemberName");
                    if (((nullable1 == null) 
                                == false)) {
                        key = nullable1;
                    }
                    else {
                        throw MsgPack.Serialization.SerializationExceptions.NewNullIsProhibited("MemberName");
                    }
                    if ((key == "Two")) {
                        System.Nullable<int> nullable3 = default(System.Nullable<int>);
                        nullable3 = MsgPack.Serialization.UnpackHelpers.UnpackNullableInt32Value(unpacker, typeof(MsgPack.Serialization.ComplexTypeWithOneBaseOrder), "Int32 Two");
                        if (nullable3.HasValue) {
                            result.Two = nullable3.Value;
                        }
                    }
                    else {
                        if ((key == "One")) {
                            System.Nullable<int> nullable2 = default(System.Nullable<int>);
                            nullable2 = MsgPack.Serialization.UnpackHelpers.UnpackNullableInt32Value(unpacker, typeof(MsgPack.Serialization.ComplexTypeWithOneBaseOrder), "Int32 One");
                            if (nullable2.HasValue) {
                                result.One = nullable2.Value;
                            }
                        }
                    }
                }
            }
            return result;
        }
        
        private static T @__Conditional<T>(bool condition, T whenTrue, T whenFalse)
         {
            if (condition) {
                return whenTrue;
            }
            else {
                return whenFalse;
            }
        }
    }
}
