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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleSystemsManagement.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SimpleSystemsManagement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// MaintenanceWindowRunCommandParameters Marshaller
    /// </summary>       
    public class MaintenanceWindowRunCommandParametersMarshaller : IRequestMarshaller<MaintenanceWindowRunCommandParameters, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(MaintenanceWindowRunCommandParameters requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetCloudWatchOutputConfig())
            {
                context.Writer.WritePropertyName("CloudWatchOutputConfig");
                context.Writer.WriteObjectStart();

                var marshaller = CloudWatchOutputConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.CloudWatchOutputConfig, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetComment())
            {
                context.Writer.WritePropertyName("Comment");
                context.Writer.Write(requestObject.Comment);
            }

            if(requestObject.IsSetDocumentHash())
            {
                context.Writer.WritePropertyName("DocumentHash");
                context.Writer.Write(requestObject.DocumentHash);
            }

            if(requestObject.IsSetDocumentHashType())
            {
                context.Writer.WritePropertyName("DocumentHashType");
                context.Writer.Write(requestObject.DocumentHashType);
            }

            if(requestObject.IsSetDocumentVersion())
            {
                context.Writer.WritePropertyName("DocumentVersion");
                context.Writer.Write(requestObject.DocumentVersion);
            }

            if(requestObject.IsSetNotificationConfig())
            {
                context.Writer.WritePropertyName("NotificationConfig");
                context.Writer.WriteObjectStart();

                var marshaller = NotificationConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.NotificationConfig, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetOutputS3BucketName())
            {
                context.Writer.WritePropertyName("OutputS3BucketName");
                context.Writer.Write(requestObject.OutputS3BucketName);
            }

            if(requestObject.IsSetOutputS3KeyPrefix())
            {
                context.Writer.WritePropertyName("OutputS3KeyPrefix");
                context.Writer.Write(requestObject.OutputS3KeyPrefix);
            }

            if(requestObject.IsSetParameters())
            {
                context.Writer.WritePropertyName("Parameters");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectParametersKvp in requestObject.Parameters)
                {
                    context.Writer.WritePropertyName(requestObjectParametersKvp.Key);
                    var requestObjectParametersValue = requestObjectParametersKvp.Value;

                    context.Writer.WriteArrayStart();
                    foreach(var requestObjectParametersValueListValue in requestObjectParametersValue)
                    {
                            context.Writer.Write(requestObjectParametersValueListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetServiceRoleArn())
            {
                context.Writer.WritePropertyName("ServiceRoleArn");
                context.Writer.Write(requestObject.ServiceRoleArn);
            }

            if(requestObject.IsSetTimeoutSeconds())
            {
                context.Writer.WritePropertyName("TimeoutSeconds");
                context.Writer.Write(requestObject.TimeoutSeconds);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static MaintenanceWindowRunCommandParametersMarshaller Instance = new MaintenanceWindowRunCommandParametersMarshaller();

    }
}