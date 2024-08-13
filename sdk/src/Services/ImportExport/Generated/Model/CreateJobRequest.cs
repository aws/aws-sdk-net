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
 * Do not modify this file. This file is generated from the importexport-2010-06-01.normal.json service model.
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
namespace Amazon.ImportExport.Model
{
    /// <summary>
    /// Container for the parameters to the CreateJob operation.
    /// This operation initiates the process of scheduling an upload or download of your data.
    /// You include in the request a manifest that describes the data transfer specifics.
    /// The response to the request includes a job ID, which you can use in other operations,
    /// a signature that you use to identify your storage device, and the address where you
    /// should ship your storage device.
    /// </summary>
    public partial class CreateJobRequest : AmazonImportExportRequest
    {
        private string _apiVersion;
        private JobType _jobType;
        private string _manifest;
        private string _manifestAddendum;
        private bool? _validateOnly;

        /// <summary>
        /// Gets and sets the property APIVersion.
        /// </summary>
        public string APIVersion
        {
            get { return this._apiVersion; }
            set { this._apiVersion = value; }
        }

        // Check to see if APIVersion property is set
        internal bool IsSetAPIVersion()
        {
            return this._apiVersion != null;
        }

        /// <summary>
        /// Gets and sets the property JobType.
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Manifest.
        /// </summary>
        [AWSProperty(Required=true)]
        public string Manifest
        {
            get { return this._manifest; }
            set { this._manifest = value; }
        }

        // Check to see if Manifest property is set
        internal bool IsSetManifest()
        {
            return this._manifest != null;
        }

        /// <summary>
        /// Gets and sets the property ManifestAddendum.
        /// </summary>
        public string ManifestAddendum
        {
            get { return this._manifestAddendum; }
            set { this._manifestAddendum = value; }
        }

        // Check to see if ManifestAddendum property is set
        internal bool IsSetManifestAddendum()
        {
            return this._manifestAddendum != null;
        }

        /// <summary>
        /// Gets and sets the property ValidateOnly.
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? ValidateOnly
        {
            get { return this._validateOnly; }
            set { this._validateOnly = value; }
        }

        // Check to see if ValidateOnly property is set
        internal bool IsSetValidateOnly()
        {
            return this._validateOnly.HasValue; 
        }

    }
}