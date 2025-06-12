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
 * Do not modify this file. This file is generated from the ecr-2015-09-21.normal.json service model.
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
namespace Amazon.ECR.Model
{
    /// <summary>
    /// The details of an image scan.
    /// </summary>
    public partial class ImageScanFindings
    {
        private List<EnhancedImageScanFinding> _enhancedFindings = AWSConfigs.InitializeCollections ? new List<EnhancedImageScanFinding>() : null;
        private List<ImageScanFinding> _findings = AWSConfigs.InitializeCollections ? new List<ImageScanFinding>() : null;
        private Dictionary<string, int> _findingSeverityCounts = AWSConfigs.InitializeCollections ? new Dictionary<string, int>() : null;
        private DateTime? _imageScanCompletedAt;
        private DateTime? _vulnerabilitySourceUpdatedAt;

        /// <summary>
        /// Gets and sets the property EnhancedFindings. 
        /// <para>
        /// Details about the enhanced scan findings from Amazon Inspector.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EnhancedImageScanFinding> EnhancedFindings
        {
            get { return this._enhancedFindings; }
            set { this._enhancedFindings = value; }
        }

        // Check to see if EnhancedFindings property is set
        internal bool IsSetEnhancedFindings()
        {
            return this._enhancedFindings != null && (this._enhancedFindings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Findings. 
        /// <para>
        /// The findings from the image scan.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ImageScanFinding> Findings
        {
            get { return this._findings; }
            set { this._findings = value; }
        }

        // Check to see if Findings property is set
        internal bool IsSetFindings()
        {
            return this._findings != null && (this._findings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FindingSeverityCounts. 
        /// <para>
        /// The image vulnerability counts, sorted by severity.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, int> FindingSeverityCounts
        {
            get { return this._findingSeverityCounts; }
            set { this._findingSeverityCounts = value; }
        }

        // Check to see if FindingSeverityCounts property is set
        internal bool IsSetFindingSeverityCounts()
        {
            return this._findingSeverityCounts != null && (this._findingSeverityCounts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ImageScanCompletedAt. 
        /// <para>
        /// The time of the last completed image scan.
        /// </para>
        /// </summary>
        public DateTime? ImageScanCompletedAt
        {
            get { return this._imageScanCompletedAt; }
            set { this._imageScanCompletedAt = value; }
        }

        // Check to see if ImageScanCompletedAt property is set
        internal bool IsSetImageScanCompletedAt()
        {
            return this._imageScanCompletedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VulnerabilitySourceUpdatedAt. 
        /// <para>
        /// The time when the vulnerability data was last scanned.
        /// </para>
        /// </summary>
        public DateTime? VulnerabilitySourceUpdatedAt
        {
            get { return this._vulnerabilitySourceUpdatedAt; }
            set { this._vulnerabilitySourceUpdatedAt = value; }
        }

        // Check to see if VulnerabilitySourceUpdatedAt property is set
        internal bool IsSetVulnerabilitySourceUpdatedAt()
        {
            return this._vulnerabilitySourceUpdatedAt.HasValue; 
        }

    }
}