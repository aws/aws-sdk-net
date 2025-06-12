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
 * Do not modify this file. This file is generated from the accessanalyzer-2019-11-01.normal.json service model.
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
namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// Contains details about the analyzed resource.
    /// </summary>
    public partial class AnalyzedResource
    {
        private List<string> _actions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _analyzedAt;
        private DateTime? _createdAt;
        private string _error;
        private bool? _isPublic;
        private string _resourceArn;
        private string _resourceOwnerAccount;
        private ResourceType _resourceType;
        private List<string> _sharedVia = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private FindingStatus _status;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property Actions. 
        /// <para>
        /// The actions that an external principal is granted permission to use by the policy
        /// that generated the finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Actions
        {
            get { return this._actions; }
            set { this._actions = value; }
        }

        // Check to see if Actions property is set
        internal bool IsSetActions()
        {
            return this._actions != null && (this._actions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AnalyzedAt. 
        /// <para>
        /// The time at which the resource was analyzed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? AnalyzedAt
        {
            get { return this._analyzedAt; }
            set { this._analyzedAt = value; }
        }

        // Check to see if AnalyzedAt property is set
        internal bool IsSetAnalyzedAt()
        {
            return this._analyzedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time at which the finding was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Error. 
        /// <para>
        /// An error message.
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
        /// Gets and sets the property IsPublic. 
        /// <para>
        /// Indicates whether the policy that generated the finding grants public access to the
        /// resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? IsPublic
        {
            get { return this._isPublic; }
            set { this._isPublic = value; }
        }

        // Check to see if IsPublic property is set
        internal bool IsSetIsPublic()
        {
            return this._isPublic.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The ARN of the resource that was analyzed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceOwnerAccount. 
        /// <para>
        /// The Amazon Web Services account ID that owns the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ResourceOwnerAccount
        {
            get { return this._resourceOwnerAccount; }
            set { this._resourceOwnerAccount = value; }
        }

        // Check to see if ResourceOwnerAccount property is set
        internal bool IsSetResourceOwnerAccount()
        {
            return this._resourceOwnerAccount != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of the resource that was analyzed.
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
        /// Gets and sets the property SharedVia. 
        /// <para>
        /// Indicates how the access that generated the finding is granted. This is populated
        /// for Amazon S3 bucket findings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SharedVia
        {
            get { return this._sharedVia; }
            set { this._sharedVia = value; }
        }

        // Check to see if SharedVia property is set
        internal bool IsSetSharedVia()
        {
            return this._sharedVia != null && (this._sharedVia.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the finding generated from the analyzed resource.
        /// </para>
        /// </summary>
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
        /// The time at which the finding was updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

    }
}