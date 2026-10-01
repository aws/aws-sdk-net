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
    /// This is the response object from the CreateScan operation.
    /// </summary>
    public partial class CreateScanResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The identifier for the resource object that contains resources that were scanned.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ResourceId ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;

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
    }
}
