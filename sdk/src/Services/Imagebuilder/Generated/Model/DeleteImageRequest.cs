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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
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
namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteImage operation.
    /// Deletes an Image Builder image resource. This does not delete any EC2 AMIs or ECR
    /// container images that are created during the image build process. You must clean those
    /// up separately, using the appropriate Amazon EC2 or Amazon ECR console actions, or
    /// API or CLI commands.
    /// 
    ///  <ul> <li> 
    /// <para>
    /// To deregister an EC2 Linux AMI, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/deregister-ami.html">Deregister
    /// your Linux AMI</a> in the <i> <i>Amazon EC2 User Guide</i> </i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To deregister an EC2 Windows AMI, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/WindowsGuide/deregister-ami.html">Deregister
    /// your Windows AMI</a> in the <i> <i>Amazon EC2 Windows Guide</i> </i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To delete a container image from Amazon ECR, see <a href="https://docs.aws.amazon.com/AmazonECR/latest/userguide/delete_image.html">Deleting
    /// an image</a> in the <i>Amazon ECR User Guide</i>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DeleteImageRequest : AmazonImagebuilderRequest
    {
        private string _imageBuildVersionArn;

        /// <summary>
        /// Gets and sets the property ImageBuildVersionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Image Builder image resource to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ImageBuildVersionArn
        {
            get { return this._imageBuildVersionArn; }
            set { this._imageBuildVersionArn = value; }
        }

        // Check to see if ImageBuildVersionArn property is set
        internal bool IsSetImageBuildVersionArn()
        {
            return this._imageBuildVersionArn != null;
        }

    }
}