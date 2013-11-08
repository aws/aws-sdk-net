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
    /// Put Attributes Request Marshaller
    /// </summary>       
    public class PutAttributesRequestMarshaller : IMarshaller<IRequest, PutAttributesRequest>
    {
        public IRequest Marshall(PutAttributesRequest putAttributesRequest)
        {
            IRequest request = new DefaultRequest(putAttributesRequest, "AmazonSimpleDB");
            request.Parameters.Add("Action", "PutAttributes");
            request.Parameters.Add("Version", "2009-04-15");
            if (putAttributesRequest != null && putAttributesRequest.IsSetDomainName())
            {
                request.Parameters.Add("DomainName", StringUtils.FromString(putAttributesRequest.DomainName));
            }
            if (putAttributesRequest != null && putAttributesRequest.IsSetItemName())
            {
                request.Parameters.Add("ItemName", StringUtils.FromString(putAttributesRequest.ItemName));
            }

            if (putAttributesRequest != null)
            {
                List<ReplaceableAttribute> attributesList = putAttributesRequest.Attributes;
                int attributesListIndex = 1;
                foreach (ReplaceableAttribute attributesListValue in attributesList)
                {
                    if (attributesListValue != null && attributesListValue.IsSetName())
                    {
                        request.Parameters.Add("Attribute." + attributesListIndex + ".Name", StringUtils.FromString(attributesListValue.Name));
                    }
                    if (attributesListValue != null && attributesListValue.IsSetValue())
                    {
                        request.Parameters.Add("Attribute." + attributesListIndex + ".Value", StringUtils.FromString(attributesListValue.Value));
                    }
                    if (attributesListValue != null && attributesListValue.IsSetReplace())
                    {
                        request.Parameters.Add("Attribute." + attributesListIndex + ".Replace", StringUtils.FromBool(attributesListValue.Replace));
                    }

                    attributesListIndex++;
                }
            }
            if (putAttributesRequest != null)
            {
                UpdateCondition expected = putAttributesRequest.Expected;
                if (expected != null && expected.IsSetName())
                {
                    request.Parameters.Add("Expected.Name", StringUtils.FromString(expected.Name));
                }
                if (expected != null && expected.IsSetValue())
                {
                    request.Parameters.Add("Expected.Value", StringUtils.FromString(expected.Value));
                }
                if (expected != null && expected.IsSetExists())
                {
                    request.Parameters.Add("Expected.Exists", StringUtils.FromBool(expected.Exists));
                }
            }

            return request;
        }
    }
}
