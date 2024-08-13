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
    /// Copy source image set properties.
    /// </summary>
    public partial class CopySourceImageSetProperties
    {
        private DateTime? _createdAt;
        private string _imageSetArn;
        private string _imageSetId;
        private ImageSetState _imageSetState;
        private ImageSetWorkflowStatus _imageSetWorkflowStatus;
        private string _latestVersionId;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the source image set properties were created.
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
        /// Gets and sets the property ImageSetArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) assigned to the source image set.
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
        /// The image set identifier for the copied source image set.
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
        /// The image set state of the copied source image set.
        /// </para>
        /// </summary>
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
        /// The workflow status of the copied source image set.
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
        /// Gets and sets the property LatestVersionId. 
        /// <para>
        /// The latest version identifier for the copied source image set.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string LatestVersionId
        {
            get { return this._latestVersionId; }
            set { this._latestVersionId = value; }
        }

        // Check to see if LatestVersionId property is set
        internal bool IsSetLatestVersionId()
        {
            return this._latestVersionId != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the source image set properties were updated.
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

    }
}