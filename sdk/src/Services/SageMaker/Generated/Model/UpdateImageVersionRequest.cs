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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateImageVersion operation.
    /// Updates the properties of a SageMaker image version.
    /// </summary>
    public partial class UpdateImageVersionRequest : AmazonSageMakerRequest
    {
        private string _alias;
        private List<string> _aliasesToAdd = new List<string>();
        private List<string> _aliasesToDelete = new List<string>();
        private bool? _horovod;
        private string _imageName;
        private JobType _jobType;
        private string _mlFramework;
        private Processor _processor;
        private string _programmingLang;
        private string _releaseNotes;
        private VendorGuidance _vendorGuidance;
        private int? _version;

        /// <summary>
        /// Gets and sets the property Alias. 
        /// <para>
        /// The alias of the image version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string Alias
        {
            get { return this._alias; }
            set { this._alias = value; }
        }

        // Check to see if Alias property is set
        internal bool IsSetAlias()
        {
            return this._alias != null;
        }

        /// <summary>
        /// Gets and sets the property AliasesToAdd. 
        /// <para>
        /// A list of aliases to add.
        /// </para>
        /// </summary>
        public List<string> AliasesToAdd
        {
            get { return this._aliasesToAdd; }
            set { this._aliasesToAdd = value; }
        }

        // Check to see if AliasesToAdd property is set
        internal bool IsSetAliasesToAdd()
        {
            return this._aliasesToAdd != null && this._aliasesToAdd.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AliasesToDelete. 
        /// <para>
        /// A list of aliases to delete.
        /// </para>
        /// </summary>
        public List<string> AliasesToDelete
        {
            get { return this._aliasesToDelete; }
            set { this._aliasesToDelete = value; }
        }

        // Check to see if AliasesToDelete property is set
        internal bool IsSetAliasesToDelete()
        {
            return this._aliasesToDelete != null && this._aliasesToDelete.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Horovod. 
        /// <para>
        /// Indicates Horovod compatibility.
        /// </para>
        /// </summary>
        public bool Horovod
        {
            get { return this._horovod.GetValueOrDefault(); }
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
        /// The name of the image.
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
        /// Indicates SageMaker job type compatibility.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>TRAINING</code>: The image version is compatible with SageMaker training jobs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>INFERENCE</code>: The image version is compatible with SageMaker inference
        /// jobs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NOTEBOOK_KERNEL</code>: The image version is compatible with SageMaker notebook
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
        ///  <code>CPU</code>: The image version is compatible with CPU.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>GPU</code>: The image version is compatible with GPU.
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
        /// The availability of the image version specified by the maintainer.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>NOT_PROVIDED</code>: The maintainers did not provide a status for image version
        /// stability.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>STABLE</code>: The image version is stable.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TO_BE_ARCHIVED</code>: The image version is set to be archived. Custom image
        /// versions that are set to be archived are automatically archived after three months.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ARCHIVED</code>: The image version is archived. Archived image versions are
        /// not searchable and are no longer actively supported. 
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

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the image.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int Version
        {
            get { return this._version.GetValueOrDefault(); }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version.HasValue; 
        }

    }
}