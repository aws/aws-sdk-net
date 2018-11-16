/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// Container for the parameters to the ImportWorkspaceImage operation.
    /// Imports the specified Windows 7 or Windows 10 bring your own license (BYOL) image
    /// into Amazon WorkSpaces. The image must be an already licensed EC2 image that is in
    /// your AWS account, and you must own the image.
    /// </summary>
    public partial class ImportWorkspaceImageRequest : AmazonWorkSpacesRequest
    {
        private string _ec2ImageId;
        private string _imageDescription;
        private string _imageName;
        private WorkspaceImageIngestionProcess _ingestionProcess;

        /// <summary>
        /// Gets and sets the property Ec2ImageId. 
        /// <para>
        /// The identifier of the EC2 image.
        /// </para>
        /// </summary>
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
        /// The ingestion process to be used when importing the image.
        /// </para>
        /// </summary>
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

    }
}