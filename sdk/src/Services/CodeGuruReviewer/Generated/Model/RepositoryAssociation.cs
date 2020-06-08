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
 * Do not modify this file. This file is generated from the codeguru-reviewer-2019-09-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeGuruReviewer.Model
{
    /// <summary>
    /// Information about a repository association.
    /// </summary>
    public partial class RepositoryAssociation
    {
        private string _associationArn;
        private string _associationId;
        private string _connectionArn;
        private DateTime? _createdTimeStamp;
        private DateTime? _lastUpdatedTimeStamp;
        private string _name;
        private string _owner;
        private ProviderType _providerType;
        private RepositoryAssociationState _state;
        private string _stateReason;

        /// <summary>
        /// Gets and sets the property AssociationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) identifying the repository association.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1600)]
        public string AssociationArn
        {
            get { return this._associationArn; }
            set { this._associationArn = value; }
        }

        // Check to see if AssociationArn property is set
        internal bool IsSetAssociationArn()
        {
            return this._associationArn != null;
        }

        /// <summary>
        /// Gets and sets the property AssociationId. 
        /// <para>
        /// The ID of the repository association.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string AssociationId
        {
            get { return this._associationId; }
            set { this._associationId = value; }
        }

        // Check to see if AssociationId property is set
        internal bool IsSetAssociationId()
        {
            return this._associationId != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectionArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) identifying the repository connection. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string ConnectionArn
        {
            get { return this._connectionArn; }
            set { this._connectionArn = value; }
        }

        // Check to see if ConnectionArn property is set
        internal bool IsSetConnectionArn()
        {
            return this._connectionArn != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedTimeStamp. 
        /// <para>
        /// The time, in milliseconds since the epoch, when the repository association was created.
        /// </para>
        /// </summary>
        public DateTime CreatedTimeStamp
        {
            get { return this._createdTimeStamp.GetValueOrDefault(); }
            set { this._createdTimeStamp = value; }
        }

        // Check to see if CreatedTimeStamp property is set
        internal bool IsSetCreatedTimeStamp()
        {
            return this._createdTimeStamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTimeStamp. 
        /// <para>
        /// The time, in milliseconds since the epoch, when the repository association was last
        /// updated.
        /// </para>
        /// </summary>
        public DateTime LastUpdatedTimeStamp
        {
            get { return this._lastUpdatedTimeStamp.GetValueOrDefault(); }
            set { this._lastUpdatedTimeStamp = value; }
        }

        // Check to see if LastUpdatedTimeStamp property is set
        internal bool IsSetLastUpdatedTimeStamp()
        {
            return this._lastUpdatedTimeStamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the repository.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// Gets and sets the property Owner. 
        /// <para>
        /// The owner of the repository.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string Owner
        {
            get { return this._owner; }
            set { this._owner = value; }
        }

        // Check to see if Owner property is set
        internal bool IsSetOwner()
        {
            return this._owner != null;
        }

        /// <summary>
        /// Gets and sets the property ProviderType. 
        /// <para>
        /// The provider type of the repository association.
        /// </para>
        /// </summary>
        public ProviderType ProviderType
        {
            get { return this._providerType; }
            set { this._providerType = value; }
        }

        // Check to see if ProviderType property is set
        internal bool IsSetProviderType()
        {
            return this._providerType != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the repository association.
        /// </para>
        /// </summary>
        public RepositoryAssociationState State
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
        /// A description of why the repository association is in the current state.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string StateReason
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