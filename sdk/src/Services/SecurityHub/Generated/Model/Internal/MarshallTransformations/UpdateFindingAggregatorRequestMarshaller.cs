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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateFindingAggregator Request Marshaller
    /// </summary>       
    public class UpdateFindingAggregatorRequestMarshaller : IMarshaller<IRequest, UpdateFindingAggregatorRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateFindingAggregatorRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateFindingAggregatorRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SecurityHub");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-10-26";
            request.HttpMethod = "PATCH";

            request.ResourcePath = "/findingAggregator/update";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetFindingAggregatorArn())
                {
                    context.Writer.WritePropertyName("FindingAggregatorArn");
                    context.Writer.Write(publicRequest.FindingAggregatorArn);
                }

                if(publicRequest.IsSetRegionLinkingMode())
                {
                    context.Writer.WritePropertyName("RegionLinkingMode");
                    context.Writer.Write(publicRequest.RegionLinkingMode);
                }

                if(publicRequest.IsSetRegions())
                {
                    context.Writer.WritePropertyName("Regions");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestRegionsListValue in publicRequest.Regions)
                    {
                            context.Writer.Write(publicRequestRegionsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateFindingAggregatorRequestMarshaller _instance = new UpdateFindingAggregatorRequestMarshaller();        

        internal static UpdateFindingAggregatorRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateFindingAggregatorRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}