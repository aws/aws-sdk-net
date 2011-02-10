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
    /// Delete Alarms Request Marshaller
    /// </summary>       
    public class DeleteAlarmsRequestMarshaller : IMarshaller<IRequest<DeleteAlarmsRequest>, DeleteAlarmsRequest> 
    {

        public IRequest<DeleteAlarmsRequest> Marshall(DeleteAlarmsRequest deleteAlarmsRequest) 
        {
            IRequest<DeleteAlarmsRequest> request = new DefaultRequest<DeleteAlarmsRequest>(deleteAlarmsRequest, "AmazonCloudWatch");
            request.Parameters.Add("Action", "DeleteAlarms");
            request.Parameters.Add("Version", "2010-08-01");
            if (deleteAlarmsRequest != null) 
            {
                List<string> alarmNamesList = deleteAlarmsRequest.AlarmNames;
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
