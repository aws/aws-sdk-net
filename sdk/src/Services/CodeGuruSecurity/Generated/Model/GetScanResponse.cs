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
 * Do not modify this file. This file is generated from the codeguru-security-2018-05-10.normal.json service model.
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
        private AnalysisType _analysisType;
        private DateTime? _createdAt;
        private string _errorMessage;
        private long? _numberOfRevisions;
        private string _runId;
        private string _scanName;
        private string _scanNameArn;
        private ScanState _scanState;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property AnalysisType. 
        /// <para>
        /// The type of analysis CodeGuru Security performed in the scan, either <c>Security</c>
        /// or <c>All</c>. The <c>Security</c> type only generates findings related to security.
        /// The <c>All</c> type generates both security findings and quality findings.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AnalysisType AnalysisType
        {
            get { return this._analysisType; }
            set { this._analysisType = value; }
        }

        // Check to see if AnalysisType property is set
        internal bool IsSetAnalysisType()
        {
            return this._analysisType != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time the scan was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// Details about the error that causes a scan to fail to be retrieved.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property NumberOfRevisions. 
        /// <para>
        /// The number of times a scan has been re-run on a revised resource.
        /// </para>
        /// </summary>
        public long? NumberOfRevisions
        {
            get { return this._numberOfRevisions; }
            set { this._numberOfRevisions = value; }
        }

        // Check to see if NumberOfRevisions property is set
        internal bool IsSetNumberOfRevisions()
        {
            return this._numberOfRevisions.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RunId. 
        /// <para>
        /// UUID that identifies the individual scan run.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RunId
        {
            get { return this._runId; }
            set { this._runId = value; }
        }

        // Check to see if RunId property is set
        internal bool IsSetRunId()
        {
            return this._runId != null;
        }

        /// <summary>
        /// Gets and sets the property ScanName. 
        /// <para>
        /// The name of the scan.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=140)]
        public string ScanName
        {
            get { return this._scanName; }
            set { this._scanName = value; }
        }

        // Check to see if ScanName property is set
        internal bool IsSetScanName()
        {
            return this._scanName != null;
        }

        /// <summary>
        /// Gets and sets the property ScanNameArn. 
        /// <para>
        /// The ARN for the scan name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=300)]
        public string ScanNameArn
        {
            get { return this._scanNameArn; }
            set { this._scanNameArn = value; }
        }

        // Check to see if ScanNameArn property is set
        internal bool IsSetScanNameArn()
        {
            return this._scanNameArn != null;
        }

        /// <summary>
        /// Gets and sets the property ScanState. 
        /// <para>
        /// The current state of the scan. Returns either <c>InProgress</c>, <c>Successful</c>,
        /// or <c>Failed</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ScanState ScanState
        {
            get { return this._scanState; }
            set { this._scanState = value; }
        }

        // Check to see if ScanState property is set
        internal bool IsSetScanState()
        {
            return this._scanState != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The time when the scan was last updated. Only available for <c>STANDARD</c> scan types.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}