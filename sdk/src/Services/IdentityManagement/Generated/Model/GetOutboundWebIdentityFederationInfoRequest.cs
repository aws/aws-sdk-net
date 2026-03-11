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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the GetOutboundWebIdentityFederationInfo operation.
    /// Retrieves the configuration information for the outbound identity federation feature
    /// in your Amazon Web Services account. The response includes the unique issuer URL for
    /// your Amazon Web Services account and the current enabled/disabled status of the feature.
    /// Use this operation to obtain the issuer URL that you need to configure trust relationships
    /// with external services.
    /// </summary>
    public partial class GetOutboundWebIdentityFederationInfoRequest : AmazonIdentityManagementServiceRequest
    {

    }
}