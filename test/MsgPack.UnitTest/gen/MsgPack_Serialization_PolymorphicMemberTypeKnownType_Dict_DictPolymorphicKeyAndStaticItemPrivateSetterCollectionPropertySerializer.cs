﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MsgPack.Serialization.GeneratedSerializers {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MsgPack.Serialization.CodeDomSerializers.CodeDomSerializerBuilder", "0.7.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class MsgPack_Serialization_PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndStaticItemPrivateSetterCollectionPropertySerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndStaticItemPrivateSetterCollectionProperty> {
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.IDictionary<MsgPack.Serialization.FileSystemEntry, string>> _serializer0;
        
        private System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndStaticItemPrivateSetterCollectionProperty> this_PackValueOfDictPolymorphicKeyAndStaticItemDelegate;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndStaticItemPrivateSetterCollectionProperty>> _packOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndStaticItemPrivateSetterCollectionProperty>> _packOperationTable;
        
        private System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndStaticItemPrivateSetterCollectionProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task> this_PackValueOfDictPolymorphicKeyAndStaticItemAsyncDelegate;
        
        private System.Collections.Generic.IList<System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndStaticItemPrivateSetterCollectionProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _packOperationListAsync;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndStaticItemPrivateSetterCollectionProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _packOperationTableAsync;
        
        private System.Reflection.MethodBase _methodBasePolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndStaticItemPrivateSetterCollectionProperty_set_DictPolymorphicKeyAndStaticItem0;
        
        private System.Action<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndStaticItemPrivateSetterCollectionProperty, System.Collections.Generic.IDictionary<MsgPack.Serialization.FileSystemEntry, string>> this_SetUnpackedValueOfDictPolymorphicKeyAndStaticItemDelegate;
        
        private System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndStaticItemPrivateSetterCollectionProperty, int, int> this_UnpackValueOfDictPolymorphicKeyAndStaticItemDelegate;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndStaticItemPrivateSetterCollectionProperty, int, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndStaticItemPrivateSetterCollectionProperty, int, int>> _unpackOperationTable;
        
        private System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndStaticItemPrivateSetterCollectionProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task> this_UnpackValueOfDictPolymorphicKeyAndStaticItemAsyncDelegate;
        
        private System.Collections.Generic.IList<System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndStaticItemPrivateSetterCollectionProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _unpackOperationListAsync;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndStaticItemPrivateSetterCollectionProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _unpackOperationTableAsync;
        
        public MsgPack_Serialization_PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndStaticItemPrivateSetterCollectionPropertySerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            MsgPack.Serialization.PolymorphismSchema keysSchema0 = default(MsgPack.Serialization.PolymorphismSchema);
            System.Collections.Generic.Dictionary<string, System.Type> keysSchemaTypeMap0 = default(System.Collections.Generic.Dictionary<string, System.Type>);
            keysSchemaTypeMap0 = new System.Collections.Generic.Dictionary<string, System.Type>(2);
            keysSchemaTypeMap0.Add("0", typeof(MsgPack.Serialization.FileEntry));
            keysSchemaTypeMap0.Add("1", typeof(MsgPack.Serialization.DirectoryEntry));
            keysSchema0 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(MsgPack.Serialization.FileSystemEntry), keysSchemaTypeMap0);
            schema0 = MsgPack.Serialization.PolymorphismSchema.ForContextSpecifiedDictionary(typeof(System.Collections.Generic.IDictionary<MsgPack.Serialization.FileSystemEntry, string>), keysSchema0, null);
            this._serializer0 = context.GetSerializer<System.Collections.Generic.IDictionary<MsgPack.Serialization.FileSystemEntry, string>>(schema0);
            this._methodBasePolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndStaticItemPrivateSetterCollectionProperty_set_DictPolymorphicKeyAndStaticItem0 = typeof(MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndStaticItemPrivateSetterCollectionProperty).GetMethod("set_DictPolymorphicKeyAndStaticItem", (System.Reflection.BindingFlags.Instance 
                            | (System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic)), null, new System.Type[] {
                        typeof(System.Collections.Generic.IDictionary<MsgPack.Serialization.FileSystemEntry, string>)}, null);
            System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndStaticItemPrivateSetterCollectionProperty>[] packOperationList = default(System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndStaticItemPrivateSetterCollectionProperty>[]);
            packOperationList = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndStaticItemPrivateSetterCollectionProperty>[1];
            packOperationList[0] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndStaticItemPrivateSetterCollectionProperty>(this.PackValueOfDictPolymorphicKeyAndStaticItem);
            this._packOperationList = packOperationList;
            System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndStaticItemPrivateSetterCollectionProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task>[] packOperationListAsync = default(System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndStaticItemPrivateSetterCollectionProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task>[]);
            packOperationListAsync = new System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndStaticItemPrivateSetterCollectionProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task>[1];
            packOperationListAsync[0] = new System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndStaticItemPrivateSetterCollectionProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfDictPolymorphicKeyAndStaticItemAsync);
            this._packOperationListAsync = packOperationListAsync;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndStaticItemPrivateSetterCollectionProperty>> packOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndStaticItemPrivateSetterCollectionProperty>>);
            packOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndStaticItemPrivateSetterCollectionProperty>>(1);
            packOperationTable["DictPolymorphicKeyAndStaticItem"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndStaticItemPrivateSetterCollectionProperty>(this.PackValueOfDictPolymorphicKeyAndStaticItem);
            this._packOperationTable = packOperationTable;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndStaticItemPrivateSetterCollectionProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task>> packOperationTableAsync = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndStaticItemPrivateSetterCollectionProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task>>);
            packOperationTableAsync = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndStaticItemPrivateSetterCollectionProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task>>(1);
            packOperationTableAsync["DictPolymorphicKeyAndStaticItem"] = new System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndStaticItemPrivateSetterCollectionProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfDictPolymorphicKeyAndStaticItemAsync);
            this._packOperationTableAsync = packOperationTableAsync;
            System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndStaticItemPrivateSetterCollectionProperty, int, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndStaticItemPrivateSetterCollectionProperty, int, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndStaticItemPrivateSetterCollectionProperty, int, int>[1];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndStaticItemPrivateSetterCollectionProperty, int, int>(this.UnpackValueOfDictPolymorphicKeyAndStaticItem);
            this._unpackOperationList = unpackOperationList;
            System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndStaticItemPrivateSetterCollectionProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>[] unpackOperationListAsync = default(System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndStaticItemPrivateSetterCollectionProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>[]);
            unpackOperationListAsync = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndStaticItemPrivateSetterCollectionProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>[1];
            unpackOperationListAsync[0] = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndStaticItemPrivateSetterCollectionProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfDictPolymorphicKeyAndStaticItemAsync);
            this._unpackOperationListAsync = unpackOperationListAsync;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndStaticItemPrivateSetterCollectionProperty, int, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndStaticItemPrivateSetterCollectionProperty, int, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndStaticItemPrivateSetterCollectionProperty, int, int>>(1);
            unpackOperationTable["DictPolymorphicKeyAndStaticItem"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndStaticItemPrivateSetterCollectionProperty, int, int>(this.UnpackValueOfDictPolymorphicKeyAndStaticItem);
            this._unpackOperationTable = unpackOperationTable;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndStaticItemPrivateSetterCollectionProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>> unpackOperationTableAsync = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndStaticItemPrivateSetterCollectionProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>>);
            unpackOperationTableAsync = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndStaticItemPrivateSetterCollectionProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>>(1);
            unpackOperationTableAsync["DictPolymorphicKeyAndStaticItem"] = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndStaticItemPrivateSetterCollectionProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfDictPolymorphicKeyAndStaticItemAsync);
            this._unpackOperationTableAsync = unpackOperationTableAsync;
            this._memberNames = new string[] {
                    "DictPolymorphicKeyAndStaticItem"};
            this.this_PackValueOfDictPolymorphicKeyAndStaticItemDelegate = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndStaticItemPrivateSetterCollectionProperty>(this.PackValueOfDictPolymorphicKeyAndStaticItem);
            this.this_PackValueOfDictPolymorphicKeyAndStaticItemAsyncDelegate = new System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndStaticItemPrivateSetterCollectionProperty, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfDictPolymorphicKeyAndStaticItemAsync);
            this.this_SetUnpackedValueOfDictPolymorphicKeyAndStaticItemDelegate = new System.Action<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndStaticItemPrivateSetterCollectionProperty, System.Collections.Generic.IDictionary<MsgPack.Serialization.FileSystemEntry, string>>(this.SetUnpackedValueOfDictPolymorphicKeyAndStaticItem);
            this.this_UnpackValueOfDictPolymorphicKeyAndStaticItemDelegate = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndStaticItemPrivateSetterCollectionProperty, int, int>(this.UnpackValueOfDictPolymorphicKeyAndStaticItem);
            this.this_UnpackValueOfDictPolymorphicKeyAndStaticItemAsyncDelegate = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndStaticItemPrivateSetterCollectionProperty, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfDictPolymorphicKeyAndStaticItemAsync);
        }
        
        private void PackValueOfDictPolymorphicKeyAndStaticItem(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndStaticItemPrivateSetterCollectionProperty objectTree) {
            this._serializer0.PackTo(packer, objectTree.DictPolymorphicKeyAndStaticItem);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndStaticItemPrivateSetterCollectionProperty objectTree) {
            if ((this.OwnerContext.SerializationMethod == MsgPack.Serialization.SerializationMethod.Array)) {
                MsgPack.Serialization.PackHelpers.PackToArray(packer, objectTree, this._packOperationList);
            }
            else {
                MsgPack.Serialization.PackHelpers.PackToMap(packer, objectTree, this._packOperationTable);
            }
        }
        
        private System.Threading.Tasks.Task PackValueOfDictPolymorphicKeyAndStaticItemAsync(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndStaticItemPrivateSetterCollectionProperty objectTree, System.Threading.CancellationToken cancellationToken) {
            return this._serializer0.PackToAsync(packer, objectTree.DictPolymorphicKeyAndStaticItem, cancellationToken);
        }
        
        protected internal override System.Threading.Tasks.Task PackToAsyncCore(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndStaticItemPrivateSetterCollectionProperty objectTree, System.Threading.CancellationToken cancellationToken) {
            if ((this.OwnerContext.SerializationMethod == MsgPack.Serialization.SerializationMethod.Array)) {
                return MsgPack.Serialization.PackHelpers.PackToArrayAsync(packer, objectTree, this._packOperationListAsync, cancellationToken);
            }
            else {
                return MsgPack.Serialization.PackHelpers.PackToMapAsync(packer, objectTree, this._packOperationTableAsync, cancellationToken);
            }
        }
        
        private void SetUnpackedValueOfDictPolymorphicKeyAndStaticItem(MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndStaticItemPrivateSetterCollectionProperty unpackingContext, System.Collections.Generic.IDictionary<MsgPack.Serialization.FileSystemEntry, string> unpackedValue) {
            System.Collections.Generic.IDictionary<MsgPack.Serialization.FileSystemEntry, string> existent = default(System.Collections.Generic.IDictionary<MsgPack.Serialization.FileSystemEntry, string>);
            existent = unpackingContext.DictPolymorphicKeyAndStaticItem;
            if ((existent == null)) {
                this._methodBasePolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndStaticItemPrivateSetterCollectionProperty_set_DictPolymorphicKeyAndStaticItem0.Invoke(unpackingContext, new object[] {
                            unpackedValue});
            }
            else {
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
        }
        
        private void UnpackValueOfDictPolymorphicKeyAndStaticItem(MsgPack.Unpacker unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndStaticItemPrivateSetterCollectionProperty unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(unpacker, unpackingContext, this._serializer0, itemsCount, indexOfItem, typeof(System.Collections.Generic.IDictionary<MsgPack.Serialization.FileSystemEntry, string>), "DictPolymorphicKeyAndStaticItem", MsgPack.Serialization.NilImplication.MemberDefault, null, this.this_SetUnpackedValueOfDictPolymorphicKeyAndStaticItemDelegate);
        }
        
        protected internal override MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndStaticItemPrivateSetterCollectionProperty UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndStaticItemPrivateSetterCollectionProperty result = default(MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndStaticItemPrivateSetterCollectionProperty);
            result = new MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndStaticItemPrivateSetterCollectionProperty();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndStaticItemPrivateSetterCollectionProperty>(), this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndStaticItemPrivateSetterCollectionProperty>(), this._unpackOperationTable);
            }
        }
        
        private System.Threading.Tasks.Task UnpackValueOfDictPolymorphicKeyAndStaticItemAsync(MsgPack.Unpacker unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndStaticItemPrivateSetterCollectionProperty unpackingContext, int indexOfItem, int itemsCount, System.Threading.CancellationToken cancellationToken) {
            return MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValueAsync(unpacker, unpackingContext, this._serializer0, itemsCount, indexOfItem, typeof(System.Collections.Generic.IDictionary<MsgPack.Serialization.FileSystemEntry, string>), "DictPolymorphicKeyAndStaticItem", MsgPack.Serialization.NilImplication.MemberDefault, null, this.this_SetUnpackedValueOfDictPolymorphicKeyAndStaticItemDelegate, cancellationToken);
        }
        
        protected internal override System.Threading.Tasks.Task<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndStaticItemPrivateSetterCollectionProperty> UnpackFromAsyncCore(MsgPack.Unpacker unpacker, System.Threading.CancellationToken cancellationToken) {
            MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndStaticItemPrivateSetterCollectionProperty result = default(MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndStaticItemPrivateSetterCollectionProperty);
            result = new MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndStaticItemPrivateSetterCollectionProperty();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArrayAsync(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndStaticItemPrivateSetterCollectionProperty>(), this._memberNames, this._unpackOperationListAsync, cancellationToken);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMapAsync(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndStaticItemPrivateSetterCollectionProperty>(), this._unpackOperationTableAsync, cancellationToken);
            }
        }
    }
}
