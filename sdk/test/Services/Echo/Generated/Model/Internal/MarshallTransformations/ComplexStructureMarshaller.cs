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

/*
 * Do not modify this file. This file is generated from the echo-service-2020-07-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Echo.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.Echo.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ComplexStructure Marshaller
    /// </summary>
    public class ComplexStructureMarshaller : IRequestMarshaller<ComplexStructure, CborMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ComplexStructure requestObject, CborMarshallerContext context)
        {
            if (requestObject == null)
                return;

            if (requestObject.IsSetBlobMember())
            {
                context.Writer.WriteTextString("blobMember");
                context.Writer.WriteByteString(requestObject.BlobMember.ToArray());
            }
            if (requestObject.IsSetBooleanMember())
            {
                context.Writer.WriteTextString("booleanMember");
                context.Writer.WriteBoolean(requestObject.BooleanMember.Value);
            }
            if (requestObject.IsSetComplexStructMember())
            {
                context.Writer.WriteTextString("complexStructMember");
                context.Writer.WriteStartMap(null);

                var marshaller = ComplexStructureMarshaller.Instance;
                marshaller.Marshall(requestObject.ComplexStructMember, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetDoubleMember())
            {
                context.Writer.WriteTextString("doubleMember");
                context.Writer.WriteOptimizedNumber(requestObject.DoubleMember.Value);
            }
            if (requestObject.IsSetFloatMember())
            {
                context.Writer.WriteTextString("floatMember");
                context.Writer.WriteOptimizedNumber(requestObject.FloatMember.Value);
            }
            if (requestObject.IsSetIntegerMember())
            {
                context.Writer.WriteTextString("integerMember");
                context.Writer.WriteInt32(requestObject.IntegerMember.Value);
            }
            if (requestObject.IsSetListOfComplexObjectMember())
            {
                context.Writer.WriteTextString("listOfComplexObjectMember");
                context.Writer.WriteStartArray(requestObject.ListOfComplexObjectMember.Count);
                foreach(var requestObjectListOfComplexObjectMemberListValue in requestObject.ListOfComplexObjectMember)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = ComplexStructureMarshaller.Instance;
                    marshaller.Marshall(requestObjectListOfComplexObjectMemberListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetListOfStringsMember())
            {
                context.Writer.WriteTextString("listOfStringsMember");
                context.Writer.WriteStartArray(requestObject.ListOfStringsMember.Count);
                foreach(var requestObjectListOfStringsMemberListValue in requestObject.ListOfStringsMember)
                {
                        context.Writer.WriteTextString(requestObjectListOfStringsMemberListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetLongMember())
            {
                context.Writer.WriteTextString("longMember");
                context.Writer.WriteInt64(requestObject.LongMember.Value);
            }
            if (requestObject.IsSetMapOfStringToStringMember())
            {
                context.Writer.WriteTextString("mapOfStringToStringMember");
                context.Writer.WriteStartMap(null);
                foreach (var requestObjectMapOfStringToStringMemberKvp in requestObject.MapOfStringToStringMember)
                {
                    context.Writer.WriteTextString(requestObjectMapOfStringToStringMemberKvp.Key);
                    var requestObjectMapOfStringToStringMemberValue = requestObjectMapOfStringToStringMemberKvp.Value;

                        context.Writer.WriteTextString(requestObjectMapOfStringToStringMemberValue);
                }
                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetStringMember())
            {
                context.Writer.WriteTextString("stringMember");
                context.Writer.WriteTextString(requestObject.StringMember);
            }
            if (requestObject.IsSetTimestampMember())
            {
                context.Writer.WriteTextString("timestampMember");
                context.Writer.WriteDateTime(requestObject.TimestampMember.Value);
            }
        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ComplexStructureMarshaller Instance = new ComplexStructureMarshaller();

    }
}