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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
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
namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// The per-scan-type inheritance reset settings for the <c>UpdateConfiguration</c> operation.
    /// Each member is independently optional. Including a member in this structure resets
    /// that scan type's configuration to inherit from the delegated administrator.
    /// </summary>
    public partial class UpdateConfigurationInheritance
    {
        private InheritanceMode _ec2Configuration;
        private InheritanceMode _ecrConfiguration;

        /// <summary>
        /// Gets and sets the property Ec2Configuration. 
        /// <para>
        /// The inheritance mode for Amazon EC2 scan configuration. Set to <c>INHERIT_FROM_ADMIN</c>
        /// to reset the member account's Amazon EC2 scan configuration to inherit from the delegated
        /// administrator. If omitted, the member account's existing Amazon EC2 scan configuration
        /// is not changed.
        /// </para>
        /// </summary>
        public InheritanceMode Ec2Configuration
        {
            get { return this._ec2Configuration; }
            set { this._ec2Configuration = value; }
        }

        // Check to see if Ec2Configuration property is set
        internal bool IsSetEc2Configuration()
        {
            return this._ec2Configuration != null;
        }

        /// <summary>
        /// Gets and sets the property EcrConfiguration. 
        /// <para>
        /// The inheritance mode for Amazon ECR scan configuration. Set to <c>INHERIT_FROM_ADMIN</c>
        /// to reset the member account's Amazon ECR scan configuration to inherit from the delegated
        /// administrator. If omitted, the member account's existing Amazon ECR scan configuration
        /// is not changed.
        /// </para>
        /// </summary>
        public InheritanceMode EcrConfiguration
        {
            get { return this._ecrConfiguration; }
            set { this._ecrConfiguration = value; }
        }

        // Check to see if EcrConfiguration property is set
        internal bool IsSetEcrConfiguration()
        {
            return this._ecrConfiguration != null;
        }

    }
}