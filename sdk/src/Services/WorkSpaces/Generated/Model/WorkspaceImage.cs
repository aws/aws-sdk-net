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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
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
namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// Describes a WorkSpace image.
    /// </summary>
    public partial class WorkspaceImage
    {
        private DateTime? _created;
        private string _description;
        private string _errorCode;
        private List<ErrorDetails> _errorDetails = AWSConfigs.InitializeCollections ? new List<ErrorDetails>() : null;
        private string _errorMessage;
        private string _imageId;
        private string _name;
        private OperatingSystem _operatingSystem;
        private string _ownerAccountId;
        private WorkspaceImageRequiredTenancy _requiredTenancy;
        private WorkspaceImageState _state;
        private UpdateResult _updates;

        /// <summary>
        /// Gets and sets the property Created. 
        /// <para>
        /// The date when the image was created. If the image has been shared, the Amazon Web
        /// Services account that the image has been shared with sees the original creation date
        /// of the image.
        /// </para>
        /// </summary>
        public DateTime? Created
        {
            get { return this._created; }
            set { this._created = value; }
        }

        // Check to see if Created property is set
        internal bool IsSetCreated()
        {
            return this._created.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the image.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// The error code that is returned for the image.
        /// </para>
        /// </summary>
        public string ErrorCode
        {
            get { return this._errorCode; }
            set { this._errorCode = value; }
        }

        // Check to see if ErrorCode property is set
        internal bool IsSetErrorCode()
        {
            return this._errorCode != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorDetails. 
        /// <para>
        /// Additional details of the error returned for the image, including the possible causes
        /// of the errors and troubleshooting information.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ErrorDetails> ErrorDetails
        {
            get { return this._errorDetails; }
            set { this._errorDetails = value; }
        }

        // Check to see if ErrorDetails property is set
        internal bool IsSetErrorDetails()
        {
            return this._errorDetails != null && (this._errorDetails.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// The text of the error message that is returned for the image.
        /// </para>
        /// </summary>
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property ImageId. 
        /// <para>
        /// The identifier of the image.
        /// </para>
        /// </summary>
        public string ImageId
        {
            get { return this._imageId; }
            set { this._imageId = value; }
        }

        // Check to see if ImageId property is set
        internal bool IsSetImageId()
        {
            return this._imageId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the image.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// Gets and sets the property OperatingSystem. 
        /// <para>
        /// The operating system that the image is running. 
        /// </para>
        /// </summary>
        public OperatingSystem OperatingSystem
        {
            get { return this._operatingSystem; }
            set { this._operatingSystem = value; }
        }

        // Check to see if OperatingSystem property is set
        internal bool IsSetOperatingSystem()
        {
            return this._operatingSystem != null;
        }

        /// <summary>
        /// Gets and sets the property OwnerAccountId. 
        /// <para>
        /// The identifier of the Amazon Web Services account that owns the image.
        /// </para>
        /// </summary>
        public string OwnerAccountId
        {
            get { return this._ownerAccountId; }
            set { this._ownerAccountId = value; }
        }

        // Check to see if OwnerAccountId property is set
        internal bool IsSetOwnerAccountId()
        {
            return this._ownerAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property RequiredTenancy. 
        /// <para>
        /// Specifies whether the image is running on dedicated hardware. When Bring Your Own
        /// License (BYOL) is enabled, this value is set to <c>DEDICATED</c>. For more information,
        /// see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/byol-windows-images.html">Bring
        /// Your Own Windows Desktop Images</a>.
        /// </para>
        /// </summary>
        public WorkspaceImageRequiredTenancy RequiredTenancy
        {
            get { return this._requiredTenancy; }
            set { this._requiredTenancy = value; }
        }

        // Check to see if RequiredTenancy property is set
        internal bool IsSetRequiredTenancy()
        {
            return this._requiredTenancy != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The status of the image.
        /// </para>
        /// </summary>
        public WorkspaceImageState State
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
        /// Gets and sets the property Updates. 
        /// <para>
        /// The updates (if any) that are available for the specified image.
        /// </para>
        /// </summary>
        public UpdateResult Updates
        {
            get { return this._updates; }
            set { this._updates = value; }
        }

        // Check to see if Updates property is set
        internal bool IsSetUpdates()
        {
            return this._updates != null;
        }

    }
}