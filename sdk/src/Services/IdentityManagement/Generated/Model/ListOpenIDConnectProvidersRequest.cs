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
    /// Container for the parameters to the ListOpenIDConnectProviders operation.
    /// Lists information about the IAM OpenID Connect (OIDC) provider resource objects defined
    /// in the Amazon Web Services account.
    /// 
    ///  <note> 
    /// <para>
    /// IAM resource-listing operations return a subset of the available attributes for the
    /// resource. For example, this operation does not return tags, even though they are an
    /// attribute of the returned object. To view all of the information for an OIDC provider,
    /// see <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetOpenIDConnectProvider.html">GetOpenIDConnectProvider</a>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ListOpenIDConnectProvidersRequest : AmazonIdentityManagementServiceRequest
    {

    }
}