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
 * Do not modify this file. This file is generated from the alexaforbusiness-2017-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AlexaForBusiness.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.AlexaForBusiness.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateContact Request Marshaller
    /// </summary>       
    public class CreateContactRequestMarshaller : IMarshaller<IRequest, CreateContactRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateContactRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateContactRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AlexaForBusiness");
            string target = "AlexaForBusiness.CreateContact";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-11-09";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetClientRequestToken())
                {
                    context.Writer.WritePropertyName("ClientRequestToken");
                    context.Writer.Write(publicRequest.ClientRequestToken);
                }

                else if(!(publicRequest.IsSetClientRequestToken()))
                {
                    context.Writer.WritePropertyName("ClientRequestToken");
                    context.Writer.Write(Guid.NewGuid().ToString());                                                
                }
                if(publicRequest.IsSetDisplayName())
                {
                    context.Writer.WritePropertyName("DisplayName");
                    context.Writer.Write(publicRequest.DisplayName);
                }

                if(publicRequest.IsSetFirstName())
                {
                    context.Writer.WritePropertyName("FirstName");
                    context.Writer.Write(publicRequest.FirstName);
                }

                if(publicRequest.IsSetLastName())
                {
                    context.Writer.WritePropertyName("LastName");
                    context.Writer.Write(publicRequest.LastName);
                }

                if(publicRequest.IsSetPhoneNumber())
                {
                    context.Writer.WritePropertyName("PhoneNumber");
                    context.Writer.Write(publicRequest.PhoneNumber);
                }

                if(publicRequest.IsSetPhoneNumbers())
                {
                    context.Writer.WritePropertyName("PhoneNumbers");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestPhoneNumbersListValue in publicRequest.PhoneNumbers)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = PhoneNumberMarshaller.Instance;
                        marshaller.Marshall(publicRequestPhoneNumbersListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetSipAddresses())
                {
                    context.Writer.WritePropertyName("SipAddresses");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSipAddressesListValue in publicRequest.SipAddresses)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = SipAddressMarshaller.Instance;
                        marshaller.Marshall(publicRequestSipAddressesListValue, context);

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
        private static CreateContactRequestMarshaller _instance = new CreateContactRequestMarshaller();        

        internal static CreateContactRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateContactRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}