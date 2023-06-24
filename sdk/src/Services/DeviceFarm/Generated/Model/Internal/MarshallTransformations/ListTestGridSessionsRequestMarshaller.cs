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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DeviceFarm.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.DeviceFarm.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListTestGridSessions Request Marshaller
    /// </summary>       
    public class ListTestGridSessionsRequestMarshaller : IMarshaller<IRequest, ListTestGridSessionsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListTestGridSessionsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListTestGridSessionsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DeviceFarm");
            string target = "DeviceFarm_20150623.ListTestGridSessions";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-06-23";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCreationTimeAfter())
                {
                    context.Writer.WritePropertyName("creationTimeAfter");
                    context.Writer.Write(publicRequest.CreationTimeAfter);
                }

                if(publicRequest.IsSetCreationTimeBefore())
                {
                    context.Writer.WritePropertyName("creationTimeBefore");
                    context.Writer.Write(publicRequest.CreationTimeBefore);
                }

                if(publicRequest.IsSetEndTimeAfter())
                {
                    context.Writer.WritePropertyName("endTimeAfter");
                    context.Writer.Write(publicRequest.EndTimeAfter);
                }

                if(publicRequest.IsSetEndTimeBefore())
                {
                    context.Writer.WritePropertyName("endTimeBefore");
                    context.Writer.Write(publicRequest.EndTimeBefore);
                }

                if(publicRequest.IsSetMaxResult())
                {
                    context.Writer.WritePropertyName("maxResult");
                    context.Writer.Write(publicRequest.MaxResult);
                }

                if(publicRequest.IsSetNextToken())
                {
                    context.Writer.WritePropertyName("nextToken");
                    context.Writer.Write(publicRequest.NextToken);
                }

                if(publicRequest.IsSetProjectArn())
                {
                    context.Writer.WritePropertyName("projectArn");
                    context.Writer.Write(publicRequest.ProjectArn);
                }

                if(publicRequest.IsSetStatus())
                {
                    context.Writer.WritePropertyName("status");
                    context.Writer.Write(publicRequest.Status);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static ListTestGridSessionsRequestMarshaller _instance = new ListTestGridSessionsRequestMarshaller();        

        internal static ListTestGridSessionsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListTestGridSessionsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}