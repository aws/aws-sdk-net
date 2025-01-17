using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ServiceClientGenerator;
using ThirdParty.Json.LitJson;
using System.Globalization;
using Amazon.Runtime.Documents;
using Amazon.Runtime.Documents.Internal.Transform;
using Amazon.Util;
using System.Text.Json;
using System.IO;

namespace AWSSDK_DotNet.UnitTests.TestTools
{
    public class JsonSampleGenerator
    {

        ServiceModel _model;
        Shape _rootStructure;
        TypeCircularReference<string> _tcr;

        public JsonSampleGenerator(ServiceModel model, Shape rootStructure)
        {
            this._model = model;
            this._rootStructure = rootStructure;
        }

        public string Execute()
        {
            this._tcr = new TypeCircularReference<string>();
            var stream = new MemoryStream();
            Utf8JsonWriter writer = new Utf8JsonWriter(stream);

            WriteStructure(writer, null, this._rootStructure);
            writer.Flush();
            var json = Encoding.UTF8.GetString(stream.ToArray());
            return json;
        }

        private void Write(Utf8JsonWriter writer, Member member, Shape shape)
        {
            if (shape.IsDocument)
            {
                var document = InstantiateClassGenerator.Execute<DummyDocumentWrapper>().Document;
                
                DocumentMarshaller.Instance.Write(
                    writer,
                    document);
            }
            else if (shape.IsStructure)
                WriteStructure(writer, member, shape);
            else if (shape.IsList)
                WriteArray(writer, member, shape);
            else if (shape.IsMap)
                WriteMap(writer, member, shape);
            else if (shape.IsEnum)
            {
                var enumerationWrapper = this._model.Enumerations(true).First(x => x.Name == shape.Name);
                writer.WriteStringValue(enumerationWrapper.EnumerationValues.ElementAt(0).MarshallName);
            }
            else if (shape.IsString)
                writer.WriteStringValue(shape.Name + "_Value");
            else if (shape.IsInt)
                writer.WriteNumberValue(int.MaxValue);
            else if (shape.IsLong)
                writer.WriteNumberValue(long.MaxValue);
            else if (shape.IsDouble)
                writer.WriteNumberValue(double.MaxValue);
            else if (shape.IsFloat)
                writer.WriteNumberValue(float.MaxValue);
            else if (shape.IsTimeStamp)
            {
                writer.WriteStringValue(ValidatorUtils.GetTestDate(member, shape));
            }
            else if (shape.IsBoolean)
                writer.WriteBooleanValue(true);
            else if (shape.IsMemoryStream)
                writer.WriteStringValue(Constants.DEFAULT_BLOB_ENCODED);
            else
                throw new Exception("Unknown Type for shape " + shape.Name);
        }


        private void WriteStructure(Utf8JsonWriter writer, Member memberWithComplexShape, Shape structure)
        {
            if (structure.IsDocument)
            {
                Write(writer, memberWithComplexShape, structure);
                return;
            }

            var pushed = this._tcr.Push(structure.Name);
            if (!pushed)
            {
                // Circular reference found. Closing the structure
                writer.WriteStartObject();
                writer.WriteEndObject();
                return;
            }

            if (structure.PayloadMemberName != null)
            {
                this.WriteStructure(writer, structure.PayloadMember, structure.PayloadMember.Shape);
                return;
            }

            writer.WriteStartObject();

            foreach (var member in structure.Members)
            {
                writer.WritePropertyName(member.MarshallName);

                if (member.OverrideDataType != null && (
                    string.Equals(member.OverrideDataType.Unmarshaller, "DateTimeEpochLongMillisecondsUnmarshaller") ||
                    string.Equals(member.OverrideDataType.Unmarshaller, "NullableDateTimeEpochLongMillisecondsUnmarshaller"))
                )
                {
                    writer.WriteNumberValue(ValidatorUtils.GetTestEpochTime().TotalMilliseconds);
                }
                else if (member.OverrideDataType != null && (
                    string.Equals(member.OverrideDataType.Unmarshaller, "Amazon.Runtime.Internal.Transform.DateTimeUnmarshaller") || 
                    string.Equals(member.OverrideDataType.Unmarshaller, "Amazon.Runtime.Internal.Transform.NullableDateTimeUnmarshaller"))
                )
                {
                    writer.WriteStringValue(Constants.DEFAULT_DATE.ToString(AWSSDKUtils.ISO8601DateFormat, CultureInfo.InvariantCulture));
                }
                else if (member.OverrideDataType != null && (
                    string.Equals(member.OverrideDataType.Unmarshaller, "Amazon.Runtime.Internal.Transform.DecimalUnmarshaller") ||
                    string.Equals(member.OverrideDataType.Unmarshaller, "Amazon.Runtime.Internal.Transform.NullableDecimalUnmarshaller"))
                )
                {
                    writer.WriteStringValue(Constants.DEFAULT_DECIMAL.ToString(CultureInfo.InvariantCulture));
                }
                else
                {
                    this.Write(writer, member, member.Shape);
                }
            }

            writer.WriteEndObject();

            if (pushed)
                this._tcr.Pop();
        }


        private void WriteArray(Utf8JsonWriter writer, Member member, Shape array)
        {

            writer.WriteStartArray();

            var listShape = array.ListShape;
            if (!listShape.IsStructure || !this._tcr.Contains(listShape.Name))
            {
                for (int i = 0; i < array.Name.Length % 5 + 2; i++)
                {
                    Write(writer, member, listShape);
                }
            }

            writer.WriteEndArray();
        }

        private void WriteMap(Utf8JsonWriter writer, Member member, Shape map)
        {

            writer.WriteStartObject();

            var mapShape = map.ValueShape;
            if (!mapShape.IsStructure || !this._tcr.Contains(mapShape.Name))
            {
                for (int i = 0; i < map.Name.Length % 5 + 2; i++)
                {
                    writer.WritePropertyName("key" + i);
                    Write(writer, member, map.ValueShape);
                }
            }

            writer.WriteEndObject();
        }

        /// <summary>
        /// Helper for populating a Document
        /// via <see cref="InstantiateClassGenerator.Execute"/>, which
        /// requires a wrapper class.
        /// </summary>
        private class DummyDocumentWrapper
        {
            public Document Document { get; set; }
        }
    }
}