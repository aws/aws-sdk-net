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
 * Do not modify this file. This file is generated from the clouddirectory-2016-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudDirectory.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CloudDirectory.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateTypedLinkFacet Request Marshaller
    /// </summary>       
    public class UpdateTypedLinkFacetRequestMarshaller : IMarshaller<IRequest, UpdateTypedLinkFacetRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateTypedLinkFacetRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateTypedLinkFacetRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudDirectory");
            request.Headers["Content-Type"] = "application/x-amz-json-";
            request.HttpMethod = "PUT";

            string uriResourcePath = "/amazonclouddirectory/2017-01-11/typedlink/facet";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAttributeUpdates())
                {
                    context.Writer.WritePropertyName("AttributeUpdates");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAttributeUpdatesListValue in publicRequest.AttributeUpdates)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TypedLinkFacetAttributeUpdateMarshaller.Instance;
                        marshaller.Marshall(publicRequestAttributeUpdatesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetIdentityAttributeOrder())
                {
                    context.Writer.WritePropertyName("IdentityAttributeOrder");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestIdentityAttributeOrderListValue in publicRequest.IdentityAttributeOrder)
                    {
                            context.Writer.Write(publicRequestIdentityAttributeOrderListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("Name");
                    context.Writer.Write(publicRequest.Name);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

        
            if(publicRequest.IsSetSchemaArn())
                request.Headers["x-amz-data-partition"] = publicRequest.SchemaArn;

            return request;
        }
        private static UpdateTypedLinkFacetRequestMarshaller _instance = new UpdateTypedLinkFacetRequestMarshaller();        

        internal static UpdateTypedLinkFacetRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateTypedLinkFacetRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}