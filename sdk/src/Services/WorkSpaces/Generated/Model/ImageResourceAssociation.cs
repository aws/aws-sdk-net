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
    /// Describes the association between an application and an image resource.
    /// </summary>
    public partial class ImageResourceAssociation
    {
        private string _associatedResourceId;
        private ImageAssociatedResourceType _associatedResourceType;
        private DateTime? _created;
        private string _imageId;
        private DateTime? _lastUpdatedTime;
        private AssociationState _state;
        private AssociationStateReason _stateReason;

        /// <summary>
        /// Gets and sets the property AssociatedResourceId. 
        /// <para>
        /// The identifier of the associated resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string AssociatedResourceId
        {
            get { return this._associatedResourceId; }
            set { this._associatedResourceId = value; }
        }

        // Check to see if AssociatedResourceId property is set
        internal bool IsSetAssociatedResourceId()
        {
            return this._associatedResourceId != null;
        }

        /// <summary>
        /// Gets and sets the property AssociatedResourceType. 
        /// <para>
        /// The resource type of the associated resources.
        /// </para>
        /// </summary>
        public ImageAssociatedResourceType AssociatedResourceType
        {
            get { return this._associatedResourceType; }
            set { this._associatedResourceType = value; }
        }

        // Check to see if AssociatedResourceType property is set
        internal bool IsSetAssociatedResourceType()
        {
            return this._associatedResourceType != null;
        }

        /// <summary>
        /// Gets and sets the property Created. 
        /// <para>
        /// The time the association is created.
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
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The time the association status was last updated.
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
        /// Gets and sets the property State. 
        /// <para>
        /// The status of the image resource association.
        /// </para>
        /// </summary>
        public AssociationState State
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
        /// Gets and sets the property StateReason. 
        /// <para>
        /// The reason the association deployment failed.
        /// </para>
        /// </summary>
        public AssociationStateReason StateReason
        {
            get { return this._stateReason; }
            set { this._stateReason = value; }
        }

        // Check to see if StateReason property is set
        internal bool IsSetStateReason()
        {
            return this._stateReason != null;
        }

    }
}