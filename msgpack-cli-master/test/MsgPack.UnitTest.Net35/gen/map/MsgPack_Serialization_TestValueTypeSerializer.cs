﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:2.0.50727.8009
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MsgPack.Serialization.GeneratedSerializers.MapBased {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MsgPack.Serialization.CodeDomSerializers.CodeDomSerializerBuilder", "0.6.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class MsgPack_Serialization_TestValueTypeSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.TestValueType> {
        
        private MsgPack.Serialization.MessagePackSerializer<string> _serializer0;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.Dictionary<int, int>> _serializer1;
        
        private MsgPack.Serialization.MessagePackSerializer<int[]> _serializer2;
        
        public MsgPack_Serialization_TestValueTypeSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            schema0 = null;
            this._serializer0 = context.GetSerializer<string>(schema0);
            MsgPack.Serialization.PolymorphismSchema schema1 = default(MsgPack.Serialization.PolymorphismSchema);
            schema1 = null;
            this._serializer1 = context.GetSerializer<System.Collections.Generic.Dictionary<int, int>>(schema1);
            MsgPack.Serialization.PolymorphismSchema schema2 = default(MsgPack.Serialization.PolymorphismSchema);
            schema2 = null;
            this._serializer2 = context.GetSerializer<int[]>(schema2);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.TestValueType objectTree) {
            packer.PackMapHeader(3);
            this._serializer0.PackTo(packer, "DictionaryField");
            this._serializer1.PackTo(packer, objectTree.DictionaryField);
            this._serializer0.PackTo(packer, "Int32ArrayField");
            this._serializer2.PackTo(packer, objectTree.Int32ArrayField);
            this._serializer0.PackTo(packer, "StringField");
            this._serializer0.PackTo(packer, objectTree.StringField);
        }
        
        protected internal override MsgPack.Serialization.TestValueType UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.TestValueType result = default(MsgPack.Serialization.TestValueType);
            if (unpacker.IsArrayHeader) {
                int unpacked = default(int);
                int itemsCount = default(int);
                itemsCount = MsgPack.Serialization.UnpackHelpers.GetItemsCount(unpacker);
                System.Collections.Generic.Dictionary<int, int> nullable = default(System.Collections.Generic.Dictionary<int, int>);
                if ((unpacked < itemsCount)) {
                    if ((unpacker.Read() == false)) {
                        throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(0);
                    }
                    if (((unpacker.IsArrayHeader == false) 
                                && (unpacker.IsMapHeader == false))) {
                        nullable = this._serializer1.UnpackFrom(unpacker);
                    }
                    else {
                        MsgPack.Unpacker disposable = default(MsgPack.Unpacker);
                        disposable = unpacker.ReadSubtree();
                        try {
                            nullable = this._serializer1.UnpackFrom(disposable);
                        }
                        finally {
                            if (((disposable == null) 
                                        == false)) {
                                disposable.Dispose();
                            }
                        }
                    }
                }
                if (((nullable == null) 
                            == false)) {
                    result.DictionaryField = nullable;
                }
                unpacked = (unpacked + 1);
                int[] nullable0 = default(int[]);
                if ((unpacked < itemsCount)) {
                    if ((unpacker.Read() == false)) {
                        throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(1);
                    }
                    if (((unpacker.IsArrayHeader == false) 
                                && (unpacker.IsMapHeader == false))) {
                        nullable0 = this._serializer2.UnpackFrom(unpacker);
                    }
                    else {
                        MsgPack.Unpacker disposable0 = default(MsgPack.Unpacker);
                        disposable0 = unpacker.ReadSubtree();
                        try {
                            nullable0 = this._serializer2.UnpackFrom(disposable0);
                        }
                        finally {
                            if (((disposable0 == null) 
                                        == false)) {
                                disposable0.Dispose();
                            }
                        }
                    }
                }
                if (((nullable0 == null) 
                            == false)) {
                    result.Int32ArrayField = nullable0;
                }
                unpacked = (unpacked + 1);
                string nullable1 = default(string);
                if ((unpacked < itemsCount)) {
                    nullable1 = MsgPack.Serialization.UnpackHelpers.UnpackStringValue(unpacker, typeof(MsgPack.Serialization.TestValueType), "System.String StringField");
                }
                if (((nullable1 == null) 
                            == false)) {
                    result.StringField = nullable1;
                }
                unpacked = (unpacked + 1);
            }
            else {
                int itemsCount0 = default(int);
                itemsCount0 = MsgPack.Serialization.UnpackHelpers.GetItemsCount(unpacker);
                for (int i = 0; (i < itemsCount0); i = (i + 1)) {
                    string key = default(string);
                    string nullable2 = default(string);
                    nullable2 = MsgPack.Serialization.UnpackHelpers.UnpackStringValue(unpacker, typeof(MsgPack.Serialization.TestValueType), "MemberName");
                    if (((nullable2 == null) 
                                == false)) {
                        key = nullable2;
                    }
                    else {
                        throw MsgPack.Serialization.SerializationExceptions.NewNullIsProhibited("MemberName");
                    }
                    if ((key == "StringField")) {
                        string nullable5 = default(string);
                        nullable5 = MsgPack.Serialization.UnpackHelpers.UnpackStringValue(unpacker, typeof(MsgPack.Serialization.TestValueType), "System.String StringField");
                        if (((nullable5 == null) 
                                    == false)) {
                            result.StringField = nullable5;
                        }
                    }
                    else {
                        if ((key == "Int32ArrayField")) {
                            int[] nullable4 = default(int[]);
                            if ((unpacker.Read() == false)) {
                                throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(i);
                            }
                            if (((unpacker.IsArrayHeader == false) 
                                        && (unpacker.IsMapHeader == false))) {
                                nullable4 = this._serializer2.UnpackFrom(unpacker);
                            }
                            else {
                                MsgPack.Unpacker disposable2 = default(MsgPack.Unpacker);
                                disposable2 = unpacker.ReadSubtree();
                                try {
                                    nullable4 = this._serializer2.UnpackFrom(disposable2);
                                }
                                finally {
                                    if (((disposable2 == null) 
                                                == false)) {
                                        disposable2.Dispose();
                                    }
                                }
                            }
                            if (((nullable4 == null) 
                                        == false)) {
                                result.Int32ArrayField = nullable4;
                            }
                        }
                        else {
                            if ((key == "DictionaryField")) {
                                System.Collections.Generic.Dictionary<int, int> nullable3 = default(System.Collections.Generic.Dictionary<int, int>);
                                if ((unpacker.Read() == false)) {
                                    throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(i);
                                }
                                if (((unpacker.IsArrayHeader == false) 
                                            && (unpacker.IsMapHeader == false))) {
                                    nullable3 = this._serializer1.UnpackFrom(unpacker);
                                }
                                else {
                                    MsgPack.Unpacker disposable1 = default(MsgPack.Unpacker);
                                    disposable1 = unpacker.ReadSubtree();
                                    try {
                                        nullable3 = this._serializer1.UnpackFrom(disposable1);
                                    }
                                    finally {
                                        if (((disposable1 == null) 
                                                    == false)) {
                                            disposable1.Dispose();
                                        }
                                    }
                                }
                                if (((nullable3 == null) 
                                            == false)) {
                                    result.DictionaryField = nullable3;
                                }
                            }
                            else {
                                unpacker.Skip();
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
