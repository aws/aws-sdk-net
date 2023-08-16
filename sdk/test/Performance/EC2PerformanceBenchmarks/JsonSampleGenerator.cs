/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using Amazon.Util;
using ServiceClientGenerator;
using System;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Linq;
using ThirdParty.Json.LitJson;

namespace AWSSDK.Benchmarks
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

            WriteStructure(writer, null, this._rootStructure);

            var json = writer.ToString();
            return json;
        }

        private void Write(JsonWriter writer, Member member, Shape shape)
        {
            if (shape.IsStructure)
                WriteStructure(writer, member, shape);
            else if (shape.IsList)
                WriteArray(writer, member, shape);
            else if (shape.IsMap)
                WriteMap(writer, member, shape);
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
            {
                writer.Write(XmlSampleGenerator.GetTestDate(member, shape));
            }
            else if (shape.IsBoolean)
                writer.Write(true);
            else if (shape.IsMemoryStream)
                writer.Write(Constants.DefaultBlobEncoded);
            else
                throw new Exception("Unknown Type for shape " + shape.Name);
        }


        private void WriteStructure(JsonWriter writer, Member memberWithComplexShape, Shape structure)
        {
            var pushed = this._tcr.Push(structure.Name);
            if (!pushed)
            {
                // Circular reference found. Closing the structure
                writer.WriteObjectStart();
                writer.WriteObjectEnd();
                return;
            }

            if (structure.PayloadMemberName != null)
            {
                this.WriteStructure(writer, structure.PayloadMember, structure.PayloadMember.Shape);
                return;
            }

            writer.WriteObjectStart();

            foreach (var member in structure.Members)
            {
                writer.WritePropertyName(member.MarshallName);

                if (member.OverrideDataType != null && string.Equals(member.OverrideDataType.Unmarshaller, "DateTimeEpochLongMillisecondsUnmarshaller"))
                {
                    writer.Write(TimeSpan.FromTicks(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).Ticks).TotalMilliseconds);
                }
                else if (member.OverrideDataType != null && string.Equals(member.OverrideDataType.Unmarshaller, "Amazon.Runtime.Internal.Transform.DateTimeUnmarshaller"))
                {
                    writer.Write(Constants.DefaultDate.ToString(AWSSDKUtils.ISO8601DateFormat, CultureInfo.InvariantCulture));
                }
                else if (member.OverrideDataType != null && string.Equals(member.OverrideDataType.Unmarshaller, "Amazon.Runtime.Internal.Transform.DecimalUnmarshaller"))
                {
                    writer.Write(Constants.DefaultDecimal.ToString(CultureInfo.InvariantCulture));
                }
                else
                {
                    this.Write(writer, member, member.Shape);
                }
            }

            writer.WriteObjectEnd();

            if (pushed)
                this._tcr.Pop();
        }


        private void WriteArray(JsonWriter writer, Member member, Shape array)
        {

            writer.WriteArrayStart();

            var listShape = array.ListShape;
            if (!listShape.IsStructure || !this._tcr.Contains(listShape.Name))
            {
                for (int i = 0; i < array.Name.Length % 5 + 2; i++)
                {
                    Write(writer, member, listShape);
                }
            }

            writer.WriteArrayEnd();
        }

        private void WriteMap(JsonWriter writer, Member member, Shape map)
        {

            writer.WriteObjectStart();

            var mapShape = map.ValueShape;
            if (!mapShape.IsStructure || !this._tcr.Contains(mapShape.Name))
            {
                for (int i = 0; i < map.Name.Length % 5 + 2; i++)
                {
                    writer.WritePropertyName("key" + i);
                    Write(writer, member, map.ValueShape);
                }
            }

            writer.WriteObjectEnd();
        }
    }
}
