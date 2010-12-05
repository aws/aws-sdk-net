/*
 * Copyright 2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.IdentityManagement.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.IdentityManagement.Model.Transform
{
    /// <summary>
    /// Update Access Key Request Marshaller
    /// </summary>       
    public class UpdateAccessKeyRequestMarshaller : IMarshaller<IRequest<UpdateAccessKeyRequest>, UpdateAccessKeyRequest> 
    {

        public IRequest<UpdateAccessKeyRequest> Marshall(UpdateAccessKeyRequest updateAccessKeyRequest) 
        {
            IRequest<UpdateAccessKeyRequest> request = new DefaultRequest<UpdateAccessKeyRequest>(updateAccessKeyRequest, "AmazonIdentityManagementService");
            request.Parameters.Add("Action", "UpdateAccessKey");
            request.Parameters.Add("Version", "2010-05-08");
            if (updateAccessKeyRequest != null && updateAccessKeyRequest.IsSetUserName()) 
            {
                request.Parameters.Add("UserName", StringUtils.FromString(updateAccessKeyRequest.UserName));
            }
            if (updateAccessKeyRequest != null && updateAccessKeyRequest.IsSetAccessKeyId()) 
            {
                request.Parameters.Add("AccessKeyId", StringUtils.FromString(updateAccessKeyRequest.AccessKeyId));
            }
            if (updateAccessKeyRequest != null && updateAccessKeyRequest.IsSetStatus()) 
            {
                request.Parameters.Add("Status", StringUtils.FromString(updateAccessKeyRequest.Status));
            }


            return request;
        }
    }
}
