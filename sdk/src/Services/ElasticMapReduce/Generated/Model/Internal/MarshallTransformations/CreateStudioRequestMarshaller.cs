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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticMapReduce.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ElasticMapReduce.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateStudio Request Marshaller
    /// </summary>       
    public class CreateStudioRequestMarshaller : IMarshaller<IRequest, CreateStudioRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateStudioRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateStudioRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticMapReduce");
            string target = "ElasticMapReduce.CreateStudio";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2009-03-31";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAuthMode())
                {
                    context.Writer.WritePropertyName("AuthMode");
                    context.Writer.Write(publicRequest.AuthMode);
                }

                if(publicRequest.IsSetDefaultS3Location())
                {
                    context.Writer.WritePropertyName("DefaultS3Location");
                    context.Writer.Write(publicRequest.DefaultS3Location);
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("Description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetEngineSecurityGroupId())
                {
                    context.Writer.WritePropertyName("EngineSecurityGroupId");
                    context.Writer.Write(publicRequest.EngineSecurityGroupId);
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("Name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetServiceRole())
                {
                    context.Writer.WritePropertyName("ServiceRole");
                    context.Writer.Write(publicRequest.ServiceRole);
                }

                if(publicRequest.IsSetSubnetIds())
                {
                    context.Writer.WritePropertyName("SubnetIds");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSubnetIdsListValue in publicRequest.SubnetIds)
                    {
                            context.Writer.Write(publicRequestSubnetIdsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("Tags");
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

                if(publicRequest.IsSetUserRole())
                {
                    context.Writer.WritePropertyName("UserRole");
                    context.Writer.Write(publicRequest.UserRole);
                }

                if(publicRequest.IsSetVpcId())
                {
                    context.Writer.WritePropertyName("VpcId");
                    context.Writer.Write(publicRequest.VpcId);
                }

                if(publicRequest.IsSetWorkspaceSecurityGroupId())
                {
                    context.Writer.WritePropertyName("WorkspaceSecurityGroupId");
                    context.Writer.Write(publicRequest.WorkspaceSecurityGroupId);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateStudioRequestMarshaller _instance = new CreateStudioRequestMarshaller();        

        internal static CreateStudioRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateStudioRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}