﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:2.0.50727.8689
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MsgPack.Serialization.GeneratedSerializers {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MsgPack.Serialization.CodeDomSerializers.CodeDomSerializerBuilder", "0.7.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class System_Collections_Generic_HashSet_1_System_DateTimeArray_Serializer : MsgPack.Serialization.CollectionSerializers.CollectionMessagePackSerializer<System.Collections.Generic.HashSet<System.DateTime[]>, System.DateTime[]> {
        
        public System_Collections_Generic_HashSet_1_System_DateTimeArray_Serializer(MsgPack.Serialization.SerializationContext context) : 
                base(context, System_Collections_Generic_HashSet_1_System_DateTimeArray_Serializer.RestoreSchema()) {
        }
        
        protected override System.Collections.Generic.HashSet<System.DateTime[]> CreateInstance(int initialCapacity) {
            System.Collections.Generic.HashSet<System.DateTime[]> collection = default(System.Collections.Generic.HashSet<System.DateTime[]>);
            collection = new System.Collections.Generic.HashSet<System.DateTime[]>(MsgPack.Serialization.UnpackHelpers.GetEqualityComparer<System.DateTime[]>());
            return collection;
        }
        
        private static MsgPack.Serialization.PolymorphismSchema RestoreSchema() {
            MsgPack.Serialization.PolymorphismSchema schema = default(MsgPack.Serialization.PolymorphismSchema);
            schema = null;
            return schema;
        }
    }
}
