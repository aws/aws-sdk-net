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
    /// Information about how to remediate a finding.
    /// </summary>
    public partial class Remediation
    {
        private Recommendation _recommendation;
        private List<SuggestedFix> _suggestedFixes = AWSConfigs.InitializeCollections ? new List<SuggestedFix>() : null;

        /// <summary>
        /// Gets and sets the property Recommendation. 
        /// <para>
        /// An object that contains information about the recommended course of action to remediate
        /// a finding.
        /// </para>
        /// </summary>
        public Recommendation Recommendation
        {
            get { return this._recommendation; }
            set { this._recommendation = value; }
        }

        // Check to see if Recommendation property is set
        internal bool IsSetRecommendation()
        {
            return this._recommendation != null;
        }

        /// <summary>
        /// Gets and sets the property SuggestedFixes. 
        /// <para>
        /// A list of <c>SuggestedFix</c> objects. Each object contains information about a suggested
        /// code fix to remediate the finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SuggestedFix> SuggestedFixes
        {
            get { return this._suggestedFixes; }
            set { this._suggestedFixes = value; }
        }

        // Check to see if SuggestedFixes property is set
        internal bool IsSetSuggestedFixes()
        {
            return this._suggestedFixes != null && (this._suggestedFixes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}