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
 * Do not modify this file. This file is generated from the securityagent-2025-09-06.normal.json service model.
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
namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// Contains summary information about a threat.
    /// </summary>
    public partial class ThreatSummary
    {
        private DateTime? _createdAt;
        private ThreatActor _createdBy;
        private ThreatSeverity _severity;
        private string _statement;
        private ThreatStatus _status;
        private List<string> _stride = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _threatId;
        private string _threatJobId;
        private string _title;
        private DateTime? _updatedAt;
        private ThreatActor _updatedBy;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time the threat was created, in UTC format.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// Who created this threat.
        /// </para>
        /// </summary>
        public ThreatActor CreatedBy
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
        /// Gets and sets the property Severity. 
        /// <para>
        /// The severity level of the threat.
        /// </para>
        /// </summary>
        public ThreatSeverity Severity
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
        /// Gets and sets the property Statement. 
        /// <para>
        /// The natural-language threat statement.
        /// </para>
        /// </summary>
        public string Statement
        {
            get { return this._statement; }
            set { this._statement = value; }
        }

        // Check to see if Statement property is set
        internal bool IsSetStatement()
        {
            return this._statement != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the threat.
        /// </para>
        /// </summary>
        public ThreatStatus Status
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
        /// Gets and sets the property Stride. 
        /// <para>
        /// The STRIDE categories applicable to this threat.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Stride
        {
            get { return this._stride; }
            set { this._stride = value; }
        }

        // Check to see if Stride property is set
        internal bool IsSetStride()
        {
            return this._stride != null && (this._stride.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ThreatId. 
        /// <para>
        /// The unique identifier of the threat.
        /// </para>
        /// </summary>
        public string ThreatId
        {
            get { return this._threatId; }
            set { this._threatId = value; }
        }

        // Check to see if ThreatId property is set
        internal bool IsSetThreatId()
        {
            return this._threatId != null;
        }

        /// <summary>
        /// Gets and sets the property ThreatJobId. 
        /// <para>
        /// The unique identifier of the threat model job that produced the threat.
        /// </para>
        /// </summary>
        public string ThreatJobId
        {
            get { return this._threatJobId; }
            set { this._threatJobId = value; }
        }

        // Check to see if ThreatJobId property is set
        internal bool IsSetThreatJobId()
        {
            return this._threatJobId != null;
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// A short title summarizing the threat.
        /// </para>
        /// </summary>
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time the threat was last updated, in UTC format.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UpdatedBy. 
        /// <para>
        /// Who last updated this threat.
        /// </para>
        /// </summary>
        public ThreatActor UpdatedBy
        {
            get { return this._updatedBy; }
            set { this._updatedBy = value; }
        }

        // Check to see if UpdatedBy property is set
        internal bool IsSetUpdatedBy()
        {
            return this._updatedBy != null;
        }

    }
}