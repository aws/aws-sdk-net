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
 * Do not modify this file. This file is generated from the location-2020-11-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LocationService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.LocationService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SearchPlaceIndexForText Request Marshaller
    /// </summary>       
    public class SearchPlaceIndexForTextRequestMarshaller : IMarshaller<IRequest, SearchPlaceIndexForTextRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SearchPlaceIndexForTextRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(SearchPlaceIndexForTextRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LocationService");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-11-19";            
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetIndexName())
                throw new AmazonLocationServiceException("Request object does not have required field IndexName set");
            request.AddPathResource("{IndexName}", StringUtils.FromString(publicRequest.IndexName));
            request.ResourcePath = "/places/v0/indexes/{IndexName}/search/text";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetBiasPosition())
                {
                    context.Writer.WritePropertyName("BiasPosition");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestBiasPositionListValue in publicRequest.BiasPosition)
                    {
                            context.Writer.Write(publicRequestBiasPositionListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetFilterBBox())
                {
                    context.Writer.WritePropertyName("FilterBBox");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestFilterBBoxListValue in publicRequest.FilterBBox)
                    {
                            context.Writer.Write(publicRequestFilterBBoxListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetFilterCountries())
                {
                    context.Writer.WritePropertyName("FilterCountries");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestFilterCountriesListValue in publicRequest.FilterCountries)
                    {
                            context.Writer.Write(publicRequestFilterCountriesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetMaxResults())
                {
                    context.Writer.WritePropertyName("MaxResults");
                    context.Writer.Write(publicRequest.MaxResults);
                }

                if(publicRequest.IsSetText())
                {
                    context.Writer.WritePropertyName("Text");
                    context.Writer.Write(publicRequest.Text);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

            
            request.HostPrefix = $"places.";

            return request;
        }
        private static SearchPlaceIndexForTextRequestMarshaller _instance = new SearchPlaceIndexForTextRequestMarshaller();        

        internal static SearchPlaceIndexForTextRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SearchPlaceIndexForTextRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}