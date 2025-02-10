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
#pragma warning disable CS0612,CS0618
namespace Amazon.MachineLearning.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RDSDataSpec Marshaller
    /// </summary>
    public class RDSDataSpecMarshaller : IRequestMarshaller<RDSDataSpec, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RDSDataSpec requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDatabaseCredentials())
            {
                context.Writer.WritePropertyName("DatabaseCredentials");
                context.Writer.WriteStartObject();

                var marshaller = RDSDatabaseCredentialsMarshaller.Instance;
                marshaller.Marshall(requestObject.DatabaseCredentials, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDatabaseInformation())
            {
                context.Writer.WritePropertyName("DatabaseInformation");
                context.Writer.WriteStartObject();

                var marshaller = RDSDatabaseMarshaller.Instance;
                marshaller.Marshall(requestObject.DatabaseInformation, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDataRearrangement())
            {
                context.Writer.WritePropertyName("DataRearrangement");
                context.Writer.WriteStringValue(requestObject.DataRearrangement);
            }

            if(requestObject.IsSetDataSchema())
            {
                context.Writer.WritePropertyName("DataSchema");
                context.Writer.WriteStringValue(requestObject.DataSchema);
            }

            if(requestObject.IsSetDataSchemaUri())
            {
                context.Writer.WritePropertyName("DataSchemaUri");
                context.Writer.WriteStringValue(requestObject.DataSchemaUri);
            }

            if(requestObject.IsSetResourceRole())
            {
                context.Writer.WritePropertyName("ResourceRole");
                context.Writer.WriteStringValue(requestObject.ResourceRole);
            }

            if(requestObject.IsSetS3StagingLocation())
            {
                context.Writer.WritePropertyName("S3StagingLocation");
                context.Writer.WriteStringValue(requestObject.S3StagingLocation);
            }

            if(requestObject.IsSetSecurityGroupIds())
            {
                context.Writer.WritePropertyName("SecurityGroupIds");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSecurityGroupIdsListValue in requestObject.SecurityGroupIds)
                {
                        context.Writer.WriteStringValue(requestObjectSecurityGroupIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSelectSqlQuery())
            {
                context.Writer.WritePropertyName("SelectSqlQuery");
                context.Writer.WriteStringValue(requestObject.SelectSqlQuery);
            }

            if(requestObject.IsSetServiceRole())
            {
                context.Writer.WritePropertyName("ServiceRole");
                context.Writer.WriteStringValue(requestObject.ServiceRole);
            }

            if(requestObject.IsSetSubnetId())
            {
                context.Writer.WritePropertyName("SubnetId");
                context.Writer.WriteStringValue(requestObject.SubnetId);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RDSDataSpecMarshaller Instance = new RDSDataSpecMarshaller();

    }
}