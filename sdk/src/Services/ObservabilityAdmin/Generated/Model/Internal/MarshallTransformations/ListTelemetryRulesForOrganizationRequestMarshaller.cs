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
 * Do not modify this file. This file is generated from the observabilityadmin-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ObservabilityAdmin.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.ObservabilityAdmin.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListTelemetryRulesForOrganization Request Marshaller
    /// </summary>       
    public class ListTelemetryRulesForOrganizationRequestMarshaller : IMarshaller<IRequest, ListTelemetryRulesForOrganizationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListTelemetryRulesForOrganizationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListTelemetryRulesForOrganizationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ObservabilityAdmin");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "POST";

            request.ResourcePath = "/ListTelemetryRulesForOrganization";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
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

                if(publicRequest.IsSetRuleNamePrefix())
                {
                    context.Writer.WritePropertyName("RuleNamePrefix");
                    context.Writer.Write(publicRequest.RuleNamePrefix);
                }

                if(publicRequest.IsSetSourceAccountIds())
                {
                    context.Writer.WritePropertyName("SourceAccountIds");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSourceAccountIdsListValue in publicRequest.SourceAccountIds)
                    {
                            context.Writer.Write(publicRequestSourceAccountIdsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetSourceOrganizationUnitIds())
                {
                    context.Writer.WritePropertyName("SourceOrganizationUnitIds");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSourceOrganizationUnitIdsListValue in publicRequest.SourceOrganizationUnitIds)
                    {
                            context.Writer.Write(publicRequestSourceOrganizationUnitIdsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static ListTelemetryRulesForOrganizationRequestMarshaller _instance = new ListTelemetryRulesForOrganizationRequestMarshaller();        

        internal static ListTelemetryRulesForOrganizationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListTelemetryRulesForOrganizationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}