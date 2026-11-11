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

using Amazon.MachineLearning.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.MachineLearning.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RedshiftDataSpec Marshaller
    /// </summary>
    public partial class RedshiftDataSpecMarshaller : IRequestMarshaller<RedshiftDataSpec, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(RedshiftDataSpec requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetDataRearrangement())
            {
                context.Writer.WritePropertyName("DataRearrangement");
                context.Writer.WriteStringValue(requestObject.DataRearrangement);
            }

            if (requestObject.IsSetDataSchema())
            {
                context.Writer.WritePropertyName("DataSchema");
                context.Writer.WriteStringValue(requestObject.DataSchema);
            }

            if (requestObject.IsSetDataSchemaUri())
            {
                context.Writer.WritePropertyName("DataSchemaUri");
                context.Writer.WriteStringValue(requestObject.DataSchemaUri);
            }

            if (requestObject.IsSetDatabaseCredentials())
            {
                context.Writer.WritePropertyName("DatabaseCredentials");
                context.Writer.WriteStartObject();

                var marshaller = RedshiftDatabaseCredentialsMarshaller.Instance;
                marshaller.Marshall(requestObject.DatabaseCredentials, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetDatabaseInformation())
            {
                context.Writer.WritePropertyName("DatabaseInformation");
                context.Writer.WriteStartObject();

                var marshaller = RedshiftDatabaseMarshaller.Instance;
                marshaller.Marshall(requestObject.DatabaseInformation, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetS3StagingLocation())
            {
                context.Writer.WritePropertyName("S3StagingLocation");
                context.Writer.WriteStringValue(requestObject.S3StagingLocation);
            }

            if (requestObject.IsSetSelectSqlQuery())
            {
                context.Writer.WritePropertyName("SelectSqlQuery");
                context.Writer.WriteStringValue(requestObject.SelectSqlQuery);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static RedshiftDataSpecMarshaller Instance = new RedshiftDataSpecMarshaller();
    }
}
