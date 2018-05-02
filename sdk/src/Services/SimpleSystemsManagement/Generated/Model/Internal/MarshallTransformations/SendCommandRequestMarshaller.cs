/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// SendCommand Request Marshaller
    /// </summary>       
    public class SendCommandRequestMarshaller : IMarshaller<IRequest, SendCommandRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SendCommandRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(SendCommandRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SimpleSystemsManagement");
            string target = "AmazonSSM.SendCommand";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetComment())
                {
                    context.Writer.WritePropertyName("Comment");
                    context.Writer.Write(publicRequest.Comment);
                }

                if(publicRequest.IsSetDocumentHash())
                {
                    context.Writer.WritePropertyName("DocumentHash");
                    context.Writer.Write(publicRequest.DocumentHash);
                }

                if(publicRequest.IsSetDocumentHashType())
                {
                    context.Writer.WritePropertyName("DocumentHashType");
                    context.Writer.Write(publicRequest.DocumentHashType);
                }

                if(publicRequest.IsSetDocumentName())
                {
                    context.Writer.WritePropertyName("DocumentName");
                    context.Writer.Write(publicRequest.DocumentName);
                }

                if(publicRequest.IsSetDocumentVersion())
                {
                    context.Writer.WritePropertyName("DocumentVersion");
                    context.Writer.Write(publicRequest.DocumentVersion);
                }

                if(publicRequest.IsSetInstanceIds())
                {
                    context.Writer.WritePropertyName("InstanceIds");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestInstanceIdsListValue in publicRequest.InstanceIds)
                    {
                            context.Writer.Write(publicRequestInstanceIdsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetMaxConcurrency())
                {
                    context.Writer.WritePropertyName("MaxConcurrency");
                    context.Writer.Write(publicRequest.MaxConcurrency);
                }

                if(publicRequest.IsSetMaxErrors())
                {
                    context.Writer.WritePropertyName("MaxErrors");
                    context.Writer.Write(publicRequest.MaxErrors);
                }

                if(publicRequest.IsSetNotificationConfig())
                {
                    context.Writer.WritePropertyName("NotificationConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = NotificationConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.NotificationConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetOutputS3BucketName())
                {
                    context.Writer.WritePropertyName("OutputS3BucketName");
                    context.Writer.Write(publicRequest.OutputS3BucketName);
                }

                if(publicRequest.IsSetOutputS3KeyPrefix())
                {
                    context.Writer.WritePropertyName("OutputS3KeyPrefix");
                    context.Writer.Write(publicRequest.OutputS3KeyPrefix);
                }

                if(publicRequest.IsSetOutputS3Region())
                {
                    context.Writer.WritePropertyName("OutputS3Region");
                    context.Writer.Write(publicRequest.OutputS3Region);
                }

                if(publicRequest.IsSetParameters())
                {
                    context.Writer.WritePropertyName("Parameters");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestParametersKvp in publicRequest.Parameters)
                    {
                        context.Writer.WritePropertyName(publicRequestParametersKvp.Key);
                        var publicRequestParametersValue = publicRequestParametersKvp.Value;

                        context.Writer.WriteArrayStart();
                        foreach(var publicRequestParametersValueListValue in publicRequestParametersValue)
                        {
                                context.Writer.Write(publicRequestParametersValueListValue);
                        }
                        context.Writer.WriteArrayEnd();
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetServiceRoleArn())
                {
                    context.Writer.WritePropertyName("ServiceRoleArn");
                    context.Writer.Write(publicRequest.ServiceRoleArn);
                }

                if(publicRequest.IsSetTargets())
                {
                    context.Writer.WritePropertyName("Targets");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTargetsListValue in publicRequest.Targets)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TargetMarshaller.Instance;
                        marshaller.Marshall(publicRequestTargetsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetTimeoutSeconds())
                {
                    context.Writer.WritePropertyName("TimeoutSeconds");
                    context.Writer.Write(publicRequest.TimeoutSeconds);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static SendCommandRequestMarshaller _instance = new SendCommandRequestMarshaller();        

        internal static SendCommandRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SendCommandRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}