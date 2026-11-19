/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

using Amazon.SimpleDB.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.SimpleDB.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BatchPutAttributes Request Marshaller
    /// </summary>
    public partial class BatchPutAttributesRequestMarshaller : IMarshaller<IRequest, BatchPutAttributesRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((BatchPutAttributesRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(BatchPutAttributesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SimpleDB");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "BatchPutAttributes");
            request.Parameters.Add("Version", "2009-04-15");

            if (publicRequest.IsSetDomainName())
            {
                request.Parameters.Add("DomainName", StringUtils.FromString(publicRequest.DomainName));
            }
            if (publicRequest.IsSetItems())
            {
                if (publicRequest.Items.Count == 0)
                {
                    request.Parameters.Add("Item", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.Items)
                    {
                        if (item0.IsSetAttributes())
                        {
                            if (item0.Attributes.Count == 0)
                            {
                                request.Parameters.Add("Item" + "." + index0 + ".Attribute", "");
                            }
                            else
                            {
                                int index1 = 1;
                                foreach (var item1 in item0.Attributes)
                                {
                                    if (item1.IsSetName())
                                    {
                                        request.Parameters.Add("Item" + "." + index0 + ".Attribute" + "." + index1 + ".Name", StringUtils.FromString(item1.Name));
                                    }
                                    if (item1.IsSetReplace())
                                    {
                                        request.Parameters.Add("Item" + "." + index0 + ".Attribute" + "." + index1 + ".Replace", StringUtils.FromBool(item1.Replace.Value));
                                    }
                                    if (item1.IsSetValue())
                                    {
                                        request.Parameters.Add("Item" + "." + index0 + ".Attribute" + "." + index1 + ".Value", StringUtils.FromString(item1.Value));
                                    }
                                    index1++;
                                }
                            }
                        }
                        if (item0.IsSetName())
                        {
                            request.Parameters.Add("Item" + "." + index0 + ".ItemName", StringUtils.FromString(item0.Name));
                        }
                        index0++;
                    }
                }
            }


            return request;
        }

        private static readonly BatchPutAttributesRequestMarshaller _instance = new();

        internal static BatchPutAttributesRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static BatchPutAttributesRequestMarshaller Instance => _instance;
    }
}
