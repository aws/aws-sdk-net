/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the cloudhsm-2014-05-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudHSM.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CloudHSM.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AddHAPartitionGroupToClient Request Marshaller
    /// </summary>       
    public class AddHAPartitionGroupToClientRequestMarshaller : IMarshaller<IRequest, AddHAPartitionGroupToClientRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((AddHAPartitionGroupToClientRequest)input);
        }

        public IRequest Marshall(AddHAPartitionGroupToClientRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudHSM");
            string target = "cloudhsm.AddHAPartitionGroupToClient";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-";
            request.HttpMethod = "PUT";

            string uriResourcePath = "/20140401/lunasa/client/{ClientArn}/{HAPartitionGroupArn}";
            uriResourcePath = uriResourcePath.Replace("{ClientArn}", publicRequest.IsSetClientArn() ? StringUtils.FromString(publicRequest.ClientArn) : string.Empty);
            uriResourcePath = uriResourcePath.Replace("{HAPartitionGroupArn}", publicRequest.IsSetHAPartitionGroupArn() ? StringUtils.FromString(publicRequest.HAPartitionGroupArn) : string.Empty);
            request.ResourcePath = uriResourcePath;

            return request;
        }


    }
}