/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoT.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoT.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DynamoDBAction Marshaller
    /// </summary>       
    public class DynamoDBActionMarshaller : IRequestMarshaller<DynamoDBAction, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DynamoDBAction requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetHashKeyField())
            {
                context.Writer.WritePropertyName("hashKeyField");
                context.Writer.Write(requestObject.HashKeyField);
            }

            if(requestObject.IsSetHashKeyType())
            {
                context.Writer.WritePropertyName("hashKeyType");
                context.Writer.Write(requestObject.HashKeyType);
            }

            if(requestObject.IsSetHashKeyValue())
            {
                context.Writer.WritePropertyName("hashKeyValue");
                context.Writer.Write(requestObject.HashKeyValue);
            }

            if(requestObject.IsSetOperation())
            {
                context.Writer.WritePropertyName("operation");
                context.Writer.Write(requestObject.Operation);
            }

            if(requestObject.IsSetPayloadField())
            {
                context.Writer.WritePropertyName("payloadField");
                context.Writer.Write(requestObject.PayloadField);
            }

            if(requestObject.IsSetRangeKeyField())
            {
                context.Writer.WritePropertyName("rangeKeyField");
                context.Writer.Write(requestObject.RangeKeyField);
            }

            if(requestObject.IsSetRangeKeyType())
            {
                context.Writer.WritePropertyName("rangeKeyType");
                context.Writer.Write(requestObject.RangeKeyType);
            }

            if(requestObject.IsSetRangeKeyValue())
            {
                context.Writer.WritePropertyName("rangeKeyValue");
                context.Writer.Write(requestObject.RangeKeyValue);
            }

            if(requestObject.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("roleArn");
                context.Writer.Write(requestObject.RoleArn);
            }

            if(requestObject.IsSetTableName())
            {
                context.Writer.WritePropertyName("tableName");
                context.Writer.Write(requestObject.TableName);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static DynamoDBActionMarshaller Instance = new DynamoDBActionMarshaller();

    }
}