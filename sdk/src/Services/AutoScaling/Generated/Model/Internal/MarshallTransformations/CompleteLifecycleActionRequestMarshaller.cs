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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AutoScaling.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.AutoScaling.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CompleteLifecycleAction Request Marshaller
    /// </summary>       
    public class CompleteLifecycleActionRequestMarshaller : IMarshaller<IRequest, CompleteLifecycleActionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CompleteLifecycleActionRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CompleteLifecycleActionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AutoScaling");
            request.Parameters.Add("Action", "CompleteLifecycleAction");
            request.Parameters.Add("Version", "2011-01-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAutoScalingGroupName())
                {
                    request.Parameters.Add("AutoScalingGroupName", StringUtils.FromString(publicRequest.AutoScalingGroupName));
                }
                if(publicRequest.IsSetInstanceId())
                {
                    request.Parameters.Add("InstanceId", StringUtils.FromString(publicRequest.InstanceId));
                }
                if(publicRequest.IsSetLifecycleActionResult())
                {
                    request.Parameters.Add("LifecycleActionResult", StringUtils.FromString(publicRequest.LifecycleActionResult));
                }
                if(publicRequest.IsSetLifecycleActionToken())
                {
                    request.Parameters.Add("LifecycleActionToken", StringUtils.FromString(publicRequest.LifecycleActionToken));
                }
                if(publicRequest.IsSetLifecycleHookName())
                {
                    request.Parameters.Add("LifecycleHookName", StringUtils.FromString(publicRequest.LifecycleHookName));
                }
            }
            return request;
        }
                    private static CompleteLifecycleActionRequestMarshaller _instance = new CompleteLifecycleActionRequestMarshaller();        

        internal static CompleteLifecycleActionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CompleteLifecycleActionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}