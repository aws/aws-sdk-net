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

namespace Amazon.WorkspacesInstances.Model
{
    /// <summary>
    /// Defines filtering criteria for WorkSpace Instance type searches. Combines multiple
    /// filter conditions including billing mode, platform type, and tenancy to help customers
    /// find instance types that meet their specific requirements.
    /// </summary>
    public partial class InstanceConfigurationFilter
    {
        /// <summary>
        /// Gets and sets the property BillingMode. 
        /// <para>
        /// Filters WorkSpace Instance types based on supported billing modes. Allows customers
        /// to search for instance types that support their preferred billing model, such as HOURLY
        /// or MONTHLY billing.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public BillingMode BillingMode { get; set; }

        /// <summary>
        /// Checks to see if the BillingMode property is set.
        /// </summary>
        internal bool IsSetBillingMode() => this.BillingMode != null;

        /// <summary>
        /// Gets and sets the property PlatformType. 
        /// <para>
        /// Filters WorkSpace Instance types by operating system platform. Allows customers to
        /// find instances that support their desired OS, such as Windows, Linux/UNIX, Ubuntu
        /// Pro, RHEL, or SUSE.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PlatformTypeEnum PlatformType { get; set; }

        /// <summary>
        /// Checks to see if the PlatformType property is set.
        /// </summary>
        internal bool IsSetPlatformType() => this.PlatformType != null;

        /// <summary>
        /// Gets and sets the property Tenancy. 
        /// <para>
        /// Filters WorkSpace Instance types by tenancy model. Allows customers to find instances
        /// that match their tenancy requirements, such as SHARED or DEDICATED.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public InstanceConfigurationTenancyEnum Tenancy { get; set; }

        /// <summary>
        /// Checks to see if the Tenancy property is set.
        /// </summary>
        internal bool IsSetTenancy() => this.Tenancy != null;
    }
}
