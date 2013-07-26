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

using Amazon.SimpleDB.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.SimpleDB.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Select Request Marshaller
    /// </summary>       
    public class SelectRequestMarshaller : IMarshaller<IRequest, SelectRequest>
    {
        public IRequest Marshall(SelectRequest selectRequest)
        {
            IRequest request = new DefaultRequest(selectRequest, "AmazonSimpleDB");
            request.Parameters.Add("Action", "Select");
            request.Parameters.Add("Version", "2009-04-15");
            if (selectRequest != null && selectRequest.IsSetSelectExpression())
            {
                request.Parameters.Add("SelectExpression", StringUtils.FromString(selectRequest.SelectExpression));
            }
            if (selectRequest != null && selectRequest.IsSetNextToken())
            {
                request.Parameters.Add("NextToken", StringUtils.FromString(selectRequest.NextToken));
            }
            if (selectRequest != null && selectRequest.IsSetConsistentRead())
            {
                request.Parameters.Add("ConsistentRead", StringUtils.FromBool(selectRequest.ConsistentRead));
            }

            return request;
        }
    }
}
