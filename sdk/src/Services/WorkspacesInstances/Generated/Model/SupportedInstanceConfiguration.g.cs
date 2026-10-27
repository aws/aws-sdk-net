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
    /// Represents a single valid configuration combination that an instance type supports,
    /// combining tenancy, platform type, and billing mode into one complete configuration
    /// specification.
    /// </summary>
    public partial class SupportedInstanceConfiguration
    {
        /// <summary>
        /// Gets and sets the property BillingMode. 
        /// <para>
        /// Specifies the billing mode supported in this configuration combination.
        /// </para>
        /// </summary>
        public BillingMode BillingMode { get; set; }

        /// <summary>
        /// Checks to see if the BillingMode property is set.
        /// </summary>
        internal bool IsSetBillingMode() => this.BillingMode != null;

        /// <summary>
        /// Gets and sets the property PlatformType. 
        /// <para>
        /// Specifies the operating system platform supported in this configuration combination.
        /// </para>
        /// </summary>
        public PlatformTypeEnum PlatformType { get; set; }

        /// <summary>
        /// Checks to see if the PlatformType property is set.
        /// </summary>
        internal bool IsSetPlatformType() => this.PlatformType != null;

        /// <summary>
        /// Gets and sets the property Tenancy. 
        /// <para>
        /// Specifies the tenancy model supported in this configuration combination.
        /// </para>
        /// </summary>
        public InstanceConfigurationTenancyEnum Tenancy { get; set; }

        /// <summary>
        /// Checks to see if the Tenancy property is set.
        /// </summary>
        internal bool IsSetTenancy() => this.Tenancy != null;
    }
}
