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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Mgn.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Application
    {
        private ApplicationAggregatedStatus _applicationAggregatedStatus;
        private string _applicationid;
        private string _arn;
        private string _creationDateTime;
        private string _description;
        private bool? _isArchived;
        private string _lastModifiedDateTime;
        private string _name;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private string _waveid;

        /// <summary>
        /// Gets and sets the property ApplicationAggregatedStatus. 
        /// <para>
        /// Application aggregated status.
        /// </para>
        /// </summary>
        public ApplicationAggregatedStatus ApplicationAggregatedStatus
        {
            get { return this._applicationAggregatedStatus; }
            set { this._applicationAggregatedStatus = value; }
        }

        // Check to see if ApplicationAggregatedStatus property is set
        internal bool IsSetApplicationAggregatedStatus()
        {
            return this._applicationAggregatedStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ApplicationID. 
        /// <para>
        /// Application ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=21, Max=21)]
        public string ApplicationID
        {
            get { return this._applicationid; }
            set { this._applicationid = value; }
        }

        // Check to see if ApplicationID property is set
        internal bool IsSetApplicationID()
        {
            return this._applicationid != null;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// Application ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
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
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// Application creation dateTime.
        /// </para>
        /// </summary>
        [AWSProperty(Min=19, Max=32)]
        public string CreationDateTime
        {
            get { return this._creationDateTime; }
            set { this._creationDateTime = value; }
        }

        // Check to see if CreationDateTime property is set
        internal bool IsSetCreationDateTime()
        {
            return this._creationDateTime != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Application description.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=600)]
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
        /// Gets and sets the property IsArchived. 
        /// <para>
        /// Application archival status.
        /// </para>
        /// </summary>
        public bool IsArchived
        {
            get { return this._isArchived.GetValueOrDefault(); }
            set { this._isArchived = value; }
        }

        // Check to see if IsArchived property is set
        internal bool IsSetIsArchived()
        {
            return this._isArchived.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastModifiedDateTime. 
        /// <para>
        /// Application last modified dateTime.
        /// </para>
        /// </summary>
        [AWSProperty(Min=19, Max=32)]
        public string LastModifiedDateTime
        {
            get { return this._lastModifiedDateTime; }
            set { this._lastModifiedDateTime = value; }
        }

        // Check to see if LastModifiedDateTime property is set
        internal bool IsSetLastModifiedDateTime()
        {
            return this._lastModifiedDateTime != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Application name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Application tags.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Dictionary<string, string> Tags
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
        /// Gets and sets the property WaveID. 
        /// <para>
        /// Application wave ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=22, Max=22)]
        public string WaveID
        {
            get { return this._waveid; }
            set { this._waveid = value; }
        }

        // Check to see if WaveID property is set
        internal bool IsSetWaveID()
        {
            return this._waveid != null;
        }

    }
}