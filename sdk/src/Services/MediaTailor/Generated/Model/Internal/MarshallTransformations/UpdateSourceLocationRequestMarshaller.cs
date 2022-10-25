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
 * Do not modify this file. This file is generated from the mediatailor-2018-04-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaTailor.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MediaTailor.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateSourceLocation Request Marshaller
    /// </summary>       
    public class UpdateSourceLocationRequestMarshaller : IMarshaller<IRequest, UpdateSourceLocationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateSourceLocationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateSourceLocationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MediaTailor");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-04-23";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetSourceLocationName())
                throw new AmazonMediaTailorException("Request object does not have required field SourceLocationName set");
            request.AddPathResource("{SourceLocationName}", StringUtils.FromString(publicRequest.SourceLocationName));
            request.ResourcePath = "/sourceLocation/{SourceLocationName}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAccessConfiguration())
                {
                    context.Writer.WritePropertyName("AccessConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = AccessConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AccessConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDefaultSegmentDeliveryConfiguration())
                {
                    context.Writer.WritePropertyName("DefaultSegmentDeliveryConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = DefaultSegmentDeliveryConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DefaultSegmentDeliveryConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetHttpConfiguration())
                {
                    context.Writer.WritePropertyName("HttpConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = HttpConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.HttpConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSegmentDeliveryConfigurations())
                {
                    context.Writer.WritePropertyName("SegmentDeliveryConfigurations");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSegmentDeliveryConfigurationsListValue in publicRequest.SegmentDeliveryConfigurations)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = SegmentDeliveryConfigurationMarshaller.Instance;
                        marshaller.Marshall(publicRequestSegmentDeliveryConfigurationsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateSourceLocationRequestMarshaller _instance = new UpdateSourceLocationRequestMarshaller();        

        internal static UpdateSourceLocationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateSourceLocationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}