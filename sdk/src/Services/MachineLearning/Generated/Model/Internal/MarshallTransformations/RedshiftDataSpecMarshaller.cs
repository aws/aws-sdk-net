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
 * Do not modify this file. This file is generated from the machinelearning-2014-12-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MachineLearning.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MachineLearning.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RedshiftDataSpec Marshaller
    /// </summary>       
    public class RedshiftDataSpecMarshaller : IRequestMarshaller<RedshiftDataSpec, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RedshiftDataSpec requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetDatabaseCredentials())
            {
                context.Writer.WritePropertyName("DatabaseCredentials");
                context.Writer.WriteObjectStart();

                var marshaller = RedshiftDatabaseCredentialsMarshaller.Instance;
                marshaller.Marshall(requestObject.DatabaseCredentials, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDatabaseInformation())
            {
                context.Writer.WritePropertyName("DatabaseInformation");
                context.Writer.WriteObjectStart();

                var marshaller = RedshiftDatabaseMarshaller.Instance;
                marshaller.Marshall(requestObject.DatabaseInformation, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDataRearrangement())
            {
                context.Writer.WritePropertyName("DataRearrangement");
                context.Writer.Write(requestObject.DataRearrangement);
            }

            if(requestObject.IsSetDataSchema())
            {
                context.Writer.WritePropertyName("DataSchema");
                context.Writer.Write(requestObject.DataSchema);
            }

            if(requestObject.IsSetDataSchemaUri())
            {
                context.Writer.WritePropertyName("DataSchemaUri");
                context.Writer.Write(requestObject.DataSchemaUri);
            }

            if(requestObject.IsSetS3StagingLocation())
            {
                context.Writer.WritePropertyName("S3StagingLocation");
                context.Writer.Write(requestObject.S3StagingLocation);
            }

            if(requestObject.IsSetSelectSqlQuery())
            {
                context.Writer.WritePropertyName("SelectSqlQuery");
                context.Writer.Write(requestObject.SelectSqlQuery);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static RedshiftDataSpecMarshaller Instance = new RedshiftDataSpecMarshaller();

    }
}