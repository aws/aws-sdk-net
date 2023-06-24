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
 * Do not modify this file. This file is generated from the emr-serverless-2021-07-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EMRServerless.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.EMRServerless.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateApplication Request Marshaller
    /// </summary>       
    public class UpdateApplicationRequestMarshaller : IMarshaller<IRequest, UpdateApplicationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateApplicationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateApplicationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EMRServerless");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-07-13";
            request.HttpMethod = "PATCH";

            if (!publicRequest.IsSetApplicationId())
                throw new AmazonEMRServerlessException("Request object does not have required field ApplicationId set");
            request.AddPathResource("{applicationId}", StringUtils.FromString(publicRequest.ApplicationId));
            request.ResourcePath = "/applications/{applicationId}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetArchitecture())
                {
                    context.Writer.WritePropertyName("architecture");
                    context.Writer.Write(publicRequest.Architecture);
                }

                if(publicRequest.IsSetAutoStartConfiguration())
                {
                    context.Writer.WritePropertyName("autoStartConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = AutoStartConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AutoStartConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetAutoStopConfiguration())
                {
                    context.Writer.WritePropertyName("autoStopConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = AutoStopConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AutoStopConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetClientToken())
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(publicRequest.ClientToken);
                }

                else if(!(publicRequest.IsSetClientToken()))
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(Guid.NewGuid().ToString());
                }
                if(publicRequest.IsSetImageConfiguration())
                {
                    context.Writer.WritePropertyName("imageConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = ImageConfigurationInputMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ImageConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetInitialCapacity())
                {
                    context.Writer.WritePropertyName("initialCapacity");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestInitialCapacityKvp in publicRequest.InitialCapacity)
                    {
                        context.Writer.WritePropertyName(publicRequestInitialCapacityKvp.Key);
                        var publicRequestInitialCapacityValue = publicRequestInitialCapacityKvp.Value;

                        context.Writer.WriteObjectStart();

                        var marshaller = InitialCapacityConfigMarshaller.Instance;
                        marshaller.Marshall(publicRequestInitialCapacityValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetMaximumCapacity())
                {
                    context.Writer.WritePropertyName("maximumCapacity");
                    context.Writer.WriteObjectStart();

                    var marshaller = MaximumAllowedResourcesMarshaller.Instance;
                    marshaller.Marshall(publicRequest.MaximumCapacity, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetNetworkConfiguration())
                {
                    context.Writer.WritePropertyName("networkConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = NetworkConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.NetworkConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetWorkerTypeSpecifications())
                {
                    context.Writer.WritePropertyName("workerTypeSpecifications");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestWorkerTypeSpecificationsKvp in publicRequest.WorkerTypeSpecifications)
                    {
                        context.Writer.WritePropertyName(publicRequestWorkerTypeSpecificationsKvp.Key);
                        var publicRequestWorkerTypeSpecificationsValue = publicRequestWorkerTypeSpecificationsKvp.Value;

                        context.Writer.WriteObjectStart();

                        var marshaller = WorkerTypeSpecificationInputMarshaller.Instance;
                        marshaller.Marshall(publicRequestWorkerTypeSpecificationsValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateApplicationRequestMarshaller _instance = new UpdateApplicationRequestMarshaller();        

        internal static UpdateApplicationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateApplicationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}