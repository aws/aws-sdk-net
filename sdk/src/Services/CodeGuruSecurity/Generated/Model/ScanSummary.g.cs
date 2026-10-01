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

namespace Amazon.CodeGuruSecurity.Model
{
    /// <summary>
    /// Information about a scan.
    /// </summary>
    public partial class ScanSummary
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        ///  The time when the scan was created. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property RunId. 
        /// <para>
        /// The identifier for the scan run. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RunId { get; set; }

        /// <summary>
        /// Checks to see if the RunId property is set.
        /// </summary>
        internal bool IsSetRunId() => this.RunId != null;

        /// <summary>
        /// Gets and sets the property ScanName. 
        /// <para>
        /// The name of the scan. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 140)]
        public string ScanName { get; set; }

        /// <summary>
        /// Checks to see if the ScanName property is set.
        /// </summary>
        internal bool IsSetScanName() => this.ScanName != null;

        /// <summary>
        /// Gets and sets the property ScanNameArn. 
        /// <para>
        /// The ARN for the scan name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 300)]
        public string ScanNameArn { get; set; }

        /// <summary>
        /// Checks to see if the ScanNameArn property is set.
        /// </summary>
        internal bool IsSetScanNameArn() => this.ScanNameArn != null;

        /// <summary>
        /// Gets and sets the property ScanState. 
        /// <para>
        /// The state of the scan. A scan can be <c>In Progress</c>, <c>Complete</c>, or <c>Failed</c>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ScanState ScanState { get; set; }

        /// <summary>
        /// Checks to see if the ScanState property is set.
        /// </summary>
        internal bool IsSetScanState() => this.ScanState != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The time the scan was last updated. A scan is updated when it is re-run.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
