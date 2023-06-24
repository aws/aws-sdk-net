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
 * Do not modify this file. This file is generated from the ssm-incidents-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SSMIncidents.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SSMIncidents.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartIncident Request Marshaller
    /// </summary>       
    public class StartIncidentRequestMarshaller : IMarshaller<IRequest, StartIncidentRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartIncidentRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartIncidentRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SSMIncidents");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "POST";

            request.ResourcePath = "/startIncident";
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
                if(publicRequest.IsSetImpact())
                {
                    context.Writer.WritePropertyName("impact");
                    context.Writer.Write(publicRequest.Impact);
                }

                if(publicRequest.IsSetRelatedItems())
                {
                    context.Writer.WritePropertyName("relatedItems");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestRelatedItemsListValue in publicRequest.RelatedItems)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = RelatedItemMarshaller.Instance;
                        marshaller.Marshall(publicRequestRelatedItemsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetResponsePlanArn())
                {
                    context.Writer.WritePropertyName("responsePlanArn");
                    context.Writer.Write(publicRequest.ResponsePlanArn);
                }

                if(publicRequest.IsSetTitle())
                {
                    context.Writer.WritePropertyName("title");
                    context.Writer.Write(publicRequest.Title);
                }

                if(publicRequest.IsSetTriggerDetails())
                {
                    context.Writer.WritePropertyName("triggerDetails");
                    context.Writer.WriteObjectStart();

                    var marshaller = TriggerDetailsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.TriggerDetails, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static StartIncidentRequestMarshaller _instance = new StartIncidentRequestMarshaller();        

        internal static StartIncidentRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartIncidentRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}