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

using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Create Dhcp Options Request Marshaller
    /// </summary>       
    public class CreateDhcpOptionsRequestMarshaller : IMarshaller<IRequest, CreateDhcpOptionsRequest>
    {
        public IRequest Marshall(CreateDhcpOptionsRequest createDhcpOptionsRequest)
        {
            IRequest request = new DefaultRequest(createDhcpOptionsRequest, "AmazonEC2");
            request.Parameters.Add("Action", "CreateDhcpOptions");
            request.Parameters.Add("Version", "2013-10-15");

            if (createDhcpOptionsRequest != null)
            {
                List<DhcpConfiguration> dhcpConfigurationsList = createDhcpOptionsRequest.DhcpConfigurations;
                int dhcpConfigurationsListIndex = 1;
                foreach (DhcpConfiguration dhcpConfigurationsListValue in dhcpConfigurationsList)
                {
                    if (dhcpConfigurationsListValue != null && dhcpConfigurationsListValue.IsSetKey())
                    {
                        request.Parameters.Add("DhcpConfiguration." + dhcpConfigurationsListIndex + ".Key", StringUtils.FromString(dhcpConfigurationsListValue.Key));
                    }
                    if (dhcpConfigurationsListValue != null)
                    {
                        List<string> valuesList = dhcpConfigurationsListValue.Values;

                        int valuesListIndex = 1;
                        foreach (string valuesListValue in valuesList)
                        { 
                            request.Parameters.Add("DhcpConfiguration." + dhcpConfigurationsListIndex + ".Value." + valuesListIndex, StringUtils.FromString(valuesListValue));
                            valuesListIndex++;
                        }
                    }

                    dhcpConfigurationsListIndex++;
                }
            }

            return request;
        }
    }
}
