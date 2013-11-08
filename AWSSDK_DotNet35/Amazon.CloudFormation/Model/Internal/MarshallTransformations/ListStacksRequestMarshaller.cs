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
    /// List Stacks Request Marshaller
    /// </summary>       
    public class ListStacksRequestMarshaller : IMarshaller<IRequest, ListStacksRequest>
    {
        public IRequest Marshall(ListStacksRequest listStacksRequest)
        {
            IRequest request = new DefaultRequest(listStacksRequest, "AmazonCloudFormation");
            request.Parameters.Add("Action", "ListStacks");
            request.Parameters.Add("Version", "2010-05-15");
            if (listStacksRequest != null && listStacksRequest.IsSetNextToken())
            {
                request.Parameters.Add("NextToken", StringUtils.FromString(listStacksRequest.NextToken));
            }
            if (listStacksRequest != null)
            {
                List<string> stackStatusFilterList = listStacksRequest.StackStatusFilter;

                int stackStatusFilterListIndex = 1;
                foreach (string stackStatusFilterListValue in stackStatusFilterList)
                { 
                    request.Parameters.Add("StackStatusFilter.member." + stackStatusFilterListIndex, StringUtils.FromString(stackStatusFilterListValue));
                    stackStatusFilterListIndex++;
                }
            }

            return request;
        }
    }
}
