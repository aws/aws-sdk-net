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
    /// Delete Index Field Request Marshaller
    /// </summary>       
    public class DeleteIndexFieldRequestMarshaller : IMarshaller<IRequest, DeleteIndexFieldRequest>
    {
        public IRequest Marshall(DeleteIndexFieldRequest deleteIndexFieldRequest)
        {
            IRequest request = new DefaultRequest(deleteIndexFieldRequest, "AmazonCloudSearch");
            request.Parameters.Add("Action", "DeleteIndexField");
            request.Parameters.Add("Version", "2011-02-01");
            if (deleteIndexFieldRequest != null && deleteIndexFieldRequest.IsSetDomainName())
            {
                request.Parameters.Add("DomainName", StringUtils.FromString(deleteIndexFieldRequest.DomainName));
            }
            if (deleteIndexFieldRequest != null && deleteIndexFieldRequest.IsSetIndexFieldName())
            {
                request.Parameters.Add("IndexFieldName", StringUtils.FromString(deleteIndexFieldRequest.IndexFieldName));
            }

            return request;
        }
    }
}
