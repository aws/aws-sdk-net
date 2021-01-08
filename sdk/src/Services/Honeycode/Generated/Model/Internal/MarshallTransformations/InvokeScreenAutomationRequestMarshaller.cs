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
 * Do not modify this file. This file is generated from the honeycode-2020-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Honeycode.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Honeycode.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// InvokeScreenAutomation Request Marshaller
    /// </summary>       
    public class InvokeScreenAutomationRequestMarshaller : IMarshaller<IRequest, InvokeScreenAutomationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((InvokeScreenAutomationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(InvokeScreenAutomationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Honeycode");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-03-01";            
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetAppId())
                throw new AmazonHoneycodeException("Request object does not have required field AppId set");
            request.AddPathResource("{appId}", StringUtils.FromString(publicRequest.AppId));
            if (!publicRequest.IsSetScreenAutomationId())
                throw new AmazonHoneycodeException("Request object does not have required field ScreenAutomationId set");
            request.AddPathResource("{automationId}", StringUtils.FromString(publicRequest.ScreenAutomationId));
            if (!publicRequest.IsSetScreenId())
                throw new AmazonHoneycodeException("Request object does not have required field ScreenId set");
            request.AddPathResource("{screenId}", StringUtils.FromString(publicRequest.ScreenId));
            if (!publicRequest.IsSetWorkbookId())
                throw new AmazonHoneycodeException("Request object does not have required field WorkbookId set");
            request.AddPathResource("{workbookId}", StringUtils.FromString(publicRequest.WorkbookId));
            request.ResourcePath = "/workbooks/{workbookId}/apps/{appId}/screens/{screenId}/automations/{automationId}";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetClientRequestToken())
                {
                    context.Writer.WritePropertyName("clientRequestToken");
                    context.Writer.Write(publicRequest.ClientRequestToken);
                }

                if(publicRequest.IsSetRowId())
                {
                    context.Writer.WritePropertyName("rowId");
                    context.Writer.Write(publicRequest.RowId);
                }

                if(publicRequest.IsSetVariables())
                {
                    context.Writer.WritePropertyName("variables");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestVariablesKvp in publicRequest.Variables)
                    {
                        context.Writer.WritePropertyName(publicRequestVariablesKvp.Key);
                        var publicRequestVariablesValue = publicRequestVariablesKvp.Value;

                        context.Writer.WriteObjectStart();

                        var marshaller = VariableValueMarshaller.Instance;
                        marshaller.Marshall(publicRequestVariablesValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteObjectEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static InvokeScreenAutomationRequestMarshaller _instance = new InvokeScreenAutomationRequestMarshaller();        

        internal static InvokeScreenAutomationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InvokeScreenAutomationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}