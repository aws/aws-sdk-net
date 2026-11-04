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

using Amazon.CloudFormation.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.CloudFormation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BatchDescribeTypeConfigurations Request Marshaller
    /// </summary>
    public partial class BatchDescribeTypeConfigurationsRequestMarshaller : IMarshaller<IRequest, BatchDescribeTypeConfigurationsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((BatchDescribeTypeConfigurationsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(BatchDescribeTypeConfigurationsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudFormation");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "BatchDescribeTypeConfigurations");
            request.Parameters.Add("Version", "2010-05-15");

            if (publicRequest.IsSetTypeConfigurationIdentifiers())
            {
                if (publicRequest.TypeConfigurationIdentifiers.Count == 0)
                {
                    request.Parameters.Add("TypeConfigurationIdentifiers", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.TypeConfigurationIdentifiers)
                    {
                        if (item0.IsSetType())
                        {
                            request.Parameters.Add("TypeConfigurationIdentifiers" + ".member" + "." + index0 + ".Type", StringUtils.FromString(item0.Type));
                        }
                        if (item0.IsSetTypeArn())
                        {
                            request.Parameters.Add("TypeConfigurationIdentifiers" + ".member" + "." + index0 + ".TypeArn", StringUtils.FromString(item0.TypeArn));
                        }
                        if (item0.IsSetTypeConfigurationAlias())
                        {
                            request.Parameters.Add("TypeConfigurationIdentifiers" + ".member" + "." + index0 + ".TypeConfigurationAlias", StringUtils.FromString(item0.TypeConfigurationAlias));
                        }
                        if (item0.IsSetTypeConfigurationArn())
                        {
                            request.Parameters.Add("TypeConfigurationIdentifiers" + ".member" + "." + index0 + ".TypeConfigurationArn", StringUtils.FromString(item0.TypeConfigurationArn));
                        }
                        if (item0.IsSetTypeName())
                        {
                            request.Parameters.Add("TypeConfigurationIdentifiers" + ".member" + "." + index0 + ".TypeName", StringUtils.FromString(item0.TypeName));
                        }
                        index0++;
                    }
                }
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly BatchDescribeTypeConfigurationsRequestMarshaller _instance = new();

        internal static BatchDescribeTypeConfigurationsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static BatchDescribeTypeConfigurationsRequestMarshaller Instance => _instance;
    }
}
