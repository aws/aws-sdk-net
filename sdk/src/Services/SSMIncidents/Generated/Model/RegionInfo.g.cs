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

namespace Amazon.SSMIncidents.Model
{
    /// <summary>
    /// Information about a Amazon Web Services Region in your replication set.
    /// </summary>
    public partial class RegionInfo
    {
        /// <summary>
        /// Gets and sets the property SseKmsKeyId. 
        /// <para>
        /// The ID of the KMS key used to encrypt the data in this Amazon Web Services Region.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 2048)]
        public string SseKmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the SseKmsKeyId property is set.
        /// </summary>
        internal bool IsSetSseKmsKeyId() => this.SseKmsKeyId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the Amazon Web Services Region in the replication set.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RegionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// Information displayed about the status of the Amazon Web Services Region.
        /// </para>
        /// </summary>
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;

        /// <summary>
        /// Gets and sets the property StatusUpdateDateTime. 
        /// <para>
        /// The timestamp for when Incident Manager updated the status of the Amazon Web Services
        /// Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StatusUpdateDateTime { get; set; }

        /// <summary>
        /// Checks to see if the StatusUpdateDateTime property is set.
        /// </summary>
        internal bool IsSetStatusUpdateDateTime() => this.StatusUpdateDateTime.HasValue;
    }
}
