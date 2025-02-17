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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockAgent.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockAgent.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// MetadataAttributeValue Marshaller
    /// </summary>
    public class MetadataAttributeValueMarshaller : IRequestMarshaller<MetadataAttributeValue, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(MetadataAttributeValue requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBooleanValue())
            {
                context.Writer.WritePropertyName("booleanValue");
                context.Writer.Write(requestObject.BooleanValue);
            }

            if(requestObject.IsSetNumberValue())
            {
                context.Writer.WritePropertyName("numberValue");
                if(StringUtils.IsSpecialDoubleValue(requestObject.NumberValue))
                {
                    context.Writer.Write(StringUtils.FromSpecialDoubleValue(requestObject.NumberValue));
                }
                else
                {
                    context.Writer.Write(requestObject.NumberValue);
                }
            }

            if(requestObject.IsSetStringListValue())
            {
                context.Writer.WritePropertyName("stringListValue");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectStringListValueListValue in requestObject.StringListValue)
                {
                        context.Writer.Write(requestObjectStringListValueListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetStringValue())
            {
                context.Writer.WritePropertyName("stringValue");
                context.Writer.Write(requestObject.StringValue);
            }

            if(requestObject.IsSetType())
            {
                context.Writer.WritePropertyName("type");
                context.Writer.Write(requestObject.Type);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static MetadataAttributeValueMarshaller Instance = new MetadataAttributeValueMarshaller();

    }
}