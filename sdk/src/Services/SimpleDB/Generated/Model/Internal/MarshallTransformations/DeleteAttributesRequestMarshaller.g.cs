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
    /// DeleteAttributes Request Marshaller
    /// </summary>
    public partial class DeleteAttributesRequestMarshaller : IMarshaller<IRequest, DeleteAttributesRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteAttributesRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(DeleteAttributesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SimpleDB");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "DeleteAttributes");
            request.Parameters.Add("Version", "2009-04-15");

            if (publicRequest.IsSetAttributes())
            {
                if (publicRequest.Attributes.Count == 0)
                {
                    request.Parameters.Add("Attribute", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.Attributes)
                    {
                        if (item0.IsSetAlternateNameEncoding())
                        {
                            request.Parameters.Add("Attribute" + "." + index0 + ".AlternateNameEncoding", StringUtils.FromString(item0.AlternateNameEncoding));
                        }
                        if (item0.IsSetAlternateValueEncoding())
                        {
                            request.Parameters.Add("Attribute" + "." + index0 + ".AlternateValueEncoding", StringUtils.FromString(item0.AlternateValueEncoding));
                        }
                        if (item0.IsSetName())
                        {
                            request.Parameters.Add("Attribute" + "." + index0 + ".Name", StringUtils.FromString(item0.Name));
                        }
                        if (item0.IsSetValue())
                        {
                            request.Parameters.Add("Attribute" + "." + index0 + ".Value", StringUtils.FromString(item0.Value));
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetDomainName())
            {
                request.Parameters.Add("DomainName", StringUtils.FromString(publicRequest.DomainName));
            }
            if (publicRequest.IsSetExpected())
            {
                if (publicRequest.Expected.IsSetExists())
                {
                    request.Parameters.Add("Expected" + ".Exists", StringUtils.FromBool(publicRequest.Expected.Exists.Value));
                }
                if (publicRequest.Expected.IsSetName())
                {
                    request.Parameters.Add("Expected" + ".Name", StringUtils.FromString(publicRequest.Expected.Name));
                }
                if (publicRequest.Expected.IsSetValue())
                {
                    request.Parameters.Add("Expected" + ".Value", StringUtils.FromString(publicRequest.Expected.Value));
                }
            }
            if (publicRequest.IsSetItemName())
            {
                request.Parameters.Add("ItemName", StringUtils.FromString(publicRequest.ItemName));
            }


            return request;
        }

        private static readonly DeleteAttributesRequestMarshaller _instance = new();

        internal static DeleteAttributesRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DeleteAttributesRequestMarshaller Instance => _instance;
    }
}
