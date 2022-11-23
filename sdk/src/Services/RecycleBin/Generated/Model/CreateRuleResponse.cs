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
 * Do not modify this file. This file is generated from the rbin-2021-06-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RecycleBin.Model
{
    /// <summary>
    /// This is the response object from the CreateRule operation.
    /// </summary>
    public partial class CreateRuleResponse : AmazonWebServiceResponse
    {
        private string _description;
        private string _identifier;
        private LockConfiguration _lockConfiguration;
        private LockState _lockState;
        private List<ResourceTag> _resourceTags = new List<ResourceTag>();
        private ResourceType _resourceType;
        private RetentionPeriod _retentionPeriod;
        private RuleStatus _status;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The retention rule description.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The unique ID of the retention rule.
        /// </para>
        /// </summary>
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

        /// <summary>
        /// Gets and sets the property LockConfiguration. 
        /// <para>
        /// Information about the retention rule lock configuration.
        /// </para>
        /// </summary>
        public LockConfiguration LockConfiguration
        {
            get { return this._lockConfiguration; }
            set { this._lockConfiguration = value; }
        }

        // Check to see if LockConfiguration property is set
        internal bool IsSetLockConfiguration()
        {
            return this._lockConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property LockState. 
        /// <para>
        /// The lock state for the retention rule.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>locked</code> - The retention rule is locked and can't be modified or deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>pending_unlock</code> - The retention rule has been unlocked but it is still
        /// within the unlock delay period. The retention rule can be modified or deleted only
        /// after the unlock delay period has expired.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>unlocked</code> - The retention rule is unlocked and it can be modified or
        /// deleted by any user with the required permissions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>null</code> - The retention rule has never been locked. Once a retention rule
        /// has been locked, it can transition between the <code>locked</code> and <code>unlocked</code>
        /// states only; it can never transition back to <code>null</code>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public LockState LockState
        {
            get { return this._lockState; }
            set { this._lockState = value; }
        }

        // Check to see if LockState property is set
        internal bool IsSetLockState()
        {
            return this._lockState != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceTags. 
        /// <para>
        /// Information about the resource tags used to identify resources that are retained by
        /// the retention rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<ResourceTag> ResourceTags
        {
            get { return this._resourceTags; }
            set { this._resourceTags = value; }
        }

        // Check to see if ResourceTags property is set
        internal bool IsSetResourceTags()
        {
            return this._resourceTags != null && this._resourceTags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The resource type retained by the retention rule.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property RetentionPeriod.
        /// </summary>
        public RetentionPeriod RetentionPeriod
        {
            get { return this._retentionPeriod; }
            set { this._retentionPeriod = value; }
        }

        // Check to see if RetentionPeriod property is set
        internal bool IsSetRetentionPeriod()
        {
            return this._retentionPeriod != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The state of the retention rule. Only retention rules that are in the <code>available</code>
        /// state retain resources.
        /// </para>
        /// </summary>
        public RuleStatus Status
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Information about the tags assigned to the retention rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
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

    }
}