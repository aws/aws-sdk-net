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
    /// This is the response object from the CreateScan operation.
    /// </summary>
    public partial class CreateScanResponse : AmazonWebServiceResponse
    {
        private ResourceId _resourceId;
        private string _runId;
        private string _scanName;
        private string _scanNameArn;
        private ScanState _scanState;

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The identifier for the resource object that contains resources that were scanned.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ResourceId ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
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

    }
}