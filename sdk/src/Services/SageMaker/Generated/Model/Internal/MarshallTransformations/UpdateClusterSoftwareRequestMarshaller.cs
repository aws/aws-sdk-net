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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMaker.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateClusterSoftware Request Marshaller
    /// </summary>       
    public class UpdateClusterSoftwareRequestMarshaller : IMarshaller<IRequest, UpdateClusterSoftwareRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateClusterSoftwareRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateClusterSoftwareRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SageMaker");
            string target = "SageMaker.UpdateClusterSoftware";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-07-24";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetClusterName())
                {
                    context.Writer.WritePropertyName("ClusterName");
                    context.Writer.Write(publicRequest.ClusterName);
                }

                if(publicRequest.IsSetDeploymentConfig())
                {
                    context.Writer.WritePropertyName("DeploymentConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = DeploymentConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DeploymentConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetImageId())
                {
                    context.Writer.WritePropertyName("ImageId");
                    context.Writer.Write(publicRequest.ImageId);
                }

                if(publicRequest.IsSetInstanceGroups())
                {
                    context.Writer.WritePropertyName("InstanceGroups");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestInstanceGroupsListValue in publicRequest.InstanceGroups)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = UpdateClusterSoftwareInstanceGroupSpecificationMarshaller.Instance;
                        marshaller.Marshall(publicRequestInstanceGroupsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateClusterSoftwareRequestMarshaller _instance = new UpdateClusterSoftwareRequestMarshaller();        

        internal static UpdateClusterSoftwareRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateClusterSoftwareRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}