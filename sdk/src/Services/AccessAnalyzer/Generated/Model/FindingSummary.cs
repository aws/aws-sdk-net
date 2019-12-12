/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// Contains information about a finding.
    /// </summary>
    public partial class FindingSummary
    {
        private List<string> _action = new List<string>();
        private DateTime? _analyzedAt;
        private Dictionary<string, string> _condition = new Dictionary<string, string>();
        private DateTime? _createdAt;
        private string _error;
        private string _id;
        private bool? _isPublic;
        private Dictionary<string, string> _principal = new Dictionary<string, string>();
        private string _resource;
        private ResourceType _resourceType;
        private FindingStatus _status;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action in the analyzed policy statement that an external principal has permission
        /// to use.
        /// </para>
        /// </summary>
        public List<string> Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null && this._action.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AnalyzedAt. 
        /// <para>
        /// The time at which the resource-based policy that generated the finding was analyzed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime AnalyzedAt
        {
            get { return this._analyzedAt.GetValueOrDefault(); }
            set { this._analyzedAt = value; }
        }

        // Check to see if AnalyzedAt property is set
        internal bool IsSetAnalyzedAt()
        {
            return this._analyzedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Condition. 
        /// <para>
        /// The condition in the analyzed policy statement that resulted in a finding.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, string> Condition
        {
            get { return this._condition; }
            set { this._condition = value; }
        }

        // Check to see if Condition property is set
        internal bool IsSetCondition()
        {
            return this._condition != null && this._condition.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time at which the finding was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// The error that resulted in an Error finding.
        /// </para>
        /// </summary>
        public string Error
        {
            get { return this._error; }
            set { this._error = value; }
        }

        // Check to see if Error property is set
        internal bool IsSetError()
        {
            return this._error != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the finding.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property IsPublic. 
        /// <para>
        /// Indicates whether the finding reports a resource that has a policy that allows public
        /// access.
        /// </para>
        /// </summary>
        public bool IsPublic
        {
            get { return this._isPublic.GetValueOrDefault(); }
            set { this._isPublic = value; }
        }

        // Check to see if IsPublic property is set
        internal bool IsSetIsPublic()
        {
            return this._isPublic.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Principal. 
        /// <para>
        /// The external principal that has access to a resource within the zone of trust.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Principal
        {
            get { return this._principal; }
            set { this._principal = value; }
        }

        // Check to see if Principal property is set
        internal bool IsSetPrincipal()
        {
            return this._principal != null && this._principal.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Resource. 
        /// <para>
        /// The resource that the external principal has access to.
        /// </para>
        /// </summary>
        public string Resource
        {
            get { return this._resource; }
            set { this._resource = value; }
        }

        // Check to see if Resource property is set
        internal bool IsSetResource()
        {
            return this._resource != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of the resource that the external principal has access to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ResourceType ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the finding.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FindingStatus Status
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
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The time at which the finding was most recently updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime UpdatedAt
        {
            get { return this._updatedAt.GetValueOrDefault(); }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}