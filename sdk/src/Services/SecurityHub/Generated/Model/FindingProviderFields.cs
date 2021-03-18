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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// In a <code>BatchImportFindings</code> request, finding providers use <code>FindingProviderFields</code>
    /// to provide and update values for confidence, criticality, related findings, severity,
    /// and types.
    /// </summary>
    public partial class FindingProviderFields
    {
        private int? _confidence;
        private int? _criticality;
        private List<RelatedFinding> _relatedFindings = new List<RelatedFinding>();
        private FindingProviderSeverity _severity;
        private List<string> _types = new List<string>();

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
        public int Confidence
        {
            get { return this._confidence.GetValueOrDefault(); }
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
        public int Criticality
        {
            get { return this._criticality.GetValueOrDefault(); }
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
        /// </summary>
        public List<RelatedFinding> RelatedFindings
        {
            get { return this._relatedFindings; }
            set { this._relatedFindings = value; }
        }

        // Check to see if RelatedFindings property is set
        internal bool IsSetRelatedFindings()
        {
            return this._relatedFindings != null && this._relatedFindings.Count > 0; 
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
        /// One or more finding types in the format of <code>namespace/category/classifier</code>
        /// that classify a finding.
        /// </para>
        ///  
        /// <para>
        /// Valid namespace values are: Software and Configuration Checks | TTPs | Effects | Unusual
        /// Behaviors | Sensitive Data Identifications
        /// </para>
        /// </summary>
        public List<string> Types
        {
            get { return this._types; }
            set { this._types = value; }
        }

        // Check to see if Types property is set
        internal bool IsSetTypes()
        {
            return this._types != null && this._types.Count > 0; 
        }

    }
}