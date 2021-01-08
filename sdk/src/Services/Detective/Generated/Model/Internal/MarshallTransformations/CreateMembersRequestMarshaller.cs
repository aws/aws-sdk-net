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
 * Do not modify this file. This file is generated from the detective-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Detective.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Detective.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateMembers Request Marshaller
    /// </summary>       
    public class CreateMembersRequestMarshaller : IMarshaller<IRequest, CreateMembersRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateMembersRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateMembersRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Detective");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-10-26";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/graph/members";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAccounts())
                {
                    context.Writer.WritePropertyName("Accounts");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAccountsListValue in publicRequest.Accounts)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = AccountMarshaller.Instance;
                        marshaller.Marshall(publicRequestAccountsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetGraphArn())
                {
                    context.Writer.WritePropertyName("GraphArn");
                    context.Writer.Write(publicRequest.GraphArn);
                }

                if(publicRequest.IsSetMessage())
                {
                    context.Writer.WritePropertyName("Message");
                    context.Writer.Write(publicRequest.Message);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateMembersRequestMarshaller _instance = new CreateMembersRequestMarshaller();        

        internal static CreateMembersRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateMembersRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}