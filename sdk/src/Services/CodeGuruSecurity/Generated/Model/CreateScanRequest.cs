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
    /// Container for the parameters to the CreateScan operation.
    /// Use to create a scan using code uploaded to an Amazon S3 bucket.
    /// </summary>
    public partial class CreateScanRequest : AmazonCodeGuruSecurityRequest
    {
        private AnalysisType _analysisType;
        private string _clientToken;
        private ResourceId _resourceId;
        private string _scanName;
        private ScanType _scanType;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property AnalysisType. 
        /// <para>
        /// The type of analysis you want CodeGuru Security to perform in the scan, either <c>Security</c>
        /// or <c>All</c>. The <c>Security</c> type only generates findings related to security.
        /// The <c>All</c> type generates both security findings and quality findings. Defaults
        /// to <c>Security</c> type if missing.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The idempotency token for the request. Amazon CodeGuru Security uses this value to
        /// prevent the accidental creation of duplicate scans if there are failures and retries.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The identifier for the resource object to be scanned.
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
        /// Gets and sets the property ScanName. 
        /// <para>
        /// The unique name that CodeGuru Security uses to track revisions across multiple scans
        /// of the same resource. Only allowed for a <c>STANDARD</c> scan type. 
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
        /// Gets and sets the property ScanType. 
        /// <para>
        /// The type of scan, either <c>Standard</c> or <c>Express</c>. Defaults to <c>Standard</c>
        /// type if missing.
        /// </para>
        ///  
        /// <para>
        ///  <c>Express</c> scans run on limited resources and use a limited set of detectors
        /// to analyze your code in near-real time. <c>Standard</c> scans have standard resource
        /// limits and use the full set of detectors to analyze your code.
        /// </para>
        /// </summary>
        public ScanType ScanType
        {
            get { return this._scanType; }
            set { this._scanType = value; }
        }

        // Check to see if ScanType property is set
        internal bool IsSetScanType()
        {
            return this._scanType != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of key-value pairs used to tag a scan. A tag is a custom attribute label
        /// with two parts:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A tag key. For example, <c>CostCenter</c>, <c>Environment</c>, or <c>Secret</c>. Tag
        /// keys are case sensitive.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An optional tag value field. For example, <c>111122223333</c>, <c>Production</c>,
        /// or a team name. Omitting the tag value is the same as using an empty string. Tag values
        /// are case sensitive.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}