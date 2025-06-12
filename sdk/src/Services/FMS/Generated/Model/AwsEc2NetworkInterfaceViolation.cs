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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
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
namespace Amazon.FMS.Model
{
    /// <summary>
    /// Violation detail for network interfaces associated with an EC2 instance.
    /// </summary>
    public partial class AwsEc2NetworkInterfaceViolation
    {
        private List<string> _violatingSecurityGroups = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _violationTarget;

        /// <summary>
        /// Gets and sets the property ViolatingSecurityGroups. 
        /// <para>
        /// List of security groups that violate the rules specified in the primary security group
        /// of the Firewall Manager policy.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ViolatingSecurityGroups
        {
            get { return this._violatingSecurityGroups; }
            set { this._violatingSecurityGroups = value; }
        }

        // Check to see if ViolatingSecurityGroups property is set
        internal bool IsSetViolatingSecurityGroups()
        {
            return this._violatingSecurityGroups != null && (this._violatingSecurityGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ViolationTarget. 
        /// <para>
        /// The resource ID of the network interface.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string ViolationTarget
        {
            get { return this._violationTarget; }
            set { this._violationTarget = value; }
        }

        // Check to see if ViolationTarget property is set
        internal bool IsSetViolationTarget()
        {
            return this._violationTarget != null;
        }

    }
}