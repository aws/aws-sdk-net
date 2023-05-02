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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a network insights analysis.
    /// </summary>
    public partial class NetworkInsightsAnalysis
    {
        private List<string> _additionalAccounts = new List<string>();
        private List<AlternatePathHint> _alternatePathHints = new List<AlternatePathHint>();
        private List<Explanation> _explanations = new List<Explanation>();
        private List<string> _filterInArns = new List<string>();
        private List<PathComponent> _forwardPathComponents = new List<PathComponent>();
        private string _networkInsightsAnalysisArn;
        private string _networkInsightsAnalysisId;
        private string _networkInsightsPathId;
        private bool? _networkPathFound;
        private List<PathComponent> _returnPathComponents = new List<PathComponent>();
        private DateTime? _startDate;
        private AnalysisStatus _status;
        private string _statusMessage;
        private List<string> _suggestedAccounts = new List<string>();
        private List<Tag> _tags = new List<Tag>();
        private string _warningMessage;

        /// <summary>
        /// Gets and sets the property AdditionalAccounts. 
        /// <para>
        /// The member accounts that contain resources that the path can traverse.
        /// </para>
        /// </summary>
        public List<string> AdditionalAccounts
        {
            get { return this._additionalAccounts; }
            set { this._additionalAccounts = value; }
        }

        // Check to see if AdditionalAccounts property is set
        internal bool IsSetAdditionalAccounts()
        {
            return this._additionalAccounts != null && this._additionalAccounts.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AlternatePathHints. 
        /// <para>
        /// Potential intermediate components.
        /// </para>
        /// </summary>
        public List<AlternatePathHint> AlternatePathHints
        {
            get { return this._alternatePathHints; }
            set { this._alternatePathHints = value; }
        }

        // Check to see if AlternatePathHints property is set
        internal bool IsSetAlternatePathHints()
        {
            return this._alternatePathHints != null && this._alternatePathHints.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Explanations. 
        /// <para>
        /// The explanations. For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/reachability/explanation-codes.html">Reachability
        /// Analyzer explanation codes</a>.
        /// </para>
        /// </summary>
        public List<Explanation> Explanations
        {
            get { return this._explanations; }
            set { this._explanations = value; }
        }

        // Check to see if Explanations property is set
        internal bool IsSetExplanations()
        {
            return this._explanations != null && this._explanations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FilterInArns. 
        /// <para>
        /// The Amazon Resource Names (ARN) of the resources that the path must traverse.
        /// </para>
        /// </summary>
        public List<string> FilterInArns
        {
            get { return this._filterInArns; }
            set { this._filterInArns = value; }
        }

        // Check to see if FilterInArns property is set
        internal bool IsSetFilterInArns()
        {
            return this._filterInArns != null && this._filterInArns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ForwardPathComponents. 
        /// <para>
        /// The components in the path from source to destination.
        /// </para>
        /// </summary>
        public List<PathComponent> ForwardPathComponents
        {
            get { return this._forwardPathComponents; }
            set { this._forwardPathComponents = value; }
        }

        // Check to see if ForwardPathComponents property is set
        internal bool IsSetForwardPathComponents()
        {
            return this._forwardPathComponents != null && this._forwardPathComponents.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NetworkInsightsAnalysisArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the network insights analysis.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1283)]
        public string NetworkInsightsAnalysisArn
        {
            get { return this._networkInsightsAnalysisArn; }
            set { this._networkInsightsAnalysisArn = value; }
        }

        // Check to see if NetworkInsightsAnalysisArn property is set
        internal bool IsSetNetworkInsightsAnalysisArn()
        {
            return this._networkInsightsAnalysisArn != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkInsightsAnalysisId. 
        /// <para>
        /// The ID of the network insights analysis.
        /// </para>
        /// </summary>
        public string NetworkInsightsAnalysisId
        {
            get { return this._networkInsightsAnalysisId; }
            set { this._networkInsightsAnalysisId = value; }
        }

        // Check to see if NetworkInsightsAnalysisId property is set
        internal bool IsSetNetworkInsightsAnalysisId()
        {
            return this._networkInsightsAnalysisId != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkInsightsPathId. 
        /// <para>
        /// The ID of the path.
        /// </para>
        /// </summary>
        public string NetworkInsightsPathId
        {
            get { return this._networkInsightsPathId; }
            set { this._networkInsightsPathId = value; }
        }

        // Check to see if NetworkInsightsPathId property is set
        internal bool IsSetNetworkInsightsPathId()
        {
            return this._networkInsightsPathId != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkPathFound. 
        /// <para>
        /// Indicates whether the destination is reachable from the source.
        /// </para>
        /// </summary>
        public bool NetworkPathFound
        {
            get { return this._networkPathFound.GetValueOrDefault(); }
            set { this._networkPathFound = value; }
        }

        // Check to see if NetworkPathFound property is set
        internal bool IsSetNetworkPathFound()
        {
            return this._networkPathFound.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReturnPathComponents. 
        /// <para>
        /// The components in the path from destination to source.
        /// </para>
        /// </summary>
        public List<PathComponent> ReturnPathComponents
        {
            get { return this._returnPathComponents; }
            set { this._returnPathComponents = value; }
        }

        // Check to see if ReturnPathComponents property is set
        internal bool IsSetReturnPathComponents()
        {
            return this._returnPathComponents != null && this._returnPathComponents.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StartDate. 
        /// <para>
        /// The time the analysis started.
        /// </para>
        /// </summary>
        public DateTime StartDate
        {
            get { return this._startDate.GetValueOrDefault(); }
            set { this._startDate = value; }
        }

        // Check to see if StartDate property is set
        internal bool IsSetStartDate()
        {
            return this._startDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the network insights analysis.
        /// </para>
        /// </summary>
        public AnalysisStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// The status message, if the status is <code>failed</code>.
        /// </para>
        /// </summary>
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property SuggestedAccounts. 
        /// <para>
        /// Potential intermediate accounts.
        /// </para>
        /// </summary>
        public List<string> SuggestedAccounts
        {
            get { return this._suggestedAccounts; }
            set { this._suggestedAccounts = value; }
        }

        // Check to see if SuggestedAccounts property is set
        internal bool IsSetSuggestedAccounts()
        {
            return this._suggestedAccounts != null && this._suggestedAccounts.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property WarningMessage. 
        /// <para>
        /// The warning message.
        /// </para>
        /// </summary>
        public string WarningMessage
        {
            get { return this._warningMessage; }
            set { this._warningMessage = value; }
        }

        // Check to see if WarningMessage property is set
        internal bool IsSetWarningMessage()
        {
            return this._warningMessage != null;
        }

    }
}