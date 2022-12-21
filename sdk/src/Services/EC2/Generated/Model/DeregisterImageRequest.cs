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
    /// Container for the parameters to the DeregisterImage operation.
    /// Deregisters the specified AMI. After you deregister an AMI, it can't be used to launch
    /// new instances.
    /// 
    ///  
    /// <para>
    /// If you deregister an AMI that matches a Recycle Bin retention rule, the AMI is retained
    /// in the Recycle Bin for the specified retention period. For more information, see <a
    /// href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/recycle-bin.html">Recycle
    /// Bin</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// When you deregister an AMI, it doesn't affect any instances that you've already launched
    /// from the AMI. You'll continue to incur usage costs for those instances until you terminate
    /// them.
    /// </para>
    ///  
    /// <para>
    /// When you deregister an Amazon EBS-backed AMI, it doesn't affect the snapshot that
    /// was created for the root volume of the instance during the AMI creation process. When
    /// you deregister an instance store-backed AMI, it doesn't affect the files that you
    /// uploaded to Amazon S3 when you created the AMI.
    /// </para>
    /// </summary>
    public partial class DeregisterImageRequest : AmazonEC2Request
    {
        private string _imageId;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DeregisterImageRequest() { }

        /// <summary>
        /// Instantiates DeregisterImageRequest with the parameterized properties
        /// </summary>
        /// <param name="imageId">The ID of the AMI.</param>
        public DeregisterImageRequest(string imageId)
        {
            _imageId = imageId;
        }

        /// <summary>
        /// Gets and sets the property ImageId. 
        /// <para>
        /// The ID of the AMI.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ImageId
        {
            get { return this._imageId; }
            set { this._imageId = value; }
        }

        // Check to see if ImageId property is set
        internal bool IsSetImageId()
        {
            return this._imageId != null;
        }

    }
}