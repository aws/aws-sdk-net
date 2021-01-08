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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QuickSight.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateThemeAlias Request Marshaller
    /// </summary>       
    public class UpdateThemeAliasRequestMarshaller : IMarshaller<IRequest, UpdateThemeAliasRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateThemeAliasRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateThemeAliasRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.QuickSight");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-04-01";            
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetAliasName())
                throw new AmazonQuickSightException("Request object does not have required field AliasName set");
            request.AddPathResource("{AliasName}", StringUtils.FromString(publicRequest.AliasName));
            if (!publicRequest.IsSetAwsAccountId())
                throw new AmazonQuickSightException("Request object does not have required field AwsAccountId set");
            request.AddPathResource("{AwsAccountId}", StringUtils.FromString(publicRequest.AwsAccountId));
            if (!publicRequest.IsSetThemeId())
                throw new AmazonQuickSightException("Request object does not have required field ThemeId set");
            request.AddPathResource("{ThemeId}", StringUtils.FromString(publicRequest.ThemeId));
            request.ResourcePath = "/accounts/{AwsAccountId}/themes/{ThemeId}/aliases/{AliasName}";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetThemeVersionNumber())
                {
                    context.Writer.WritePropertyName("ThemeVersionNumber");
                    context.Writer.Write(publicRequest.ThemeVersionNumber);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateThemeAliasRequestMarshaller _instance = new UpdateThemeAliasRequestMarshaller();        

        internal static UpdateThemeAliasRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateThemeAliasRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}