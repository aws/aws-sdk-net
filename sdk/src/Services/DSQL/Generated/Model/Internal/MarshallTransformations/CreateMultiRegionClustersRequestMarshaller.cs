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
 * Do not modify this file. This file is generated from the dsql-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DSQL.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.DSQL.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateMultiRegionClusters Request Marshaller
    /// </summary>       
    public class CreateMultiRegionClustersRequestMarshaller : IMarshaller<IRequest, CreateMultiRegionClustersRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateMultiRegionClustersRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateMultiRegionClustersRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DSQL");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "POST";

            request.ResourcePath = "/multi-region-clusters";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
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
                if(publicRequest.IsSetClusterProperties())
                {
                    context.Writer.WritePropertyName("clusterProperties");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestClusterPropertiesKvp in publicRequest.ClusterProperties)
                    {
                        context.Writer.WritePropertyName(publicRequestClusterPropertiesKvp.Key);
                        var publicRequestClusterPropertiesValue = publicRequestClusterPropertiesKvp.Value;

                        context.Writer.WriteObjectStart();

                        var marshaller = LinkedClusterPropertiesMarshaller.Instance;
                        marshaller.Marshall(publicRequestClusterPropertiesValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetLinkedRegionList())
                {
                    context.Writer.WritePropertyName("linkedRegionList");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestLinkedRegionListListValue in publicRequest.LinkedRegionList)
                    {
                            context.Writer.Write(publicRequestLinkedRegionListListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetWitnessRegion())
                {
                    context.Writer.WritePropertyName("witnessRegion");
                    context.Writer.Write(publicRequest.WitnessRegion);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateMultiRegionClustersRequestMarshaller _instance = new CreateMultiRegionClustersRequestMarshaller();        

        internal static CreateMultiRegionClustersRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateMultiRegionClustersRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}