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
 * Do not modify this file. This file is generated from the sqs-2012-11-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SQS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SQS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// MessageSystemAttributeValue Marshaller
    /// </summary>
    public class MessageSystemAttributeValueMarshaller : IRequestMarshaller<MessageSystemAttributeValue, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(MessageSystemAttributeValue requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBinaryListValues())
            {
                context.Writer.WritePropertyName("BinaryListValues");
                context.Writer.WriteStartArray();
                foreach(var requestObjectBinaryListValuesListValue in requestObject.BinaryListValues)
                {
                    context.Writer.WriteStringValue(StringUtils.FromMemoryStream(requestObjectBinaryListValuesListValue));
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetBinaryValue())
            {
                context.Writer.WritePropertyName("BinaryValue");
                context.Writer.WriteStringValue(StringUtils.FromMemoryStream(requestObject.BinaryValue));
            }

            if(requestObject.IsSetDataType())
            {
                context.Writer.WritePropertyName("DataType");
                context.Writer.WriteStringValue(requestObject.DataType);
            }

            if(requestObject.IsSetStringListValues())
            {
                context.Writer.WritePropertyName("StringListValues");
                context.Writer.WriteStartArray();
                foreach(var requestObjectStringListValuesListValue in requestObject.StringListValues)
                {
                        context.Writer.WriteStringValue(requestObjectStringListValuesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetStringValue())
            {
                context.Writer.WritePropertyName("StringValue");
                context.Writer.WriteStringValue(requestObject.StringValue);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static MessageSystemAttributeValueMarshaller Instance = new MessageSystemAttributeValueMarshaller();

    }
}