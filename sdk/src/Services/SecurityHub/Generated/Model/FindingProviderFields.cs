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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// In a <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/API_BatchImportFindings.html">
    /// <c>BatchImportFindings</c> </a> request, finding providers use <c>FindingProviderFields</c>
    /// to provide and update values for the following fields:
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <c>Confidence</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>Criticality</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>RelatedFindings</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>Severity</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>Types</c> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// The preceding fields are nested under the <c>FindingProviderFields</c> object, but
    /// also have analogues of the same name as top-level ASFF fields. When a new finding
    /// is sent to Security Hub by a finding provider, Security Hub populates the <c>FindingProviderFields</c>
    /// object automatically, if it is empty, based on the corresponding top-level fields.
    /// </para>
    ///  
    /// <para>
    /// Finding providers can update <c>FindingProviderFields</c> only by using the <c>BatchImportFindings</c>
    /// operation. Finding providers can't update this object with the <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/API_BatchUpdateFindings.html">
    /// <c>BatchUpdateFindings</c> </a> operation. Customers can update the top-level fields
    /// by using the <c>BatchUpdateFindings</c> operation. Customers can't update <c>FindingProviderFields</c>.
    /// </para>
    ///  
    /// <para>
    /// For information about how Security Hub handles updates from <c>BatchImportFindings</c>
    /// to <c>FindingProviderFields</c> and to the corresponding top-level attributes, see
    /// <a href="https://docs.aws.amazon.com/securityhub/latest/userguide/finding-update-batchimportfindings.html#batchimportfindings-findingproviderfields">Using
    /// <c>FindingProviderFields</c> </a> in the <i>Security Hub User Guide</i>.
    /// </para>
    /// </summary>
    public partial class FindingProviderFields
    {
        private int? _confidence;
        private int? _criticality;
        private List<RelatedFinding> _relatedFindings = AWSConfigs.InitializeCollections ? new List<RelatedFinding>() : null;
        private FindingProviderSeverity _severity;
        private List<string> _types = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Confidence. 
        /// <para>
        /// A finding's confidence. Confidence is defined as the likelihood that a finding accurately
        /// identifies the behavior or issue that it was intended to identify.
        /// </para>
        ///  
        /// <para>
        /// Confidence is scored on a 0-100 basis using a ratio scale, where 0 means zero percent
        /// confidence and 100 means 100 percent confidence.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public int? Confidence
        {
            get { return this._confidence; }
            set { this._confidence = value; }
        }

        // Check to see if Confidence property is set
        internal bool IsSetConfidence()
        {
            return this._confidence.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Criticality. 
        /// <para>
        /// The level of importance assigned to the resources associated with the finding.
        /// </para>
        ///  
        /// <para>
        /// A score of 0 means that the underlying resources have no criticality, and a score
        /// of 100 is reserved for the most critical resources.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public int? Criticality
        {
            get { return this._criticality; }
            set { this._criticality = value; }
        }

        // Check to see if Criticality property is set
        internal bool IsSetCriticality()
        {
            return this._criticality.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RelatedFindings. 
        /// <para>
        /// A list of findings that are related to the current finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RelatedFinding> RelatedFindings
        {
            get { return this._relatedFindings; }
            set { this._relatedFindings = value; }
        }

        // Check to see if RelatedFindings property is set
        internal bool IsSetRelatedFindings()
        {
            return this._relatedFindings != null && (this._relatedFindings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        /// The severity of a finding.
        /// </para>
        /// </summary>
        public FindingProviderSeverity Severity
        {
            get { return this._severity; }
            set { this._severity = value; }
        }

        // Check to see if Severity property is set
        internal bool IsSetSeverity()
        {
            return this._severity != null;
        }

        /// <summary>
        /// Gets and sets the property Types. 
        /// <para>
        /// One or more finding types in the format of <c>namespace/category/classifier</c> that
        /// classify a finding.
        /// </para>
        ///  
        /// <para>
        /// Valid namespace values are: Software and Configuration Checks | TTPs | Effects | Unusual
        /// Behaviors | Sensitive Data Identifications
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Types
        {
            get { return this._types; }
            set { this._types = value; }
        }

        // Check to see if Types property is set
        internal bool IsSetTypes()
        {
            return this._types != null && (this._types.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}