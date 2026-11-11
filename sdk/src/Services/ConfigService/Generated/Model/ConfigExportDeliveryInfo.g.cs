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

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Provides status of the delivery of the snapshot or the configuration history to the
    /// specified Amazon S3 bucket. Also provides the status of notifications about the Amazon
    /// S3 delivery to the specified Amazon SNS topic.
    /// </summary>
    public partial class ConfigExportDeliveryInfo
    {
        /// <summary>
        /// Gets and sets the property LastAttemptTime. 
        /// <para>
        /// The time of the last attempted delivery.
        /// </para>
        /// </summary>
        public DateTime? LastAttemptTime { get; set; }

        /// <summary>
        /// Checks to see if the LastAttemptTime property is set.
        /// </summary>
        internal bool IsSetLastAttemptTime() => this.LastAttemptTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastErrorCode. 
        /// <para>
        /// The error code from the last attempted delivery.
        /// </para>
        /// </summary>
        public string LastErrorCode { get; set; }

        /// <summary>
        /// Checks to see if the LastErrorCode property is set.
        /// </summary>
        internal bool IsSetLastErrorCode() => this.LastErrorCode != null;

        /// <summary>
        /// Gets and sets the property LastErrorMessage. 
        /// <para>
        /// The error message from the last attempted delivery.
        /// </para>
        /// </summary>
        public string LastErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the LastErrorMessage property is set.
        /// </summary>
        internal bool IsSetLastErrorMessage() => this.LastErrorMessage != null;

        /// <summary>
        /// Gets and sets the property LastStatus. 
        /// <para>
        /// Status of the last attempted delivery.
        /// </para>
        /// </summary>
        public DeliveryStatus LastStatus { get; set; }

        /// <summary>
        /// Checks to see if the LastStatus property is set.
        /// </summary>
        internal bool IsSetLastStatus() => this.LastStatus != null;

        /// <summary>
        /// Gets and sets the property LastSuccessfulTime. 
        /// <para>
        /// The time of the last successful delivery.
        /// </para>
        /// </summary>
        public DateTime? LastSuccessfulTime { get; set; }

        /// <summary>
        /// Checks to see if the LastSuccessfulTime property is set.
        /// </summary>
        internal bool IsSetLastSuccessfulTime() => this.LastSuccessfulTime.HasValue;

        /// <summary>
        /// Gets and sets the property NextDeliveryTime. 
        /// <para>
        /// The time that the next delivery occurs.
        /// </para>
        /// </summary>
        public DateTime? NextDeliveryTime { get; set; }

        /// <summary>
        /// Checks to see if the NextDeliveryTime property is set.
        /// </summary>
        internal bool IsSetNextDeliveryTime() => this.NextDeliveryTime.HasValue;
    }
}
