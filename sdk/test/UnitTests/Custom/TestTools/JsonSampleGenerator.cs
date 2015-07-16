using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ServiceClientGenerator;
using ThirdParty.Json.LitJson;
using System.Globalization;
using Amazon.Util;

namespace AWSSDK_DotNet35.UnitTests.TestTools
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
            JsonWriter writer = new JsonWriter();
            writer.PrettyPrint = true;

            WriteStructure(writer, this._rootStructure);

            var json = writer.ToString();
            return json;
        }

        private void Write(JsonWriter writer, Shape shape)
        {
            if (shape.IsStructure)
                WriteStructure(writer, shape);
            else if (shape.IsList)
                WriteArray(writer, shape);
            else if (shape.IsMap)
                WriteMap(writer, shape);
            else if (shape.IsEnum)
            {
                var enumerationWrapper = this._model.Enumerations(true).First(x => x.Name == shape.Name);
                writer.Write(enumerationWrapper.EnumerationValues.ElementAt(0).MarshallName);
            }
            else if (shape.IsString)
                writer.Write(shape.Name + "_Value");
            else if (shape.IsInt)
                writer.Write(int.MaxValue);
            else if (shape.IsLong)
                writer.Write(long.MaxValue);
            else if (shape.IsDouble)
                writer.Write(double.MaxValue);
            else if (shape.IsFloat)
                writer.Write(float.MaxValue);
            else if (shape.IsDateTime)
                writer.Write(Constants.DEFAULT_DATE);
            else if (shape.IsBoolean)
                writer.Write(true);
            else if (shape.IsBlob)
                writer.Write(Constants.DEFAULT_BLOB_ENCODED);
            else
                throw new Exception("Unknown Type for shape " + shape.Name);
        }


        private void WriteStructure(JsonWriter writer, Shape structure)
        {
            var pushed = this._tcr.Push(structure.Name);
            if (!pushed)
                return;

            if (structure.PayloadMemberName != null)
            {
                this.WriteStructure(writer, structure.Members[0].Shape);
                return;
            }

            writer.WriteObjectStart();

            foreach (var member in structure.Members)
            {
                writer.WritePropertyName(member.MarshallName);

                if (member.OverrideDataType != null && string.Equals(member.OverrideDataType.Unmarshaller, "DateTimeEpochLongMillisecondsUnmarshaller"))
                {
                    var ticks = Constants.DEFAULT_DATE.Ticks - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).Ticks;
                    writer.Write((long)TimeSpan.FromTicks(ticks).TotalMilliseconds);
                }
                else if (member.OverrideDataType != null && string.Equals(member.OverrideDataType.Unmarshaller, "Amazon.Runtime.Internal.Transform.DateTimeUnmarshaller"))
                {
                    writer.Write(Constants.DEFAULT_DATE.ToString(AWSSDKUtils.ISO8601DateFormat, CultureInfo.InvariantCulture));
                }
                else
                {
                    this.Write(writer, member.Shape);
                }
            }

            writer.WriteObjectEnd();

            if (pushed)
                this._tcr.Pop();
        }

        private void WriteArray(JsonWriter writer, Shape array)
        {

            writer.WriteArrayStart();

            var listShape = array.ListShape;
            if (!listShape.IsStructure || !this._tcr.Contains(listShape.Name))
            {
                for (int i = 0; i < array.Name.Length % 5 + 2; i++)
                {
                    Write(writer, listShape);
                }
            }

            writer.WriteArrayEnd();
        }

        private void WriteMap(JsonWriter writer, Shape map)
        {

            writer.WriteObjectStart();

            var mapShape = map.ValueShape;
            if (!mapShape.IsStructure || !this._tcr.Contains(mapShape.Name))
            {
                for (int i = 0; i < map.Name.Length % 5 + 2; i++)
                {
                    writer.WritePropertyName("key" + i);
                    Write(writer, map.ValueShape);
                }
            }

            writer.WriteObjectEnd();
        }
    }
}
