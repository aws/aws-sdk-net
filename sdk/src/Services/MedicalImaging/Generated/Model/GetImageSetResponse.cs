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
 * Do not modify this file. This file is generated from the medical-imaging-2023-07-19.normal.json service model.
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
namespace Amazon.MedicalImaging.Model
{
    /// <summary>
    /// This is the response object from the GetImageSet operation.
    /// </summary>
    public partial class GetImageSetResponse : AmazonWebServiceResponse
    {
        private DateTime? _createdAt;
        private string _datastoreId;
        private DateTime? _deletedAt;
        private string _imageSetArn;
        private string _imageSetId;
        private ImageSetState _imageSetState;
        private ImageSetWorkflowStatus _imageSetWorkflowStatus;
        private bool? _isPrimary;
        private string _message;
        private Overrides _overrides;
        private DateTime? _updatedAt;
        private string _versionId;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when image set properties were created.
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
        /// Gets and sets the property DatastoreId. 
        /// <para>
        /// The data store identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DatastoreId
        {
            get { return this._datastoreId; }
            set { this._datastoreId = value; }
        }

        // Check to see if DatastoreId property is set
        internal bool IsSetDatastoreId()
        {
            return this._datastoreId != null;
        }

        /// <summary>
        /// Gets and sets the property DeletedAt. 
        /// <para>
        /// The timestamp when the image set properties were deleted.
        /// </para>
        /// </summary>
        public DateTime? DeletedAt
        {
            get { return this._deletedAt; }
            set { this._deletedAt = value; }
        }

        // Check to see if DeletedAt property is set
        internal bool IsSetDeletedAt()
        {
            return this._deletedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ImageSetArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) assigned to the image set.
        /// </para>
        /// </summary>
        public string ImageSetArn
        {
            get { return this._imageSetArn; }
            set { this._imageSetArn = value; }
        }

        // Check to see if ImageSetArn property is set
        internal bool IsSetImageSetArn()
        {
            return this._imageSetArn != null;
        }

        /// <summary>
        /// Gets and sets the property ImageSetId. 
        /// <para>
        /// The image set identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ImageSetId
        {
            get { return this._imageSetId; }
            set { this._imageSetId = value; }
        }

        // Check to see if ImageSetId property is set
        internal bool IsSetImageSetId()
        {
            return this._imageSetId != null;
        }

        /// <summary>
        /// Gets and sets the property ImageSetState. 
        /// <para>
        /// The image set state.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ImageSetState ImageSetState
        {
            get { return this._imageSetState; }
            set { this._imageSetState = value; }
        }

        // Check to see if ImageSetState property is set
        internal bool IsSetImageSetState()
        {
            return this._imageSetState != null;
        }

        /// <summary>
        /// Gets and sets the property ImageSetWorkflowStatus. 
        /// <para>
        /// The image set workflow status.
        /// </para>
        /// </summary>
        public ImageSetWorkflowStatus ImageSetWorkflowStatus
        {
            get { return this._imageSetWorkflowStatus; }
            set { this._imageSetWorkflowStatus = value; }
        }

        // Check to see if ImageSetWorkflowStatus property is set
        internal bool IsSetImageSetWorkflowStatus()
        {
            return this._imageSetWorkflowStatus != null;
        }

        /// <summary>
        /// Gets and sets the property IsPrimary. 
        /// <para>
        /// The flag to determine whether the image set is primary or not.
        /// </para>
        /// </summary>
        public bool? IsPrimary
        {
            get { return this._isPrimary; }
            set { this._isPrimary = value; }
        }

        // Check to see if IsPrimary property is set
        internal bool IsSetIsPrimary()
        {
            return this._isPrimary.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The error message thrown if an image set action fails.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property Overrides. 
        /// <para>
        /// This object contains the details of any overrides used while creating a specific image
        /// set version. If an image set was copied or updated using the <c>force</c> flag, this
        /// object will contain the <c>forced</c> flag.
        /// </para>
        /// </summary>
        public Overrides Overrides
        {
            get { return this._overrides; }
            set { this._overrides = value; }
        }

        // Check to see if Overrides property is set
        internal bool IsSetOverrides()
        {
            return this._overrides != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when image set properties were updated.
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
        /// Gets and sets the property VersionId. 
        /// <para>
        /// The image set version identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string VersionId
        {
            get { return this._versionId; }
            set { this._versionId = value; }
        }

        // Check to see if VersionId property is set
        internal bool IsSetVersionId()
        {
            return this._versionId != null;
        }

    }
}