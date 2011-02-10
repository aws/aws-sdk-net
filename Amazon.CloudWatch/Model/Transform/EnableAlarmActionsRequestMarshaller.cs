/*
 * Copyright 2010-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.CloudWatch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.CloudWatch.Model.Transform
{
    /// <summary>
    /// Enable Alarm Actions Request Marshaller
    /// </summary>       
    public class EnableAlarmActionsRequestMarshaller : IMarshaller<IRequest<EnableAlarmActionsRequest>, EnableAlarmActionsRequest> 
    {

        public IRequest<EnableAlarmActionsRequest> Marshall(EnableAlarmActionsRequest enableAlarmActionsRequest) 
        {
            IRequest<EnableAlarmActionsRequest> request = new DefaultRequest<EnableAlarmActionsRequest>(enableAlarmActionsRequest, "AmazonCloudWatch");
            request.Parameters.Add("Action", "EnableAlarmActions");
            request.Parameters.Add("Version", "2010-08-01");
            if (enableAlarmActionsRequest != null) 
            {
                List<string> alarmNamesList = enableAlarmActionsRequest.AlarmNames;
                int alarmNamesListIndex = 1;
                foreach (string alarmNamesListValue in alarmNamesList) 
                { 
                    request.Parameters.Add("AlarmNames.member." + alarmNamesListIndex, StringUtils.FromString(alarmNamesListValue));
                    alarmNamesListIndex++;
                }
            }


            return request;
        }
    }
}
