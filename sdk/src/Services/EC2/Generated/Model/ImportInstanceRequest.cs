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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ImportInstance operation.
    /// <note> 
    /// <para>
    /// We recommend that you use the <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_ImportImage.html">
    /// <c>ImportImage</c> </a> API instead. For more information, see <a href="https://docs.aws.amazon.com/vm-import/latest/userguide/vmimport-image-import.html">Importing
    /// a VM as an image using VM Import/Export</a> in the <i>VM Import/Export User Guide</i>.
    /// </para>
    ///  </note> 
    /// <para>
    /// Creates an import instance task using metadata from the specified disk image.
    /// </para>
    ///  
    /// <para>
    /// This API action supports only single-volume VMs. To import multi-volume VMs, use <a>ImportImage</a>
    /// instead.
    /// </para>
    ///  
    /// <para>
    /// For information about the import manifest referenced by this API action, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/manifest.html">VM
    /// Import Manifest</a>.
    /// </para>
    ///  
    /// <para>
    /// This API action is not supported by the Command Line Interface (CLI).
    /// </para>
    /// </summary>
    public partial class ImportInstanceRequest : AmazonEC2Request
    {
        private string _description;
        private List<DiskImage> _diskImages = AWSConfigs.InitializeCollections ? new List<DiskImage>() : null;
        private bool? _dryRun;
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DiskImage> DiskImages
        {
            get { return this._diskImages; }
            set { this._diskImages = value; }
        }

        // Check to see if DiskImages property is set
        internal bool IsSetDiskImages()
        {
            return this._diskImages != null && (this._diskImages.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
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