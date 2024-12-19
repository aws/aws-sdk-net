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
    /// Delete Marshaller
    /// </summary>
    public class DeleteMarshaller : IRequestMarshaller<Delete, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Delete requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetConditionExpression())
            {
                context.Writer.WritePropertyName("ConditionExpression");
                context.Writer.WriteStringValue(requestObject.ConditionExpression);
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

            if(requestObject.IsSetExpressionAttributeValues())
            {
                context.Writer.WritePropertyName("ExpressionAttributeValues");
                context.Writer.WriteStartObject();
                foreach (var requestObjectExpressionAttributeValuesKvp in requestObject.ExpressionAttributeValues)
                {
                    context.Writer.WritePropertyName(requestObjectExpressionAttributeValuesKvp.Key);
                    var requestObjectExpressionAttributeValuesValue = requestObjectExpressionAttributeValuesKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = AttributeValueMarshaller.Instance;
                    marshaller.Marshall(requestObjectExpressionAttributeValuesValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetKey())
            {
                context.Writer.WritePropertyName("Key");
                context.Writer.WriteStartObject();
                foreach (var requestObjectKeyKvp in requestObject.Key)
                {
                    context.Writer.WritePropertyName(requestObjectKeyKvp.Key);
                    var requestObjectKeyValue = requestObjectKeyKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = AttributeValueMarshaller.Instance;
                    marshaller.Marshall(requestObjectKeyValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetReturnValuesOnConditionCheckFailure())
            {
                context.Writer.WritePropertyName("ReturnValuesOnConditionCheckFailure");
                context.Writer.WriteStringValue(requestObject.ReturnValuesOnConditionCheckFailure);
            }

            if(requestObject.IsSetTableName())
            {
                context.Writer.WritePropertyName("TableName");
                context.Writer.WriteStringValue(requestObject.TableName);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DeleteMarshaller Instance = new DeleteMarshaller();

    }
}