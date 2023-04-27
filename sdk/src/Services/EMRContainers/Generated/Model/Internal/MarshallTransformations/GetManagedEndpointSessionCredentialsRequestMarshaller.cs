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
 * Do not modify this file. This file is generated from the emr-containers-2020-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EMRContainers.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.EMRContainers.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetManagedEndpointSessionCredentials Request Marshaller
    /// </summary>       
    public class GetManagedEndpointSessionCredentialsRequestMarshaller : IMarshaller<IRequest, GetManagedEndpointSessionCredentialsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetManagedEndpointSessionCredentialsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetManagedEndpointSessionCredentialsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EMRContainers");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-10-01";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetEndpointIdentifier())
                throw new AmazonEMRContainersException("Request object does not have required field EndpointIdentifier set");
            request.AddPathResource("{endpointId}", StringUtils.FromString(publicRequest.EndpointIdentifier));
            if (!publicRequest.IsSetVirtualClusterIdentifier())
                throw new AmazonEMRContainersException("Request object does not have required field VirtualClusterIdentifier set");
            request.AddPathResource("{virtualClusterId}", StringUtils.FromString(publicRequest.VirtualClusterIdentifier));
            request.ResourcePath = "/virtualclusters/{virtualClusterId}/endpoints/{endpointId}/credentials";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetClientToken())
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(publicRequest.ClientToken);
                }

                else if(!(publicRequest.IsSetClientToken()))
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(Guid.NewGuid().ToString());
                }
                if(publicRequest.IsSetCredentialType())
                {
                    context.Writer.WritePropertyName("credentialType");
                    context.Writer.Write(publicRequest.CredentialType);
                }

                if(publicRequest.IsSetDurationInSeconds())
                {
                    context.Writer.WritePropertyName("durationInSeconds");
                    context.Writer.Write(publicRequest.DurationInSeconds);
                }

                if(publicRequest.IsSetExecutionRoleArn())
                {
                    context.Writer.WritePropertyName("executionRoleArn");
                    context.Writer.Write(publicRequest.ExecutionRoleArn);
                }

                if(publicRequest.IsSetLogContext())
                {
                    context.Writer.WritePropertyName("logContext");
                    context.Writer.Write(publicRequest.LogContext);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static GetManagedEndpointSessionCredentialsRequestMarshaller _instance = new GetManagedEndpointSessionCredentialsRequestMarshaller();        

        internal static GetManagedEndpointSessionCredentialsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetManagedEndpointSessionCredentialsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}