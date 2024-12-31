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
 * Do not modify this file. This file is generated from the memorydb-2021-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MemoryDB.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.MemoryDB.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateMultiRegionCluster Request Marshaller
    /// </summary>       
    public class UpdateMultiRegionClusterRequestMarshaller : IMarshaller<IRequest, UpdateMultiRegionClusterRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateMultiRegionClusterRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateMultiRegionClusterRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MemoryDB");
            string target = "AmazonMemoryDB.UpdateMultiRegionCluster";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-01-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("Description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetEngineVersion())
                {
                    context.Writer.WritePropertyName("EngineVersion");
                    context.Writer.Write(publicRequest.EngineVersion);
                }

                if(publicRequest.IsSetMultiRegionClusterName())
                {
                    context.Writer.WritePropertyName("MultiRegionClusterName");
                    context.Writer.Write(publicRequest.MultiRegionClusterName);
                }

                if(publicRequest.IsSetMultiRegionParameterGroupName())
                {
                    context.Writer.WritePropertyName("MultiRegionParameterGroupName");
                    context.Writer.Write(publicRequest.MultiRegionParameterGroupName);
                }

                if(publicRequest.IsSetNodeType())
                {
                    context.Writer.WritePropertyName("NodeType");
                    context.Writer.Write(publicRequest.NodeType);
                }

                if(publicRequest.IsSetShardConfiguration())
                {
                    context.Writer.WritePropertyName("ShardConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = ShardConfigurationRequestMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ShardConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetUpdateStrategy())
                {
                    context.Writer.WritePropertyName("UpdateStrategy");
                    context.Writer.Write(publicRequest.UpdateStrategy);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateMultiRegionClusterRequestMarshaller _instance = new UpdateMultiRegionClusterRequestMarshaller();        

        internal static UpdateMultiRegionClusterRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateMultiRegionClusterRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}