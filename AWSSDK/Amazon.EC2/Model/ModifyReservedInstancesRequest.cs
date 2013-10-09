/*******************************************************************************
 * Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
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
    /// Modifies the Availability Zone, instance count, instance type, or network platform (EC2-Classic or EC2-VPC) of
    /// your Reserved Instances.
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class ModifyReservedInstancesRequest : EC2Request
    {
        private string clientTokenField;
        private List<string> reservedInstancesIdsField;
        private List<ReservedInstancesConfiguration> targetConfigurationsField;

        /// <summary>
        /// A unique, case-sensitive, token you provide to ensure idempotency of your modification request.
        ///  
        /// </summary>
        [XmlElementAttribute(ElementName = "ClientToken")]
        public string ClientToken
        {
            get { return this.clientTokenField; }
            set { this.clientTokenField = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this.clientTokenField != null;
        }

        /// <summary>
        /// The IDs of the Reserved Instances to modify.
        ///  
        /// </summary>
        [XmlElementAttribute(ElementName = "ReservedInstancesIds")]
        public List<string> ReservedInstancesIds
        {
            get
            {
                if (this.reservedInstancesIdsField == null)
                    this.reservedInstancesIdsField = new List<string>();
                return this.reservedInstancesIdsField;
            }
            set { this.reservedInstancesIdsField = value; }
        }

        // Check to see if ReservedInstancesIds property is set
        internal bool IsSetReservedInstancesIds()
        {
            return this.ReservedInstancesIds.Count > 0;
        }

        /// <summary>
        /// The configuration settings for the Reserved Instances to modify.
        ///  
        /// </summary>
        [XmlElementAttribute(ElementName = "TargetConfigurations")]
        public List<ReservedInstancesConfiguration> TargetConfigurations
        {
            get
            {
                if (this.targetConfigurationsField == null)
                    this.targetConfigurationsField = new List<ReservedInstancesConfiguration>();
                return this.targetConfigurationsField;
            }
            set { this.targetConfigurationsField = value; }
        }

        // Check to see if TargetConfigurations property is set
        internal bool IsSetTargetConfigurations()
        {
            return this.TargetConfigurations.Count > 0;
        }

    }
}
    
