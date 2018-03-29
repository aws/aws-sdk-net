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
 * Do not modify this file. This file is generated from the lex-models-2017-04-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LexModelBuildingService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.LexModelBuildingService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutSlotType Request Marshaller
    /// </summary>       
    public class PutSlotTypeRequestMarshaller : IMarshaller<IRequest, PutSlotTypeRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutSlotTypeRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutSlotTypeRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LexModelBuildingService");
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "PUT";

            string uriResourcePath = "/slottypes/{name}/versions/$LATEST";
            if (!publicRequest.IsSetName())
                throw new AmazonLexModelBuildingServiceException("Request object does not have required field Name set");
            uriResourcePath = uriResourcePath.Replace("{name}", StringUtils.FromString(publicRequest.Name));
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetChecksum())
                {
                    context.Writer.WritePropertyName("checksum");
                    context.Writer.Write(publicRequest.Checksum);
                }

                if(publicRequest.IsSetCreateVersion())
                {
                    context.Writer.WritePropertyName("createVersion");
                    context.Writer.Write(publicRequest.CreateVersion);
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetEnumerationValues())
                {
                    context.Writer.WritePropertyName("enumerationValues");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestEnumerationValuesListValue in publicRequest.EnumerationValues)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = EnumerationValueMarshaller.Instance;
                        marshaller.Marshall(publicRequestEnumerationValuesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetValueSelectionStrategy())
                {
                    context.Writer.WritePropertyName("valueSelectionStrategy");
                    context.Writer.Write(publicRequest.ValueSelectionStrategy);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static PutSlotTypeRequestMarshaller _instance = new PutSlotTypeRequestMarshaller();        

        internal static PutSlotTypeRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutSlotTypeRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}