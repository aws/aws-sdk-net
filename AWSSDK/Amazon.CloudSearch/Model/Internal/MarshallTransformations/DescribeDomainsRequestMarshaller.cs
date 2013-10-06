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

using Amazon.CloudSearch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.CloudSearch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Describe Domains Request Marshaller
    /// </summary>       
    public class DescribeDomainsRequestMarshaller : IMarshaller<IRequest, DescribeDomainsRequest>
    {
        public IRequest Marshall(DescribeDomainsRequest describeDomainsRequest)
        {
            IRequest request = new DefaultRequest(describeDomainsRequest, "AmazonCloudSearch");
            request.Parameters.Add("Action", "DescribeDomains");
            request.Parameters.Add("Version", "2011-02-01");
            if (describeDomainsRequest != null)
            {
                List<string> domainNamesList = describeDomainsRequest.DomainNames;

                int domainNamesListIndex = 1;
                foreach (string domainNamesListValue in domainNamesList)
                { 
                    request.Parameters.Add("DomainNames.member." + domainNamesListIndex, StringUtils.FromString(domainNamesListValue));
                    domainNamesListIndex++;
                }
            }

            return request;
        }
    }
}
