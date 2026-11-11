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
    /// A list that contains the status of the delivery of the configuration stream notification
    /// to the Amazon SNS topic.
    /// </summary>
    public partial class ConfigStreamDeliveryInfo
    {
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
        ///  
        /// <para>
        ///  <b>Note</b> Providing an SNS topic on a <a href="https://docs.aws.amazon.com/config/latest/APIReference/API_DeliveryChannel.html">DeliveryChannel</a>
        /// for Config is optional. If the SNS delivery is turned off, the last status will be
        /// <b>Not_Applicable</b>.
        /// </para>
        /// </summary>
        public DeliveryStatus LastStatus { get; set; }

        /// <summary>
        /// Checks to see if the LastStatus property is set.
        /// </summary>
        internal bool IsSetLastStatus() => this.LastStatus != null;

        /// <summary>
        /// Gets and sets the property LastStatusChangeTime. 
        /// <para>
        /// The time from the last status change.
        /// </para>
        /// </summary>
        public DateTime? LastStatusChangeTime { get; set; }

        /// <summary>
        /// Checks to see if the LastStatusChangeTime property is set.
        /// </summary>
        internal bool IsSetLastStatusChangeTime() => this.LastStatusChangeTime.HasValue;
    }
}
