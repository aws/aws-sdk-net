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
    /// Describe Key Pairs Request Marshaller
    /// </summary>       
    public class DescribeKeyPairsRequestMarshaller : IMarshaller<IRequest, DescribeKeyPairsRequest>
    {
        public IRequest Marshall(DescribeKeyPairsRequest describeKeyPairsRequest)
        {
            IRequest request = new DefaultRequest(describeKeyPairsRequest, "AmazonEC2");
            request.Parameters.Add("Action", "DescribeKeyPairs");
            request.Parameters.Add("Version", "2013-10-15");
            if (describeKeyPairsRequest != null)
            {
                List<string> keyNamesList = describeKeyPairsRequest.KeyNames;

                int keyNamesListIndex = 1;
                foreach (string keyNamesListValue in keyNamesList)
                { 
                    request.Parameters.Add("KeyName." + keyNamesListIndex, StringUtils.FromString(keyNamesListValue));
                    keyNamesListIndex++;
                }
            }

            if (describeKeyPairsRequest != null)
            {
                List<Filter> filtersList = describeKeyPairsRequest.Filters;
                int filtersListIndex = 1;
                foreach (Filter filtersListValue in filtersList)
                {
                    if (filtersListValue != null && filtersListValue.IsSetName())
                    {
                        request.Parameters.Add("Filter." + filtersListIndex + ".Name", StringUtils.FromString(filtersListValue.Name));
                    }
                    if (filtersListValue != null)
                    {
                        List<string> valuesList = filtersListValue.Values;

                        int valuesListIndex = 1;
                        foreach (string valuesListValue in valuesList)
                        { 
                            request.Parameters.Add("Filter." + filtersListIndex + ".Value." + valuesListIndex, StringUtils.FromString(valuesListValue));
                            valuesListIndex++;
                        }
                    }

                    filtersListIndex++;
                }
            }

            return request;
        }
    }
}
