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
 * Do not modify this file. This file is generated from the ram-2018-01-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.RAM.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.RAM.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetResourceShares Request Marshaller
    /// </summary>       
    public class GetResourceSharesRequestMarshaller : IMarshaller<IRequest, GetResourceSharesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetResourceSharesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetResourceSharesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RAM");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-01-04";            
            request.HttpMethod = "POST";

            string uriResourcePath = "/getresourceshares";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetMaxResults())
                {
                    context.Writer.WritePropertyName("maxResults");
                    context.Writer.Write(publicRequest.MaxResults);
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetNextToken())
                {
                    context.Writer.WritePropertyName("nextToken");
                    context.Writer.Write(publicRequest.NextToken);
                }

                if(publicRequest.IsSetResourceOwner())
                {
                    context.Writer.WritePropertyName("resourceOwner");
                    context.Writer.Write(publicRequest.ResourceOwner);
                }

                if(publicRequest.IsSetResourceShareArns())
                {
                    context.Writer.WritePropertyName("resourceShareArns");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestResourceShareArnsListValue in publicRequest.ResourceShareArns)
                    {
                            context.Writer.Write(publicRequestResourceShareArnsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetResourceShareStatus())
                {
                    context.Writer.WritePropertyName("resourceShareStatus");
                    context.Writer.Write(publicRequest.ResourceShareStatus);
                }

                if(publicRequest.IsSetTagFilters())
                {
                    context.Writer.WritePropertyName("tagFilters");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTagFiltersListValue in publicRequest.TagFilters)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TagFilterMarshaller.Instance;
                        marshaller.Marshall(publicRequestTagFiltersListValue, context);

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
        private static GetResourceSharesRequestMarshaller _instance = new GetResourceSharesRequestMarshaller();        

        internal static GetResourceSharesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetResourceSharesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}