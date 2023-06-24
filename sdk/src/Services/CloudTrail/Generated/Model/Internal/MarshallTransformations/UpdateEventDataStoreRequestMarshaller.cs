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

namespace Amazon.CloudTrail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateEventDataStore Request Marshaller
    /// </summary>       
    public class UpdateEventDataStoreRequestMarshaller : IMarshaller<IRequest, UpdateEventDataStoreRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateEventDataStoreRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateEventDataStoreRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudTrail");
            string target = "com.amazonaws.cloudtrail.v20131101.CloudTrail_20131101.UpdateEventDataStore";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2013-11-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAdvancedEventSelectors())
                {
                    context.Writer.WritePropertyName("AdvancedEventSelectors");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAdvancedEventSelectorsListValue in publicRequest.AdvancedEventSelectors)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = AdvancedEventSelectorMarshaller.Instance;
                        marshaller.Marshall(publicRequestAdvancedEventSelectorsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetEventDataStore())
                {
                    context.Writer.WritePropertyName("EventDataStore");
                    context.Writer.Write(publicRequest.EventDataStore);
                }

                if(publicRequest.IsSetKmsKeyId())
                {
                    context.Writer.WritePropertyName("KmsKeyId");
                    context.Writer.Write(publicRequest.KmsKeyId);
                }

                if(publicRequest.IsSetMultiRegionEnabled())
                {
                    context.Writer.WritePropertyName("MultiRegionEnabled");
                    context.Writer.Write(publicRequest.MultiRegionEnabled);
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("Name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetOrganizationEnabled())
                {
                    context.Writer.WritePropertyName("OrganizationEnabled");
                    context.Writer.Write(publicRequest.OrganizationEnabled);
                }

                if(publicRequest.IsSetRetentionPeriod())
                {
                    context.Writer.WritePropertyName("RetentionPeriod");
                    context.Writer.Write(publicRequest.RetentionPeriod);
                }

                if(publicRequest.IsSetTerminationProtectionEnabled())
                {
                    context.Writer.WritePropertyName("TerminationProtectionEnabled");
                    context.Writer.Write(publicRequest.TerminationProtectionEnabled);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateEventDataStoreRequestMarshaller _instance = new UpdateEventDataStoreRequestMarshaller();        

        internal static UpdateEventDataStoreRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateEventDataStoreRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}