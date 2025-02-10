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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CleanRooms.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.CleanRooms.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SnowflakeTableReference Marshaller
    /// </summary>
    public class SnowflakeTableReferenceMarshaller : IRequestMarshaller<SnowflakeTableReference, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SnowflakeTableReference requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAccountIdentifier())
            {
                context.Writer.WritePropertyName("accountIdentifier");
                context.Writer.WriteStringValue(requestObject.AccountIdentifier);
            }

            if(requestObject.IsSetDatabaseName())
            {
                context.Writer.WritePropertyName("databaseName");
                context.Writer.WriteStringValue(requestObject.DatabaseName);
            }

            if(requestObject.IsSetSchemaName())
            {
                context.Writer.WritePropertyName("schemaName");
                context.Writer.WriteStringValue(requestObject.SchemaName);
            }

            if(requestObject.IsSetSecretArn())
            {
                context.Writer.WritePropertyName("secretArn");
                context.Writer.WriteStringValue(requestObject.SecretArn);
            }

            if(requestObject.IsSetTableName())
            {
                context.Writer.WritePropertyName("tableName");
                context.Writer.WriteStringValue(requestObject.TableName);
            }

            if(requestObject.IsSetTableSchema())
            {
                context.Writer.WritePropertyName("tableSchema");
                context.Writer.WriteStartObject();

                var marshaller = SnowflakeTableSchemaMarshaller.Instance;
                marshaller.Marshall(requestObject.TableSchema, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SnowflakeTableReferenceMarshaller Instance = new SnowflakeTableReferenceMarshaller();

    }
}