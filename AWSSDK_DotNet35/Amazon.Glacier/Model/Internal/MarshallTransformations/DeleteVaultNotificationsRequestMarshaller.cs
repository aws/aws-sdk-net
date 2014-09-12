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
 * Do not modify this file. This file is generated from the glacier-2012-06-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glacier.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Glacier.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteVaultNotifications Request Marshaller
    /// </summary>       
    public class DeleteVaultNotificationsRequestMarshaller : IMarshaller<IRequest, DeleteVaultNotificationsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteVaultNotificationsRequest)input);
        }

        public IRequest Marshall(DeleteVaultNotificationsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Glacier");
            request.HttpMethod = "DELETE";

            string uriResourcePath = "/{accountId}/vaults/{vaultName}/notification-configuration";
            uriResourcePath = uriResourcePath.Replace("{accountId}", publicRequest.IsSetAccountId() ? StringUtils.FromString(publicRequest.AccountId) : string.Empty);
            uriResourcePath = uriResourcePath.Replace("{vaultName}", publicRequest.IsSetVaultName() ? StringUtils.FromString(publicRequest.VaultName) : string.Empty);
            request.ResourcePath = uriResourcePath;
            request.UseQueryString = true;

            return request;
        }


    }
}