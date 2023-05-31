[assembly:System.Security.AllowPartiallyTrustedCallers()]
[assembly:System.Security.SecurityTransparent()]
[assembly:System.Security.SecurityRules(System.Security.SecurityRuleSet.Level1)]
[assembly:System.Xml.Serialization.XmlSerializerVersionAttribute(ParentAssemblyId=@"503b941e-b5dd-476c-a952-51a3e920f780,", Version=@"1.0.0.0")]
namespace Microsoft.Xml.Serialization.GeneratedAssembly {

    public class XmlSerializationWriterByteBank_Atendimento : System.Xml.Serialization.XmlSerializationWriter {

        public void Write3_ByteBank_Atendimento(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"ByteBank_Atendimento", @"");
                return;
            }
            TopLevelElement();
            Write2_ByteBank_Atendimento(@"ByteBank_Atendimento", @"", ((global::bytebank_ATENDIMENTO.bytebank.Atendimento.ByteBank_Atendimento)o), true, false);
        }

        void Write2_ByteBank_Atendimento(string n, string ns, global::bytebank_ATENDIMENTO.bytebank.Atendimento.ByteBank_Atendimento o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::bytebank_ATENDIMENTO.bytebank.Atendimento.ByteBank_Atendimento)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"ByteBank_Atendimento", @"");
            WriteEndElement(o);
        }

        protected override void InitCallbacks() {
        }
    }

    public class XmlSerializationReaderByteBank_Atendimento : System.Xml.Serialization.XmlSerializationReader {

        public object Read3_ByteBank_Atendimento() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id1_ByteBank_Atendimento && (object) Reader.NamespaceURI == (object)id2_Item)) {
                        o = Read2_ByteBank_Atendimento(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":ByteBank_Atendimento");
            }
            return (object)o;
        }

        global::bytebank_ATENDIMENTO.bytebank.Atendimento.ByteBank_Atendimento Read2_ByteBank_Atendimento(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id1_ByteBank_Atendimento && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::bytebank_ATENDIMENTO.bytebank.Atendimento.ByteBank_Atendimento o;
            o = new global::bytebank_ATENDIMENTO.bytebank.Atendimento.ByteBank_Atendimento();
            System.Span<bool> paramsRead = stackalloc bool[0];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    UnknownNode((object)o, @"");
                }
                else {
                    UnknownNode((object)o, @"");
                }
                Reader.MoveToContent();
            }
            ReadEndElement();
            return o;
        }

        protected override void InitCallbacks() {
        }

        string id1_ByteBank_Atendimento;
        string id2_Item;

        protected override void InitIDs() {
            id1_ByteBank_Atendimento = Reader.NameTable.Add(@"ByteBank_Atendimento");
            id2_Item = Reader.NameTable.Add(@"");
        }
    }

    public abstract class XmlSerializer1 : System.Xml.Serialization.XmlSerializer {
        protected override System.Xml.Serialization.XmlSerializationReader CreateReader() {
            return new XmlSerializationReaderByteBank_Atendimento();
        }
        protected override System.Xml.Serialization.XmlSerializationWriter CreateWriter() {
            return new XmlSerializationWriterByteBank_Atendimento();
        }
    }

    public sealed class ByteBank_AtendimentoSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"ByteBank_Atendimento", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriterByteBank_Atendimento)writer).Write3_ByteBank_Atendimento(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReaderByteBank_Atendimento)reader).Read3_ByteBank_Atendimento();
        }
    }

    public class XmlSerializerContract : global::System.Xml.Serialization.XmlSerializerImplementation {
        public override global::System.Xml.Serialization.XmlSerializationReader Reader { get { return new XmlSerializationReaderByteBank_Atendimento(); } }
        public override global::System.Xml.Serialization.XmlSerializationWriter Writer { get { return new XmlSerializationWriterByteBank_Atendimento(); } }
        System.Collections.Hashtable readMethods = null;
        public override System.Collections.Hashtable ReadMethods {
            get {
                if (readMethods == null) {
                    System.Collections.Hashtable _tmp = new System.Collections.Hashtable();
                    _tmp[@"bytebank_ATENDIMENTO.bytebank.Atendimento.ByteBank_Atendimento::"] = @"Read3_ByteBank_Atendimento";
                    if (readMethods == null) readMethods = _tmp;
                }
                return readMethods;
            }
        }
        System.Collections.Hashtable writeMethods = null;
        public override System.Collections.Hashtable WriteMethods {
            get {
                if (writeMethods == null) {
                    System.Collections.Hashtable _tmp = new System.Collections.Hashtable();
                    _tmp[@"bytebank_ATENDIMENTO.bytebank.Atendimento.ByteBank_Atendimento::"] = @"Write3_ByteBank_Atendimento";
                    if (writeMethods == null) writeMethods = _tmp;
                }
                return writeMethods;
            }
        }
        System.Collections.Hashtable typedSerializers = null;
        public override System.Collections.Hashtable TypedSerializers {
            get {
                if (typedSerializers == null) {
                    System.Collections.Hashtable _tmp = new System.Collections.Hashtable();
                    _tmp.Add(@"bytebank_ATENDIMENTO.bytebank.Atendimento.ByteBank_Atendimento::", new ByteBank_AtendimentoSerializer());
                    if (typedSerializers == null) typedSerializers = _tmp;
                }
                return typedSerializers;
            }
        }
        public override System.Boolean CanSerialize(System.Type type) {
            if (type == typeof(global::bytebank_ATENDIMENTO.bytebank.Atendimento.ByteBank_Atendimento)) return true;
            return false;
        }
        public override System.Xml.Serialization.XmlSerializer GetSerializer(System.Type type) {
            if (type == typeof(global::bytebank_ATENDIMENTO.bytebank.Atendimento.ByteBank_Atendimento)) return new ByteBank_AtendimentoSerializer();
            return null;
        }
    }
}
