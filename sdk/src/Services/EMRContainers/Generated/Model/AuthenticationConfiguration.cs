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
 * Do not modify this file. This file is generated from the emr-containers-2020-10-01.normal.json service model.
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
namespace Amazon.EMRContainers.Model
{
    /// <summary>
    /// Authentication configuration for the security configuration.
    /// </summary>
    public partial class AuthenticationConfiguration
    {
        private IAMConfiguration _iamConfiguration;
        private IdentityCenterConfiguration _identityCenterConfiguration;

        /// <summary>
        /// Gets and sets the property IamConfiguration. 
        /// <para>
        /// IAM configuration for authentication in the security configuration.
        /// </para>
        /// </summary>
        public IAMConfiguration IamConfiguration
        {
            get { return this._iamConfiguration; }
            set { this._iamConfiguration = value; }
        }

        // Check to see if IamConfiguration property is set
        internal bool IsSetIamConfiguration()
        {
            return this._iamConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityCenterConfiguration. 
        /// <para>
        /// Identity Center configuration for authentication in the security configuration.
        /// </para>
        /// </summary>
        public IdentityCenterConfiguration IdentityCenterConfiguration
        {
            get { return this._identityCenterConfiguration; }
            set { this._identityCenterConfiguration = value; }
        }

        // Check to see if IdentityCenterConfiguration property is set
        internal bool IsSetIdentityCenterConfiguration()
        {
            return this._identityCenterConfiguration != null;
        }

    }
}