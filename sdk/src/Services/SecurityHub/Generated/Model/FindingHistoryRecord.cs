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
    /// A list of events that changed the specified finding during the specified time period.
    /// Each record represents a single finding change event.
    /// </summary>
    public partial class FindingHistoryRecord
    {
        private bool? _findingCreated;
        private AwsSecurityFindingIdentifier _findingIdentifier;
        private string _nextToken;
        private List<FindingHistoryUpdate> _updates = new List<FindingHistoryUpdate>();
        private FindingHistoryUpdateSource _updateSource;
        private DateTime? _updateTime;

        /// <summary>
        /// Gets and sets the property FindingCreated. 
        /// <para>
        ///  Identifies whether the event marks the creation of a new finding. A value of <code>True</code>
        /// means that the finding is newly created. A value of <code>False</code> means that
        /// the finding isn’t newly created. 
        /// </para>
        /// </summary>
        public bool FindingCreated
        {
            get { return this._findingCreated.GetValueOrDefault(); }
            set { this._findingCreated = value; }
        }

        // Check to see if FindingCreated property is set
        internal bool IsSetFindingCreated()
        {
            return this._findingCreated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FindingIdentifier.
        /// </summary>
        public AwsSecurityFindingIdentifier FindingIdentifier
        {
            get { return this._findingIdentifier; }
            set { this._findingIdentifier = value; }
        }

        // Check to see if FindingIdentifier property is set
        internal bool IsSetFindingIdentifier()
        {
            return this._findingIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  A token for pagination purposes. Provide this token in the subsequent request to
        /// <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/API_GetFindingsHistory.html">
        /// <code>GetFindingsHistory</code> </a> to get up to an additional 100 results of history
        /// for the same finding that you specified in your initial request. 
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property Updates. 
        /// <para>
        ///  An array of objects that provides details about the finding change event, including
        /// the Amazon Web Services Security Finding Format (ASFF) field that changed, the value
        /// of the field before the change, and the value of the field after the change. 
        /// </para>
        /// </summary>
        public List<FindingHistoryUpdate> Updates
        {
            get { return this._updates; }
            set { this._updates = value; }
        }

        // Check to see if Updates property is set
        internal bool IsSetUpdates()
        {
            return this._updates != null && this._updates.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UpdateSource. 
        /// <para>
        ///  Identifies the source of the event that changed the finding. For example, an integrated
        /// Amazon Web Service or third-party partner integration may call <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/API_BatchImportFindings.html">
        /// <code>BatchImportFindings</code> </a>, or an Security Hub customer may call <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/API_BatchUpdateFindings.html">
        /// <code>BatchUpdateFindings</code> </a>. 
        /// </para>
        /// </summary>
        public FindingHistoryUpdateSource UpdateSource
        {
            get { return this._updateSource; }
            set { this._updateSource = value; }
        }

        // Check to see if UpdateSource property is set
        internal bool IsSetUpdateSource()
        {
            return this._updateSource != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateTime. 
        /// <para>
        ///  An ISO 8601-formatted timestamp that indicates when Security Hub processed the updated
        /// finding record.
        /// </para>
        ///  
        /// <para>
        /// A correctly formatted example is <code>2020-05-21T20:16:34.724Z</code>. The value
        /// cannot contain spaces, and date and time should be separated by <code>T</code>. For
        /// more information, see <a href="https://www.rfc-editor.org/rfc/rfc3339#section-5.6">RFC
        /// 3339 section 5.6, Internet Date/Time Format</a>. 
        /// </para>
        /// </summary>
        public DateTime UpdateTime
        {
            get { return this._updateTime.GetValueOrDefault(); }
            set { this._updateTime = value; }
        }

        // Check to see if UpdateTime property is set
        internal bool IsSetUpdateTime()
        {
            return this._updateTime.HasValue; 
        }

    }
}