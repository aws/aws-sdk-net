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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

using Amazon.ElastiCache.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.ElastiCache.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PrepareMigration Request Marshaller
    /// </summary>
    public partial class PrepareMigrationRequestMarshaller : IMarshaller<IRequest, PrepareMigrationRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PrepareMigrationRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(PrepareMigrationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElastiCache");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "PrepareMigration");
            request.Parameters.Add("Version", "2015-02-02");

            if (publicRequest.IsSetCustomerNodeEndpointList())
            {
                if (publicRequest.CustomerNodeEndpointList.Count == 0)
                {
                    request.Parameters.Add("CustomerNodeEndpointList", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.CustomerNodeEndpointList)
                    {
                        if (item0.IsSetAddress())
                        {
                            request.Parameters.Add("CustomerNodeEndpointList" + ".member" + "." + index0 + ".Address", StringUtils.FromString(item0.Address));
                        }
                        if (item0.IsSetPort())
                        {
                            request.Parameters.Add("CustomerNodeEndpointList" + ".member" + "." + index0 + ".Port", StringUtils.FromInt(item0.Port.Value));
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetServerlessCacheName())
            {
                request.Parameters.Add("ServerlessCacheName", StringUtils.FromString(publicRequest.ServerlessCacheName));
            }
            if (publicRequest.IsSetSourceAuthenticationConfiguration())
            {
                if (publicRequest.SourceAuthenticationConfiguration.IsSetSecretManagerConfig())
                {
                    if (publicRequest.SourceAuthenticationConfiguration.SecretManagerConfig.IsSetSecretArn())
                    {
                        request.Parameters.Add("SourceAuthenticationConfiguration" + ".SecretManagerConfig" + ".SecretArn", StringUtils.FromString(publicRequest.SourceAuthenticationConfiguration.SecretManagerConfig.SecretArn));
                    }
                }
            }
            if (publicRequest.IsSetSourceTlsConfiguration())
            {
                if (publicRequest.SourceTlsConfiguration.IsSetSourceTlsCertificate())
                {
                    request.Parameters.Add("SourceTlsConfiguration" + ".SourceTlsCertificate", StringUtils.FromString(publicRequest.SourceTlsConfiguration.SourceTlsCertificate));
                }
                if (publicRequest.SourceTlsConfiguration.IsSetSourceTlsMode())
                {
                    request.Parameters.Add("SourceTlsConfiguration" + ".SourceTlsMode", StringUtils.FromString(publicRequest.SourceTlsConfiguration.SourceTlsMode));
                }
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly PrepareMigrationRequestMarshaller _instance = new();

        internal static PrepareMigrationRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static PrepareMigrationRequestMarshaller Instance => _instance;
    }
}
