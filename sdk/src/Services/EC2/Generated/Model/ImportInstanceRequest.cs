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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ImportInstance operation.
    /// Creates an import instance task using metadata from the specified disk image. <code>ImportInstance</code>
    /// only supports single-volume VMs. To import multi-volume VMs, use <a>ImportImage</a>.
    /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/CommandLineReference/ec2-cli-vmimport-export.html">Importing
    /// a Virtual Machine Using the Amazon EC2 CLI</a>.
    /// 
    ///  
    /// <para>
    /// For information about the import manifest referenced by this API action, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/manifest.html">VM
    /// Import Manifest</a>.
    /// </para>
    /// </summary>
    public partial class ImportInstanceRequest : AmazonEC2Request
    {
        private string _description;
        private List<DiskImage> _diskImages = new List<DiskImage>();
        private ImportInstanceLaunchSpecification _launchSpecification;
        private PlatformValues _platform;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the instance being imported.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DiskImages. 
        /// <para>
        /// The disk image.
        /// </para>
        /// </summary>
        public List<DiskImage> DiskImages
        {
            get { return this._diskImages; }
            set { this._diskImages = value; }
        }

        // Check to see if DiskImages property is set
        internal bool IsSetDiskImages()
        {
            return this._diskImages != null && this._diskImages.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LaunchSpecification. 
        /// <para>
        /// The launch specification.
        /// </para>
        /// </summary>
        public ImportInstanceLaunchSpecification LaunchSpecification
        {
            get { return this._launchSpecification; }
            set { this._launchSpecification = value; }
        }

        // Check to see if LaunchSpecification property is set
        internal bool IsSetLaunchSpecification()
        {
            return this._launchSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property Platform. 
        /// <para>
        /// The instance operating system.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PlatformValues Platform
        {
            get { return this._platform; }
            set { this._platform = value; }
        }

        // Check to see if Platform property is set
        internal bool IsSetPlatform()
        {
            return this._platform != null;
        }

    }
}