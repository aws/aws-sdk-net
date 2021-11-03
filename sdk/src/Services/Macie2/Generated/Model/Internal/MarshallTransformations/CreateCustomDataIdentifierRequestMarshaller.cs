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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Macie2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Macie2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateCustomDataIdentifier Request Marshaller
    /// </summary>       
    public class CreateCustomDataIdentifierRequestMarshaller : IMarshaller<IRequest, CreateCustomDataIdentifierRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateCustomDataIdentifierRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateCustomDataIdentifierRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Macie2");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-01-01";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/custom-data-identifiers";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetClientToken())
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(publicRequest.ClientToken);
                }

                else if(!(publicRequest.IsSetClientToken()))
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(Guid.NewGuid().ToString());                                                
                }
                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetIgnoreWords())
                {
                    context.Writer.WritePropertyName("ignoreWords");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestIgnoreWordsListValue in publicRequest.IgnoreWords)
                    {
                            context.Writer.Write(publicRequestIgnoreWordsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetKeywords())
                {
                    context.Writer.WritePropertyName("keywords");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestKeywordsListValue in publicRequest.Keywords)
                    {
                            context.Writer.Write(publicRequestKeywordsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetMaximumMatchDistance())
                {
                    context.Writer.WritePropertyName("maximumMatchDistance");
                    context.Writer.Write(publicRequest.MaximumMatchDistance);
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetRegex())
                {
                    context.Writer.WritePropertyName("regex");
                    context.Writer.Write(publicRequest.Regex);
                }

                if(publicRequest.IsSetSeverityLevels())
                {
                    context.Writer.WritePropertyName("severityLevels");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSeverityLevelsListValue in publicRequest.SeverityLevels)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = SeverityLevelMarshaller.Instance;
                        marshaller.Marshall(publicRequestSeverityLevelsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("tags");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestTagsKvp in publicRequest.Tags)
                    {
                        context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                        var publicRequestTagsValue = publicRequestTagsKvp.Value;

                            context.Writer.Write(publicRequestTagsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateCustomDataIdentifierRequestMarshaller _instance = new CreateCustomDataIdentifierRequestMarshaller();        

        internal static CreateCustomDataIdentifierRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateCustomDataIdentifierRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}