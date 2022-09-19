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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudTrail.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CloudTrail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartImport Request Marshaller
    /// </summary>       
    public class StartImportRequestMarshaller : IMarshaller<IRequest, StartImportRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartImportRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartImportRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudTrail");
            string target = "com.amazonaws.cloudtrail.v20131101.CloudTrail_20131101.StartImport";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2013-11-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDestinations())
                {
                    context.Writer.WritePropertyName("Destinations");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestDestinationsListValue in publicRequest.Destinations)
                    {
                            context.Writer.Write(publicRequestDestinationsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetEndEventTime())
                {
                    context.Writer.WritePropertyName("EndEventTime");
                    context.Writer.Write(publicRequest.EndEventTime);
                }

                if(publicRequest.IsSetImportId())
                {
                    context.Writer.WritePropertyName("ImportId");
                    context.Writer.Write(publicRequest.ImportId);
                }

                if(publicRequest.IsSetImportSource())
                {
                    context.Writer.WritePropertyName("ImportSource");
                    context.Writer.WriteObjectStart();

                    var marshaller = ImportSourceMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ImportSource, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetStartEventTime())
                {
                    context.Writer.WritePropertyName("StartEventTime");
                    context.Writer.Write(publicRequest.StartEventTime);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static StartImportRequestMarshaller _instance = new StartImportRequestMarshaller();        

        internal static StartImportRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartImportRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}