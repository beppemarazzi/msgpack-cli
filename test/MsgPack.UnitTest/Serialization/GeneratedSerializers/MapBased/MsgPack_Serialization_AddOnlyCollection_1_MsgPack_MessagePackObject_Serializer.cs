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
    public class MsgPack_Serialization_AddOnlyCollection_1_MsgPack_MessagePackObject_Serializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.AddOnlyCollection<MsgPack.MessagePackObject>> {
        
        private MsgPack.Serialization.MessagePackSerializer<MsgPack.MessagePackObject[]> _serializer0;
        
        public MsgPack_Serialization_AddOnlyCollection_1_MsgPack_MessagePackObject_Serializer(MsgPack.Serialization.SerializationContext context) : 
                base(MsgPack_Serialization_AddOnlyCollection_1_MsgPack_MessagePackObject_Serializer.@__Conditional((context != null), context, MsgPack.Serialization.SerializationContext.Default).CompatibilityOptions.PackerCompatibilityOptions) {
            MsgPack.Serialization.SerializationContext safeContext = MsgPack_Serialization_AddOnlyCollection_1_MsgPack_MessagePackObject_Serializer.@__Conditional((context != null), context, MsgPack.Serialization.SerializationContext.Default);
            this._serializer0 = safeContext.GetSerializer<MsgPack.MessagePackObject[]>();
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.AddOnlyCollection<MsgPack.MessagePackObject> objectTree) {
            this._serializer0.PackTo(packer, System.Linq.Enumerable.ToArray(objectTree));
        }
        
        protected internal override MsgPack.Serialization.AddOnlyCollection<MsgPack.MessagePackObject> UnpackFromCore(MsgPack.Unpacker unpacker) {
            if ((unpacker.IsArrayHeader == false)) {
                throw MsgPack.Serialization.SerializationExceptions.NewIsNotArrayHeader();
            }
            MsgPack.Serialization.AddOnlyCollection<MsgPack.MessagePackObject> collection = default(MsgPack.Serialization.AddOnlyCollection<MsgPack.MessagePackObject>);
            collection = new MsgPack.Serialization.AddOnlyCollection<MsgPack.MessagePackObject>();
            this.UnpackToCore(unpacker, collection);
            return collection;
        }
        
        protected internal override void UnpackToCore(MsgPack.Unpacker unpacker, MsgPack.Serialization.AddOnlyCollection<MsgPack.MessagePackObject> collection) {
            if ((unpacker.IsArrayHeader == false)) {
                throw MsgPack.Serialization.SerializationExceptions.NewIsNotArrayHeader();
            }
            int count = default(int);
            count = MsgPack.Serialization.UnpackHelpers.GetItemsCount(unpacker);
            for (int i = 0; (i < count); i = (i + 1)) {
                MsgPack.MessagePackObject nullable = default(MsgPack.MessagePackObject);
                if ((unpacker.Read() == false)) {
                    throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(i);
                }
                if (((unpacker.IsArrayHeader == false) 
                            && (unpacker.IsMapHeader == false))) {
                    nullable = unpacker.LastReadData;
                }
                else {
                    nullable = unpacker.UnpackSubtreeData();
                }
                if ((nullable.IsNil == false)) {
                    collection.Add(nullable);
                }
                else {
                    collection.Add(nullable);
                }
            }
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
