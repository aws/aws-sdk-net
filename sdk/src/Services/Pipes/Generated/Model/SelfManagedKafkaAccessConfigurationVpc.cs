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
 * Do not modify this file. This file is generated from the pipes-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pipes.Model
{
    /// <summary>
    /// This structure specifies the VPC subnets and security groups for the stream, and whether
    /// a public IP address is to be used.
    /// </summary>
    public partial class SelfManagedKafkaAccessConfigurationVpc
    {
        private List<string> _securityGroup = new List<string>();
        private List<string> _subnets = new List<string>();

        /// <summary>
        /// Gets and sets the property SecurityGroup. 
        /// <para>
        /// Specifies the security groups associated with the stream. These security groups must
        /// all be in the same VPC. You can specify as many as five security groups. If you do
        /// not specify a security group, the default security group for the VPC is used.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<string> SecurityGroup
        {
            get { return this._securityGroup; }
            set { this._securityGroup = value; }
        }

        // Check to see if SecurityGroup property is set
        internal bool IsSetSecurityGroup()
        {
            return this._securityGroup != null && this._securityGroup.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Subnets. 
        /// <para>
        /// Specifies the subnets associated with the stream. These subnets must all be in the
        /// same VPC. You can specify as many as 16 subnets.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=16)]
        public List<string> Subnets
        {
            get { return this._subnets; }
            set { this._subnets = value; }
        }

        // Check to see if Subnets property is set
        internal bool IsSetSubnets()
        {
            return this._subnets != null && this._subnets.Count > 0; 
        }

    }
}