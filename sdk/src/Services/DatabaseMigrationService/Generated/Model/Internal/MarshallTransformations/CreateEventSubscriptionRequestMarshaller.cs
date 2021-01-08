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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DatabaseMigrationService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.DatabaseMigrationService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateEventSubscription Request Marshaller
    /// </summary>       
    public class CreateEventSubscriptionRequestMarshaller : IMarshaller<IRequest, CreateEventSubscriptionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateEventSubscriptionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateEventSubscriptionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DatabaseMigrationService");
            string target = "AmazonDMSv20160101.CreateEventSubscription";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-01-01";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetEnabled())
                {
                    context.Writer.WritePropertyName("Enabled");
                    context.Writer.Write(publicRequest.Enabled);
                }

                if(publicRequest.IsSetEventCategories())
                {
                    context.Writer.WritePropertyName("EventCategories");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestEventCategoriesListValue in publicRequest.EventCategories)
                    {
                            context.Writer.Write(publicRequestEventCategoriesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetSnsTopicArn())
                {
                    context.Writer.WritePropertyName("SnsTopicArn");
                    context.Writer.Write(publicRequest.SnsTopicArn);
                }

                if(publicRequest.IsSetSourceIds())
                {
                    context.Writer.WritePropertyName("SourceIds");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSourceIdsListValue in publicRequest.SourceIds)
                    {
                            context.Writer.Write(publicRequestSourceIdsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetSourceType())
                {
                    context.Writer.WritePropertyName("SourceType");
                    context.Writer.Write(publicRequest.SourceType);
                }

                if(publicRequest.IsSetSubscriptionName())
                {
                    context.Writer.WritePropertyName("SubscriptionName");
                    context.Writer.Write(publicRequest.SubscriptionName);
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("Tags");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTagsListValue in publicRequest.Tags)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TagMarshaller.Instance;
                        marshaller.Marshall(publicRequestTagsListValue, context);

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
        private static CreateEventSubscriptionRequestMarshaller _instance = new CreateEventSubscriptionRequestMarshaller();        

        internal static CreateEventSubscriptionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateEventSubscriptionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}