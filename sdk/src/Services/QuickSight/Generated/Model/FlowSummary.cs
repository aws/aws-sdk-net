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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The basic information of the flow exluding its definition specifying the steps.
    /// </summary>
    public partial class FlowSummary
    {
        private string _arn;
        private string _createdBy;
        private DateTime? _createdTime;
        private string _description;
        private string _flowId;
        private DateTime? _lastPublishedAt;
        private string _lastPublishedBy;
        private string _lastUpdatedBy;
        private DateTime? _lastUpdatedTime;
        private string _name;
        private FlowPublishState _publishState;
        private int? _runCount;
        private int? _userCount;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the flow.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The identifier of the principal who created the flow.
        /// </para>
        /// </summary>
        public string CreatedBy
        {
            get { return this._createdBy; }
            set { this._createdBy = value; }
        }

        // Check to see if CreatedBy property is set
        internal bool IsSetCreatedBy()
        {
            return this._createdBy != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The time this flow was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreatedTime
        {
            get { return this._createdTime.GetValueOrDefault(); }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the flow.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property FlowId. 
        /// <para>
        /// The unique identifier of the flow.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FlowId
        {
            get { return this._flowId; }
            set { this._flowId = value; }
        }

        // Check to see if FlowId property is set
        internal bool IsSetFlowId()
        {
            return this._flowId != null;
        }

        /// <summary>
        /// Gets and sets the property LastPublishedAt. 
        /// <para>
        /// The last time this flow was published.
        /// </para>
        /// </summary>
        public DateTime LastPublishedAt
        {
            get { return this._lastPublishedAt.GetValueOrDefault(); }
            set { this._lastPublishedAt = value; }
        }

        // Check to see if LastPublishedAt property is set
        internal bool IsSetLastPublishedAt()
        {
            return this._lastPublishedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastPublishedBy. 
        /// <para>
        /// The identifier of the last principal who published the flow.
        /// </para>
        /// </summary>
        public string LastPublishedBy
        {
            get { return this._lastPublishedBy; }
            set { this._lastPublishedBy = value; }
        }

        // Check to see if LastPublishedBy property is set
        internal bool IsSetLastPublishedBy()
        {
            return this._lastPublishedBy != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedBy. 
        /// <para>
        /// The identifier of the last principal who updated the flow.
        /// </para>
        /// </summary>
        public string LastUpdatedBy
        {
            get { return this._lastUpdatedBy; }
            set { this._lastUpdatedBy = value; }
        }

        // Check to see if LastUpdatedBy property is set
        internal bool IsSetLastUpdatedBy()
        {
            return this._lastUpdatedBy != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The last time this flow was modified.
        /// </para>
        /// </summary>
        public DateTime LastUpdatedTime
        {
            get { return this._lastUpdatedTime.GetValueOrDefault(); }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The display name of the flow.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property PublishState. 
        /// <para>
        /// The publish state for the flow. The valid values are <c>DRAFT</c>, <c>PUBLISHED</c>,
        /// or <c>PENDING_APPROVAL</c>.
        /// </para>
        /// </summary>
        public FlowPublishState PublishState
        {
            get { return this._publishState; }
            set { this._publishState = value; }
        }

        // Check to see if PublishState property is set
        internal bool IsSetPublishState()
        {
            return this._publishState != null;
        }

        /// <summary>
        /// Gets and sets the property RunCount. 
        /// <para>
        /// The number of runs done for the flow.
        /// </para>
        /// </summary>
        public int RunCount
        {
            get { return this._runCount.GetValueOrDefault(); }
            set { this._runCount = value; }
        }

        // Check to see if RunCount property is set
        internal bool IsSetRunCount()
        {
            return this._runCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UserCount. 
        /// <para>
        /// The number of users who have used the flow.
        /// </para>
        /// </summary>
        public int UserCount
        {
            get { return this._userCount.GetValueOrDefault(); }
            set { this._userCount = value; }
        }

        // Check to see if UserCount property is set
        internal bool IsSetUserCount()
        {
            return this._userCount.HasValue; 
        }

    }
}