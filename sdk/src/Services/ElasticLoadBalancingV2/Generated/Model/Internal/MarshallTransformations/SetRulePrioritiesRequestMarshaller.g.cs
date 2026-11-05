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

using Amazon.ElasticLoadBalancingV2.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.ElasticLoadBalancingV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SetRulePriorities Request Marshaller
    /// </summary>
    public partial class SetRulePrioritiesRequestMarshaller : IMarshaller<IRequest, SetRulePrioritiesRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SetRulePrioritiesRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(SetRulePrioritiesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticLoadBalancingV2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "SetRulePriorities");
            request.Parameters.Add("Version", "2015-12-01");

            if (publicRequest.IsSetRulePriorities())
            {
                if (publicRequest.RulePriorities.Count == 0)
                {
                    request.Parameters.Add("RulePriorities", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.RulePriorities)
                    {
                        if (item0.IsSetPriority())
                        {
                            request.Parameters.Add("RulePriorities" + ".member" + "." + index0 + ".Priority", StringUtils.FromInt(item0.Priority.Value));
                        }
                        if (item0.IsSetRuleArn())
                        {
                            request.Parameters.Add("RulePriorities" + ".member" + "." + index0 + ".RuleArn", StringUtils.FromString(item0.RuleArn));
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

        private static readonly SetRulePrioritiesRequestMarshaller _instance = new();

        internal static SetRulePrioritiesRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static SetRulePrioritiesRequestMarshaller Instance => _instance;
    }
}
