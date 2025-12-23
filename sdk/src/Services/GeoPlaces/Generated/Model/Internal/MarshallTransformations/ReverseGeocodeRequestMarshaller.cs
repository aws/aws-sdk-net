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
 * Do not modify this file. This file is generated from the geo-places-2020-11-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.GeoPlaces.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.GeoPlaces.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ReverseGeocode Request Marshaller
    /// </summary>       
    public class ReverseGeocodeRequestMarshaller : IMarshaller<IRequest, ReverseGeocodeRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ReverseGeocodeRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ReverseGeocodeRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.GeoPlaces");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-11-19";
            request.HttpMethod = "POST";

            
            if (publicRequest.IsSetKey())
                request.Parameters.Add("key", StringUtils.FromString(publicRequest.Key));
            request.ResourcePath = "/reverse-geocode";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAdditionalFeatures())
                {
                    context.Writer.WritePropertyName("AdditionalFeatures");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAdditionalFeaturesListValue in publicRequest.AdditionalFeatures)
                    {
                            context.Writer.Write(publicRequestAdditionalFeaturesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetFilter())
                {
                    context.Writer.WritePropertyName("Filter");
                    context.Writer.WriteObjectStart();

                    var marshaller = ReverseGeocodeFilterMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Filter, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetHeading())
                {
                    context.Writer.WritePropertyName("Heading");
                    if(StringUtils.IsSpecialDoubleValue(publicRequest.Heading))
                    {
                        context.Writer.Write(StringUtils.FromSpecialDoubleValue(publicRequest.Heading));
                    }
                    else
                    {
                        context.Writer.Write(publicRequest.Heading);
                    }
                }

                if(publicRequest.IsSetIntendedUse())
                {
                    context.Writer.WritePropertyName("IntendedUse");
                    context.Writer.Write(publicRequest.IntendedUse);
                }

                if(publicRequest.IsSetLanguage())
                {
                    context.Writer.WritePropertyName("Language");
                    context.Writer.Write(publicRequest.Language);
                }

                if(publicRequest.IsSetMaxResults())
                {
                    context.Writer.WritePropertyName("MaxResults");
                    context.Writer.Write(publicRequest.MaxResults);
                }

                if(publicRequest.IsSetPoliticalView())
                {
                    context.Writer.WritePropertyName("PoliticalView");
                    context.Writer.Write(publicRequest.PoliticalView);
                }

                if(publicRequest.IsSetQueryPosition())
                {
                    context.Writer.WritePropertyName("QueryPosition");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestQueryPositionListValue in publicRequest.QueryPosition)
                    {
                            context.Writer.Write(publicRequestQueryPositionListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetQueryRadius())
                {
                    context.Writer.WritePropertyName("QueryRadius");
                    context.Writer.Write(publicRequest.QueryRadius);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

            request.UseQueryString = true;

            return request;
        }
        private static ReverseGeocodeRequestMarshaller _instance = new ReverseGeocodeRequestMarshaller();        

        internal static ReverseGeocodeRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ReverseGeocodeRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}