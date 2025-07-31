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

#pragma warning disable CS0612,CS0618
namespace Amazon.SimpleEmailV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SendBulkEmail Request Marshaller
    /// </summary>       
    public class SendBulkEmailRequestMarshaller : IMarshaller<IRequest, SendBulkEmailRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SendBulkEmailRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(SendBulkEmailRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SimpleEmailV2");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-09-27";
            request.HttpMethod = "POST";

            request.ResourcePath = "/v2/email/outbound-bulk-emails";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetBulkEmailEntries())
                {
                    context.Writer.WritePropertyName("BulkEmailEntries");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestBulkEmailEntriesListValue in publicRequest.BulkEmailEntries)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = BulkEmailEntryMarshaller.Instance;
                        marshaller.Marshall(publicRequestBulkEmailEntriesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetConfigurationSetName())
                {
                    context.Writer.WritePropertyName("ConfigurationSetName");
                    context.Writer.Write(publicRequest.ConfigurationSetName);
                }

                if(publicRequest.IsSetDefaultContent())
                {
                    context.Writer.WritePropertyName("DefaultContent");
                    context.Writer.WriteObjectStart();

                    var marshaller = BulkEmailContentMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DefaultContent, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDefaultEmailTags())
                {
                    context.Writer.WritePropertyName("DefaultEmailTags");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestDefaultEmailTagsListValue in publicRequest.DefaultEmailTags)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = MessageTagMarshaller.Instance;
                        marshaller.Marshall(publicRequestDefaultEmailTagsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetEndpointId())
                {
                    context.Writer.WritePropertyName("EndpointId");
                    context.Writer.Write(publicRequest.EndpointId);
                }

                if(publicRequest.IsSetFeedbackForwardingEmailAddress())
                {
                    context.Writer.WritePropertyName("FeedbackForwardingEmailAddress");
                    context.Writer.Write(publicRequest.FeedbackForwardingEmailAddress);
                }

                if(publicRequest.IsSetFeedbackForwardingEmailAddressIdentityArn())
                {
                    context.Writer.WritePropertyName("FeedbackForwardingEmailAddressIdentityArn");
                    context.Writer.Write(publicRequest.FeedbackForwardingEmailAddressIdentityArn);
                }

                if(publicRequest.IsSetFromEmailAddress())
                {
                    context.Writer.WritePropertyName("FromEmailAddress");
                    context.Writer.Write(publicRequest.FromEmailAddress);
                }

                if(publicRequest.IsSetFromEmailAddressIdentityArn())
                {
                    context.Writer.WritePropertyName("FromEmailAddressIdentityArn");
                    context.Writer.Write(publicRequest.FromEmailAddressIdentityArn);
                }

                if(publicRequest.IsSetReplyToAddresses())
                {
                    context.Writer.WritePropertyName("ReplyToAddresses");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestReplyToAddressesListValue in publicRequest.ReplyToAddresses)
                    {
                            context.Writer.Write(publicRequestReplyToAddressesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetTenantName())
                {
                    context.Writer.WritePropertyName("TenantName");
                    context.Writer.Write(publicRequest.TenantName);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static SendBulkEmailRequestMarshaller _instance = new SendBulkEmailRequestMarshaller();        

        internal static SendBulkEmailRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SendBulkEmailRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}