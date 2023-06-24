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
 * Do not modify this file. This file is generated from the route53-recovery-cluster-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Route53RecoveryCluster.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Route53RecoveryCluster.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateRoutingControlStates Request Marshaller
    /// </summary>       
    public class UpdateRoutingControlStatesRequestMarshaller : IMarshaller<IRequest, UpdateRoutingControlStatesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateRoutingControlStatesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateRoutingControlStatesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Route53RecoveryCluster");
            string target = "ToggleCustomerAPI.UpdateRoutingControlStates";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-12-02";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetSafetyRulesToOverride())
                {
                    context.Writer.WritePropertyName("SafetyRulesToOverride");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSafetyRulesToOverrideListValue in publicRequest.SafetyRulesToOverride)
                    {
                            context.Writer.Write(publicRequestSafetyRulesToOverrideListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetUpdateRoutingControlStateEntries())
                {
                    context.Writer.WritePropertyName("UpdateRoutingControlStateEntries");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestUpdateRoutingControlStateEntriesListValue in publicRequest.UpdateRoutingControlStateEntries)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = UpdateRoutingControlStateEntryMarshaller.Instance;
                        marshaller.Marshall(publicRequestUpdateRoutingControlStateEntriesListValue, context);

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
        private static UpdateRoutingControlStatesRequestMarshaller _instance = new UpdateRoutingControlStatesRequestMarshaller();        

        internal static UpdateRoutingControlStatesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateRoutingControlStatesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}