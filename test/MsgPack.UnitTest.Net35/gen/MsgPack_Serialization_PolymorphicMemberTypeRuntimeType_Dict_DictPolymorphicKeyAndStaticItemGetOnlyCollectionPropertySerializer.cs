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
    public class MsgPack_Serialization_PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemGetOnlyCollectionPropertySerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemGetOnlyCollectionProperty> {
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.IDictionary<MsgPack.Serialization.FileSystemEntry, string>> _serializer0;
        
        private System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemGetOnlyCollectionProperty> this_PackValueOfDictPolymorphicKeyAndStaticItemDelegate;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemGetOnlyCollectionProperty>> _packOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemGetOnlyCollectionProperty>> _packOperationTable;
        
        private System.Action<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemGetOnlyCollectionProperty, System.Collections.Generic.IDictionary<MsgPack.Serialization.FileSystemEntry, string>> this_SetUnpackedValueOfDictPolymorphicKeyAndStaticItemDelegate;
        
        private System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemGetOnlyCollectionProperty, int, int> this_UnpackValueOfDictPolymorphicKeyAndStaticItemDelegate;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemGetOnlyCollectionProperty, int, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemGetOnlyCollectionProperty, int, int>> _unpackOperationTable;
        
        public MsgPack_Serialization_PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemGetOnlyCollectionPropertySerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            MsgPack.Serialization.PolymorphismSchema keysSchema0 = default(MsgPack.Serialization.PolymorphismSchema);
            keysSchema0 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(MsgPack.Serialization.FileSystemEntry));
            schema0 = MsgPack.Serialization.PolymorphismSchema.ForContextSpecifiedDictionary(typeof(System.Collections.Generic.IDictionary<MsgPack.Serialization.FileSystemEntry, string>), keysSchema0, null);
            this._serializer0 = context.GetSerializer<System.Collections.Generic.IDictionary<MsgPack.Serialization.FileSystemEntry, string>>(schema0);
            System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemGetOnlyCollectionProperty>[] packOperationList = default(System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemGetOnlyCollectionProperty>[]);
            packOperationList = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemGetOnlyCollectionProperty>[1];
            packOperationList[0] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemGetOnlyCollectionProperty>(this.PackValueOfDictPolymorphicKeyAndStaticItem);
            this._packOperationList = packOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemGetOnlyCollectionProperty>> packOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemGetOnlyCollectionProperty>>);
            packOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemGetOnlyCollectionProperty>>(1);
            packOperationTable["DictPolymorphicKeyAndStaticItem"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemGetOnlyCollectionProperty>(this.PackValueOfDictPolymorphicKeyAndStaticItem);
            this._packOperationTable = packOperationTable;
            System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemGetOnlyCollectionProperty, int, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemGetOnlyCollectionProperty, int, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemGetOnlyCollectionProperty, int, int>[1];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemGetOnlyCollectionProperty, int, int>(this.UnpackValueOfDictPolymorphicKeyAndStaticItem);
            this._unpackOperationList = unpackOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemGetOnlyCollectionProperty, int, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemGetOnlyCollectionProperty, int, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemGetOnlyCollectionProperty, int, int>>(1);
            unpackOperationTable["DictPolymorphicKeyAndStaticItem"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemGetOnlyCollectionProperty, int, int>(this.UnpackValueOfDictPolymorphicKeyAndStaticItem);
            this._unpackOperationTable = unpackOperationTable;
            this._memberNames = new string[] {
                    "DictPolymorphicKeyAndStaticItem"};
            this.this_PackValueOfDictPolymorphicKeyAndStaticItemDelegate = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemGetOnlyCollectionProperty>(this.PackValueOfDictPolymorphicKeyAndStaticItem);
            this.this_SetUnpackedValueOfDictPolymorphicKeyAndStaticItemDelegate = new System.Action<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemGetOnlyCollectionProperty, System.Collections.Generic.IDictionary<MsgPack.Serialization.FileSystemEntry, string>>(this.SetUnpackedValueOfDictPolymorphicKeyAndStaticItem);
            this.this_UnpackValueOfDictPolymorphicKeyAndStaticItemDelegate = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemGetOnlyCollectionProperty, int, int>(this.UnpackValueOfDictPolymorphicKeyAndStaticItem);
        }
        
        private void PackValueOfDictPolymorphicKeyAndStaticItem(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemGetOnlyCollectionProperty objectTree) {
            this._serializer0.PackTo(packer, objectTree.DictPolymorphicKeyAndStaticItem);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemGetOnlyCollectionProperty objectTree) {
            if ((this.OwnerContext.SerializationMethod == MsgPack.Serialization.SerializationMethod.Array)) {
                MsgPack.Serialization.PackHelpers.PackToArray(packer, objectTree, this._packOperationList);
            }
            else {
                MsgPack.Serialization.PackHelpers.PackToMap(packer, objectTree, this._packOperationTable);
            }
        }
        
        private void SetUnpackedValueOfDictPolymorphicKeyAndStaticItem(MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemGetOnlyCollectionProperty unpackingContext, System.Collections.Generic.IDictionary<MsgPack.Serialization.FileSystemEntry, string> unpackedValue) {
            System.Collections.Generic.IDictionary<MsgPack.Serialization.FileSystemEntry, string> existent = default(System.Collections.Generic.IDictionary<MsgPack.Serialization.FileSystemEntry, string>);
            existent = unpackingContext.DictPolymorphicKeyAndStaticItem;
            System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<MsgPack.Serialization.FileSystemEntry, string>> enumerator = unpackedValue.GetEnumerator();
            System.Collections.Generic.KeyValuePair<MsgPack.Serialization.FileSystemEntry, string> current;
            try {
                for (
                ; enumerator.MoveNext(); 
                ) {
                    current = enumerator.Current;
                    existent.Add(current.Key, current.Value);
                }
            }
            finally {
                enumerator.Dispose();
            }
        }
        
        private void UnpackValueOfDictPolymorphicKeyAndStaticItem(MsgPack.Unpacker unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemGetOnlyCollectionProperty unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(unpacker, unpackingContext, this._serializer0, itemsCount, indexOfItem, typeof(System.Collections.Generic.IDictionary<MsgPack.Serialization.FileSystemEntry, string>), "DictPolymorphicKeyAndStaticItem", MsgPack.Serialization.NilImplication.MemberDefault, null, this.this_SetUnpackedValueOfDictPolymorphicKeyAndStaticItemDelegate);
        }
        
        protected internal override MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemGetOnlyCollectionProperty UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemGetOnlyCollectionProperty result = default(MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemGetOnlyCollectionProperty);
            result = new MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemGetOnlyCollectionProperty();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemGetOnlyCollectionProperty>(), this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemGetOnlyCollectionProperty>(), this._unpackOperationTable);
            }
        }
    }
}
