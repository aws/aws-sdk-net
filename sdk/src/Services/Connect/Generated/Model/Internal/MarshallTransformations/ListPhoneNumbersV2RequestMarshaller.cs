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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Connect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Connect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListPhoneNumbersV2 Request Marshaller
    /// </summary>       
    public class ListPhoneNumbersV2RequestMarshaller : IMarshaller<IRequest, ListPhoneNumbersV2Request> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListPhoneNumbersV2Request)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListPhoneNumbersV2Request publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Connect");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-08-08";
            request.HttpMethod = "POST";

            request.ResourcePath = "/phone-number/list";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetMaxResults())
                {
                    context.Writer.WritePropertyName("MaxResults");
                    context.Writer.Write(publicRequest.MaxResults);
                }

                if(publicRequest.IsSetNextToken())
                {
                    context.Writer.WritePropertyName("NextToken");
                    context.Writer.Write(publicRequest.NextToken);
                }

                if(publicRequest.IsSetPhoneNumberCountryCodes())
                {
                    context.Writer.WritePropertyName("PhoneNumberCountryCodes");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestPhoneNumberCountryCodesListValue in publicRequest.PhoneNumberCountryCodes)
                    {
                            context.Writer.Write(publicRequestPhoneNumberCountryCodesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetPhoneNumberPrefix())
                {
                    context.Writer.WritePropertyName("PhoneNumberPrefix");
                    context.Writer.Write(publicRequest.PhoneNumberPrefix);
                }

                if(publicRequest.IsSetPhoneNumberTypes())
                {
                    context.Writer.WritePropertyName("PhoneNumberTypes");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestPhoneNumberTypesListValue in publicRequest.PhoneNumberTypes)
                    {
                            context.Writer.Write(publicRequestPhoneNumberTypesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetTargetArn())
                {
                    context.Writer.WritePropertyName("TargetArn");
                    context.Writer.Write(publicRequest.TargetArn);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static ListPhoneNumbersV2RequestMarshaller _instance = new ListPhoneNumbersV2RequestMarshaller();        

        internal static ListPhoneNumbersV2RequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListPhoneNumbersV2RequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}