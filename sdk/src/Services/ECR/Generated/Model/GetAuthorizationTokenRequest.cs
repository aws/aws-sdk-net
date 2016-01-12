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
 * Do not modify this file. This file is generated from the ecr-2015-09-21.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ECR.Model
{
    /// <summary>
    /// Container for the parameters to the GetAuthorizationToken operation.
    /// Retrieves a token that is valid for a specified registry for 12 hours. This command
    /// allows you to use the <code>docker</code> CLI to push and pull images with Amazon
    /// ECR. If you do not specify a registry, the default registry is assumed.
    /// 
    ///  
    /// <para>
    /// The <code>authorizationToken</code> returned for each registry specified is a base64
    /// encoded string that can be decoded and used in a <code>docker login</code> command
    /// to authenticate to a registry. The AWS CLI offers an <code>aws ecr get-login</code>
    /// command that simplifies the login process.
    /// </para>
    /// </summary>
    public partial class GetAuthorizationTokenRequest : AmazonECRRequest
    {
        private List<string> _registryIds = new List<string>();

        /// <summary>
        /// Gets and sets the property RegistryIds. 
        /// <para>
        /// A list of AWS account IDs that are associated with the registries for which to get
        /// authorization tokens. If you do not specify a registry, the default registry is assumed.
        /// </para>
        /// </summary>
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