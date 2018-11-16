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
 * Do not modify this file. This file is generated from the ram-2018-01-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RAM.Model
{
    /// <summary>
    /// Describes an association with a resource share.
    /// </summary>
    public partial class ResourceShareAssociation
    {
        private string _associatedEntity;
        private ResourceShareAssociationType _associationType;
        private DateTime? _creationTime;
        private bool? _external;
        private DateTime? _lastUpdatedTime;
        private string _resourceShareArn;
        private ResourceShareAssociationStatus _status;
        private string _statusMessage;

        /// <summary>
        /// Gets and sets the property AssociatedEntity. 
        /// <para>
        /// The associated entity. For resource associations, this is the ARN of the resource.
        /// For principal associations, this is the ID of an AWS account or the ARN of an OU or
        /// organization from AWS Organizations.
        /// </para>
        /// </summary>
        public string AssociatedEntity
        {
            get { return this._associatedEntity; }
            set { this._associatedEntity = value; }
        }

        // Check to see if AssociatedEntity property is set
        internal bool IsSetAssociatedEntity()
        {
            return this._associatedEntity != null;
        }

        /// <summary>
        /// Gets and sets the property AssociationType. 
        /// <para>
        /// The association type.
        /// </para>
        /// </summary>
        public ResourceShareAssociationType AssociationType
        {
            get { return this._associationType; }
            set { this._associationType = value; }
        }

        // Check to see if AssociationType property is set
        internal bool IsSetAssociationType()
        {
            return this._associationType != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time when the association was created.
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property External. 
        /// <para>
        /// Indicates whether the principal belongs to the same organization as the AWS account
        /// that owns the resource share.
        /// </para>
        /// </summary>
        public bool External
        {
            get { return this._external.GetValueOrDefault(); }
            set { this._external = value; }
        }

        // Check to see if External property is set
        internal bool IsSetExternal()
        {
            return this._external.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The time when the association was last updated.
        /// </para>
        /// </summary>
        public DateTime LastUpdatedTime
        {
            get { return this._lastUpdatedTime.GetValueOrDefault(); }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceShareArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource share.
        /// </para>
        /// </summary>
        public string ResourceShareArn
        {
            get { return this._resourceShareArn; }
            set { this._resourceShareArn = value; }
        }

        // Check to see if ResourceShareArn property is set
        internal bool IsSetResourceShareArn()
        {
            return this._resourceShareArn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the association.
        /// </para>
        /// </summary>
        public ResourceShareAssociationStatus Status
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
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// A message about the status of the association.
        /// </para>
        /// </summary>
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

    }
}