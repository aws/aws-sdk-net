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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.IoT.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.IoT.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DynamoDBAction Marshaller
    /// </summary>
    public partial class DynamoDBActionMarshaller : IRequestMarshaller<DynamoDBAction, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(DynamoDBAction requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetHashKeyField())
            {
                context.Writer.WritePropertyName("hashKeyField");
                context.Writer.WriteStringValue(requestObject.HashKeyField);
            }

            if (requestObject.IsSetHashKeyType())
            {
                context.Writer.WritePropertyName("hashKeyType");
                context.Writer.WriteStringValue(requestObject.HashKeyType);
            }

            if (requestObject.IsSetHashKeyValue())
            {
                context.Writer.WritePropertyName("hashKeyValue");
                context.Writer.WriteStringValue(requestObject.HashKeyValue);
            }

            if (requestObject.IsSetOperation())
            {
                context.Writer.WritePropertyName("operation");
                context.Writer.WriteStringValue(requestObject.Operation);
            }

            if (requestObject.IsSetPayloadField())
            {
                context.Writer.WritePropertyName("payloadField");
                context.Writer.WriteStringValue(requestObject.PayloadField);
            }

            if (requestObject.IsSetRangeKeyField())
            {
                context.Writer.WritePropertyName("rangeKeyField");
                context.Writer.WriteStringValue(requestObject.RangeKeyField);
            }

            if (requestObject.IsSetRangeKeyType())
            {
                context.Writer.WritePropertyName("rangeKeyType");
                context.Writer.WriteStringValue(requestObject.RangeKeyType);
            }

            if (requestObject.IsSetRangeKeyValue())
            {
                context.Writer.WritePropertyName("rangeKeyValue");
                context.Writer.WriteStringValue(requestObject.RangeKeyValue);
            }

            if (requestObject.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("roleArn");
                context.Writer.WriteStringValue(requestObject.RoleArn);
            }

            if (requestObject.IsSetTableName())
            {
                context.Writer.WritePropertyName("tableName");
                context.Writer.WriteStringValue(requestObject.TableName);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static DynamoDBActionMarshaller Instance = new DynamoDBActionMarshaller();
    }
}
