/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the frauddetector-2019-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.FraudDetector.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.FraudDetector.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetPrediction Request Marshaller
    /// </summary>       
    public class GetPredictionRequestMarshaller : IMarshaller<IRequest, GetPredictionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetPredictionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetPredictionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.FraudDetector");
            string target = "AWSHawksNestServiceFacade.GetPrediction";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-11-15";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDetectorId())
                {
                    context.Writer.WritePropertyName("detectorId");
                    context.Writer.Write(publicRequest.DetectorId);
                }

                if(publicRequest.IsSetDetectorVersionId())
                {
                    context.Writer.WritePropertyName("detectorVersionId");
                    context.Writer.Write(publicRequest.DetectorVersionId);
                }

                if(publicRequest.IsSetEventAttributes())
                {
                    context.Writer.WritePropertyName("eventAttributes");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestEventAttributesKvp in publicRequest.EventAttributes)
                    {
                        context.Writer.WritePropertyName(publicRequestEventAttributesKvp.Key);
                        var publicRequestEventAttributesValue = publicRequestEventAttributesKvp.Value;

                            context.Writer.Write(publicRequestEventAttributesValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetEventId())
                {
                    context.Writer.WritePropertyName("eventId");
                    context.Writer.Write(publicRequest.EventId);
                }

                if(publicRequest.IsSetExternalModelEndpointDataBlobs())
                {
                    context.Writer.WritePropertyName("externalModelEndpointDataBlobs");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestExternalModelEndpointDataBlobsKvp in publicRequest.ExternalModelEndpointDataBlobs)
                    {
                        context.Writer.WritePropertyName(publicRequestExternalModelEndpointDataBlobsKvp.Key);
                        var publicRequestExternalModelEndpointDataBlobsValue = publicRequestExternalModelEndpointDataBlobsKvp.Value;

                        context.Writer.WriteObjectStart();

                        var marshaller = ModelEndpointDataBlobMarshaller.Instance;
                        marshaller.Marshall(publicRequestExternalModelEndpointDataBlobsValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteObjectEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static GetPredictionRequestMarshaller _instance = new GetPredictionRequestMarshaller();        

        internal static GetPredictionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetPredictionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}