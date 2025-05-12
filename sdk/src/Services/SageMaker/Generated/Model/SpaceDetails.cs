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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The space's details.
    /// </summary>
    public partial class SpaceDetails
    {
        private DateTime? _creationTime;
        private string _domainId;
        private DateTime? _lastModifiedTime;
        private OwnershipSettingsSummary _ownershipSettingsSummary;
        private string _spaceDisplayName;
        private string _spaceName;
        private SpaceSettingsSummary _spaceSettingsSummary;
        private SpaceSharingSettingsSummary _spaceSharingSettingsSummary;
        private SpaceStatus _status;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The creation time.
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
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The ID of the associated domain.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=63)]
        public string DomainId
        {
            get { return this._domainId; }
            set { this._domainId = value; }
        }

        // Check to see if DomainId property is set
        internal bool IsSetDomainId()
        {
            return this._domainId != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The last modified time.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OwnershipSettingsSummary. 
        /// <para>
        /// Specifies summary information about the ownership settings.
        /// </para>
        /// </summary>
        public OwnershipSettingsSummary OwnershipSettingsSummary
        {
            get { return this._ownershipSettingsSummary; }
            set { this._ownershipSettingsSummary = value; }
        }

        // Check to see if OwnershipSettingsSummary property is set
        internal bool IsSetOwnershipSettingsSummary()
        {
            return this._ownershipSettingsSummary != null;
        }

        /// <summary>
        /// Gets and sets the property SpaceDisplayName. 
        /// <para>
        /// The name of the space that appears in the Studio UI.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=64)]
        public string SpaceDisplayName
        {
            get { return this._spaceDisplayName; }
            set { this._spaceDisplayName = value; }
        }

        // Check to see if SpaceDisplayName property is set
        internal bool IsSetSpaceDisplayName()
        {
            return this._spaceDisplayName != null;
        }

        /// <summary>
        /// Gets and sets the property SpaceName. 
        /// <para>
        /// The name of the space.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=63)]
        public string SpaceName
        {
            get { return this._spaceName; }
            set { this._spaceName = value; }
        }

        // Check to see if SpaceName property is set
        internal bool IsSetSpaceName()
        {
            return this._spaceName != null;
        }

        /// <summary>
        /// Gets and sets the property SpaceSettingsSummary. 
        /// <para>
        /// Specifies summary information about the space settings.
        /// </para>
        /// </summary>
        public SpaceSettingsSummary SpaceSettingsSummary
        {
            get { return this._spaceSettingsSummary; }
            set { this._spaceSettingsSummary = value; }
        }

        // Check to see if SpaceSettingsSummary property is set
        internal bool IsSetSpaceSettingsSummary()
        {
            return this._spaceSettingsSummary != null;
        }

        /// <summary>
        /// Gets and sets the property SpaceSharingSettingsSummary. 
        /// <para>
        /// Specifies summary information about the space sharing settings.
        /// </para>
        /// </summary>
        public SpaceSharingSettingsSummary SpaceSharingSettingsSummary
        {
            get { return this._spaceSharingSettingsSummary; }
            set { this._spaceSharingSettingsSummary = value; }
        }

        // Check to see if SpaceSharingSettingsSummary property is set
        internal bool IsSetSpaceSharingSettingsSummary()
        {
            return this._spaceSharingSettingsSummary != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status.
        /// </para>
        /// </summary>
        public SpaceStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}