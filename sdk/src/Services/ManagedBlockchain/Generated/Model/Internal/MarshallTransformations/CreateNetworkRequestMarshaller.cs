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
 * Do not modify this file. This file is generated from the managedblockchain-2018-09-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ManagedBlockchain.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ManagedBlockchain.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateNetwork Request Marshaller
    /// </summary>       
    public class CreateNetworkRequestMarshaller : IMarshaller<IRequest, CreateNetworkRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateNetworkRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateNetworkRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ManagedBlockchain");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-09-24";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/networks";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetClientRequestToken())
                {
                    context.Writer.WritePropertyName("ClientRequestToken");
                    context.Writer.Write(publicRequest.ClientRequestToken);
                }

                else if(!(publicRequest.IsSetClientRequestToken()))
                {
                    context.Writer.WritePropertyName("ClientRequestToken");
                    context.Writer.Write(Guid.NewGuid().ToString());                                                
                }
                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("Description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetFramework())
                {
                    context.Writer.WritePropertyName("Framework");
                    context.Writer.Write(publicRequest.Framework);
                }

                if(publicRequest.IsSetFrameworkConfiguration())
                {
                    context.Writer.WritePropertyName("FrameworkConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = NetworkFrameworkConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.FrameworkConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetFrameworkVersion())
                {
                    context.Writer.WritePropertyName("FrameworkVersion");
                    context.Writer.Write(publicRequest.FrameworkVersion);
                }

                if(publicRequest.IsSetMemberConfiguration())
                {
                    context.Writer.WritePropertyName("MemberConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = MemberConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.MemberConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("Name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetVotingPolicy())
                {
                    context.Writer.WritePropertyName("VotingPolicy");
                    context.Writer.WriteObjectStart();

                    var marshaller = VotingPolicyMarshaller.Instance;
                    marshaller.Marshall(publicRequest.VotingPolicy, context);

                    context.Writer.WriteObjectEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateNetworkRequestMarshaller _instance = new CreateNetworkRequestMarshaller();        

        internal static CreateNetworkRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateNetworkRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}