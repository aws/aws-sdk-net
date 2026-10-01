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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Contains the authentication settings for a security configuration, including Identity
    /// Center and IAM configuration options.
    /// </summary>
    public partial class AuthenticationConfiguration
    {
        /// <summary>
        /// Gets and sets the property IamConfiguration. 
        /// <para>
        /// The IAM configuration to use for authentication.
        /// </para>
        /// </summary>
        public IAMConfiguration IamConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the IamConfiguration property is set.
        /// </summary>
        internal bool IsSetIamConfiguration() => this.IamConfiguration != null;

        /// <summary>
        /// Gets and sets the property IdentityCenterConfiguration. 
        /// <para>
        /// The IAM Identity Center configuration to use for authentication.
        /// </para>
        /// </summary>
        public IdentityCenterConfiguration IdentityCenterConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the IdentityCenterConfiguration property is set.
        /// </summary>
        internal bool IsSetIdentityCenterConfiguration() => this.IdentityCenterConfiguration != null;
    }
}
