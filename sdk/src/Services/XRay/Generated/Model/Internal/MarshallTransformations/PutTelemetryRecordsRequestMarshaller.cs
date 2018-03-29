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
 * Do not modify this file. This file is generated from the xray-2016-04-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.XRay.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.XRay.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutTelemetryRecords Request Marshaller
    /// </summary>       
    public class PutTelemetryRecordsRequestMarshaller : IMarshaller<IRequest, PutTelemetryRecordsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutTelemetryRecordsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutTelemetryRecordsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.XRay");
            request.Headers["Content-Type"] = "application/x-amz-json-";
            request.HttpMethod = "POST";

            string uriResourcePath = "/TelemetryRecords";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetEC2InstanceId())
                {
                    context.Writer.WritePropertyName("EC2InstanceId");
                    context.Writer.Write(publicRequest.EC2InstanceId);
                }

                if(publicRequest.IsSetHostname())
                {
                    context.Writer.WritePropertyName("Hostname");
                    context.Writer.Write(publicRequest.Hostname);
                }

                if(publicRequest.IsSetResourceARN())
                {
                    context.Writer.WritePropertyName("ResourceARN");
                    context.Writer.Write(publicRequest.ResourceARN);
                }

                if(publicRequest.IsSetTelemetryRecords())
                {
                    context.Writer.WritePropertyName("TelemetryRecords");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTelemetryRecordsListValue in publicRequest.TelemetryRecords)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TelemetryRecordMarshaller.Instance;
                        marshaller.Marshall(publicRequestTelemetryRecordsListValue, context);

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
        private static PutTelemetryRecordsRequestMarshaller _instance = new PutTelemetryRecordsRequestMarshaller();        

        internal static PutTelemetryRecordsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutTelemetryRecordsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}