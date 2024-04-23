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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateTrafficMirrorFilterRule Request Marshaller
    /// </summary>       
    public class CreateTrafficMirrorFilterRuleRequestMarshaller : IMarshaller<IRequest, CreateTrafficMirrorFilterRuleRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateTrafficMirrorFilterRuleRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateTrafficMirrorFilterRuleRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "CreateTrafficMirrorFilterRule");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetClientToken())
                {
                    request.Parameters.Add("ClientToken", StringUtils.FromString(publicRequest.ClientToken));
                }
                else if(!(publicRequest.IsSetClientToken()))
                {
                    request.Parameters.Add("ClientToken", StringUtils.FromString(Guid.NewGuid().ToString()));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetDescription())
                {
                    request.Parameters.Add("Description", StringUtils.FromString(publicRequest.Description));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetDestinationCidrBlock())
                {
                    request.Parameters.Add("DestinationCidrBlock", StringUtils.FromString(publicRequest.DestinationCidrBlock));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetDestinationPortRange())
                {
                    if(publicRequest.DestinationPortRange.IsSetFromPort())
                    {
                        request.Parameters.Add("DestinationPortRange" + "." + "FromPort", StringUtils.FromInt(publicRequest.DestinationPortRange.FromPort));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.DestinationPortRange.IsSetToPort())
                    {
                        request.Parameters.Add("DestinationPortRange" + "." + "ToPort", StringUtils.FromInt(publicRequest.DestinationPortRange.ToPort));
                    }
#pragma warning restore CS0612,CS0618
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetProtocol())
                {
                    request.Parameters.Add("Protocol", StringUtils.FromInt(publicRequest.Protocol));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetRuleAction())
                {
                    request.Parameters.Add("RuleAction", StringUtils.FromString(publicRequest.RuleAction));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetRuleNumber())
                {
                    request.Parameters.Add("RuleNumber", StringUtils.FromInt(publicRequest.RuleNumber));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetSourceCidrBlock())
                {
                    request.Parameters.Add("SourceCidrBlock", StringUtils.FromString(publicRequest.SourceCidrBlock));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetSourcePortRange())
                {
                    if(publicRequest.SourcePortRange.IsSetFromPort())
                    {
                        request.Parameters.Add("SourcePortRange" + "." + "FromPort", StringUtils.FromInt(publicRequest.SourcePortRange.FromPort));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.SourcePortRange.IsSetToPort())
                    {
                        request.Parameters.Add("SourcePortRange" + "." + "ToPort", StringUtils.FromInt(publicRequest.SourcePortRange.ToPort));
                    }
#pragma warning restore CS0612,CS0618
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetTrafficDirection())
                {
                    request.Parameters.Add("TrafficDirection", StringUtils.FromString(publicRequest.TrafficDirection));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetTrafficMirrorFilterId())
                {
                    request.Parameters.Add("TrafficMirrorFilterId", StringUtils.FromString(publicRequest.TrafficMirrorFilterId));
                }
#pragma warning restore CS0612,CS0618
            }
            return request;
        }
                    private static CreateTrafficMirrorFilterRuleRequestMarshaller _instance = new CreateTrafficMirrorFilterRuleRequestMarshaller();        

        internal static CreateTrafficMirrorFilterRuleRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateTrafficMirrorFilterRuleRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}