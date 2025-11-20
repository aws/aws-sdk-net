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
    /// CreateTransitGatewayMeteringPolicyEntry Request Marshaller
    /// </summary>       
    public class CreateTransitGatewayMeteringPolicyEntryRequestMarshaller : IMarshaller<IRequest, CreateTransitGatewayMeteringPolicyEntryRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateTransitGatewayMeteringPolicyEntryRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateTransitGatewayMeteringPolicyEntryRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "CreateTransitGatewayMeteringPolicyEntry");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetDestinationCidrBlock())
                {
                    request.Parameters.Add("DestinationCidrBlock", StringUtils.FromString(publicRequest.DestinationCidrBlock));
                }
                if(publicRequest.IsSetDestinationPortRange())
                {
                    request.Parameters.Add("DestinationPortRange", StringUtils.FromString(publicRequest.DestinationPortRange));
                }
                if(publicRequest.IsSetDestinationTransitGatewayAttachmentId())
                {
                    request.Parameters.Add("DestinationTransitGatewayAttachmentId", StringUtils.FromString(publicRequest.DestinationTransitGatewayAttachmentId));
                }
                if(publicRequest.IsSetDestinationTransitGatewayAttachmentType())
                {
                    request.Parameters.Add("DestinationTransitGatewayAttachmentType", StringUtils.FromString(publicRequest.DestinationTransitGatewayAttachmentType));
                }
                if(publicRequest.IsSetMeteredAccount())
                {
                    request.Parameters.Add("MeteredAccount", StringUtils.FromString(publicRequest.MeteredAccount));
                }
                if(publicRequest.IsSetPolicyRuleNumber())
                {
                    request.Parameters.Add("PolicyRuleNumber", StringUtils.FromInt(publicRequest.PolicyRuleNumber));
                }
                if(publicRequest.IsSetProtocol())
                {
                    request.Parameters.Add("Protocol", StringUtils.FromString(publicRequest.Protocol));
                }
                if(publicRequest.IsSetSourceCidrBlock())
                {
                    request.Parameters.Add("SourceCidrBlock", StringUtils.FromString(publicRequest.SourceCidrBlock));
                }
                if(publicRequest.IsSetSourcePortRange())
                {
                    request.Parameters.Add("SourcePortRange", StringUtils.FromString(publicRequest.SourcePortRange));
                }
                if(publicRequest.IsSetSourceTransitGatewayAttachmentId())
                {
                    request.Parameters.Add("SourceTransitGatewayAttachmentId", StringUtils.FromString(publicRequest.SourceTransitGatewayAttachmentId));
                }
                if(publicRequest.IsSetSourceTransitGatewayAttachmentType())
                {
                    request.Parameters.Add("SourceTransitGatewayAttachmentType", StringUtils.FromString(publicRequest.SourceTransitGatewayAttachmentType));
                }
                if(publicRequest.IsSetTransitGatewayMeteringPolicyId())
                {
                    request.Parameters.Add("TransitGatewayMeteringPolicyId", StringUtils.FromString(publicRequest.TransitGatewayMeteringPolicyId));
                }
            }
            return request;
        }
                    private static CreateTransitGatewayMeteringPolicyEntryRequestMarshaller _instance = new CreateTransitGatewayMeteringPolicyEntryRequestMarshaller();        

        internal static CreateTransitGatewayMeteringPolicyEntryRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateTransitGatewayMeteringPolicyEntryRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}