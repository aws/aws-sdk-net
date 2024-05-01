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
    /// SetAlarmState Request Marshaller
    /// </summary>       
    public class SetAlarmStateRequestMarshaller : IMarshaller<IRequest, SetAlarmStateRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SetAlarmStateRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(SetAlarmStateRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudWatch");
            request.Parameters.Add("Action", "SetAlarmState");
            request.Parameters.Add("Version", "2010-08-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAlarmName())
                {
                    request.Parameters.Add("AlarmName", StringUtils.FromString(publicRequest.AlarmName));
                }
                if(publicRequest.IsSetStateReason())
                {
                    request.Parameters.Add("StateReason", StringUtils.FromString(publicRequest.StateReason));
                }
                if(publicRequest.IsSetStateReasonData())
                {
                    request.Parameters.Add("StateReasonData", StringUtils.FromString(publicRequest.StateReasonData));
                }
                if(publicRequest.IsSetStateValue())
                {
                    request.Parameters.Add("StateValue", StringUtils.FromString(publicRequest.StateValue));
                }
            }
            return request;
        }
                    private static SetAlarmStateRequestMarshaller _instance = new SetAlarmStateRequestMarshaller();        

        internal static SetAlarmStateRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SetAlarmStateRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}