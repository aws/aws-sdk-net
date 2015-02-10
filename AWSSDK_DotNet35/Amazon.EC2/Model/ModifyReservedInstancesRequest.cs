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
 * Do not modify this file. This file is generated from the ec2-2014-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyReservedInstances operation.
    /// Modifies the Availability Zone, instance count, instance type, or network platform
    /// (EC2-Classic or EC2-VPC) of your Reserved Instances. The Reserved Instances to be
    /// modified must be identical, except for Availability Zone, network platform, and instance
    /// type.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-modifying.html">Modifying
    /// Reserved Instances</a> in the Amazon Elastic Compute Cloud User Guide for Linux.
    /// </para>
    /// </summary>
    public partial class ModifyReservedInstancesRequest : AmazonEC2Request
    {
        private string _clientToken;
        private List<string> _reservedInstancesIds = new List<string>();
        private List<ReservedInstancesConfiguration> _targetConfigurations = new List<ReservedInstancesConfiguration>();

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive token you provide to ensure idempotency of your modification
        /// request.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property ReservedInstancesIds. 
        /// <para>
        /// The IDs of the Reserved Instances to modify.
        /// </para>
        /// </summary>
        public List<string> ReservedInstancesIds
        {
            get { return this._reservedInstancesIds; }
            set { this._reservedInstancesIds = value; }
        }

        // Check to see if ReservedInstancesIds property is set
        internal bool IsSetReservedInstancesIds()
        {
            return this._reservedInstancesIds != null && this._reservedInstancesIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TargetConfigurations. 
        /// <para>
        /// The configuration settings for the Reserved Instances to modify.
        /// </para>
        /// </summary>
        public List<ReservedInstancesConfiguration> TargetConfigurations
        {
            get { return this._targetConfigurations; }
            set { this._targetConfigurations = value; }
        }

        // Check to see if TargetConfigurations property is set
        internal bool IsSetTargetConfigurations()
        {
            return this._targetConfigurations != null && this._targetConfigurations.Count > 0; 
        }

    }
}