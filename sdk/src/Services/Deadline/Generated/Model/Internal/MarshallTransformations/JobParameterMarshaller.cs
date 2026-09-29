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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Deadline.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Deadline.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// JobParameter Marshaller
    /// </summary>
    public class JobParameterMarshaller : IRequestMarshaller<JobParameter, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(JobParameter requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBool())
            {
                context.Writer.WritePropertyName("bool");
                context.Writer.WriteStringValue(requestObject.Bool);
            }

            if(requestObject.IsSetBoolList())
            {
                context.Writer.WritePropertyName("boolList");
                context.Writer.WriteStartArray();
                foreach(var requestObjectBoolListListValue in requestObject.BoolList)
                {
                        context.Writer.WriteStringValue(requestObjectBoolListListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetFloat())
            {
                context.Writer.WritePropertyName("float");
                context.Writer.WriteStringValue(requestObject.Float);
            }

            if(requestObject.IsSetFloatList())
            {
                context.Writer.WritePropertyName("floatList");
                context.Writer.WriteStartArray();
                foreach(var requestObjectFloatListListValue in requestObject.FloatList)
                {
                        context.Writer.WriteStringValue(requestObjectFloatListListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetInt())
            {
                context.Writer.WritePropertyName("int");
                context.Writer.WriteStringValue(requestObject.Int);
            }

            if(requestObject.IsSetIntList())
            {
                context.Writer.WritePropertyName("intList");
                context.Writer.WriteStartArray();
                foreach(var requestObjectIntListListValue in requestObject.IntList)
                {
                        context.Writer.WriteStringValue(requestObjectIntListListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetIntListList())
            {
                context.Writer.WritePropertyName("intListList");
                context.Writer.WriteStartArray();
                foreach(var requestObjectIntListListListValue in requestObject.IntListList)
                {
                    context.Writer.WriteStartArray();
                    foreach(var requestObjectIntListListListValueListValue in requestObjectIntListListListValue)
                    {
                            context.Writer.WriteStringValue(requestObjectIntListListListValueListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetPath())
            {
                context.Writer.WritePropertyName("path");
                context.Writer.WriteStringValue(requestObject.Path);
            }

            if(requestObject.IsSetPathList())
            {
                context.Writer.WritePropertyName("pathList");
                context.Writer.WriteStartArray();
                foreach(var requestObjectPathListListValue in requestObject.PathList)
                {
                        context.Writer.WriteStringValue(requestObjectPathListListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetRangeExpr())
            {
                context.Writer.WritePropertyName("rangeExpr");
                context.Writer.WriteStringValue(requestObject.RangeExpr);
            }

            if(requestObject.IsSetString())
            {
                context.Writer.WritePropertyName("string");
                context.Writer.WriteStringValue(requestObject.String);
            }

            if(requestObject.IsSetStringList())
            {
                context.Writer.WritePropertyName("stringList");
                context.Writer.WriteStartArray();
                foreach(var requestObjectStringListListValue in requestObject.StringList)
                {
                        context.Writer.WriteStringValue(requestObjectStringListListValue);
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static JobParameterMarshaller Instance = new JobParameterMarshaller();

    }
}