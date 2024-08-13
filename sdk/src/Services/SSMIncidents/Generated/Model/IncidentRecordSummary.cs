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
 * Do not modify this file. This file is generated from the ssm-incidents-2018-05-10.normal.json service model.
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
namespace Amazon.SSMIncidents.Model
{
    /// <summary>
    /// Details describing an incident record.
    /// </summary>
    public partial class IncidentRecordSummary
    {
        private string _arn;
        private DateTime? _creationTime;
        private int? _impact;
        private IncidentRecordSource _incidentRecordSource;
        private DateTime? _resolvedTime;
        private IncidentRecordStatus _status;
        private string _title;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the incident.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1000)]
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
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The timestamp for when the incident was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Impact. 
        /// <para>
        /// Defines the impact to customers and applications.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5)]
        public int? Impact
        {
            get { return this._impact; }
            set { this._impact = value; }
        }

        // Check to see if Impact property is set
        internal bool IsSetImpact()
        {
            return this._impact.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IncidentRecordSource. 
        /// <para>
        /// What caused Incident Manager to create the incident.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IncidentRecordSource IncidentRecordSource
        {
            get { return this._incidentRecordSource; }
            set { this._incidentRecordSource = value; }
        }

        // Check to see if IncidentRecordSource property is set
        internal bool IsSetIncidentRecordSource()
        {
            return this._incidentRecordSource != null;
        }

        /// <summary>
        /// Gets and sets the property ResolvedTime. 
        /// <para>
        /// The timestamp for when the incident was resolved.
        /// </para>
        /// </summary>
        public DateTime? ResolvedTime
        {
            get { return this._resolvedTime; }
            set { this._resolvedTime = value; }
        }

        // Check to see if ResolvedTime property is set
        internal bool IsSetResolvedTime()
        {
            return this._resolvedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the incident.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IncidentRecordStatus Status
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
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the incident. This value is either provided by the response plan or overwritten
        /// on creation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=200)]
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

    }
}