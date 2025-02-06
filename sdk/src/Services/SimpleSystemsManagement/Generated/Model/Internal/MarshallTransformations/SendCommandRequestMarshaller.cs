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
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
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
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2014-11-06";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAlarmConfiguration())
            {
                context.Writer.WritePropertyName("AlarmConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = AlarmConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.AlarmConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetCloudWatchOutputConfig())
            {
                context.Writer.WritePropertyName("CloudWatchOutputConfig");
                context.Writer.WriteStartObject();

                var marshaller = CloudWatchOutputConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.CloudWatchOutputConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetComment())
            {
                context.Writer.WritePropertyName("Comment");
                context.Writer.WriteStringValue(publicRequest.Comment);
            }

            if(publicRequest.IsSetDocumentHash())
            {
                context.Writer.WritePropertyName("DocumentHash");
                context.Writer.WriteStringValue(publicRequest.DocumentHash);
            }

            if(publicRequest.IsSetDocumentHashType())
            {
                context.Writer.WritePropertyName("DocumentHashType");
                context.Writer.WriteStringValue(publicRequest.DocumentHashType);
            }

            if(publicRequest.IsSetDocumentName())
            {
                context.Writer.WritePropertyName("DocumentName");
                context.Writer.WriteStringValue(publicRequest.DocumentName);
            }

            if(publicRequest.IsSetDocumentVersion())
            {
                context.Writer.WritePropertyName("DocumentVersion");
                context.Writer.WriteStringValue(publicRequest.DocumentVersion);
            }

            if(publicRequest.IsSetInstanceIds())
            {
                context.Writer.WritePropertyName("InstanceIds");
                context.Writer.WriteStartArray();
                foreach(var publicRequestInstanceIdsListValue in publicRequest.InstanceIds)
                {
                        context.Writer.WriteStringValue(publicRequestInstanceIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetMaxConcurrency())
            {
                context.Writer.WritePropertyName("MaxConcurrency");
                context.Writer.WriteStringValue(publicRequest.MaxConcurrency);
            }

            if(publicRequest.IsSetMaxErrors())
            {
                context.Writer.WritePropertyName("MaxErrors");
                context.Writer.WriteStringValue(publicRequest.MaxErrors);
            }

            if(publicRequest.IsSetNotificationConfig())
            {
                context.Writer.WritePropertyName("NotificationConfig");
                context.Writer.WriteStartObject();

                var marshaller = NotificationConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.NotificationConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetOutputS3BucketName())
            {
                context.Writer.WritePropertyName("OutputS3BucketName");
                context.Writer.WriteStringValue(publicRequest.OutputS3BucketName);
            }

            if(publicRequest.IsSetOutputS3KeyPrefix())
            {
                context.Writer.WritePropertyName("OutputS3KeyPrefix");
                context.Writer.WriteStringValue(publicRequest.OutputS3KeyPrefix);
            }

            if(publicRequest.IsSetOutputS3Region())
            {
                context.Writer.WritePropertyName("OutputS3Region");
                context.Writer.WriteStringValue(publicRequest.OutputS3Region);
            }

            if(publicRequest.IsSetParameters())
            {
                context.Writer.WritePropertyName("Parameters");
                context.Writer.WriteStartObject();
                foreach (var publicRequestParametersKvp in publicRequest.Parameters)
                {
                    context.Writer.WritePropertyName(publicRequestParametersKvp.Key);
                    var publicRequestParametersValue = publicRequestParametersKvp.Value;

                    context.Writer.WriteStartArray();
                    foreach(var publicRequestParametersValueListValue in publicRequestParametersValue)
                    {
                            context.Writer.WriteStringValue(publicRequestParametersValueListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetServiceRoleArn())
            {
                context.Writer.WritePropertyName("ServiceRoleArn");
                context.Writer.WriteStringValue(publicRequest.ServiceRoleArn);
            }

            if(publicRequest.IsSetTargets())
            {
                context.Writer.WritePropertyName("Targets");
                context.Writer.WriteStartArray();
                foreach(var publicRequestTargetsListValue in publicRequest.Targets)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TargetMarshaller.Instance;
                    marshaller.Marshall(publicRequestTargetsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetTimeoutSeconds())
            {
                context.Writer.WritePropertyName("TimeoutSeconds");
                context.Writer.WriteNumberValue(publicRequest.TimeoutSeconds.Value);
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            


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