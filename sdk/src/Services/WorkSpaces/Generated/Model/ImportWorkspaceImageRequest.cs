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

namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// Container for the parameters to the ImportWorkspaceImage operation.
    /// Imports the specified Windows 10 Bring Your Own License (BYOL) image into Amazon WorkSpaces.
    /// The image must be an already licensed Amazon EC2 image that is in your Amazon Web
    /// Services account, and you must own the image. For more information about creating
    /// BYOL images, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/byol-windows-images.html">
    /// Bring Your Own Windows Desktop Licenses</a>.
    /// </summary>
    public partial class ImportWorkspaceImageRequest : AmazonWorkSpacesRequest
    {
        private List<string> _applications = new List<string>();
        private string _ec2ImageId;
        private string _imageDescription;
        private string _imageName;
        private WorkspaceImageIngestionProcess _ingestionProcess;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property Applications. 
        /// <para>
        /// If specified, the version of Microsoft Office to subscribe to. Valid only for Windows
        /// 10 BYOL images. For more information about subscribing to Office for BYOL images,
        /// see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/byol-windows-images.html">
        /// Bring Your Own Windows Desktop Licenses</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Although this parameter is an array, only one item is allowed at this time.
        /// </para>
        ///  </note>
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
            return this._applications != null && this._applications.Count > 0; 
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
        /// you want to use for your BYOL Workspace image, either PCoIP, WorkSpaces Streaming
        /// Protocol (WSP), or bring your own protocol (BYOP). To use WSP, specify a value that
        /// ends in <code>_WSP</code>. To use PCoIP, specify a value that does not end in <code>_WSP</code>.
        /// To use BYOP, specify a value that ends in <code>_BYOP</code>.
        /// </para>
        ///  
        /// <para>
        /// For non-GPU-enabled bundles (bundles other than Graphics or GraphicsPro), specify
        /// <code>BYOL_REGULAR</code>, <code>BYOL_REGULAR_WSP</code>, or <code>BYOL_REGULAR_BYOP</code>,
        /// depending on the protocol.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>BYOL_REGULAR_BYOP</code> and <code>BYOL_GRAPHICS_G4DN_BYOP</code> values
        /// are only supported by Amazon WorkSpaces Core. Contact your account team to be allow-listed
        /// to use these values. For more information, see <a href="http://aws.amazon.com/workspaces/core/">Amazon
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
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}