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

using Amazon.SQS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.SQS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Add Permission Request Marshaller
    /// </summary>       
    public class AddPermissionRequestMarshaller : IMarshaller<IRequest, AddPermissionRequest>
    {
        public IRequest Marshall(AddPermissionRequest addPermissionRequest)
        {
            IRequest request = new DefaultRequest(addPermissionRequest, "AmazonSQS");
            request.Parameters.Add("Action", "AddPermission");
            request.Parameters.Add("Version", "2012-11-05");
            if (addPermissionRequest != null && addPermissionRequest.IsSetQueueUrl())
            {
                request.Parameters.Add("QueueUrl", StringUtils.FromString(addPermissionRequest.QueueUrl));
            }
            if (addPermissionRequest != null && addPermissionRequest.IsSetLabel())
            {
                request.Parameters.Add("Label", StringUtils.FromString(addPermissionRequest.Label));
            }
            if (addPermissionRequest != null)
            {
                List<string> aWSAccountIdsList = addPermissionRequest.AWSAccountIds;

                int aWSAccountIdsListIndex = 1;
                foreach (string aWSAccountIdsListValue in aWSAccountIdsList)
                { 
                    request.Parameters.Add("AWSAccountId." + aWSAccountIdsListIndex, StringUtils.FromString(aWSAccountIdsListValue));
                    aWSAccountIdsListIndex++;
                }
            }
            if (addPermissionRequest != null)
            {
                List<string> actionsList = addPermissionRequest.Actions;

                int actionsListIndex = 1;
                foreach (string actionsListValue in actionsList)
                { 
                    request.Parameters.Add("ActionName." + actionsListIndex, StringUtils.FromString(actionsListValue));
                    actionsListIndex++;
                }
            }

            return request;
        }
    }
}
