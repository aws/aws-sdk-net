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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AwsEksClusterDetails Marshaller
    /// </summary>
    public class AwsEksClusterDetailsMarshaller : IRequestMarshaller<AwsEksClusterDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsEksClusterDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetArn())
            {
                context.Writer.WritePropertyName("Arn");
                context.Writer.WriteStringValue(requestObject.Arn);
            }

            if(requestObject.IsSetCertificateAuthorityData())
            {
                context.Writer.WritePropertyName("CertificateAuthorityData");
                context.Writer.WriteStringValue(requestObject.CertificateAuthorityData);
            }

            if(requestObject.IsSetClusterStatus())
            {
                context.Writer.WritePropertyName("ClusterStatus");
                context.Writer.WriteStringValue(requestObject.ClusterStatus);
            }

            if(requestObject.IsSetEndpoint())
            {
                context.Writer.WritePropertyName("Endpoint");
                context.Writer.WriteStringValue(requestObject.Endpoint);
            }

            if(requestObject.IsSetLogging())
            {
                context.Writer.WritePropertyName("Logging");
                context.Writer.WriteStartObject();

                var marshaller = AwsEksClusterLoggingDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.Logging, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if(requestObject.IsSetResourcesVpcConfig())
            {
                context.Writer.WritePropertyName("ResourcesVpcConfig");
                context.Writer.WriteStartObject();

                var marshaller = AwsEksClusterResourcesVpcConfigDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.ResourcesVpcConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("RoleArn");
                context.Writer.WriteStringValue(requestObject.RoleArn);
            }

            if(requestObject.IsSetVersion())
            {
                context.Writer.WritePropertyName("Version");
                context.Writer.WriteStringValue(requestObject.Version);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsEksClusterDetailsMarshaller Instance = new AwsEksClusterDetailsMarshaller();

    }
}