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
    /// Container for the parameters to the UpdateImageVersion operation. Updates the properties
    /// of a SageMaker AI image version.
    /// </summary>
    public partial class UpdateImageVersionRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property Alias. 
        /// <para>
        /// The alias of the image version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Alias { get; set; }

        /// <summary>
        /// Checks to see if the Alias property is set.
        /// </summary>
        internal bool IsSetAlias() => this.Alias != null;

        /// <summary>
        /// Gets and sets the property AliasesToAdd. 
        /// <para>
        /// A list of aliases to add.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AliasesToAdd { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AliasesToAdd property is set.
        /// </summary>
        internal bool IsSetAliasesToAdd() => this.AliasesToAdd != null && (this.AliasesToAdd.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AliasesToDelete. 
        /// <para>
        /// A list of aliases to delete.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AliasesToDelete { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AliasesToDelete property is set.
        /// </summary>
        internal bool IsSetAliasesToDelete() => this.AliasesToDelete != null && (this.AliasesToDelete.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Horovod. 
        /// <para>
        /// Indicates Horovod compatibility.
        /// </para>
        /// </summary>
        public bool? Horovod { get; set; }

        /// <summary>
        /// Checks to see if the Horovod property is set.
        /// </summary>
        internal bool IsSetHorovod() => this.Horovod.HasValue;

        /// <summary>
        /// Gets and sets the property ImageName. 
        /// <para>
        /// The name of the image.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string ImageName { get; set; }

        /// <summary>
        /// Checks to see if the ImageName property is set.
        /// </summary>
        internal bool IsSetImageName() => this.ImageName != null;

        /// <summary>
        /// Gets and sets the property JobType. 
        /// <para>
        /// Indicates SageMaker AI job type compatibility.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>TRAINING</c>: The image version is compatible with SageMaker AI training jobs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INFERENCE</c>: The image version is compatible with SageMaker AI inference jobs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NOTEBOOK_KERNEL</c>: The image version is compatible with SageMaker AI notebook
        /// kernels.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public JobType JobType { get; set; }

        /// <summary>
        /// Checks to see if the JobType property is set.
        /// </summary>
        internal bool IsSetJobType() => this.JobType != null;

        /// <summary>
        /// Gets and sets the property MLFramework. 
        /// <para>
        /// The machine learning framework vended in the image version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string MLFramework { get; set; }

        /// <summary>
        /// Checks to see if the MLFramework property is set.
        /// </summary>
        internal bool IsSetMLFramework() => this.MLFramework != null;

        /// <summary>
        /// Gets and sets the property Processor. 
        /// <para>
        /// Indicates CPU or GPU compatibility.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CPU</c>: The image version is compatible with CPU.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GPU</c>: The image version is compatible with GPU.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public Processor Processor { get; set; }

        /// <summary>
        /// Checks to see if the Processor property is set.
        /// </summary>
        internal bool IsSetProcessor() => this.Processor != null;

        /// <summary>
        /// Gets and sets the property ProgrammingLang. 
        /// <para>
        /// The supported programming language and its version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ProgrammingLang { get; set; }

        /// <summary>
        /// Checks to see if the ProgrammingLang property is set.
        /// </summary>
        internal bool IsSetProgrammingLang() => this.ProgrammingLang != null;

        /// <summary>
        /// Gets and sets the property ReleaseNotes. 
        /// <para>
        /// The maintainer description of the image version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string ReleaseNotes { get; set; }

        /// <summary>
        /// Checks to see if the ReleaseNotes property is set.
        /// </summary>
        internal bool IsSetReleaseNotes() => this.ReleaseNotes != null;

        /// <summary>
        /// Gets and sets the property VendorGuidance. 
        /// <para>
        /// The availability of the image version specified by the maintainer.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>NOT_PROVIDED</c>: The maintainers did not provide a status for image version stability.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>STABLE</c>: The image version is stable.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TO_BE_ARCHIVED</c>: The image version is set to be archived. Custom image versions
        /// that are set to be archived are automatically archived after three months.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ARCHIVED</c>: The image version is archived. Archived image versions are not searchable
        /// and are no longer actively supported. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public VendorGuidance VendorGuidance { get; set; }

        /// <summary>
        /// Checks to see if the VendorGuidance property is set.
        /// </summary>
        internal bool IsSetVendorGuidance() => this.VendorGuidance != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the image.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version.HasValue;
    }
}
