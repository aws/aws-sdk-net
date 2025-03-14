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
 * Do not modify this file. This file is generated from the partnercentral-selling-2022-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.PartnerCentralSelling.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.PartnerCentralSelling.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListSolutions Request Marshaller
    /// </summary>       
    public class ListSolutionsRequestMarshaller : IMarshaller<IRequest, ListSolutionsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListSolutionsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListSolutionsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.PartnerCentralSelling");
            string target = "AWSPartnerCentralSelling.ListSolutions";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-07-26";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCatalog())
                {
                    context.Writer.WritePropertyName("Catalog");
                    context.Writer.Write(publicRequest.Catalog);
                }

                if(publicRequest.IsSetCategory())
                {
                    context.Writer.WritePropertyName("Category");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestCategoryListValue in publicRequest.Category)
                    {
                            context.Writer.Write(publicRequestCategoryListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetIdentifier())
                {
                    context.Writer.WritePropertyName("Identifier");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestIdentifierListValue in publicRequest.Identifier)
                    {
                            context.Writer.Write(publicRequestIdentifierListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetMaxResults())
                {
                    context.Writer.WritePropertyName("MaxResults");
                    context.Writer.Write(publicRequest.MaxResults);
                }

                if(publicRequest.IsSetNextToken())
                {
                    context.Writer.WritePropertyName("NextToken");
                    context.Writer.Write(publicRequest.NextToken);
                }

                if(publicRequest.IsSetSort())
                {
                    context.Writer.WritePropertyName("Sort");
                    context.Writer.WriteObjectStart();

                    var marshaller = SolutionSortMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Sort, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetStatus())
                {
                    context.Writer.WritePropertyName("Status");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestStatusListValue in publicRequest.Status)
                    {
                            context.Writer.Write(publicRequestStatusListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static ListSolutionsRequestMarshaller _instance = new ListSolutionsRequestMarshaller();        

        internal static ListSolutionsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListSolutionsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}