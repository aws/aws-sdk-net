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

using Amazon.CloudFormation.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.CloudFormation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Get Stack Policy Request Marshaller
    /// </summary>       
    public class GetStackPolicyRequestMarshaller : IMarshaller<IRequest, GetStackPolicyRequest>
    {
        public IRequest Marshall(GetStackPolicyRequest getStackPolicyRequest)
        {
            IRequest request = new DefaultRequest(getStackPolicyRequest, "AmazonCloudFormation");
            request.Parameters.Add("Action", "GetStackPolicy");
            request.Parameters.Add("Version", "2010-05-15");
            if (getStackPolicyRequest != null && getStackPolicyRequest.IsSetStackName())
            {
                request.Parameters.Add("StackName", StringUtils.FromString(getStackPolicyRequest.StackName));
            }

            return request;
        }
    }
}
