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
    /// DeleteClient Request Marshaller
    /// </summary>       
    public class DeleteClientRequestMarshaller : IMarshaller<IRequest, DeleteClientRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteClientRequest)input);
        }

        public IRequest Marshall(DeleteClientRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudHSM");
            string target = "cloudhsm.DeleteClient";
            request.Headers["X-Amz-Target"] = target;
            request.HttpMethod = "DELETE";

            string uriResourcePath = "/20140401/lunasa/client/{ClientArn}";
            uriResourcePath = uriResourcePath.Replace("{ClientArn}", publicRequest.IsSetClientArn() ? StringUtils.FromString(publicRequest.ClientArn) : string.Empty);
            request.ResourcePath = uriResourcePath;

            return request;
        }


    }
}