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
    /// AwsGuardDutyDetectorDataSourcesDetails Marshaller
    /// </summary>
    public class AwsGuardDutyDetectorDataSourcesDetailsMarshaller : IRequestMarshaller<AwsGuardDutyDetectorDataSourcesDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsGuardDutyDetectorDataSourcesDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCloudTrail())
            {
                context.Writer.WritePropertyName("CloudTrail");
                context.Writer.WriteStartObject();

                var marshaller = AwsGuardDutyDetectorDataSourcesCloudTrailDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.CloudTrail, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDnsLogs())
            {
                context.Writer.WritePropertyName("DnsLogs");
                context.Writer.WriteStartObject();

                var marshaller = AwsGuardDutyDetectorDataSourcesDnsLogsDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.DnsLogs, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetFlowLogs())
            {
                context.Writer.WritePropertyName("FlowLogs");
                context.Writer.WriteStartObject();

                var marshaller = AwsGuardDutyDetectorDataSourcesFlowLogsDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.FlowLogs, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetKubernetes())
            {
                context.Writer.WritePropertyName("Kubernetes");
                context.Writer.WriteStartObject();

                var marshaller = AwsGuardDutyDetectorDataSourcesKubernetesDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.Kubernetes, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMalwareProtection())
            {
                context.Writer.WritePropertyName("MalwareProtection");
                context.Writer.WriteStartObject();

                var marshaller = AwsGuardDutyDetectorDataSourcesMalwareProtectionDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.MalwareProtection, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetS3Logs())
            {
                context.Writer.WritePropertyName("S3Logs");
                context.Writer.WriteStartObject();

                var marshaller = AwsGuardDutyDetectorDataSourcesS3LogsDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.S3Logs, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsGuardDutyDetectorDataSourcesDetailsMarshaller Instance = new AwsGuardDutyDetectorDataSourcesDetailsMarshaller();

    }
}