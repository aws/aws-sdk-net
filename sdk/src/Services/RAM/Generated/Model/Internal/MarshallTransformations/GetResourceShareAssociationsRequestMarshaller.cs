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
    /// GetResourceShareAssociations Request Marshaller
    /// </summary>       
    public class GetResourceShareAssociationsRequestMarshaller : IMarshaller<IRequest, GetResourceShareAssociationsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetResourceShareAssociationsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetResourceShareAssociationsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RAM");
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-01-04";            
            request.HttpMethod = "POST";

            string uriResourcePath = "/getresourceshareassociations";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAssociationStatus())
                {
                    context.Writer.WritePropertyName("associationStatus");
                    context.Writer.Write(publicRequest.AssociationStatus);
                }

                if(publicRequest.IsSetAssociationType())
                {
                    context.Writer.WritePropertyName("associationType");
                    context.Writer.Write(publicRequest.AssociationType);
                }

                if(publicRequest.IsSetMaxResults())
                {
                    context.Writer.WritePropertyName("maxResults");
                    context.Writer.Write(publicRequest.MaxResults);
                }

                if(publicRequest.IsSetNextToken())
                {
                    context.Writer.WritePropertyName("nextToken");
                    context.Writer.Write(publicRequest.NextToken);
                }

                if(publicRequest.IsSetPrincipal())
                {
                    context.Writer.WritePropertyName("principal");
                    context.Writer.Write(publicRequest.Principal);
                }

                if(publicRequest.IsSetResourceArn())
                {
                    context.Writer.WritePropertyName("resourceArn");
                    context.Writer.Write(publicRequest.ResourceArn);
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

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static GetResourceShareAssociationsRequestMarshaller _instance = new GetResourceShareAssociationsRequestMarshaller();        

        internal static GetResourceShareAssociationsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetResourceShareAssociationsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}