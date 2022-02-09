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
    /// Container for the parameters to the DisableFastLaunch operation.
    /// Discontinue faster launching for a Windows AMI, and clean up existing pre-provisioned
    /// snapshots. When you disable faster launching, the AMI uses the standard launch process
    /// for each instance. All pre-provisioned snapshots must be removed before you can enable
    /// faster launching again.
    /// 
    ///  <note> 
    /// <para>
    /// To change these settings, you must own the AMI.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DisableFastLaunchRequest : AmazonEC2Request
    {
        private bool? _force;
        private string _imageId;

        /// <summary>
        /// Gets and sets the property Force. 
        /// <para>
        /// Forces the image settings to turn off faster launching for your Windows AMI. This
        /// parameter overrides any errors that are encountered while cleaning up resources in
        /// your account.
        /// </para>
        /// </summary>
        public bool Force
        {
            get { return this._force.GetValueOrDefault(); }
            set { this._force = value; }
        }

        // Check to see if Force property is set
        internal bool IsSetForce()
        {
            return this._force.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ImageId. 
        /// <para>
        /// The ID of the image for which you’re turning off faster launching, and removing pre-provisioned
        /// snapshots.
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