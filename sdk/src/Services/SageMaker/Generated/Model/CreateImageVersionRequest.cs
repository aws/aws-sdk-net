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
    /// Container for the parameters to the CreateImageVersion operation.
    /// Creates a version of the SageMaker AI image specified by <c>ImageName</c>. The version
    /// represents the Amazon ECR container image specified by <c>BaseImage</c>.
    /// </summary>
    public partial class CreateImageVersionRequest : AmazonSageMakerRequest
    {
        private List<string> _aliases = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _baseImage;
        private string _clientToken;
        private bool? _horovod;
        private string _imageName;
        private JobType _jobType;
        private string _mlFramework;
        private Processor _processor;
        private string _programmingLang;
        private string _releaseNotes;
        private VendorGuidance _vendorGuidance;

        /// <summary>
        /// Gets and sets the property Aliases. 
        /// <para>
        /// A list of aliases created with the image version.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Aliases
        {
            get { return this._aliases; }
            set { this._aliases = value; }
        }

        // Check to see if Aliases property is set
        internal bool IsSetAliases()
        {
            return this._aliases != null && (this._aliases.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property BaseImage. 
        /// <para>
        /// The registry path of the container image to use as the starting point for this version.
        /// The path is an Amazon ECR URI in the following format:
        /// </para>
        ///  
        /// <para>
        ///  <c>&lt;acct-id&gt;.dkr.ecr.&lt;region&gt;.amazonaws.com/&lt;repo-name[:tag] or [@digest]&gt;</c>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string BaseImage
        {
            get { return this._baseImage; }
            set { this._baseImage = value; }
        }

        // Check to see if BaseImage property is set
        internal bool IsSetBaseImage()
        {
            return this._baseImage != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique ID. If not specified, the Amazon Web Services CLI and Amazon Web Services
        /// SDKs, such as the SDK for Python (Boto3), add a unique value to the call.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=36)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Horovod. 
        /// <para>
        /// Indicates Horovod compatibility.
        /// </para>
        /// </summary>
        public bool? Horovod
        {
            get { return this._horovod; }
            set { this._horovod = value; }
        }

        // Check to see if Horovod property is set
        internal bool IsSetHorovod()
        {
            return this._horovod.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ImageName. 
        /// <para>
        /// The <c>ImageName</c> of the <c>Image</c> to create a version of.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string ImageName
        {
            get { return this._imageName; }
            set { this._imageName = value; }
        }

        // Check to see if ImageName property is set
        internal bool IsSetImageName()
        {
            return this._imageName != null;
        }

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
        public JobType JobType
        {
            get { return this._jobType; }
            set { this._jobType = value; }
        }

        // Check to see if JobType property is set
        internal bool IsSetJobType()
        {
            return this._jobType != null;
        }

        /// <summary>
        /// Gets and sets the property MLFramework. 
        /// <para>
        /// The machine learning framework vended in the image version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string MLFramework
        {
            get { return this._mlFramework; }
            set { this._mlFramework = value; }
        }

        // Check to see if MLFramework property is set
        internal bool IsSetMLFramework()
        {
            return this._mlFramework != null;
        }

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
        public Processor Processor
        {
            get { return this._processor; }
            set { this._processor = value; }
        }

        // Check to see if Processor property is set
        internal bool IsSetProcessor()
        {
            return this._processor != null;
        }

        /// <summary>
        /// Gets and sets the property ProgrammingLang. 
        /// <para>
        /// The supported programming language and its version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ProgrammingLang
        {
            get { return this._programmingLang; }
            set { this._programmingLang = value; }
        }

        // Check to see if ProgrammingLang property is set
        internal bool IsSetProgrammingLang()
        {
            return this._programmingLang != null;
        }

        /// <summary>
        /// Gets and sets the property ReleaseNotes. 
        /// <para>
        /// The maintainer description of the image version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string ReleaseNotes
        {
            get { return this._releaseNotes; }
            set { this._releaseNotes = value; }
        }

        // Check to see if ReleaseNotes property is set
        internal bool IsSetReleaseNotes()
        {
            return this._releaseNotes != null;
        }

        /// <summary>
        /// Gets and sets the property VendorGuidance. 
        /// <para>
        /// The stability of the image version, specified by the maintainer.
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
        public VendorGuidance VendorGuidance
        {
            get { return this._vendorGuidance; }
            set { this._vendorGuidance = value; }
        }

        // Check to see if VendorGuidance property is set
        internal bool IsSetVendorGuidance()
        {
            return this._vendorGuidance != null;
        }

    }
}