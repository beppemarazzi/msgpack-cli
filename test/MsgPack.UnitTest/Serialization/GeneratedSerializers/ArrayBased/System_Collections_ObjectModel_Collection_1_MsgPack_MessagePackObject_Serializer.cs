﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.34011
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MsgPack.Serialization.GeneratedSerializers.ArrayBased {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MsgPack.Serialization.CodeDomSerializers.CodeDomSerializerBuilder", "0.5.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class System_Collections_ObjectModel_Collection_1_MsgPack_MessagePackObject_Serializer : MsgPack.Serialization.MessagePackSerializer<System.Collections.ObjectModel.Collection<MsgPack.MessagePackObject>> {
        
        private MsgPack.Serialization.MessagePackSerializer<MsgPack.MessagePackObject> _serializer0;
        
        public System_Collections_ObjectModel_Collection_1_MsgPack_MessagePackObject_Serializer(MsgPack.Serialization.SerializationContext context) : 
                base(System_Collections_ObjectModel_Collection_1_MsgPack_MessagePackObject_Serializer.@__Conditional((context != null), context, MsgPack.Serialization.SerializationContext.Default).CompatibilityOptions.PackerCompatibilityOptions) {
            MsgPack.Serialization.SerializationContext safeContext = System_Collections_ObjectModel_Collection_1_MsgPack_MessagePackObject_Serializer.@__Conditional((context != null), context, MsgPack.Serialization.SerializationContext.Default);
            this._serializer0 = safeContext.GetSerializer<MsgPack.MessagePackObject>();
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, System.Collections.ObjectModel.Collection<MsgPack.MessagePackObject> objectTree) {
            packer.PackArrayHeader(objectTree.Count);
            System.Collections.Generic.IEnumerator<MsgPack.MessagePackObject> enumerator = objectTree.GetEnumerator();
            MsgPack.MessagePackObject current;
            try {
                for (
                ; enumerator.MoveNext(); 
                ) {
                    current = enumerator.Current;
                    this._serializer0.PackTo(packer, current);
                }
            }
            finally {
                enumerator.Dispose();
            }
        }
        
        protected internal override System.Collections.ObjectModel.Collection<MsgPack.MessagePackObject> UnpackFromCore(MsgPack.Unpacker unpacker) {
            if ((unpacker.IsArrayHeader == false)) {
                throw MsgPack.Serialization.SerializationExceptions.NewIsNotArrayHeader();
            }
            System.Collections.ObjectModel.Collection<MsgPack.MessagePackObject> collection = default(System.Collections.ObjectModel.Collection<MsgPack.MessagePackObject>);
            collection = new System.Collections.ObjectModel.Collection<MsgPack.MessagePackObject>();
            this.UnpackToCore(unpacker, collection);
            return collection;
        }
        
        protected internal override void UnpackToCore(MsgPack.Unpacker unpacker, System.Collections.ObjectModel.Collection<MsgPack.MessagePackObject> collection) {
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
