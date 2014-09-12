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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.CloudFormation.Model;

namespace Amazon.CloudFormation.Internal
{
    public class ProcessRequestHandler : GenericHandler
    {
        protected override void PreInvoke(IExecutionContext executionContext)
        {
            var request = executionContext.RequestContext.Request;
            var updateStackRequest = request.OriginalRequest as UpdateStackRequest;
            if (updateStackRequest != null)
            {
                var arns = updateStackRequest.NotificationARNs;
                bool arnsAutoConstructed = arns is AutoConstructedList<string>;

                // if there are no NotificationARNs and the list was created by user (type is NOT AutoConstructed)
                // only then pass empty param
                if (arns.Count == 0 && !arnsAutoConstructed)
                {
                    request.Parameters.Add("NotificationARNs", "");
                }
            }
        }
    }
}
