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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleEmailV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SimpleEmailV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateConfigurationSet Request Marshaller
    /// </summary>       
    public class CreateConfigurationSetRequestMarshaller : IMarshaller<IRequest, CreateConfigurationSetRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateConfigurationSetRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateConfigurationSetRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SimpleEmailV2");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-09-27";
            request.HttpMethod = "POST";

            request.ResourcePath = "/v2/email/configuration-sets";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetConfigurationSetName())
                {
                    context.Writer.WritePropertyName("ConfigurationSetName");
                    context.Writer.Write(publicRequest.ConfigurationSetName);
                }

                if(publicRequest.IsSetDeliveryOptions())
                {
                    context.Writer.WritePropertyName("DeliveryOptions");
                    context.Writer.WriteObjectStart();

                    var marshaller = DeliveryOptionsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DeliveryOptions, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetReputationOptions())
                {
                    context.Writer.WritePropertyName("ReputationOptions");
                    context.Writer.WriteObjectStart();

                    var marshaller = ReputationOptionsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ReputationOptions, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSendingOptions())
                {
                    context.Writer.WritePropertyName("SendingOptions");
                    context.Writer.WriteObjectStart();

                    var marshaller = SendingOptionsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.SendingOptions, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSuppressionOptions())
                {
                    context.Writer.WritePropertyName("SuppressionOptions");
                    context.Writer.WriteObjectStart();

                    var marshaller = SuppressionOptionsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.SuppressionOptions, context);

                    context.Writer.WriteObjectEnd();
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

                if(publicRequest.IsSetTrackingOptions())
                {
                    context.Writer.WritePropertyName("TrackingOptions");
                    context.Writer.WriteObjectStart();

                    var marshaller = TrackingOptionsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.TrackingOptions, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetVdmOptions())
                {
                    context.Writer.WritePropertyName("VdmOptions");
                    context.Writer.WriteObjectStart();

                    var marshaller = VdmOptionsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.VdmOptions, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateConfigurationSetRequestMarshaller _instance = new CreateConfigurationSetRequestMarshaller();        

        internal static CreateConfigurationSetRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateConfigurationSetRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}