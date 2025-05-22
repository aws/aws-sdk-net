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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutInsightRule Request Marshaller
    /// </summary>       
    public class PutInsightRuleRequestMarshaller : IMarshaller<IRequest, PutInsightRuleRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutInsightRuleRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutInsightRuleRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudWatch");
            request.Parameters.Add("Action", "PutInsightRule");
            request.Parameters.Add("Version", "2010-08-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetApplyOnTransformedLogs())
                {
                    request.Parameters.Add("ApplyOnTransformedLogs", StringUtils.FromBool(publicRequest.ApplyOnTransformedLogs));
                }
                if(publicRequest.IsSetRuleDefinition())
                {
                    request.Parameters.Add("RuleDefinition", StringUtils.FromString(publicRequest.RuleDefinition));
                }
                if(publicRequest.IsSetRuleName())
                {
                    request.Parameters.Add("RuleName", StringUtils.FromString(publicRequest.RuleName));
                }
                if(publicRequest.IsSetRuleState())
                {
                    request.Parameters.Add("RuleState", StringUtils.FromString(publicRequest.RuleState));
                }
                if(publicRequest.IsSetTags())
                {
                    if (publicRequest.Tags.Count == 0)
                        request.Parameters.Add("Tags", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.Tags)
                         {
                            if(publicRequestlistValue.IsSetKey())
                            {
                                request.Parameters.Add("Tags" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Key", StringUtils.FromString(publicRequestlistValue.Key));
                            }
                            if(publicRequestlistValue.IsSetValue())
                            {
                                request.Parameters.Add("Tags" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Value", StringUtils.FromString(publicRequestlistValue.Value));
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
            }
            return request;
        }
                    private static PutInsightRuleRequestMarshaller _instance = new PutInsightRuleRequestMarshaller();        

        internal static PutInsightRuleRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutInsightRuleRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}