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
 * Do not modify this file. This file is generated from the accessanalyzer-2019-11-01.normal.json service model.
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
namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// A finding in a policy. Each finding is an actionable recommendation that can be used
    /// to improve the policy.
    /// </summary>
    public partial class ValidatePolicyFinding
    {
        private string _findingDetails;
        private ValidatePolicyFindingType _findingType;
        private string _issueCode;
        private string _learnMoreLink;
        private List<Location> _locations = AWSConfigs.InitializeCollections ? new List<Location>() : null;

        /// <summary>
        /// Gets and sets the property FindingDetails. 
        /// <para>
        /// A localized message that explains the finding and provides guidance on how to address
        /// it.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FindingDetails
        {
            get { return this._findingDetails; }
            set { this._findingDetails = value; }
        }

        // Check to see if FindingDetails property is set
        internal bool IsSetFindingDetails()
        {
            return this._findingDetails != null;
        }

        /// <summary>
        /// Gets and sets the property FindingType. 
        /// <para>
        /// The impact of the finding.
        /// </para>
        ///  
        /// <para>
        /// Security warnings report when the policy allows access that we consider overly permissive.
        /// </para>
        ///  
        /// <para>
        /// Errors report when a part of the policy is not functional.
        /// </para>
        ///  
        /// <para>
        /// Warnings report non-security issues when a policy does not conform to policy writing
        /// best practices.
        /// </para>
        ///  
        /// <para>
        /// Suggestions recommend stylistic improvements in the policy that do not impact access.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ValidatePolicyFindingType FindingType
        {
            get { return this._findingType; }
            set { this._findingType = value; }
        }

        // Check to see if FindingType property is set
        internal bool IsSetFindingType()
        {
            return this._findingType != null;
        }

        /// <summary>
        /// Gets and sets the property IssueCode. 
        /// <para>
        /// The issue code provides an identifier of the issue associated with this finding.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string IssueCode
        {
            get { return this._issueCode; }
            set { this._issueCode = value; }
        }

        // Check to see if IssueCode property is set
        internal bool IsSetIssueCode()
        {
            return this._issueCode != null;
        }

        /// <summary>
        /// Gets and sets the property LearnMoreLink. 
        /// <para>
        /// A link to additional documentation about the type of finding.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string LearnMoreLink
        {
            get { return this._learnMoreLink; }
            set { this._learnMoreLink = value; }
        }

        // Check to see if LearnMoreLink property is set
        internal bool IsSetLearnMoreLink()
        {
            return this._learnMoreLink != null;
        }

        /// <summary>
        /// Gets and sets the property Locations. 
        /// <para>
        /// The list of locations in the policy document that are related to the finding. The
        /// issue code provides a summary of an issue identified by the finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Location> Locations
        {
            get { return this._locations; }
            set { this._locations = value; }
        }

        // Check to see if Locations property is set
        internal bool IsSetLocations()
        {
            return this._locations != null && (this._locations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}