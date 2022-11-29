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
 * Do not modify this file. This file is generated from the securitylake-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityLake.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SecurityLake.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateAwsLogSource Request Marshaller
    /// </summary>       
    public class CreateAwsLogSourceRequestMarshaller : IMarshaller<IRequest, CreateAwsLogSourceRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateAwsLogSourceRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateAwsLogSourceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SecurityLake");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "POST";

            request.ResourcePath = "/v1/logsources/aws";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetEnableAllDimensions())
                {
                    context.Writer.WritePropertyName("enableAllDimensions");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestEnableAllDimensionsKvp in publicRequest.EnableAllDimensions)
                    {
                        context.Writer.WritePropertyName(publicRequestEnableAllDimensionsKvp.Key);
                        var publicRequestEnableAllDimensionsValue = publicRequestEnableAllDimensionsKvp.Value;

                        context.Writer.WriteObjectStart();
                        foreach (var publicRequestEnableAllDimensionsValueKvp in publicRequestEnableAllDimensionsValue)
                        {
                            context.Writer.WritePropertyName(publicRequestEnableAllDimensionsValueKvp.Key);
                            var publicRequestEnableAllDimensionsValueValue = publicRequestEnableAllDimensionsValueKvp.Value;

                            context.Writer.WriteArrayStart();
                            foreach(var publicRequestEnableAllDimensionsValueValueListValue in publicRequestEnableAllDimensionsValueValue)
                            {
                                    context.Writer.Write(publicRequestEnableAllDimensionsValueValueListValue);
                            }
                            context.Writer.WriteArrayEnd();
                        }
                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetEnableSingleDimension())
                {
                    context.Writer.WritePropertyName("enableSingleDimension");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestEnableSingleDimensionListValue in publicRequest.EnableSingleDimension)
                    {
                            context.Writer.Write(publicRequestEnableSingleDimensionListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetEnableTwoDimensions())
                {
                    context.Writer.WritePropertyName("enableTwoDimensions");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestEnableTwoDimensionsKvp in publicRequest.EnableTwoDimensions)
                    {
                        context.Writer.WritePropertyName(publicRequestEnableTwoDimensionsKvp.Key);
                        var publicRequestEnableTwoDimensionsValue = publicRequestEnableTwoDimensionsKvp.Value;

                        context.Writer.WriteArrayStart();
                        foreach(var publicRequestEnableTwoDimensionsValueListValue in publicRequestEnableTwoDimensionsValue)
                        {
                                context.Writer.Write(publicRequestEnableTwoDimensionsValueListValue);
                        }
                        context.Writer.WriteArrayEnd();
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetInputOrder())
                {
                    context.Writer.WritePropertyName("inputOrder");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestInputOrderListValue in publicRequest.InputOrder)
                    {
                            context.Writer.Write(publicRequestInputOrderListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateAwsLogSourceRequestMarshaller _instance = new CreateAwsLogSourceRequestMarshaller();        

        internal static CreateAwsLogSourceRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateAwsLogSourceRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}