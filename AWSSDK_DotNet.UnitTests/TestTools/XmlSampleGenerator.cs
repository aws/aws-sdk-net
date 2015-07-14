using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Text;
using System.Threading.Tasks;

using ServiceClientGenerator;

namespace AWSSDK_DotNet35.UnitTests.TestTools
{
    public class XmlSampleGenerator
    {
        readonly ServiceModel _model;
        readonly Operation _operation;

        public XmlSampleGenerator(ServiceModel model, Operation operation)
        {
            this._model = model;
            this._operation = operation;
        }

        public string Execute()
        {
            var content = new StringWriter();
            using (var writer = XmlTextWriter.Create(content))
            {
                if (_model.Type == ServiceType.Rest_Xml &&
                    _operation.ResponseStructure.PayloadMemberName == null)
                {
                    writer.WriteStartElement(this._operation.Name + "Response");
                }

                if (_model.Type == ServiceType.Query)
                {
                    writer.WriteStartElement(this._operation.Name + "Response");
                }

                if (this._operation.ResponseStructure != null)
                {
                    if (!string.IsNullOrEmpty(this._operation.ResultWrapper))
                    {
                        writer.WriteStartElement(this._operation.ResultWrapper);
                    }

                    //if (this._operation.IsResponsedWrapped)
                    //    writer.WriteStartElement(this._operation.ResponseStructure.MarshallName);

                    WriteStructure(writer, this._operation.ResponseStructure);

                    //if (this._operation.IsResponsedWrapped)
                    //    writer.WriteEndElement();

                    if (!string.IsNullOrEmpty(this._operation.ResultWrapper))
                    {
                        writer.WriteEndElement();
                    }
                }

                if (_model.Type == ServiceType.Rest_Xml && 
                    _operation.ResponseStructure.PayloadMemberName == null)
                {
                    writer.WriteEndElement();
                }

                if (_model.Type == ServiceType.Query)
                {
                    if (!_model.IsEC2Protocol)
                        writer.WriteStartElement("ResponseMetadata");
                    writer.WriteElementString("RequestId", "6fbe234c-80f9-11e2-a17f-9148EXAMPLE");
                    if (!_model.IsEC2Protocol)
                        writer.WriteEndElement();
                }
            }

            var xml = content.ToString();
            return xml;
        }

        private void WriteStructure(XmlWriter writer, Shape structure)
        {
            foreach (var member in structure.Members)
            {
                if (member.IsInHeader)
                    continue;

                if (member.Shape.IsMap)
                {
                    WriteMap(writer, member.MarshallName, member.Shape);  // map not used by EC2 protocol
                }
                else if (member.Shape.IsList)
                {
                    WriteArray(writer, member, member.Shape);
                }
                else
                {
                    // to allow for EC2's substitution of AttributeValue et al structure types with simple values,
                    // eg request.Description => Description.Value after marshall, we potentially need to create 
                    // sub elements for each '.' subexpression and wind back after writing the actual value
                    var unmarshallName = GeneratorHelpers.DetermineAWSQueryTestExpression(member);
                    var nameElements = unmarshallName.Split('/');
                    foreach (var el in nameElements)
                    {
                        writer.WriteStartElement(el);
                    }

                    this.Write(writer, member.Shape);

                    for (var i = 0; i < nameElements.Length; i++)
                    {
                        writer.WriteEndElement();
                    }
                }
            }
        }

        private void Write(XmlWriter writer, Shape shape)
        {
            if (shape.IsStructure)
                WriteStructure(writer, shape);
            else if (shape.IsEnum)
            {
                var enumerationWrapper = this._model.Enumerations(true).First(x => x.Name == shape.Name);
                writer.WriteValue(enumerationWrapper.EnumerationValues.ElementAt(0).MarshallName);
            }
            else if (shape.IsString)
                writer.WriteValue(shape.Name + "_Value");
            else if (shape.IsInt)
                writer.WriteValue(int.MaxValue);
            else if (shape.IsLong)
                writer.WriteValue(long.MaxValue);
            else if (shape.IsFloat)
                writer.WriteValue(float.MaxValue);
            else if (shape.IsDouble)
                writer.WriteValue(double.MaxValue);
            else if (shape.IsDateTime)
                writer.WriteValue(Constants.DEFAULT_DATE);
            else if (shape.IsBoolean)
                writer.WriteValue(true);
            else if (shape.IsBlob)
                writer.WriteValue(Constants.DEFAULT_BLOB_ENCODED);
            else
                throw new Exception("Unknown Type for shape " + shape.Name);

        }

        private void WriteArray(XmlWriter writer, Member member, Shape shape)
        {
            if (!shape.IsFlattened)
            {
                writer.WriteStartElement(GeneratorHelpers.DetermineAWSQueryBaseUnmarshallName(member));
            }

            for (int i = 0; i < shape.Name.Length % 5 + 2; i++)
            {
                writer.WriteStartElement(shape.ListMarshallName ?? "member");
                Write(writer, shape.ModelListShape);
                writer.WriteEndElement();
            }

            if (!shape.IsFlattened)
                writer.WriteEndElement();
        }

        private void WriteMap(XmlWriter writer, string memberMarshallName, Shape shape)
        {
            if (!shape.IsFlattened)
                writer.WriteStartElement(memberMarshallName);

            for (int i = 0; i < shape.Name.Length % 5 + 2; i++)
            {
                if (!shape.IsFlattened)
                    writer.WriteStartElement("entry");
                else
                    writer.WriteStartElement(memberMarshallName);

                writer.WriteStartElement(shape.KeyMarshallName);
                writer.WriteValue("Key" + i);
                writer.WriteEndElement();

                writer.WriteStartElement(shape.ValueMarshallName);
                Write(writer, shape.ValueShape);
                writer.WriteEndElement();

                writer.WriteEndElement();
            }

            if (!shape.IsFlattened)
                writer.WriteEndElement();
        }
    }
}
