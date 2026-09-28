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
    /// Container for the parameters to the CreateScan operation. Use to create a scan using
    /// code uploaded to an Amazon S3 bucket.
    /// </summary>
    public partial class CreateScanRequest : AmazonCodeGuruSecurityRequest
    {
        /// <summary>
        /// Gets and sets the property AnalysisType. 
        /// <para>
        /// The type of analysis you want CodeGuru Security to perform in the scan, either <c>Security</c>
        /// or <c>All</c>. The <c>Security</c> type only generates findings related to security.
        /// The <c>All</c> type generates both security findings and quality findings. Defaults
        /// to <c>Security</c> type if missing.
        /// </para>
        /// </summary>
        public AnalysisType AnalysisType { get; set; }

        /// <summary>
        /// Checks to see if the AnalysisType property is set.
        /// </summary>
        internal bool IsSetAnalysisType() => this.AnalysisType != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The idempotency token for the request. Amazon CodeGuru Security uses this value to
        /// prevent the accidental creation of duplicate scans if there are failures and retries.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The identifier for the resource object to be scanned.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ResourceId ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;

        /// <summary>
        /// Gets and sets the property ScanName. 
        /// <para>
        /// The unique name that CodeGuru Security uses to track revisions across multiple scans
        /// of the same resource. Only allowed for a <c>STANDARD</c> scan type. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 140)]
        public string ScanName { get; set; }

        /// <summary>
        /// Checks to see if the ScanName property is set.
        /// </summary>
        internal bool IsSetScanName() => this.ScanName != null;

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
        public ScanType ScanType { get; set; }

        /// <summary>
        /// Checks to see if the ScanType property is set.
        /// </summary>
        internal bool IsSetScanType() => this.ScanType != null;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
