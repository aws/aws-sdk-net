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

using Amazon.CloudFormation.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.CloudFormation.Model.Transform
{
    /// <summary>
    /// List Stack Resources Request Marshaller
    /// </summary>       
    public class ListStackResourcesRequestMarshaller : IMarshaller<IRequest<ListStackResourcesRequest>, ListStackResourcesRequest> 
    {

        public IRequest<ListStackResourcesRequest> Marshall(ListStackResourcesRequest listStackResourcesRequest) 
        {
            IRequest<ListStackResourcesRequest> request = new DefaultRequest<ListStackResourcesRequest>(listStackResourcesRequest, "AmazonCloudFormation");
            request.Parameters.Add("Action", "ListStackResources");
            request.Parameters.Add("Version", "2010-05-15");
            if (listStackResourcesRequest != null && listStackResourcesRequest.IsSetStackName()) 
            {
                request.Parameters.Add("StackName", StringUtils.FromString(listStackResourcesRequest.StackName));
            }
            if (listStackResourcesRequest != null && listStackResourcesRequest.IsSetNextToken()) 
            {
                request.Parameters.Add("NextToken", StringUtils.FromString(listStackResourcesRequest.NextToken));
            }


            return request;
        }
    }
}
