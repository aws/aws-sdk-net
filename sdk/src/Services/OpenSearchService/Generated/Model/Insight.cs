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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
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
namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Represents an insight returned by the <c>ListInsights</c> operation. An insight is
    /// a notification about a domain event or recommendation that helps you optimize your
    /// Amazon OpenSearch Service domain.
    /// </summary>
    public partial class Insight
    {
        private DateTime? _creationTime;
        private string _displayName;
        private string _insightId;
        private bool? _isExperimental;
        private InsightPriorityLevel _priority;
        private InsightStatus _status;
        private InsightType _type;
        private DateTime? _updateTime;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The timestamp when the insight was created, in epoch milliseconds.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The display name of the insight.
        /// </para>
        /// </summary>
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property InsightId. 
        /// <para>
        /// The unique identifier of the insight.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string InsightId
        {
            get { return this._insightId; }
            set { this._insightId = value; }
        }

        // Check to see if InsightId property is set
        internal bool IsSetInsightId()
        {
            return this._insightId != null;
        }

        /// <summary>
        /// Gets and sets the property IsExperimental. 
        /// <para>
        /// Indicates whether the insight is experimental.
        /// </para>
        /// </summary>
        public bool? IsExperimental
        {
            get { return this._isExperimental; }
            set { this._isExperimental = value; }
        }

        // Check to see if IsExperimental property is set
        internal bool IsSetIsExperimental()
        {
            return this._isExperimental.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// The priority level of the insight. Possible values are <c>CRITICAL</c>, <c>HIGH</c>,
        /// <c>MEDIUM</c>, and <c>LOW</c>.
        /// </para>
        /// </summary>
        public InsightPriorityLevel Priority
        {
            get { return this._priority; }
            set { this._priority = value; }
        }

        // Check to see if Priority property is set
        internal bool IsSetPriority()
        {
            return this._priority != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the insight. Possible values are <c>ACTIVE</c>, <c>RESOLVED</c>,
        /// and <c>DISMISSED</c>.
        /// </para>
        /// </summary>
        public InsightStatus Status
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
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the insight. Possible values are <c>EVENT</c> and <c>RECOMMENDATION</c>.
        /// </para>
        /// </summary>
        public InsightType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateTime. 
        /// <para>
        /// The timestamp when the insight was last updated, in epoch milliseconds.
        /// </para>
        /// </summary>
        public DateTime? UpdateTime
        {
            get { return this._updateTime; }
            set { this._updateTime = value; }
        }

        // Check to see if UpdateTime property is set
        internal bool IsSetUpdateTime()
        {
            return this._updateTime.HasValue; 
        }

    }
}