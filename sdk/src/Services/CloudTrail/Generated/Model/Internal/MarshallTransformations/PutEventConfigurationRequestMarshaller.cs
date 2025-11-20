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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudTrail.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.CloudTrail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutEventConfiguration Request Marshaller
    /// </summary>       
    public class PutEventConfigurationRequestMarshaller : IMarshaller<IRequest, PutEventConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutEventConfigurationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutEventConfigurationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudTrail");
            string target = "com.amazonaws.cloudtrail.v20131101.CloudTrail_20131101.PutEventConfiguration";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2013-11-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAggregationConfigurations())
                {
                    context.Writer.WritePropertyName("AggregationConfigurations");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAggregationConfigurationsListValue in publicRequest.AggregationConfigurations)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = AggregationConfigurationMarshaller.Instance;
                        marshaller.Marshall(publicRequestAggregationConfigurationsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetContextKeySelectors())
                {
                    context.Writer.WritePropertyName("ContextKeySelectors");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestContextKeySelectorsListValue in publicRequest.ContextKeySelectors)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = ContextKeySelectorMarshaller.Instance;
                        marshaller.Marshall(publicRequestContextKeySelectorsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetEventDataStore())
                {
                    context.Writer.WritePropertyName("EventDataStore");
                    context.Writer.Write(publicRequest.EventDataStore);
                }

                if(publicRequest.IsSetMaxEventSize())
                {
                    context.Writer.WritePropertyName("MaxEventSize");
                    context.Writer.Write(publicRequest.MaxEventSize);
                }

                if(publicRequest.IsSetTrailName())
                {
                    context.Writer.WritePropertyName("TrailName");
                    context.Writer.Write(publicRequest.TrailName);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static PutEventConfigurationRequestMarshaller _instance = new PutEventConfigurationRequestMarshaller();        

        internal static PutEventConfigurationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutEventConfigurationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}