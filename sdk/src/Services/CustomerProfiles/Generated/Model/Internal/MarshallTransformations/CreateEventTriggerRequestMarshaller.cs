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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CustomerProfiles.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.CustomerProfiles.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateEventTrigger Request Marshaller
    /// </summary>       
    public class CreateEventTriggerRequestMarshaller : IMarshaller<IRequest, CreateEventTriggerRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateEventTriggerRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateEventTriggerRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CustomerProfiles");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-08-15";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetDomainName())
                throw new AmazonCustomerProfilesException("Request object does not have required field DomainName set");
            request.AddPathResource("{DomainName}", StringUtils.FromString(publicRequest.DomainName));
            if (!publicRequest.IsSetEventTriggerName())
                throw new AmazonCustomerProfilesException("Request object does not have required field EventTriggerName set");
            request.AddPathResource("{EventTriggerName}", StringUtils.FromString(publicRequest.EventTriggerName));
            request.ResourcePath = "/domains/{DomainName}/event-triggers/{EventTriggerName}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("Description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetEventTriggerConditions())
                {
                    context.Writer.WritePropertyName("EventTriggerConditions");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestEventTriggerConditionsListValue in publicRequest.EventTriggerConditions)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = EventTriggerConditionMarshaller.Instance;
                        marshaller.Marshall(publicRequestEventTriggerConditionsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetEventTriggerLimits())
                {
                    context.Writer.WritePropertyName("EventTriggerLimits");
                    context.Writer.WriteObjectStart();

                    var marshaller = EventTriggerLimitsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.EventTriggerLimits, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetObjectTypeName())
                {
                    context.Writer.WritePropertyName("ObjectTypeName");
                    context.Writer.Write(publicRequest.ObjectTypeName);
                }

                if(publicRequest.IsSetSegmentFilter())
                {
                    context.Writer.WritePropertyName("SegmentFilter");
                    context.Writer.Write(publicRequest.SegmentFilter);
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("Tags");
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
        private static CreateEventTriggerRequestMarshaller _instance = new CreateEventTriggerRequestMarshaller();        

        internal static CreateEventTriggerRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateEventTriggerRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}