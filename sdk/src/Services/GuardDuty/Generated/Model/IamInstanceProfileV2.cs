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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains information about the IAM instance profile involved in a GuardDuty finding,
    /// including unique identifiers of the Amazon EC2 instances.
    /// </summary>
    public partial class IamInstanceProfileV2
    {
        private List<string> _ec2InstanceUids = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Ec2InstanceUids. 
        /// <para>
        /// A list of unique identifiers for the compromised Amazon EC2 instances that share the
        /// same IAM instance profile.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=25)]
        public List<string> Ec2InstanceUids
        {
            get { return this._ec2InstanceUids; }
            set { this._ec2InstanceUids = value; }
        }

        // Check to see if Ec2InstanceUids property is set
        internal bool IsSetEc2InstanceUids()
        {
            return this._ec2InstanceUids != null && (this._ec2InstanceUids.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}