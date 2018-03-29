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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glue.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetPlan Request Marshaller
    /// </summary>       
    public class GetPlanRequestMarshaller : IMarshaller<IRequest, GetPlanRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetPlanRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetPlanRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Glue");
            string target = "AWSGlue.GetPlan";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetLanguage())
                {
                    context.Writer.WritePropertyName("Language");
                    context.Writer.Write(publicRequest.Language);
                }

                if(publicRequest.IsSetLocation())
                {
                    context.Writer.WritePropertyName("Location");
                    context.Writer.WriteObjectStart();

                    var marshaller = LocationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Location, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetMapping())
                {
                    context.Writer.WritePropertyName("Mapping");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestMappingListValue in publicRequest.Mapping)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = MappingEntryMarshaller.Instance;
                        marshaller.Marshall(publicRequestMappingListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetSinks())
                {
                    context.Writer.WritePropertyName("Sinks");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSinksListValue in publicRequest.Sinks)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = CatalogEntryMarshaller.Instance;
                        marshaller.Marshall(publicRequestSinksListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetSource())
                {
                    context.Writer.WritePropertyName("Source");
                    context.Writer.WriteObjectStart();

                    var marshaller = CatalogEntryMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Source, context);

                    context.Writer.WriteObjectEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static GetPlanRequestMarshaller _instance = new GetPlanRequestMarshaller();        

        internal static GetPlanRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetPlanRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}