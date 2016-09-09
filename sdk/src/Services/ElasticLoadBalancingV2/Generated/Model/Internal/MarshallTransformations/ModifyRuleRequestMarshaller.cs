/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
namespace Amazon.ElasticLoadBalancingV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ModifyRule Request Marshaller
    /// </summary>       
    public class ModifyRuleRequestMarshaller : IMarshaller<IRequest, ModifyRuleRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyRuleRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ModifyRuleRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticLoadBalancingV2");
            request.Parameters.Add("Action", "ModifyRule");
            request.Parameters.Add("Version", "2015-12-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetActions())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.Actions)
                    {
                        if(publicRequestlistValue.IsSetTargetGroupArn())
                        {
                            request.Parameters.Add("Actions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "TargetGroupArn", StringUtils.FromString(publicRequestlistValue.TargetGroupArn));
                        }
                        if(publicRequestlistValue.IsSetType())
                        {
                            request.Parameters.Add("Actions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Type", StringUtils.FromString(publicRequestlistValue.Type));
                        }
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetConditions())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.Conditions)
                    {
                        if(publicRequestlistValue.IsSetField())
                        {
                            request.Parameters.Add("Conditions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Field", StringUtils.FromString(publicRequestlistValue.Field));
                        }
                        if(publicRequestlistValue.IsSetValues())
                        {
                            int publicRequestlistValuelistValueIndex = 1;
                            foreach(var publicRequestlistValuelistValue in publicRequestlistValue.Values)
                            {
                                request.Parameters.Add("Conditions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Values" + "." + "member" + "." + publicRequestlistValuelistValueIndex, StringUtils.FromString(publicRequestlistValuelistValue));
                                publicRequestlistValuelistValueIndex++;
                            }
                        }
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetRuleArn())
                {
                    request.Parameters.Add("RuleArn", StringUtils.FromString(publicRequest.RuleArn));
                }
            }
            return request;
        }
    }
}