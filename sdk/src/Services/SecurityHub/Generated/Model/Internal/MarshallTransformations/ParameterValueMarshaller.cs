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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ParameterValue Marshaller
    /// </summary>
    public class ParameterValueMarshaller : IRequestMarshaller<ParameterValue, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ParameterValue requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBoolean())
            {
                context.Writer.WritePropertyName("Boolean");
                context.Writer.WriteBooleanValue(requestObject.Boolean.Value);
            }

            if(requestObject.IsSetDouble())
            {
                context.Writer.WritePropertyName("Double");
                if(StringUtils.IsSpecialDoubleValue(requestObject.Double.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.Double.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.Double.Value);
                }
            }

            if(requestObject.IsSetEnum())
            {
                context.Writer.WritePropertyName("Enum");
                context.Writer.WriteStringValue(requestObject.Enum);
            }

            if(requestObject.IsSetEnumList())
            {
                context.Writer.WritePropertyName("EnumList");
                context.Writer.WriteStartArray();
                foreach(var requestObjectEnumListListValue in requestObject.EnumList)
                {
                        context.Writer.WriteStringValue(requestObjectEnumListListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetInteger())
            {
                context.Writer.WritePropertyName("Integer");
                context.Writer.WriteNumberValue(requestObject.Integer.Value);
            }

            if(requestObject.IsSetIntegerList())
            {
                context.Writer.WritePropertyName("IntegerList");
                context.Writer.WriteStartArray();
                foreach(var requestObjectIntegerListListValue in requestObject.IntegerList)
                {
                        context.Writer.WriteNumberValue(requestObjectIntegerListListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetString())
            {
                context.Writer.WritePropertyName("String");
                context.Writer.WriteStringValue(requestObject.String);
            }

            if(requestObject.IsSetStringList())
            {
                context.Writer.WritePropertyName("StringList");
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
        public readonly static ParameterValueMarshaller Instance = new ParameterValueMarshaller();

    }
}