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
    /// Batch Delete Attributes Request Marshaller
    /// </summary>       
    public class BatchDeleteAttributesRequestMarshaller : IMarshaller<IRequest, BatchDeleteAttributesRequest>
    {
        public IRequest Marshall(BatchDeleteAttributesRequest batchDeleteAttributesRequest)
        {
            IRequest request = new DefaultRequest(batchDeleteAttributesRequest, "AmazonSimpleDB");
            request.Parameters.Add("Action", "BatchDeleteAttributes");
            request.Parameters.Add("Version", "2009-04-15");
            if (batchDeleteAttributesRequest != null && batchDeleteAttributesRequest.IsSetDomainName())
            {
                request.Parameters.Add("DomainName", StringUtils.FromString(batchDeleteAttributesRequest.DomainName));
            }

            if (batchDeleteAttributesRequest != null)
            {
                List<DeletableItem> itemsList = batchDeleteAttributesRequest.Items;
                int itemsListIndex = 1;
                foreach (DeletableItem itemsListValue in itemsList)
                {
                    if (itemsListValue != null && itemsListValue.IsSetName())
                    {
                        request.Parameters.Add("Item." + itemsListIndex + ".ItemName", StringUtils.FromString(itemsListValue.Name));
                    }

                    if (itemsListValue != null)
                    {
                        List<Attribute> attributesList = itemsListValue.Attributes;
                        int attributesListIndex = 1;
                        foreach (Attribute attributesListValue in attributesList)
                        {
                            if (attributesListValue != null && attributesListValue.IsSetName())
                            {
                                request.Parameters.Add("Item." + itemsListIndex + ".Attribute." + attributesListIndex + ".Name", StringUtils.FromString(attributesListValue.Name));
                            }
                            if (attributesListValue != null && attributesListValue.IsSetAlternateNameEncoding())
                            {
                                request.Parameters.Add("Item." + itemsListIndex + ".Attribute." + attributesListIndex + ".AlternateNameEncoding", StringUtils.FromString(attributesListValue.AlternateNameEncoding));
                            }
                            if (attributesListValue != null && attributesListValue.IsSetValue())
                            {
                                request.Parameters.Add("Item." + itemsListIndex + ".Attribute." + attributesListIndex + ".Value", StringUtils.FromString(attributesListValue.Value));
                            }
                            if (attributesListValue != null && attributesListValue.IsSetAlternateValueEncoding())
                            {
                                request.Parameters.Add("Item." + itemsListIndex + ".Attribute." + attributesListIndex + ".AlternateValueEncoding", StringUtils.FromString(attributesListValue.AlternateValueEncoding));
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
