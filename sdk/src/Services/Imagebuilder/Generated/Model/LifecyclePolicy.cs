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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
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
namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// The configuration details for a lifecycle policy resource.
    /// </summary>
    public partial class LifecyclePolicy
    {
        private string _arn;
        private DateTime? _dateCreated;
        private DateTime? _dateLastRun;
        private DateTime? _dateUpdated;
        private string _description;
        private string _executionRole;
        private string _name;
        private List<LifecyclePolicyDetail> _policyDetails = AWSConfigs.InitializeCollections ? new List<LifecyclePolicyDetail>() : null;
        private LifecyclePolicyResourceSelection _resourceSelection;
        private LifecyclePolicyResourceType _resourceType;
        private LifecyclePolicyStatus _status;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the lifecycle policy resource.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
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
        /// Gets and sets the property DateCreated. 
        /// <para>
        /// The timestamp when Image Builder created the lifecycle policy resource.
        /// </para>
        /// </summary>
        public DateTime? DateCreated
        {
            get { return this._dateCreated; }
            set { this._dateCreated = value; }
        }

        // Check to see if DateCreated property is set
        internal bool IsSetDateCreated()
        {
            return this._dateCreated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DateLastRun. 
        /// <para>
        /// The timestamp for the last time Image Builder ran the lifecycle policy.
        /// </para>
        /// </summary>
        public DateTime? DateLastRun
        {
            get { return this._dateLastRun; }
            set { this._dateLastRun = value; }
        }

        // Check to see if DateLastRun property is set
        internal bool IsSetDateLastRun()
        {
            return this._dateLastRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DateUpdated. 
        /// <para>
        /// The timestamp when Image Builder updated the lifecycle policy resource.
        /// </para>
        /// </summary>
        public DateTime? DateUpdated
        {
            get { return this._dateUpdated; }
            set { this._dateUpdated = value; }
        }

        // Check to see if DateUpdated property is set
        internal bool IsSetDateUpdated()
        {
            return this._dateUpdated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Optional description for the lifecycle policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// Gets and sets the property ExecutionRole. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of the IAM role that Image Builder uses to
        /// run the lifecycle policy. This is a custom role that you create.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ExecutionRole
        {
            get { return this._executionRole; }
            set { this._executionRole = value; }
        }

        // Check to see if ExecutionRole property is set
        internal bool IsSetExecutionRole()
        {
            return this._executionRole != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the lifecycle policy.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property PolicyDetails. 
        /// <para>
        /// The configuration details for a lifecycle policy resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=3)]
        public List<LifecyclePolicyDetail> PolicyDetails
        {
            get { return this._policyDetails; }
            set { this._policyDetails = value; }
        }

        // Check to see if PolicyDetails property is set
        internal bool IsSetPolicyDetails()
        {
            return this._policyDetails != null && (this._policyDetails.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceSelection. 
        /// <para>
        /// Resource selection criteria used to run the lifecycle policy.
        /// </para>
        /// </summary>
        public LifecyclePolicyResourceSelection ResourceSelection
        {
            get { return this._resourceSelection; }
            set { this._resourceSelection = value; }
        }

        // Check to see if ResourceSelection property is set
        internal bool IsSetResourceSelection()
        {
            return this._resourceSelection != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of resources the lifecycle policy targets.
        /// </para>
        /// </summary>
        public LifecyclePolicyResourceType ResourceType
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
        /// Indicates whether the lifecycle policy resource is enabled.
        /// </para>
        /// </summary>
        public LifecyclePolicyStatus Status
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
        /// To help manage your lifecycle policy resources, you can assign your own metadata to
        /// each resource in the form of tags. Each tag consists of a key and an optional value,
        /// both of which you define.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}