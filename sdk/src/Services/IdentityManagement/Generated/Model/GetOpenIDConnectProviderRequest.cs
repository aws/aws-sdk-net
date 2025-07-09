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
    /// Container for the parameters to the GetOpenIDConnectProvider operation.
    /// Returns information about the specified OpenID Connect (OIDC) provider resource object
    /// in IAM.
    /// </summary>
    public partial class GetOpenIDConnectProviderRequest : AmazonIdentityManagementServiceRequest
    {
        private string _openIDConnectProviderArn;

        /// <summary>
        /// Gets and sets the property OpenIDConnectProviderArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the OIDC provider resource object in IAM to get
        /// information for. You can get a list of OIDC provider resource ARNs by using the <a
        /// href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_ListOpenIDConnectProviders.html">ListOpenIDConnectProviders</a>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs)</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string OpenIDConnectProviderArn
        {
            get { return this._openIDConnectProviderArn; }
            set { this._openIDConnectProviderArn = value; }
        }

        // Check to see if OpenIDConnectProviderArn property is set
        internal bool IsSetOpenIDConnectProviderArn()
        {
            return this._openIDConnectProviderArn != null;
        }

    }
}