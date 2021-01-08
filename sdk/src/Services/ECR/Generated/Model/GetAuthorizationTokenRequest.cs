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
 * Do not modify this file. This file is generated from the ecr-2015-09-21.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ECR.Model
{
    /// <summary>
    /// Container for the parameters to the GetAuthorizationToken operation.
    /// Retrieves an authorization token. An authorization token represents your IAM authentication
    /// credentials and can be used to access any Amazon ECR registry that your IAM principal
    /// has access to. The authorization token is valid for 12 hours.
    /// 
    ///  
    /// <para>
    /// The <code>authorizationToken</code> returned is a base64 encoded string that can be
    /// decoded and used in a <code>docker login</code> command to authenticate to a registry.
    /// The AWS CLI offers an <code>get-login-password</code> command that simplifies the
    /// login process. For more information, see <a href="https://docs.aws.amazon.com/AmazonECR/latest/userguide/Registries.html#registry_auth">Registry
    /// Authentication</a> in the <i>Amazon Elastic Container Registry User Guide</i>.
    /// </para>
    /// </summary>
    public partial class GetAuthorizationTokenRequest : AmazonECRRequest
    {
        private List<string> _registryIds = new List<string>();

        /// <summary>
        /// Gets and sets the property RegistryIds. 
        /// <para>
        /// A list of AWS account IDs that are associated with the registries for which to get
        /// AuthorizationData objects. If you do not specify a registry, the default registry
        /// is assumed.
        /// </para>
        /// </summary>
        [Obsolete("This field is deprecated. The returned authorization token can be used to access any Amazon ECR registry that the IAM principal has access to, specifying a registry ID doesn't change the permissions scope of the authorization token.")]
        [AWSProperty(Min=1, Max=10)]
        public List<string> RegistryIds
        {
            get { return this._registryIds; }
            set { this._registryIds = value; }
        }

        // Check to see if RegistryIds property is set
        internal bool IsSetRegistryIds()
        {
            return this._registryIds != null && this._registryIds.Count > 0; 
        }

    }
}