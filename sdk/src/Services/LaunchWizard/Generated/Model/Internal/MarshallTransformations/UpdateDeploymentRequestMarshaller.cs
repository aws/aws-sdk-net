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
 * Do not modify this file. This file is generated from the launch-wizard-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LaunchWizard.Model;
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
namespace Amazon.LaunchWizard.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateDeployment Request Marshaller
    /// </summary>       
    public class UpdateDeploymentRequestMarshaller : IMarshaller<IRequest, UpdateDeploymentRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateDeploymentRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateDeploymentRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LaunchWizard");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "POST";

            request.ResourcePath = "/updateDeployment";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetDeploymentId())
            {
                context.Writer.WritePropertyName("deploymentId");
                context.Writer.WriteStringValue(publicRequest.DeploymentId);
            }

            if(publicRequest.IsSetDeploymentPatternVersionName())
            {
                context.Writer.WritePropertyName("deploymentPatternVersionName");
                context.Writer.WriteStringValue(publicRequest.DeploymentPatternVersionName);
            }

            if(publicRequest.IsSetDryRun())
            {
                context.Writer.WritePropertyName("dryRun");
                context.Writer.WriteBooleanValue(publicRequest.DryRun.Value);
            }

            if(publicRequest.IsSetForce())
            {
                context.Writer.WritePropertyName("force");
                context.Writer.WriteBooleanValue(publicRequest.Force.Value);
            }

            if(publicRequest.IsSetSpecifications())
            {
                context.Writer.WritePropertyName("specifications");
                context.Writer.WriteStartObject();
                foreach (var publicRequestSpecificationsKvp in publicRequest.Specifications)
                {
                    context.Writer.WritePropertyName(publicRequestSpecificationsKvp.Key);
                    var publicRequestSpecificationsValue = publicRequestSpecificationsKvp.Value;

                        context.Writer.WriteStringValue(publicRequestSpecificationsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetWorkloadVersionName())
            {
                context.Writer.WritePropertyName("workloadVersionName");
                context.Writer.WriteStringValue(publicRequest.WorkloadVersionName);
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
        private static UpdateDeploymentRequestMarshaller _instance = new UpdateDeploymentRequestMarshaller();        

        internal static UpdateDeploymentRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateDeploymentRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}