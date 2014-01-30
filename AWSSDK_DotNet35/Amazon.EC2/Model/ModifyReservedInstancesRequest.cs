/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para>Modifies the Availability Zone, instance count, instance type, or network platform (EC2-Classic or EC2-VPC) of your Reserved
    /// Instances. The Reserved Instances to be modified must be identical, except for Availability Zone, network platform, and instance
    /// type.</para>
    /// </summary>
    public partial class ModifyReservedInstancesRequest : AmazonEC2Request
    {
        private string clientToken;
        private List<string> reservedInstancesIds = new List<string>();
        private List<ReservedInstancesConfiguration> targetConfigurations = new List<ReservedInstancesConfiguration>();


        /// <summary>
        /// A unique, case-sensitive token you provide to ensure idempotency of your modification request.
        ///  
        /// </summary>
        public string ClientToken
        {
            get { return this.clientToken; }
            set { this.clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this.clientToken != null;
        }

        /// <summary>
        /// The IDs of the Reserved Instances to modify.
        ///  
        /// </summary>
        public List<string> ReservedInstancesIds
        {
            get { return this.reservedInstancesIds; }
            set { this.reservedInstancesIds = value; }
        }

        // Check to see if ReservedInstancesIds property is set
        internal bool IsSetReservedInstancesIds()
        {
            return this.reservedInstancesIds.Count > 0;
        }

        /// <summary>
        /// The configuration settings for the Reserved Instances to modify.
        ///  
        /// </summary>
        public List<ReservedInstancesConfiguration> TargetConfigurations
        {
            get { return this.targetConfigurations; }
            set { this.targetConfigurations = value; }
        }

        // Check to see if TargetConfigurations property is set
        internal bool IsSetTargetConfigurations()
        {
            return this.targetConfigurations.Count > 0;
        }

    }
}
    
