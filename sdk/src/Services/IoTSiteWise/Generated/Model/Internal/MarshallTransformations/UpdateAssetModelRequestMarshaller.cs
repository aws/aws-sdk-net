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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTSiteWise.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoTSiteWise.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateAssetModel Request Marshaller
    /// </summary>       
    public class UpdateAssetModelRequestMarshaller : IMarshaller<IRequest, UpdateAssetModelRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateAssetModelRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateAssetModelRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoTSiteWise");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-12-02";            
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetAssetModelId())
                throw new AmazonIoTSiteWiseException("Request object does not have required field AssetModelId set");
            request.AddPathResource("{assetModelId}", StringUtils.FromString(publicRequest.AssetModelId));
            request.ResourcePath = "/asset-models/{assetModelId}";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAssetModelCompositeModels())
                {
                    context.Writer.WritePropertyName("assetModelCompositeModels");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAssetModelCompositeModelsListValue in publicRequest.AssetModelCompositeModels)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = AssetModelCompositeModelMarshaller.Instance;
                        marshaller.Marshall(publicRequestAssetModelCompositeModelsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetAssetModelDescription())
                {
                    context.Writer.WritePropertyName("assetModelDescription");
                    context.Writer.Write(publicRequest.AssetModelDescription);
                }

                if(publicRequest.IsSetAssetModelHierarchies())
                {
                    context.Writer.WritePropertyName("assetModelHierarchies");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAssetModelHierarchiesListValue in publicRequest.AssetModelHierarchies)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = AssetModelHierarchyMarshaller.Instance;
                        marshaller.Marshall(publicRequestAssetModelHierarchiesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetAssetModelName())
                {
                    context.Writer.WritePropertyName("assetModelName");
                    context.Writer.Write(publicRequest.AssetModelName);
                }

                if(publicRequest.IsSetAssetModelProperties())
                {
                    context.Writer.WritePropertyName("assetModelProperties");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAssetModelPropertiesListValue in publicRequest.AssetModelProperties)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = AssetModelPropertyMarshaller.Instance;
                        marshaller.Marshall(publicRequestAssetModelPropertiesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
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
        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

            
            request.HostPrefix = $"model.";

            return request;
        }
        private static UpdateAssetModelRequestMarshaller _instance = new UpdateAssetModelRequestMarshaller();        

        internal static UpdateAssetModelRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateAssetModelRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}