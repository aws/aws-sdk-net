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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ConfigService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.ConfigService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutConfigurationAggregator Request Marshaller
    /// </summary>       
    public class PutConfigurationAggregatorRequestMarshaller : IMarshaller<IRequest, PutConfigurationAggregatorRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutConfigurationAggregatorRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutConfigurationAggregatorRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ConfigService");
            string target = "StarlingDoveService.PutConfigurationAggregator";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2014-11-12";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAccountAggregationSources())
                {
                    context.Writer.WritePropertyName("AccountAggregationSources");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAccountAggregationSourcesListValue in publicRequest.AccountAggregationSources)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = AccountAggregationSourceMarshaller.Instance;
                        marshaller.Marshall(publicRequestAccountAggregationSourcesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetAggregatorFilters())
                {
                    context.Writer.WritePropertyName("AggregatorFilters");
                    context.Writer.WriteObjectStart();

                    var marshaller = AggregatorFiltersMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AggregatorFilters, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetConfigurationAggregatorName())
                {
                    context.Writer.WritePropertyName("ConfigurationAggregatorName");
                    context.Writer.Write(publicRequest.ConfigurationAggregatorName);
                }

                if(publicRequest.IsSetOrganizationAggregationSource())
                {
                    context.Writer.WritePropertyName("OrganizationAggregationSource");
                    context.Writer.WriteObjectStart();

                    var marshaller = OrganizationAggregationSourceMarshaller.Instance;
                    marshaller.Marshall(publicRequest.OrganizationAggregationSource, context);

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

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static PutConfigurationAggregatorRequestMarshaller _instance = new PutConfigurationAggregatorRequestMarshaller();        

        internal static PutConfigurationAggregatorRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutConfigurationAggregatorRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}