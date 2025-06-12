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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a Network Access Scope analysis.
    /// </summary>
    public partial class NetworkInsightsAccessScopeAnalysis
    {
        private int? _analyzedEniCount;
        private DateTime? _endDate;
        private FindingsFound _findingsFound;
        private string _networkInsightsAccessScopeAnalysisArn;
        private string _networkInsightsAccessScopeAnalysisId;
        private string _networkInsightsAccessScopeId;
        private DateTime? _startDate;
        private AnalysisStatus _status;
        private string _statusMessage;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _warningMessage;

        /// <summary>
        /// Gets and sets the property AnalyzedEniCount. 
        /// <para>
        /// The number of network interfaces analyzed.
        /// </para>
        /// </summary>
        public int? AnalyzedEniCount
        {
            get { return this._analyzedEniCount; }
            set { this._analyzedEniCount = value; }
        }

        // Check to see if AnalyzedEniCount property is set
        internal bool IsSetAnalyzedEniCount()
        {
            return this._analyzedEniCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndDate. 
        /// <para>
        /// The analysis end date.
        /// </para>
        /// </summary>
        public DateTime? EndDate
        {
            get { return this._endDate; }
            set { this._endDate = value; }
        }

        // Check to see if EndDate property is set
        internal bool IsSetEndDate()
        {
            return this._endDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FindingsFound. 
        /// <para>
        /// Indicates whether there are findings.
        /// </para>
        /// </summary>
        public FindingsFound FindingsFound
        {
            get { return this._findingsFound; }
            set { this._findingsFound = value; }
        }

        // Check to see if FindingsFound property is set
        internal bool IsSetFindingsFound()
        {
            return this._findingsFound != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkInsightsAccessScopeAnalysisArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Network Access Scope analysis.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1283)]
        public string NetworkInsightsAccessScopeAnalysisArn
        {
            get { return this._networkInsightsAccessScopeAnalysisArn; }
            set { this._networkInsightsAccessScopeAnalysisArn = value; }
        }

        // Check to see if NetworkInsightsAccessScopeAnalysisArn property is set
        internal bool IsSetNetworkInsightsAccessScopeAnalysisArn()
        {
            return this._networkInsightsAccessScopeAnalysisArn != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkInsightsAccessScopeAnalysisId. 
        /// <para>
        /// The ID of the Network Access Scope analysis.
        /// </para>
        /// </summary>
        public string NetworkInsightsAccessScopeAnalysisId
        {
            get { return this._networkInsightsAccessScopeAnalysisId; }
            set { this._networkInsightsAccessScopeAnalysisId = value; }
        }

        // Check to see if NetworkInsightsAccessScopeAnalysisId property is set
        internal bool IsSetNetworkInsightsAccessScopeAnalysisId()
        {
            return this._networkInsightsAccessScopeAnalysisId != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkInsightsAccessScopeId. 
        /// <para>
        /// The ID of the Network Access Scope.
        /// </para>
        /// </summary>
        public string NetworkInsightsAccessScopeId
        {
            get { return this._networkInsightsAccessScopeId; }
            set { this._networkInsightsAccessScopeId = value; }
        }

        // Check to see if NetworkInsightsAccessScopeId property is set
        internal bool IsSetNetworkInsightsAccessScopeId()
        {
            return this._networkInsightsAccessScopeId != null;
        }

        /// <summary>
        /// Gets and sets the property StartDate. 
        /// <para>
        /// The analysis start date.
        /// </para>
        /// </summary>
        public DateTime? StartDate
        {
            get { return this._startDate; }
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
        /// The status.
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
        /// The status message.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
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