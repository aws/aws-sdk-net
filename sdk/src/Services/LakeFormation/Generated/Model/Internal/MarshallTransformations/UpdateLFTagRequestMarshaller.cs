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
 * Do not modify this file. This file is generated from the lakeformation-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LakeFormation.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.LakeFormation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateLFTag Request Marshaller
    /// </summary>       
    public class UpdateLFTagRequestMarshaller : IMarshaller<IRequest, UpdateLFTagRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateLFTagRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateLFTagRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LakeFormation");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-03-31";
            request.HttpMethod = "POST";

            request.ResourcePath = "/UpdateLFTag";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCatalogId())
                {
                    context.Writer.WritePropertyName("CatalogId");
                    context.Writer.Write(publicRequest.CatalogId);
                }

                if(publicRequest.IsSetTagKey())
                {
                    context.Writer.WritePropertyName("TagKey");
                    context.Writer.Write(publicRequest.TagKey);
                }

                if(publicRequest.IsSetTagValuesToAdd())
                {
                    context.Writer.WritePropertyName("TagValuesToAdd");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTagValuesToAddListValue in publicRequest.TagValuesToAdd)
                    {
                            context.Writer.Write(publicRequestTagValuesToAddListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetTagValuesToDelete())
                {
                    context.Writer.WritePropertyName("TagValuesToDelete");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTagValuesToDeleteListValue in publicRequest.TagValuesToDelete)
                    {
                            context.Writer.Write(publicRequestTagValuesToDeleteListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateLFTagRequestMarshaller _instance = new UpdateLFTagRequestMarshaller();        

        internal static UpdateLFTagRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateLFTagRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}