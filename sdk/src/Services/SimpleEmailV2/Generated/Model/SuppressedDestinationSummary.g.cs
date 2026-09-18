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
    /// A summary that describes the suppressed email address.
    /// </summary>
    public partial class SuppressedDestinationSummary
    {
        /// <summary>
        /// Gets and sets the property EmailAddress. 
        /// <para>
        /// The email address that's on the suppression list for your account or for a specific
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
    }
}
