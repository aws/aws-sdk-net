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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.RecycleBin.Model
{
    /// <summary>
    /// This is the response object from the UpdateRule operation.
    /// </summary>
    public partial class UpdateRuleResponse : AmazonWebServiceResponse
    {
        private string _description;
        private List<ResourceTag> _excludeResourceTags = AWSConfigs.InitializeCollections ? new List<ResourceTag>() : null;
        private string _identifier;
        private DateTime? _lockEndTime;
        private LockState _lockState;
        private List<ResourceTag> _resourceTags = AWSConfigs.InitializeCollections ? new List<ResourceTag>() : null;
        private ResourceType _resourceType;
        private RetentionPeriod _retentionPeriod;
        private string _ruleArn;
        private RuleStatus _status;

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
        /// Gets and sets the property ExcludeResourceTags. 
        /// <para>
        /// [Region-level retention rules only] Information about the exclusion tags used to identify
        /// resources that are to be excluded, or ignored, by the retention rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<ResourceTag> ExcludeResourceTags
        {
            get { return this._excludeResourceTags; }
            set { this._excludeResourceTags = value; }
        }

        // Check to see if ExcludeResourceTags property is set
        internal bool IsSetExcludeResourceTags()
        {
            return this._excludeResourceTags != null && (this._excludeResourceTags.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// Gets and sets the property LockEndTime. 
        /// <para>
        /// The date and time at which the unlock delay is set to expire. Only returned for retention
        /// rules that have been unlocked and that are still within the unlock delay period.
        /// </para>
        /// </summary>
        public DateTime LockEndTime
        {
            get { return this._lockEndTime.GetValueOrDefault(); }
            set { this._lockEndTime = value; }
        }

        // Check to see if LockEndTime property is set
        internal bool IsSetLockEndTime()
        {
            return this._lockEndTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LockState. 
        /// <para>
        /// [Region-level retention rules only] The lock state for the retention rule.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>locked</c> - The retention rule is locked and can't be modified or deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>pending_unlock</c> - The retention rule has been unlocked but it is still within
        /// the unlock delay period. The retention rule can be modified or deleted only after
        /// the unlock delay period has expired.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>unlocked</c> - The retention rule is unlocked and it can be modified or deleted
        /// by any user with the required permissions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>null</c> - The retention rule has never been locked. Once a retention rule has
        /// been locked, it can transition between the <c>locked</c> and <c>unlocked</c> states
        /// only; it can never transition back to <c>null</c>.
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
        /// [Tag-level retention rules only] Information about the resource tags used to identify
        /// resources that are retained by the retention rule.
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
            return this._resourceTags != null && (this._resourceTags.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// Gets and sets the property RuleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the retention rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1011)]
        public string RuleArn
        {
            get { return this._ruleArn; }
            set { this._ruleArn = value; }
        }

        // Check to see if RuleArn property is set
        internal bool IsSetRuleArn()
        {
            return this._ruleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The state of the retention rule. Only retention rules that are in the <c>available</c>
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

    }
}