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
 * Do not modify this file. This file is generated from the detective-2018-10-26.normal.json service model.
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
namespace Amazon.Detective.Model
{
    /// <summary>
    /// This is the response object from the GetInvestigation operation.
    /// </summary>
    public partial class GetInvestigationResponse : AmazonWebServiceResponse
    {
        private DateTime? _createdTime;
        private string _entityArn;
        private EntityType _entityType;
        private string _graphArn;
        private string _investigationId;
        private DateTime? _scopeEndTime;
        private DateTime? _scopeStartTime;
        private Severity _severity;
        private State _state;
        private Status _status;

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The creation time of the investigation report in UTC time stamp format.
        /// </para>
        /// </summary>
        public DateTime? CreatedTime
        {
            get { return this._createdTime; }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EntityArn. 
        /// <para>
        /// The unique Amazon Resource Name (ARN). Detective supports IAM user ARNs and IAM role
        /// ARNs.
        /// </para>
        /// </summary>
        public string EntityArn
        {
            get { return this._entityArn; }
            set { this._entityArn = value; }
        }

        // Check to see if EntityArn property is set
        internal bool IsSetEntityArn()
        {
            return this._entityArn != null;
        }

        /// <summary>
        /// Gets and sets the property EntityType. 
        /// <para>
        /// Type of entity. For example, Amazon Web Services accounts, such as an IAM user and/or
        /// IAM role.
        /// </para>
        /// </summary>
        public EntityType EntityType
        {
            get { return this._entityType; }
            set { this._entityType = value; }
        }

        // Check to see if EntityType property is set
        internal bool IsSetEntityType()
        {
            return this._entityType != null;
        }

        /// <summary>
        /// Gets and sets the property GraphArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the behavior graph.
        /// </para>
        /// </summary>
        public string GraphArn
        {
            get { return this._graphArn; }
            set { this._graphArn = value; }
        }

        // Check to see if GraphArn property is set
        internal bool IsSetGraphArn()
        {
            return this._graphArn != null;
        }

        /// <summary>
        /// Gets and sets the property InvestigationId. 
        /// <para>
        /// The investigation ID of the investigation report.
        /// </para>
        /// </summary>
        [AWSProperty(Min=21, Max=21)]
        public string InvestigationId
        {
            get { return this._investigationId; }
            set { this._investigationId = value; }
        }

        // Check to see if InvestigationId property is set
        internal bool IsSetInvestigationId()
        {
            return this._investigationId != null;
        }

        /// <summary>
        /// Gets and sets the property ScopeEndTime. 
        /// <para>
        /// The data and time when the investigation began. The value is an UTC ISO8601 formatted
        /// string. For example, <c>2021-08-18T16:35:56.284Z</c>.
        /// </para>
        /// </summary>
        public DateTime? ScopeEndTime
        {
            get { return this._scopeEndTime; }
            set { this._scopeEndTime = value; }
        }

        // Check to see if ScopeEndTime property is set
        internal bool IsSetScopeEndTime()
        {
            return this._scopeEndTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ScopeStartTime. 
        /// <para>
        /// The start date and time used to set the scope time within which you want to generate
        /// the investigation report. The value is an UTC ISO8601 formatted string. For example,
        /// <c>2021-08-18T16:35:56.284Z</c>.
        /// </para>
        /// </summary>
        public DateTime? ScopeStartTime
        {
            get { return this._scopeStartTime; }
            set { this._scopeStartTime = value; }
        }

        // Check to see if ScopeStartTime property is set
        internal bool IsSetScopeStartTime()
        {
            return this._scopeStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        /// The severity assigned is based on the likelihood and impact of the indicators of compromise
        /// discovered in the investigation.
        /// </para>
        /// </summary>
        public Severity Severity
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
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the investigation. An archived investigation indicates that you
        /// have completed reviewing the investigation.
        /// </para>
        /// </summary>
        public State State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status based on the completion status of the investigation.
        /// </para>
        /// </summary>
        public Status Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}