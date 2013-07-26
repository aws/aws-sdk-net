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
    /// List Domains Request Marshaller
    /// </summary>       
    public class ListDomainsRequestMarshaller : IMarshaller<IRequest, ListDomainsRequest>
    {
        public IRequest Marshall(ListDomainsRequest listDomainsRequest)
        {
            IRequest request = new DefaultRequest(listDomainsRequest, "AmazonSimpleDB");
            request.Parameters.Add("Action", "ListDomains");
            request.Parameters.Add("Version", "2009-04-15");
            if (listDomainsRequest != null && listDomainsRequest.IsSetMaxNumberOfDomains())
            {
                request.Parameters.Add("MaxNumberOfDomains", StringUtils.FromInt(listDomainsRequest.MaxNumberOfDomains));
            }
            if (listDomainsRequest != null && listDomainsRequest.IsSetNextToken())
            {
                request.Parameters.Add("NextToken", StringUtils.FromString(listDomainsRequest.NextToken));
            }

            return request;
        }
    }
}
