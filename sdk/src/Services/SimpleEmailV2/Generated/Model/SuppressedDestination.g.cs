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

namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// An object that contains information about an email address that is on the suppression
    /// list for your account or for a specific tenant.
    /// </summary>
    public partial class SuppressedDestination
    {
        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// An optional value that can contain additional information about the reasons that the
        /// address was added to the suppression list for your account or for a specific tenant.
        /// </para>
        /// </summary>
        public SuppressedDestinationAttributes Attributes { get; set; }

        /// <summary>
        /// Checks to see if the Attributes property is set.
        /// </summary>
        internal bool IsSetAttributes() => this.Attributes != null;

        /// <summary>
        /// Gets and sets the property EmailAddress. 
        /// <para>
        /// The email address that is on the suppression list for your account or for a specific
        /// tenant.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Checks to see if the EmailAddress property is set.
        /// </summary>
        internal bool IsSetEmailAddress() => this.EmailAddress != null;

        /// <summary>
        /// Gets and sets the property LastUpdateTime. 
        /// <para>
        /// The date and time when the suppressed destination was last updated, shown in Unix
        /// time format.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastUpdateTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdateTime property is set.
        /// </summary>
        internal bool IsSetLastUpdateTime() => this.LastUpdateTime.HasValue;

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// The reason that the address was added to the suppression list for your account or
        /// for a specific tenant.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SuppressionListReason Reason { get; set; }

        /// <summary>
        /// Checks to see if the Reason property is set.
        /// </summary>
        internal bool IsSetReason() => this.Reason != null;

        /// <summary>
        /// Gets and sets the property TenantName. 
        /// <para>
        /// The name of the tenant that the suppressed destination belongs to. This field is present
        /// only when the suppressed destination is on a tenant's suppression list.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string TenantName { get; set; }

        /// <summary>
        /// Checks to see if the TenantName property is set.
        /// </summary>
        internal bool IsSetTenantName() => this.TenantName != null;
    }
}
