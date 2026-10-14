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

namespace Amazon.LicenseManager.Model
{
    /// <summary>
    /// Describes a resource entitled for use with a license.
    /// </summary>
    public partial class Entitlement
    {
        /// <summary>
        /// Gets and sets the property AllowCheckIn. 
        /// <para>
        /// Indicates whether check-ins are allowed.
        /// </para>
        /// </summary>
        public bool? AllowCheckIn { get; set; }

        /// <summary>
        /// Checks to see if the AllowCheckIn property is set.
        /// </summary>
        internal bool IsSetAllowCheckIn() => this.AllowCheckIn.HasValue;

        /// <summary>
        /// Gets and sets the property MaxCount. 
        /// <para>
        /// Maximum entitlement count. Use if the unit is not None.
        /// </para>
        /// </summary>
        public long? MaxCount { get; set; }

        /// <summary>
        /// Checks to see if the MaxCount property is set.
        /// </summary>
        internal bool IsSetMaxCount() => this.MaxCount.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Entitlement name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Overage. 
        /// <para>
        /// Indicates whether overages are allowed.
        /// </para>
        /// </summary>
        public bool? Overage { get; set; }

        /// <summary>
        /// Checks to see if the Overage property is set.
        /// </summary>
        internal bool IsSetOverage() => this.Overage.HasValue;

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        /// Entitlement unit.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EntitlementUnit Unit { get; set; }

        /// <summary>
        /// Checks to see if the Unit property is set.
        /// </summary>
        internal bool IsSetUnit() => this.Unit != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// Entitlement resource. Use only if the unit is None.
        /// </para>
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
