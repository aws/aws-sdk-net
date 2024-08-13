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
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
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
namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Describes a trust relationship between an Managed Microsoft AD directory and an external
    /// domain.
    /// </summary>
    public partial class Trust
    {
        private DateTime? _createdDateTime;
        private string _directoryId;
        private DateTime? _lastUpdatedDateTime;
        private string _remoteDomainName;
        private SelectiveAuth _selectiveAuth;
        private DateTime? _stateLastUpdatedDateTime;
        private TrustDirection _trustDirection;
        private string _trustId;
        private TrustState _trustState;
        private string _trustStateReason;
        private TrustType _trustType;

        /// <summary>
        /// Gets and sets the property CreatedDateTime. 
        /// <para>
        /// The date and time that the trust relationship was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedDateTime
        {
            get { return this._createdDateTime; }
            set { this._createdDateTime = value; }
        }

        // Check to see if CreatedDateTime property is set
        internal bool IsSetCreatedDateTime()
        {
            return this._createdDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// The Directory ID of the Amazon Web Services directory involved in the trust relationship.
        /// </para>
        /// </summary>
        public string DirectoryId
        {
            get { return this._directoryId; }
            set { this._directoryId = value; }
        }

        // Check to see if DirectoryId property is set
        internal bool IsSetDirectoryId()
        {
            return this._directoryId != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedDateTime. 
        /// <para>
        /// The date and time that the trust relationship was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedDateTime
        {
            get { return this._lastUpdatedDateTime; }
            set { this._lastUpdatedDateTime = value; }
        }

        // Check to see if LastUpdatedDateTime property is set
        internal bool IsSetLastUpdatedDateTime()
        {
            return this._lastUpdatedDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RemoteDomainName. 
        /// <para>
        /// The Fully Qualified Domain Name (FQDN) of the external domain involved in the trust
        /// relationship.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string RemoteDomainName
        {
            get { return this._remoteDomainName; }
            set { this._remoteDomainName = value; }
        }

        // Check to see if RemoteDomainName property is set
        internal bool IsSetRemoteDomainName()
        {
            return this._remoteDomainName != null;
        }

        /// <summary>
        /// Gets and sets the property SelectiveAuth. 
        /// <para>
        /// Current state of selective authentication for the trust.
        /// </para>
        /// </summary>
        public SelectiveAuth SelectiveAuth
        {
            get { return this._selectiveAuth; }
            set { this._selectiveAuth = value; }
        }

        // Check to see if SelectiveAuth property is set
        internal bool IsSetSelectiveAuth()
        {
            return this._selectiveAuth != null;
        }

        /// <summary>
        /// Gets and sets the property StateLastUpdatedDateTime. 
        /// <para>
        /// The date and time that the TrustState was last updated.
        /// </para>
        /// </summary>
        public DateTime? StateLastUpdatedDateTime
        {
            get { return this._stateLastUpdatedDateTime; }
            set { this._stateLastUpdatedDateTime = value; }
        }

        // Check to see if StateLastUpdatedDateTime property is set
        internal bool IsSetStateLastUpdatedDateTime()
        {
            return this._stateLastUpdatedDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TrustDirection. 
        /// <para>
        /// The trust relationship direction.
        /// </para>
        /// </summary>
        public TrustDirection TrustDirection
        {
            get { return this._trustDirection; }
            set { this._trustDirection = value; }
        }

        // Check to see if TrustDirection property is set
        internal bool IsSetTrustDirection()
        {
            return this._trustDirection != null;
        }

        /// <summary>
        /// Gets and sets the property TrustId. 
        /// <para>
        /// The unique ID of the trust relationship.
        /// </para>
        /// </summary>
        public string TrustId
        {
            get { return this._trustId; }
            set { this._trustId = value; }
        }

        // Check to see if TrustId property is set
        internal bool IsSetTrustId()
        {
            return this._trustId != null;
        }

        /// <summary>
        /// Gets and sets the property TrustState. 
        /// <para>
        /// The trust relationship state.
        /// </para>
        /// </summary>
        public TrustState TrustState
        {
            get { return this._trustState; }
            set { this._trustState = value; }
        }

        // Check to see if TrustState property is set
        internal bool IsSetTrustState()
        {
            return this._trustState != null;
        }

        /// <summary>
        /// Gets and sets the property TrustStateReason. 
        /// <para>
        /// The reason for the TrustState.
        /// </para>
        /// </summary>
        public string TrustStateReason
        {
            get { return this._trustStateReason; }
            set { this._trustStateReason = value; }
        }

        // Check to see if TrustStateReason property is set
        internal bool IsSetTrustStateReason()
        {
            return this._trustStateReason != null;
        }

        /// <summary>
        /// Gets and sets the property TrustType. 
        /// <para>
        /// The trust relationship type. <c>Forest</c> is the default.
        /// </para>
        /// </summary>
        public TrustType TrustType
        {
            get { return this._trustType; }
            set { this._trustType = value; }
        }

        // Check to see if TrustType property is set
        internal bool IsSetTrustType()
        {
            return this._trustType != null;
        }

    }
}