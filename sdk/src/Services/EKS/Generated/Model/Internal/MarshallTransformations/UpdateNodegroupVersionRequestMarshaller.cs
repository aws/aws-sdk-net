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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EKS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.EKS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateNodegroupVersion Request Marshaller
    /// </summary>       
    public class UpdateNodegroupVersionRequestMarshaller : IMarshaller<IRequest, UpdateNodegroupVersionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateNodegroupVersionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateNodegroupVersionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EKS");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-11-01";            
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetClusterName())
                throw new AmazonEKSException("Request object does not have required field ClusterName set");
            request.AddPathResource("{name}", StringUtils.FromString(publicRequest.ClusterName));
            if (!publicRequest.IsSetNodegroupName())
                throw new AmazonEKSException("Request object does not have required field NodegroupName set");
            request.AddPathResource("{nodegroupName}", StringUtils.FromString(publicRequest.NodegroupName));
            request.ResourcePath = "/clusters/{name}/node-groups/{nodegroupName}/update-version";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetClientRequestToken())
                {
                    context.Writer.WritePropertyName("clientRequestToken");
                    context.Writer.Write(publicRequest.ClientRequestToken);
                }

                else if(!(publicRequest.IsSetClientRequestToken()))
                {
                    context.Writer.WritePropertyName("clientRequestToken");
                    context.Writer.Write(Guid.NewGuid().ToString());                                                
                }
                if(publicRequest.IsSetForce())
                {
                    context.Writer.WritePropertyName("force");
                    context.Writer.Write(publicRequest.Force);
                }

                if(publicRequest.IsSetLaunchTemplate())
                {
                    context.Writer.WritePropertyName("launchTemplate");
                    context.Writer.WriteObjectStart();

                    var marshaller = LaunchTemplateSpecificationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.LaunchTemplate, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetReleaseVersion())
                {
                    context.Writer.WritePropertyName("releaseVersion");
                    context.Writer.Write(publicRequest.ReleaseVersion);
                }

                if(publicRequest.IsSetVersion())
                {
                    context.Writer.WritePropertyName("version");
                    context.Writer.Write(publicRequest.Version);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateNodegroupVersionRequestMarshaller _instance = new UpdateNodegroupVersionRequestMarshaller();        

        internal static UpdateNodegroupVersionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateNodegroupVersionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}