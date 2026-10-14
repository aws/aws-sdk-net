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

namespace Amazon.PaymentCryptography.Model
{
    /// <summary>
    /// The status of an MPA session.
    /// </summary>
    public partial class MpaStatus
    {
        /// <summary>
        /// Gets and sets the property InitiationDate. 
        /// <para>
        /// The date and time when the MPA session was initiated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? InitiationDate { get; set; }

        /// <summary>
        /// Checks to see if the InitiationDate property is set.
        /// </summary>
        internal bool IsSetInitiationDate() => this.InitiationDate.HasValue;

        /// <summary>
        /// Gets and sets the property MpaSessionArn. 
        /// <para>
        /// The ARN of the MPA session.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string MpaSessionArn { get; set; }

        /// <summary>
        /// Checks to see if the MpaSessionArn property is set.
        /// </summary>
        internal bool IsSetMpaSessionArn() => this.MpaSessionArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the MPA session.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SessionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// The message providing additional information about the MPA session status.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 1000)]
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;
    }
}
