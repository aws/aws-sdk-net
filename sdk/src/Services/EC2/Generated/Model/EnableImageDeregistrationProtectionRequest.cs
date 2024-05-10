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
    /// Container for the parameters to the EnableImageDeregistrationProtection operation.
    /// Enables deregistration protection for an AMI. When deregistration protection is enabled,
    /// the AMI can't be deregistered.
    /// 
    ///  
    /// <para>
    /// To allow the AMI to be deregistered, you must first disable deregistration protection
    /// using <a>DisableImageDeregistrationProtection</a>.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/deregister-ami.html#ami-deregistration-protection">Protect
    /// an AMI from deregistration</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    /// </summary>
    public partial class EnableImageDeregistrationProtectionRequest : AmazonEC2Request
    {
        private string _imageId;
        private bool? _withCooldown;

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

        /// <summary>
        /// Gets and sets the property WithCooldown. 
        /// <para>
        /// If <c>true</c>, enforces deregistration protection for 24 hours after deregistration
        /// protection is disabled.
        /// </para>
        /// </summary>
        public bool? WithCooldown
        {
            get { return this._withCooldown; }
            set { this._withCooldown = value; }
        }

        // Check to see if WithCooldown property is set
        internal bool IsSetWithCooldown()
        {
            return this._withCooldown.HasValue; 
        }

    }
}