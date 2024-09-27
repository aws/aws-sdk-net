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
 * Do not modify this file. This file is generated from the elasticloadbalancingv2-2015-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticLoadBalancingV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ElasticLoadBalancingV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SetRulePriorities Request Marshaller
    /// </summary>       
    public class SetRulePrioritiesRequestMarshaller : IMarshaller<IRequest, SetRulePrioritiesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SetRulePrioritiesRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(SetRulePrioritiesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticLoadBalancingV2");
            request.Parameters.Add("Action", "SetRulePriorities");
            request.Parameters.Add("Version", "2015-12-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetRulePriorities())
                {
                    if (publicRequest.RulePriorities.Count == 0)
                        request.Parameters.Add("RulePriorities", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.RulePriorities)
                         {
                            if(publicRequestlistValue.IsSetPriority())
                            {
                                request.Parameters.Add("RulePriorities" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Priority", StringUtils.FromInt(publicRequestlistValue.Priority));
                            }
                            if(publicRequestlistValue.IsSetRuleArn())
                            {
                                request.Parameters.Add("RulePriorities" + "." + "member" + "." + publicRequestlistValueIndex + "." + "RuleArn", StringUtils.FromString(publicRequestlistValue.RuleArn));
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
            }
            return request;
        }
                    private static SetRulePrioritiesRequestMarshaller _instance = new SetRulePrioritiesRequestMarshaller();        

        internal static SetRulePrioritiesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SetRulePrioritiesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}