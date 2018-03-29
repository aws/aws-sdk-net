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
    /// CreateTargetGroup Request Marshaller
    /// </summary>       
    public class CreateTargetGroupRequestMarshaller : IMarshaller<IRequest, CreateTargetGroupRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateTargetGroupRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateTargetGroupRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticLoadBalancingV2");
            request.Parameters.Add("Action", "CreateTargetGroup");
            request.Parameters.Add("Version", "2015-12-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetHealthCheckIntervalSeconds())
                {
                    request.Parameters.Add("HealthCheckIntervalSeconds", StringUtils.FromInt(publicRequest.HealthCheckIntervalSeconds));
                }
                if(publicRequest.IsSetHealthCheckPath())
                {
                    request.Parameters.Add("HealthCheckPath", StringUtils.FromString(publicRequest.HealthCheckPath));
                }
                if(publicRequest.IsSetHealthCheckPort())
                {
                    request.Parameters.Add("HealthCheckPort", StringUtils.FromString(publicRequest.HealthCheckPort));
                }
                if(publicRequest.IsSetHealthCheckProtocol())
                {
                    request.Parameters.Add("HealthCheckProtocol", StringUtils.FromString(publicRequest.HealthCheckProtocol));
                }
                if(publicRequest.IsSetHealthCheckTimeoutSeconds())
                {
                    request.Parameters.Add("HealthCheckTimeoutSeconds", StringUtils.FromInt(publicRequest.HealthCheckTimeoutSeconds));
                }
                if(publicRequest.IsSetHealthyThresholdCount())
                {
                    request.Parameters.Add("HealthyThresholdCount", StringUtils.FromInt(publicRequest.HealthyThresholdCount));
                }
                if(publicRequest.IsSetMatcher())
                {
                    if(publicRequest.Matcher.IsSetHttpCode())
                    {
                        request.Parameters.Add("Matcher" + "." + "HttpCode", StringUtils.FromString(publicRequest.Matcher.HttpCode));
                    }
                }
                if(publicRequest.IsSetName())
                {
                    request.Parameters.Add("Name", StringUtils.FromString(publicRequest.Name));
                }
                if(publicRequest.IsSetPort())
                {
                    request.Parameters.Add("Port", StringUtils.FromInt(publicRequest.Port));
                }
                if(publicRequest.IsSetProtocol())
                {
                    request.Parameters.Add("Protocol", StringUtils.FromString(publicRequest.Protocol));
                }
                if(publicRequest.IsSetTargetType())
                {
                    request.Parameters.Add("TargetType", StringUtils.FromString(publicRequest.TargetType));
                }
                if(publicRequest.IsSetUnhealthyThresholdCount())
                {
                    request.Parameters.Add("UnhealthyThresholdCount", StringUtils.FromInt(publicRequest.UnhealthyThresholdCount));
                }
                if(publicRequest.IsSetVpcId())
                {
                    request.Parameters.Add("VpcId", StringUtils.FromString(publicRequest.VpcId));
                }
            }
            return request;
        }
                    private static CreateTargetGroupRequestMarshaller _instance = new CreateTargetGroupRequestMarshaller();        

        internal static CreateTargetGroupRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateTargetGroupRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}