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

namespace Amazon.FraudDetector.Model
{
    /// <summary>
    /// The summary of the detector version.
    /// </summary>
    public partial class DetectorVersionSummary
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The detector version description. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DetectorVersionId. 
        /// <para>
        /// The detector version ID. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public string DetectorVersionId { get; set; }

        /// <summary>
        /// Checks to see if the DetectorVersionId property is set.
        /// </summary>
        internal bool IsSetDetectorVersionId() => this.DetectorVersionId != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// Timestamp of when the detector version was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 11, Max = 30)]
        public string LastUpdatedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTime() => this.LastUpdatedTime != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The detector version status. 
        /// </para>
        /// </summary>
        public DetectorVersionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
