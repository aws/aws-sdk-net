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
 * Do not modify this file. This file is generated from the dynamodb-2012-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DynamoDBv2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.DynamoDBv2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// KeysAndAttributes Marshaller
    /// </summary>
    public class KeysAndAttributesMarshaller : IRequestMarshaller<KeysAndAttributes, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(KeysAndAttributes requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAttributesToGet())
            {
                context.Writer.WritePropertyName("AttributesToGet");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAttributesToGetListValue in requestObject.AttributesToGet)
                {
                        context.Writer.WriteStringValue(requestObjectAttributesToGetListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetConsistentRead())
            {
                context.Writer.WritePropertyName("ConsistentRead");
                context.Writer.WriteBooleanValue(requestObject.ConsistentRead.Value);
            }

            if(requestObject.IsSetExpressionAttributeNames())
            {
                context.Writer.WritePropertyName("ExpressionAttributeNames");
                context.Writer.WriteStartObject();
                foreach (var requestObjectExpressionAttributeNamesKvp in requestObject.ExpressionAttributeNames)
                {
                    context.Writer.WritePropertyName(requestObjectExpressionAttributeNamesKvp.Key);
                    var requestObjectExpressionAttributeNamesValue = requestObjectExpressionAttributeNamesKvp.Value;

                        context.Writer.WriteStringValue(requestObjectExpressionAttributeNamesValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetKeys())
            {
                context.Writer.WritePropertyName("Keys");
                context.Writer.WriteStartArray();
                foreach(var requestObjectKeysListValue in requestObject.Keys)
                {
                    context.Writer.WriteStartObject();
                    foreach (var requestObjectKeysListValueKvp in requestObjectKeysListValue)
                    {
                        context.Writer.WritePropertyName(requestObjectKeysListValueKvp.Key);
                        var requestObjectKeysListValueValue = requestObjectKeysListValueKvp.Value;

                        context.Writer.WriteStartObject();

                        var marshaller = AttributeValueMarshaller.Instance;
                        marshaller.Marshall(requestObjectKeysListValueValue, context);

                        context.Writer.WriteEndObject();
                    }
                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetProjectionExpression())
            {
                context.Writer.WritePropertyName("ProjectionExpression");
                context.Writer.WriteStringValue(requestObject.ProjectionExpression);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static KeysAndAttributesMarshaller Instance = new KeysAndAttributesMarshaller();

    }
}