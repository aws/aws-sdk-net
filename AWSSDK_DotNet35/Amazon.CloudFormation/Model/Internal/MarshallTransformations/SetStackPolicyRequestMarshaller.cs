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
    /// Set Stack Policy Request Marshaller
    /// </summary>       
    public class SetStackPolicyRequestMarshaller : IMarshaller<IRequest, SetStackPolicyRequest>
    {
        public IRequest Marshall(SetStackPolicyRequest setStackPolicyRequest)
        {
            IRequest request = new DefaultRequest(setStackPolicyRequest, "AmazonCloudFormation");
            request.Parameters.Add("Action", "SetStackPolicy");
            request.Parameters.Add("Version", "2010-05-15");
            if (setStackPolicyRequest != null && setStackPolicyRequest.IsSetStackName())
            {
                request.Parameters.Add("StackName", StringUtils.FromString(setStackPolicyRequest.StackName));
            }
            if (setStackPolicyRequest != null && setStackPolicyRequest.IsSetStackPolicyBody())
            {
                request.Parameters.Add("StackPolicyBody", StringUtils.FromString(setStackPolicyRequest.StackPolicyBody));
            }
            if (setStackPolicyRequest != null && setStackPolicyRequest.IsSetStackPolicyURL())
            {
                request.Parameters.Add("StackPolicyURL", StringUtils.FromString(setStackPolicyRequest.StackPolicyURL));
            }

            return request;
        }
    }
}
