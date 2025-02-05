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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Appflow.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Appflow.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RedshiftConnectorProfileProperties Marshaller
    /// </summary>
    public class RedshiftConnectorProfilePropertiesMarshaller : IRequestMarshaller<RedshiftConnectorProfileProperties, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RedshiftConnectorProfileProperties requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBucketName())
            {
                context.Writer.WritePropertyName("bucketName");
                context.Writer.WriteStringValue(requestObject.BucketName);
            }

            if(requestObject.IsSetBucketPrefix())
            {
                context.Writer.WritePropertyName("bucketPrefix");
                context.Writer.WriteStringValue(requestObject.BucketPrefix);
            }

            if(requestObject.IsSetClusterIdentifier())
            {
                context.Writer.WritePropertyName("clusterIdentifier");
                context.Writer.WriteStringValue(requestObject.ClusterIdentifier);
            }

            if(requestObject.IsSetDataApiRoleArn())
            {
                context.Writer.WritePropertyName("dataApiRoleArn");
                context.Writer.WriteStringValue(requestObject.DataApiRoleArn);
            }

            if(requestObject.IsSetDatabaseName())
            {
                context.Writer.WritePropertyName("databaseName");
                context.Writer.WriteStringValue(requestObject.DatabaseName);
            }

            if(requestObject.IsSetDatabaseUrl())
            {
                context.Writer.WritePropertyName("databaseUrl");
                context.Writer.WriteStringValue(requestObject.DatabaseUrl);
            }

            if(requestObject.IsSetIsRedshiftServerless())
            {
                context.Writer.WritePropertyName("isRedshiftServerless");
                context.Writer.WriteBooleanValue(requestObject.IsRedshiftServerless.Value);
            }

            if(requestObject.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("roleArn");
                context.Writer.WriteStringValue(requestObject.RoleArn);
            }

            if(requestObject.IsSetWorkgroupName())
            {
                context.Writer.WritePropertyName("workgroupName");
                context.Writer.WriteStringValue(requestObject.WorkgroupName);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RedshiftConnectorProfilePropertiesMarshaller Instance = new RedshiftConnectorProfilePropertiesMarshaller();

    }
}