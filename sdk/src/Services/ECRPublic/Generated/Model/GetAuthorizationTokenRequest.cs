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
 * Do not modify this file. This file is generated from the ecr-public-2020-10-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ECRPublic.Model
{
    /// <summary>
    /// Container for the parameters to the GetAuthorizationToken operation.
    /// Retrieves an authorization token. An authorization token represents your IAM authentication
    /// credentials. You can use it to access any Amazon ECR registry that your IAM principal
    /// has access to. The authorization token is valid for 12 hours. This API requires the
    /// <code>ecr-public:GetAuthorizationToken</code> and <code>sts:GetServiceBearerToken</code>
    /// permissions.
    /// </summary>
    public partial class GetAuthorizationTokenRequest : AmazonECRPublicRequest
    {

    }
}