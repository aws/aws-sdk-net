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
 * Do not modify this file. This file is generated from the firehose-2015-08-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.KinesisFirehose.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.KinesisFirehose.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DatabaseSourceConfiguration Marshaller
    /// </summary>
    public class DatabaseSourceConfigurationMarshaller : IRequestMarshaller<DatabaseSourceConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DatabaseSourceConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetColumns())
            {
                context.Writer.WritePropertyName("Columns");
                context.Writer.WriteObjectStart();

                var marshaller = DatabaseColumnListMarshaller.Instance;
                marshaller.Marshall(requestObject.Columns, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDatabases())
            {
                context.Writer.WritePropertyName("Databases");
                context.Writer.WriteObjectStart();

                var marshaller = DatabaseListMarshaller.Instance;
                marshaller.Marshall(requestObject.Databases, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDatabaseSourceAuthenticationConfiguration())
            {
                context.Writer.WritePropertyName("DatabaseSourceAuthenticationConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = DatabaseSourceAuthenticationConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.DatabaseSourceAuthenticationConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDatabaseSourceVPCConfiguration())
            {
                context.Writer.WritePropertyName("DatabaseSourceVPCConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = DatabaseSourceVPCConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.DatabaseSourceVPCConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetEndpoint())
            {
                context.Writer.WritePropertyName("Endpoint");
                context.Writer.Write(requestObject.Endpoint);
            }

            if(requestObject.IsSetPort())
            {
                context.Writer.WritePropertyName("Port");
                context.Writer.Write(requestObject.Port);
            }

            if(requestObject.IsSetSnapshotWatermarkTable())
            {
                context.Writer.WritePropertyName("SnapshotWatermarkTable");
                context.Writer.Write(requestObject.SnapshotWatermarkTable);
            }

            if(requestObject.IsSetSSLMode())
            {
                context.Writer.WritePropertyName("SSLMode");
                context.Writer.Write(requestObject.SSLMode);
            }

            if(requestObject.IsSetSurrogateKeys())
            {
                context.Writer.WritePropertyName("SurrogateKeys");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSurrogateKeysListValue in requestObject.SurrogateKeys)
                {
                        context.Writer.Write(requestObjectSurrogateKeysListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetTables())
            {
                context.Writer.WritePropertyName("Tables");
                context.Writer.WriteObjectStart();

                var marshaller = DatabaseTableListMarshaller.Instance;
                marshaller.Marshall(requestObject.Tables, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetType())
            {
                context.Writer.WritePropertyName("Type");
                context.Writer.Write(requestObject.Type);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DatabaseSourceConfigurationMarshaller Instance = new DatabaseSourceConfigurationMarshaller();

    }
}