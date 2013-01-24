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
    /// Update Stemming Options Request Marshaller
    /// </summary>       
    public class UpdateStemmingOptionsRequestMarshaller : IMarshaller<IRequest, UpdateStemmingOptionsRequest>
    {
        public IRequest Marshall(UpdateStemmingOptionsRequest updateStemmingOptionsRequest)
        {
            IRequest request = new DefaultRequest(updateStemmingOptionsRequest, "AmazonCloudSearch");
            request.Parameters.Add("Action", "UpdateStemmingOptions");
            request.Parameters.Add("Version", "2011-02-01");
            if (updateStemmingOptionsRequest != null && updateStemmingOptionsRequest.IsSetDomainName())
            {
                request.Parameters.Add("DomainName", StringUtils.FromString(updateStemmingOptionsRequest.DomainName));
            }
            if (updateStemmingOptionsRequest != null && updateStemmingOptionsRequest.IsSetStems())
            {
                request.Parameters.Add("Stems", StringUtils.FromString(updateStemmingOptionsRequest.Stems));
            }

            return request;
        }
    }
}
