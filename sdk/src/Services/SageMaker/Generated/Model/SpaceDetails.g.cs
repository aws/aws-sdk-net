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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The creation time.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The ID of the associated domain.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 63)]
        public string DomainId { get; set; }

        /// <summary>
        /// Checks to see if the DomainId property is set.
        /// </summary>
        internal bool IsSetDomainId() => this.DomainId != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The last modified time.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property OwnershipSettingsSummary. 
        /// <para>
        /// Specifies summary information about the ownership settings.
        /// </para>
        /// </summary>
        public OwnershipSettingsSummary OwnershipSettingsSummary { get; set; }

        /// <summary>
        /// Checks to see if the OwnershipSettingsSummary property is set.
        /// </summary>
        internal bool IsSetOwnershipSettingsSummary() => this.OwnershipSettingsSummary != null;

        /// <summary>
        /// Gets and sets the property SpaceDisplayName. 
        /// <para>
        /// The name of the space that appears in the Studio UI.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string SpaceDisplayName { get; set; }

        /// <summary>
        /// Checks to see if the SpaceDisplayName property is set.
        /// </summary>
        internal bool IsSetSpaceDisplayName() => this.SpaceDisplayName != null;

        /// <summary>
        /// Gets and sets the property SpaceName. 
        /// <para>
        /// The name of the space.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 63)]
        public string SpaceName { get; set; }

        /// <summary>
        /// Checks to see if the SpaceName property is set.
        /// </summary>
        internal bool IsSetSpaceName() => this.SpaceName != null;

        /// <summary>
        /// Gets and sets the property SpaceSettingsSummary. 
        /// <para>
        /// Specifies summary information about the space settings.
        /// </para>
        /// </summary>
        public SpaceSettingsSummary SpaceSettingsSummary { get; set; }

        /// <summary>
        /// Checks to see if the SpaceSettingsSummary property is set.
        /// </summary>
        internal bool IsSetSpaceSettingsSummary() => this.SpaceSettingsSummary != null;

        /// <summary>
        /// Gets and sets the property SpaceSharingSettingsSummary. 
        /// <para>
        /// Specifies summary information about the space sharing settings.
        /// </para>
        /// </summary>
        public SpaceSharingSettingsSummary SpaceSharingSettingsSummary { get; set; }

        /// <summary>
        /// Checks to see if the SpaceSharingSettingsSummary property is set.
        /// </summary>
        internal bool IsSetSpaceSharingSettingsSummary() => this.SpaceSharingSettingsSummary != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status.
        /// </para>
        /// </summary>
        public SpaceStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
