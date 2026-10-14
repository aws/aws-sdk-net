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
    /// This is the response object from the DescribeImageVersion operation.
    /// </summary>
    public partial class DescribeImageVersionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property BaseImage. 
        /// <para>
        /// The registry path of the container image on which this image version is based.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string BaseImage { get; set; }

        /// <summary>
        /// Checks to see if the BaseImage property is set.
        /// </summary>
        internal bool IsSetBaseImage() => this.BaseImage != null;

        /// <summary>
        /// Gets and sets the property ContainerImage. 
        /// <para>
        /// The registry path of the container image that contains this image version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string ContainerImage { get; set; }

        /// <summary>
        /// Checks to see if the ContainerImage property is set.
        /// </summary>
        internal bool IsSetContainerImage() => this.ContainerImage != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// When the version was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// When a create or delete operation fails, the reason for the failure.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

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
        /// Gets and sets the property ImageArn. 
        /// <para>
        /// The ARN of the image the version is based on.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string ImageArn { get; set; }

        /// <summary>
        /// Checks to see if the ImageArn property is set.
        /// </summary>
        internal bool IsSetImageArn() => this.ImageArn != null;

        /// <summary>
        /// Gets and sets the property ImageVersionArn. 
        /// <para>
        /// The ARN of the version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string ImageVersionArn { get; set; }

        /// <summary>
        /// Checks to see if the ImageVersionArn property is set.
        /// </summary>
        internal bool IsSetImageVersionArn() => this.ImageVersionArn != null;

        /// <summary>
        /// Gets and sets the property ImageVersionStatus. 
        /// <para>
        /// The status of the version.
        /// </para>
        /// </summary>
        public ImageVersionStatus ImageVersionStatus { get; set; }

        /// <summary>
        /// Checks to see if the ImageVersionStatus property is set.
        /// </summary>
        internal bool IsSetImageVersionStatus() => this.ImageVersionStatus != null;

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
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// When the version was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

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
        /// The stability of the image version specified by the maintainer.
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
        /// The version number.
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
