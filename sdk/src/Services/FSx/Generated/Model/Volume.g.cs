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

namespace Amazon.FSx.Model
{
    /// <summary>
    /// Describes an Amazon FSx volume.
    /// </summary>
    public partial class Volume
    {
        /// <summary>
        /// Gets and sets the property AdministrativeActions. 
        /// <para>
        /// A list of administrative actions for the volume that are in process or waiting to
        /// be processed. Administrative actions describe changes to the volume that you have
        /// initiated using the <c>UpdateVolume</c> action.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<AdministrativeAction> AdministrativeActions { get; set; } = AWSConfigs.InitializeCollections ? new List<AdministrativeAction>() : null;

        /// <summary>
        /// Checks to see if the AdministrativeActions property is set.
        /// </summary>
        internal bool IsSetAdministrativeActions() => this.AdministrativeActions != null && (this.AdministrativeActions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CreationTime.
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property FileSystemId.
        /// </summary>
        [AWSProperty(Min = 11, Max = 21)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// Checks to see if the FileSystemId property is set.
        /// </summary>
        internal bool IsSetFileSystemId() => this.FileSystemId != null;

        /// <summary>
        /// Gets and sets the property Lifecycle. 
        /// <para>
        /// The lifecycle status of the volume.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AVAILABLE</c> - The volume is fully available for use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATED</c> - The volume has been created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATING</c> - Amazon FSx is creating the new volume.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETING</c> - Amazon FSx is deleting an existing volume.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> - Amazon FSx was unable to create the volume.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MISCONFIGURED</c> - The volume is in a failed but recoverable state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PENDING</c> - Amazon FSx hasn't started creating the volume.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public VolumeLifecycle Lifecycle { get; set; }

        /// <summary>
        /// Checks to see if the Lifecycle property is set.
        /// </summary>
        internal bool IsSetLifecycle() => this.Lifecycle != null;

        /// <summary>
        /// Gets and sets the property LifecycleTransitionReason. 
        /// <para>
        /// The reason why the volume lifecycle status changed.
        /// </para>
        /// </summary>
        public LifecycleTransitionReason LifecycleTransitionReason { get; set; }

        /// <summary>
        /// Checks to see if the LifecycleTransitionReason property is set.
        /// </summary>
        internal bool IsSetLifecycleTransitionReason() => this.LifecycleTransitionReason != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the volume.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 203)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OntapConfiguration.
        /// </summary>
        public OntapVolumeConfiguration OntapConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the OntapConfiguration property is set.
        /// </summary>
        internal bool IsSetOntapConfiguration() => this.OntapConfiguration != null;

        /// <summary>
        /// Gets and sets the property OpenZFSConfiguration. 
        /// <para>
        /// The configuration of an Amazon FSx for OpenZFS volume.
        /// </para>
        /// </summary>
        public OpenZFSVolumeConfiguration OpenZFSConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the OpenZFSConfiguration property is set.
        /// </summary>
        internal bool IsSetOpenZFSConfiguration() => this.OpenZFSConfiguration != null;

        /// <summary>
        /// Gets and sets the property ResourceARN.
        /// </summary>
        [AWSProperty(Min = 8, Max = 512)]
        public string ResourceARN { get; set; }

        /// <summary>
        /// Checks to see if the ResourceARN property is set.
        /// </summary>
        internal bool IsSetResourceARN() => this.ResourceARN != null;

        /// <summary>
        /// Gets and sets the property Tags.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VolumeId. 
        /// <para>
        /// The system-generated, unique ID of the volume.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 23, Max = 23)]
        public string VolumeId { get; set; }

        /// <summary>
        /// Checks to see if the VolumeId property is set.
        /// </summary>
        internal bool IsSetVolumeId() => this.VolumeId != null;

        /// <summary>
        /// Gets and sets the property VolumeType. 
        /// <para>
        /// The type of the volume.
        /// </para>
        /// </summary>
        public VolumeType VolumeType { get; set; }

        /// <summary>
        /// Checks to see if the VolumeType property is set.
        /// </summary>
        internal bool IsSetVolumeType() => this.VolumeType != null;
    }
}
