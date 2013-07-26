/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.SimpleNotificationService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.SimpleNotificationService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Add Permission Request Marshaller
    /// </summary>       
    public class AddPermissionRequestMarshaller : IMarshaller<IRequest, AddPermissionRequest>
    {
        public IRequest Marshall(AddPermissionRequest addPermissionRequest)
        {
            IRequest request = new DefaultRequest(addPermissionRequest, "AmazonSimpleNotificationService");
            request.Parameters.Add("Action", "AddPermission");
            request.Parameters.Add("Version", "2010-03-31");
            if (addPermissionRequest != null && addPermissionRequest.IsSetTopicArn())
            {
                request.Parameters.Add("TopicArn", StringUtils.FromString(addPermissionRequest.TopicArn));
            }
            if (addPermissionRequest != null && addPermissionRequest.IsSetLabel())
            {
                request.Parameters.Add("Label", StringUtils.FromString(addPermissionRequest.Label));
            }
            if (addPermissionRequest != null)
            {
                List<string> aWSAccountIdList = addPermissionRequest.AWSAccountId;

                int aWSAccountIdListIndex = 1;
                foreach (string aWSAccountIdListValue in aWSAccountIdList)
                { 
                    request.Parameters.Add("AWSAccountId.member." + aWSAccountIdListIndex, StringUtils.FromString(aWSAccountIdListValue));
                    aWSAccountIdListIndex++;
                }
            }
            if (addPermissionRequest != null)
            {
                List<string> actionNameList = addPermissionRequest.ActionName;

                int actionNameListIndex = 1;
                foreach (string actionNameListValue in actionNameList)
                { 
                    request.Parameters.Add("ActionName.member." + actionNameListIndex, StringUtils.FromString(actionNameListValue));
                    actionNameListIndex++;
                }
            }

            return request;
        }
    }
}
