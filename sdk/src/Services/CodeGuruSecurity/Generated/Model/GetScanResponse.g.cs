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
    /// This is the response object from the GetScan operation.
    /// </summary>
    public partial class GetScanResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AnalysisType. 
        /// <para>
        /// The type of analysis CodeGuru Security performed in the scan, either <c>Security</c>
        /// or <c>All</c>. The <c>Security</c> type only generates findings related to security.
        /// The <c>All</c> type generates both security findings and quality findings.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AnalysisType AnalysisType { get; set; }

        /// <summary>
        /// Checks to see if the AnalysisType property is set.
        /// </summary>
        internal bool IsSetAnalysisType() => this.AnalysisType != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time the scan was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// Details about the error that causes a scan to fail to be retrieved.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;

        /// <summary>
        /// Gets and sets the property NumberOfRevisions. 
        /// <para>
        /// The number of times a scan has been re-run on a revised resource.
        /// </para>
        /// </summary>
        public long? NumberOfRevisions { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfRevisions property is set.
        /// </summary>
        internal bool IsSetNumberOfRevisions() => this.NumberOfRevisions.HasValue;

        /// <summary>
        /// Gets and sets the property RunId. 
        /// <para>
        /// UUID that identifies the individual scan run.
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
        /// The current state of the scan. Returns either <c>InProgress</c>, <c>Successful</c>,
        /// or <c>Failed</c>.
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
        /// The time when the scan was last updated. Only available for <c>STANDARD</c> scan types.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
