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
 * Do not modify this file. This file is generated from the ram-2018-01-04.normal.json service model.
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
namespace Amazon.RAM.Model
{
    /// <summary>
    /// Information about a RAM managed permission.
    /// </summary>
    public partial class ResourceSharePermissionDetail
    {
        private string _arn;
        private DateTime? _creationTime;
        private bool? _defaultVersion;
        private PermissionFeatureSet _featureSet;
        private bool? _isResourceTypeDefault;
        private DateTime? _lastUpdatedTime;
        private string _name;
        private string _permission;
        private PermissionType _permissionType;
        private string _resourceType;
        private PermissionStatus _status;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _version;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> of this RAM managed permission.
        /// </para>
        /// </summary>
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
        /// The date and time when the permission was created.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property DefaultVersion. 
        /// <para>
        /// Specifies whether the version of the permission represented in this response is the
        /// default version for this permission.
        /// </para>
        /// </summary>
        public bool? DefaultVersion
        {
            get { return this._defaultVersion; }
            set { this._defaultVersion = value; }
        }

        // Check to see if DefaultVersion property is set
        internal bool IsSetDefaultVersion()
        {
            return this._defaultVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FeatureSet. 
        /// <para>
        /// Indicates what features are available for this resource share. This parameter can
        /// have one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>STANDARD</b> – A resource share that supports all functionality. These resource
        /// shares are visible to all principals you share the resource share with. You can modify
        /// these resource shares in RAM using the console or APIs. This resource share might
        /// have been created by RAM, or it might have been <b>CREATED_FROM_POLICY</b> and then
        /// promoted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>CREATED_FROM_POLICY</b> – The customer manually shared a resource by attaching
        /// a resource-based policy. That policy did not match any existing managed permissions,
        /// so RAM created this customer managed permission automatically on the customer's behalf
        /// based on the attached policy document. This type of resource share is visible only
        /// to the Amazon Web Services account that created it. You can't modify it in RAM unless
        /// you promote it. For more information, see <a>PromoteResourceShareCreatedFromPolicy</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>PROMOTING_TO_STANDARD</b> – This resource share was originally <c>CREATED_FROM_POLICY</c>,
        /// but the customer ran the <a>PromoteResourceShareCreatedFromPolicy</a> and that operation
        /// is still in progress. This value changes to <c>STANDARD</c> when complete.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public PermissionFeatureSet FeatureSet
        {
            get { return this._featureSet; }
            set { this._featureSet = value; }
        }

        // Check to see if FeatureSet property is set
        internal bool IsSetFeatureSet()
        {
            return this._featureSet != null;
        }

        /// <summary>
        /// Gets and sets the property IsResourceTypeDefault. 
        /// <para>
        /// Specifies whether the version of the permission represented in this response is the
        /// default version for all resources of this resource type.
        /// </para>
        /// </summary>
        public bool? IsResourceTypeDefault
        {
            get { return this._isResourceTypeDefault; }
            set { this._isResourceTypeDefault = value; }
        }

        // Check to see if IsResourceTypeDefault property is set
        internal bool IsSetIsResourceTypeDefault()
        {
            return this._isResourceTypeDefault.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The date and time when the permission was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTime
        {
            get { return this._lastUpdatedTime; }
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
        /// The name of this permission.
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
        /// Gets and sets the property Permission. 
        /// <para>
        /// The permission's effect and actions in JSON format. The <c>effect</c> indicates whether
        /// the specified actions are allowed or denied. The <c>actions</c> list the operations
        /// to which the principal is granted or denied access.
        /// </para>
        /// </summary>
        public string Permission
        {
            get { return this._permission; }
            set { this._permission = value; }
        }

        // Check to see if Permission property is set
        internal bool IsSetPermission()
        {
            return this._permission != null;
        }

        /// <summary>
        /// Gets and sets the property PermissionType. 
        /// <para>
        /// The type of managed permission. This can be one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AWS_MANAGED</c> – Amazon Web Services created and manages this managed permission.
        /// You can associate it with your resource shares, but you can't modify it.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CUSTOMER_MANAGED</c> – You, or another principal in your account created this
        /// managed permission. You can associate it with your resource shares and create new
        /// versions that have different permissions.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public PermissionType PermissionType
        {
            get { return this._permissionType; }
            set { this._permissionType = value; }
        }

        // Check to see if PermissionType property is set
        internal bool IsSetPermissionType()
        {
            return this._permissionType != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The resource type to which this permission applies.
        /// </para>
        /// </summary>
        public string ResourceType
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
        /// The current status of the association between the permission and the resource share.
        /// The following are the possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ATTACHABLE</c> – This permission or version can be associated with resource shares.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UNATTACHABLE</c> – This permission or version can't currently be associated with
        /// resource shares.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETING</c> – This permission or version is in the process of being deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETED</c> – This permission or version is deleted.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public PermissionStatus Status
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
        /// The tag key and value pairs attached to the resource share.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the permission described in this response.
        /// </para>
        /// </summary>
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

    }
}