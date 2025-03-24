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
 * Do not modify this file. This file is generated from the application-signals-2024-04-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ApplicationSignals.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.ApplicationSignals.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BatchUpdateExclusionWindows Request Marshaller
    /// </summary>       
    public class BatchUpdateExclusionWindowsRequestMarshaller : IMarshaller<IRequest, BatchUpdateExclusionWindowsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((BatchUpdateExclusionWindowsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(BatchUpdateExclusionWindowsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ApplicationSignals");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2024-04-15";
            request.HttpMethod = "PATCH";

            request.ResourcePath = "/exclusion-windows";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAddExclusionWindows())
                {
                    context.Writer.WritePropertyName("AddExclusionWindows");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAddExclusionWindowsListValue in publicRequest.AddExclusionWindows)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = ExclusionWindowMarshaller.Instance;
                        marshaller.Marshall(publicRequestAddExclusionWindowsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetRemoveExclusionWindows())
                {
                    context.Writer.WritePropertyName("RemoveExclusionWindows");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestRemoveExclusionWindowsListValue in publicRequest.RemoveExclusionWindows)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = ExclusionWindowMarshaller.Instance;
                        marshaller.Marshall(publicRequestRemoveExclusionWindowsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetSloIds())
                {
                    context.Writer.WritePropertyName("SloIds");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSloIdsListValue in publicRequest.SloIds)
                    {
                            context.Writer.Write(publicRequestSloIdsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static BatchUpdateExclusionWindowsRequestMarshaller _instance = new BatchUpdateExclusionWindowsRequestMarshaller();        

        internal static BatchUpdateExclusionWindowsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static BatchUpdateExclusionWindowsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}