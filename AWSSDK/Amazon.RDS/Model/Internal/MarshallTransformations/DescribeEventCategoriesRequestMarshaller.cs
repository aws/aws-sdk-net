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

using Amazon.RDS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.RDS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Describe Event Categories Request Marshaller
    /// </summary>       
    public class DescribeEventCategoriesRequestMarshaller : IMarshaller<IRequest, DescribeEventCategoriesRequest>
    {
        public IRequest Marshall(DescribeEventCategoriesRequest describeEventCategoriesRequest)
        {
            IRequest request = new DefaultRequest(describeEventCategoriesRequest, "AmazonRDS");
            request.Parameters.Add("Action", "DescribeEventCategories");
            request.Parameters.Add("Version", "2013-01-10");
            if (describeEventCategoriesRequest != null && describeEventCategoriesRequest.IsSetSourceType())
            {
                request.Parameters.Add("SourceType", StringUtils.FromString(describeEventCategoriesRequest.SourceType));
            }

            return request;
        }
    }
}
