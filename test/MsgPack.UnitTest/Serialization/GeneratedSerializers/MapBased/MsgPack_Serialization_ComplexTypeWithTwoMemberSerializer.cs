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
    public class MsgPack_Serialization_ComplexTypeWithTwoMemberSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.ComplexTypeWithTwoMember> {
        
        private MsgPack.Serialization.MessagePackSerializer<string> _serializer0;
        
        public MsgPack_Serialization_ComplexTypeWithTwoMemberSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(MsgPack_Serialization_ComplexTypeWithTwoMemberSerializer.@__Conditional((context != null), context, MsgPack.Serialization.SerializationContext.Default).CompatibilityOptions.PackerCompatibilityOptions) {
            MsgPack.Serialization.SerializationContext safeContext = MsgPack_Serialization_ComplexTypeWithTwoMemberSerializer.@__Conditional((context != null), context, MsgPack.Serialization.SerializationContext.Default);
            this._serializer0 = safeContext.GetSerializer<string>();
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.ComplexTypeWithTwoMember objectTree) {
            packer.PackMapHeader(2);
            this._serializer0.PackTo(packer, "Value1");
            this._serializer0.PackTo(packer, objectTree.Value1);
            this._serializer0.PackTo(packer, "Value2");
            this._serializer0.PackTo(packer, objectTree.Value2);
        }
        
        protected internal override MsgPack.Serialization.ComplexTypeWithTwoMember UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.ComplexTypeWithTwoMember result = default(MsgPack.Serialization.ComplexTypeWithTwoMember);
            result = new MsgPack.Serialization.ComplexTypeWithTwoMember();
            if (unpacker.IsArrayHeader) {
                int unpacked = default(int);
                int itemsCount = default(int);
                itemsCount = MsgPack.Serialization.UnpackHelpers.GetItemsCount(unpacker);
                string nullable = default(string);
                if ((unpacked < itemsCount)) {
                    nullable = MsgPack.Serialization.UnpackHelpers.UnpackStringValue(unpacker, typeof(MsgPack.Serialization.ComplexTypeWithTwoMember), "System.String Value1");
                }
                if (((nullable == null) 
                            == false)) {
                    result.Value1 = nullable;
                }
                unpacked = (unpacked + 1);
                string nullable0 = default(string);
                if ((unpacked < itemsCount)) {
                    nullable0 = MsgPack.Serialization.UnpackHelpers.UnpackStringValue(unpacker, typeof(MsgPack.Serialization.ComplexTypeWithTwoMember), "System.String Value2");
                }
                if (((nullable0 == null) 
                            == false)) {
                    result.Value2 = nullable0;
                }
                unpacked = (unpacked + 1);
            }
            else {
                int itemsCount0 = default(int);
                itemsCount0 = MsgPack.Serialization.UnpackHelpers.GetItemsCount(unpacker);
                for (int i = 0; (i < itemsCount0); i = (i + 1)) {
                    string key = default(string);
                    string nullable1 = default(string);
                    nullable1 = MsgPack.Serialization.UnpackHelpers.UnpackStringValue(unpacker, typeof(MsgPack.Serialization.ComplexTypeWithTwoMember), "MemberName");
                    if (((nullable1 == null) 
                                == false)) {
                        key = nullable1;
                    }
                    else {
                        throw MsgPack.Serialization.SerializationExceptions.NewNullIsProhibited("MemberName");
                    }
                    if ((key == "Value2")) {
                        string nullable3 = default(string);
                        nullable3 = MsgPack.Serialization.UnpackHelpers.UnpackStringValue(unpacker, typeof(MsgPack.Serialization.ComplexTypeWithTwoMember), "System.String Value2");
                        if (((nullable3 == null) 
                                    == false)) {
                            result.Value2 = nullable3;
                        }
                    }
                    else {
                        if ((key == "Value1")) {
                            string nullable2 = default(string);
                            nullable2 = MsgPack.Serialization.UnpackHelpers.UnpackStringValue(unpacker, typeof(MsgPack.Serialization.ComplexTypeWithTwoMember), "System.String Value1");
                            if (((nullable2 == null) 
                                        == false)) {
                                result.Value1 = nullable2;
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
