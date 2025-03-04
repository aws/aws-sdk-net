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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DatabaseMigrationService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.DatabaseMigrationService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DataProviderSettings Marshaller
    /// </summary>
    public class DataProviderSettingsMarshaller : IRequestMarshaller<DataProviderSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DataProviderSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDocDbSettings())
            {
                context.Writer.WritePropertyName("DocDbSettings");
                context.Writer.WriteStartObject();

                var marshaller = DocDbDataProviderSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.DocDbSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetIbmDb2LuwSettings())
            {
                context.Writer.WritePropertyName("IbmDb2LuwSettings");
                context.Writer.WriteStartObject();

                var marshaller = IbmDb2LuwDataProviderSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.IbmDb2LuwSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetIbmDb2zOsSettings())
            {
                context.Writer.WritePropertyName("IbmDb2zOsSettings");
                context.Writer.WriteStartObject();

                var marshaller = IbmDb2zOsDataProviderSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.IbmDb2zOsSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMariaDbSettings())
            {
                context.Writer.WritePropertyName("MariaDbSettings");
                context.Writer.WriteStartObject();

                var marshaller = MariaDbDataProviderSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.MariaDbSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMicrosoftSqlServerSettings())
            {
                context.Writer.WritePropertyName("MicrosoftSqlServerSettings");
                context.Writer.WriteStartObject();

                var marshaller = MicrosoftSqlServerDataProviderSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.MicrosoftSqlServerSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMongoDbSettings())
            {
                context.Writer.WritePropertyName("MongoDbSettings");
                context.Writer.WriteStartObject();

                var marshaller = MongoDbDataProviderSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.MongoDbSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMySqlSettings())
            {
                context.Writer.WritePropertyName("MySqlSettings");
                context.Writer.WriteStartObject();

                var marshaller = MySqlDataProviderSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.MySqlSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetOracleSettings())
            {
                context.Writer.WritePropertyName("OracleSettings");
                context.Writer.WriteStartObject();

                var marshaller = OracleDataProviderSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.OracleSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPostgreSqlSettings())
            {
                context.Writer.WritePropertyName("PostgreSqlSettings");
                context.Writer.WriteStartObject();

                var marshaller = PostgreSqlDataProviderSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.PostgreSqlSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRedshiftSettings())
            {
                context.Writer.WritePropertyName("RedshiftSettings");
                context.Writer.WriteStartObject();

                var marshaller = RedshiftDataProviderSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.RedshiftSettings, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DataProviderSettingsMarshaller Instance = new DataProviderSettingsMarshaller();

    }
}