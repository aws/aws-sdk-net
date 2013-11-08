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
    /// Batch Put Attributes Request Marshaller
    /// </summary>       
    public class BatchPutAttributesRequestMarshaller : IMarshaller<IRequest, BatchPutAttributesRequest>
    {
        public IRequest Marshall(BatchPutAttributesRequest batchPutAttributesRequest)
        {
            IRequest request = new DefaultRequest(batchPutAttributesRequest, "AmazonSimpleDB");
            request.Parameters.Add("Action", "BatchPutAttributes");
            request.Parameters.Add("Version", "2009-04-15");
            if (batchPutAttributesRequest != null && batchPutAttributesRequest.IsSetDomainName())
            {
                request.Parameters.Add("DomainName", StringUtils.FromString(batchPutAttributesRequest.DomainName));
            }

            if (batchPutAttributesRequest != null)
            {
                List<ReplaceableItem> itemsList = batchPutAttributesRequest.Items;
                int itemsListIndex = 1;
                foreach (ReplaceableItem itemsListValue in itemsList)
                {
                    if (itemsListValue != null && itemsListValue.IsSetName())
                    {
                        request.Parameters.Add("Item." + itemsListIndex + ".ItemName", StringUtils.FromString(itemsListValue.Name));
                    }

                    if (itemsListValue != null)
                    {
                        List<ReplaceableAttribute> attributesList = itemsListValue.Attributes;
                        int attributesListIndex = 1;
                        foreach (ReplaceableAttribute attributesListValue in attributesList)
                        {
                            if (attributesListValue != null && attributesListValue.IsSetName())
                            {
                                request.Parameters.Add("Item." + itemsListIndex + ".Attribute." + attributesListIndex + ".Name", StringUtils.FromString(attributesListValue.Name));
                            }
                            if (attributesListValue != null && attributesListValue.IsSetValue())
                            {
                                request.Parameters.Add("Item." + itemsListIndex + ".Attribute." + attributesListIndex + ".Value", StringUtils.FromString(attributesListValue.Value));
                            }
                            if (attributesListValue != null && attributesListValue.IsSetReplace())
                            {
                                request.Parameters.Add("Item." + itemsListIndex + ".Attribute." + attributesListIndex + ".Replace", StringUtils.FromBool(attributesListValue.Replace));
                            }

                            attributesListIndex++;
                        }
                    }

                    itemsListIndex++;
                }
            }

            return request;
        }
    }
}
