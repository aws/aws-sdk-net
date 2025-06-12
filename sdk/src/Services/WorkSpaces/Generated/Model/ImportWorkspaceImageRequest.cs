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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
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
namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// Container for the parameters to the ImportWorkspaceImage operation.
    /// Imports the specified Windows 10 or 11 Bring Your Own License (BYOL) image into Amazon
    /// WorkSpaces. The image must be an already licensed Amazon EC2 image that is in your
    /// Amazon Web Services account, and you must own the image. For more information about
    /// creating BYOL images, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/byol-windows-images.html">
    /// Bring Your Own Windows Desktop Licenses</a>.
    /// </summary>
    public partial class ImportWorkspaceImageRequest : AmazonWorkSpacesRequest
    {
        private List<string> _applications = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _ec2ImageId;
        private string _imageDescription;
        private string _imageName;
        private WorkspaceImageIngestionProcess _ingestionProcess;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property Applications. 
        /// <para>
        /// If specified, the version of Microsoft Office to subscribe to. Valid only for Windows
        /// 10 and 11 BYOL images. For more information about subscribing to Office for BYOL images,
        /// see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/byol-windows-images.html">
        /// Bring Your Own Windows Desktop Licenses</a>.
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        /// Although this parameter is an array, only one item is allowed at this time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// During the image import process, non-GPU DCV (formerly WSP) WorkSpaces with Windows
        /// 11 support only <c>Microsoft_Office_2019</c>. GPU DCV (formerly WSP) WorkSpaces with
        /// Windows 11 do not support Office installation.
        /// </para>
        ///  </li> </ul> </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public List<string> Applications
        {
            get { return this._applications; }
            set { this._applications = value; }
        }

        // Check to see if Applications property is set
        internal bool IsSetApplications()
        {
            return this._applications != null && (this._applications.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Ec2ImageId. 
        /// <para>
        /// The identifier of the EC2 image.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Ec2ImageId
        {
            get { return this._ec2ImageId; }
            set { this._ec2ImageId = value; }
        }

        // Check to see if Ec2ImageId property is set
        internal bool IsSetEc2ImageId()
        {
            return this._ec2ImageId != null;
        }

        /// <summary>
        /// Gets and sets the property ImageDescription. 
        /// <para>
        /// The description of the WorkSpace image.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ImageDescription
        {
            get { return this._imageDescription; }
            set { this._imageDescription = value; }
        }

        // Check to see if ImageDescription property is set
        internal bool IsSetImageDescription()
        {
            return this._imageDescription != null;
        }

        /// <summary>
        /// Gets and sets the property ImageName. 
        /// <para>
        /// The name of the WorkSpace image.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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
        /// Gets and sets the property IngestionProcess. 
        /// <para>
        /// The ingestion process to be used when importing the image, depending on which protocol
        /// you want to use for your BYOL Workspace image, either PCoIP, WSP, or bring your own
        /// protocol (BYOP). To use DCV, specify a value that ends in <c>_WSP</c>. To use PCoIP,
        /// specify a value that does not end in <c>_WSP</c>. To use BYOP, specify a value that
        /// ends in <c>_BYOP</c>.
        /// </para>
        ///  
        /// <para>
        /// For non-GPU-enabled bundles (bundles other than Graphics or GraphicsPro), specify
        /// <c>BYOL_REGULAR</c>, <c>BYOL_REGULAR_WSP</c>, or <c>BYOL_REGULAR_BYOP</c>, depending
        /// on the protocol.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <c>BYOL_REGULAR_BYOP</c> and <c>BYOL_GRAPHICS_G4DN_BYOP</c> values are only supported
        /// by Amazon WorkSpaces Core. Contact your account team to be allow-listed to use these
        /// values. For more information, see <a href="http://aws.amazon.com/workspaces/core/">Amazon
        /// WorkSpaces Core</a>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
        public WorkspaceImageIngestionProcess IngestionProcess
        {
            get { return this._ingestionProcess; }
            set { this._ingestionProcess = value; }
        }

        // Check to see if IngestionProcess property is set
        internal bool IsSetIngestionProcess()
        {
            return this._ingestionProcess != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags. Each WorkSpaces resource can have a maximum of 50 tags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}