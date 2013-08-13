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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// <para> Contains Availability Zone information. </para> <para> This data type is used as an element in the following data type:
    /// <ul>
    /// <li> OrderableDBInstanceOption </li>
    /// 
    /// </ul>
    /// </para>
    /// </summary>
    public class AvailabilityZone
    {
        
        private string name;
        private bool? provisionedIopsCapable;

        /// <summary>
        /// The name of the availability zone.
        ///  
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        /// <summary>
        /// Sets the Name property
        /// </summary>
        /// <param name="name">The value to set for the Name property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AvailabilityZone WithName(string name)
        {
            this.name = name;
            return this;
        }
            

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this.name != null;
        }

        /// <summary>
        /// True indicates the availability zone is capable of provisioned IOPs.
        ///  
        /// </summary>
        public bool ProvisionedIopsCapable
        {
            get { return this.provisionedIopsCapable ?? default(bool); }
            set { this.provisionedIopsCapable = value; }
        }

        /// <summary>
        /// Sets the ProvisionedIopsCapable property
        /// </summary>
        /// <param name="provisionedIopsCapable">The value to set for the ProvisionedIopsCapable property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AvailabilityZone WithProvisionedIopsCapable(bool provisionedIopsCapable)
        {
            this.provisionedIopsCapable = provisionedIopsCapable;
            return this;
        }
            

        // Check to see if ProvisionedIopsCapable property is set
        internal bool IsSetProvisionedIopsCapable()
        {
            return this.provisionedIopsCapable.HasValue;
        }
    }
}
