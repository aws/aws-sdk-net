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
    /// Get Attributes Request Marshaller
    /// </summary>       
    public class GetAttributesRequestMarshaller : IMarshaller<IRequest, GetAttributesRequest>
    {
        public IRequest Marshall(GetAttributesRequest getAttributesRequest)
        {
            IRequest request = new DefaultRequest(getAttributesRequest, "AmazonSimpleDB");
            request.Parameters.Add("Action", "GetAttributes");
            request.Parameters.Add("Version", "2009-04-15");
            if (getAttributesRequest != null && getAttributesRequest.IsSetDomainName())
            {
                request.Parameters.Add("DomainName", StringUtils.FromString(getAttributesRequest.DomainName));
            }
            if (getAttributesRequest != null && getAttributesRequest.IsSetItemName())
            {
                request.Parameters.Add("ItemName", StringUtils.FromString(getAttributesRequest.ItemName));
            }
            if (getAttributesRequest != null)
            {
                List<string> attributeNamesList = getAttributesRequest.AttributeNames;

                int attributeNamesListIndex = 1;
                foreach (string attributeNamesListValue in attributeNamesList)
                { 
                    request.Parameters.Add("AttributeName." + attributeNamesListIndex, StringUtils.FromString(attributeNamesListValue));
                    attributeNamesListIndex++;
                }
            }
            if (getAttributesRequest != null && getAttributesRequest.IsSetConsistentRead())
            {
                request.Parameters.Add("ConsistentRead", StringUtils.FromBool(getAttributesRequest.ConsistentRead));
            }

            return request;
        }
    }
}
