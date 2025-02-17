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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodeBuild.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.CodeBuild.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateFleet Request Marshaller
    /// </summary>       
    public class UpdateFleetRequestMarshaller : IMarshaller<IRequest, UpdateFleetRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateFleetRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateFleetRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CodeBuild");
            string target = "CodeBuild_20161006.UpdateFleet";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-10-06";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetArn())
                {
                    context.Writer.WritePropertyName("arn");
                    context.Writer.Write(publicRequest.Arn);
                }

                if(publicRequest.IsSetBaseCapacity())
                {
                    context.Writer.WritePropertyName("baseCapacity");
                    context.Writer.Write(publicRequest.BaseCapacity);
                }

                if(publicRequest.IsSetComputeConfiguration())
                {
                    context.Writer.WritePropertyName("computeConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = ComputeConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ComputeConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetComputeType())
                {
                    context.Writer.WritePropertyName("computeType");
                    context.Writer.Write(publicRequest.ComputeType);
                }

                if(publicRequest.IsSetEnvironmentType())
                {
                    context.Writer.WritePropertyName("environmentType");
                    context.Writer.Write(publicRequest.EnvironmentType);
                }

                if(publicRequest.IsSetFleetServiceRole())
                {
                    context.Writer.WritePropertyName("fleetServiceRole");
                    context.Writer.Write(publicRequest.FleetServiceRole);
                }

                if(publicRequest.IsSetImageId())
                {
                    context.Writer.WritePropertyName("imageId");
                    context.Writer.Write(publicRequest.ImageId);
                }

                if(publicRequest.IsSetOverflowBehavior())
                {
                    context.Writer.WritePropertyName("overflowBehavior");
                    context.Writer.Write(publicRequest.OverflowBehavior);
                }

                if(publicRequest.IsSetProxyConfiguration())
                {
                    context.Writer.WritePropertyName("proxyConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = ProxyConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ProxyConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetScalingConfiguration())
                {
                    context.Writer.WritePropertyName("scalingConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = ScalingConfigurationInputMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ScalingConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("tags");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTagsListValue in publicRequest.Tags)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TagMarshaller.Instance;
                        marshaller.Marshall(publicRequestTagsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetVpcConfig())
                {
                    context.Writer.WritePropertyName("vpcConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = VpcConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.VpcConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateFleetRequestMarshaller _instance = new UpdateFleetRequestMarshaller();        

        internal static UpdateFleetRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateFleetRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}