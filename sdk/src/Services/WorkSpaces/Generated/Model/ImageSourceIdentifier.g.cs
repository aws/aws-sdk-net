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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Describes the image import source.
    /// </summary>
    public partial class ImageSourceIdentifier
    {
        /// <summary>
        /// Gets and sets the property Ec2ImageId. 
        /// <para>
        /// The identifier of the EC2 image.
        /// </para>
        /// </summary>
        public string Ec2ImageId { get; set; }

        /// <summary>
        /// Checks to see if the Ec2ImageId property is set.
        /// </summary>
        internal bool IsSetEc2ImageId() => this.Ec2ImageId != null;

        /// <summary>
        /// Gets and sets the property Ec2ImportTaskId. 
        /// <para>
        /// The EC2 import task ID to import the image from the Amazon EC2 VM import process.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 19, Max = 28)]
        public string Ec2ImportTaskId { get; set; }

        /// <summary>
        /// Checks to see if the Ec2ImportTaskId property is set.
        /// </summary>
        internal bool IsSetEc2ImportTaskId() => this.Ec2ImportTaskId != null;

        /// <summary>
        /// Gets and sets the property ImageBuildVersionArn. 
        /// <para>
        /// The ARN of the EC2 Image Builder image.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string ImageBuildVersionArn { get; set; }

        /// <summary>
        /// Checks to see if the ImageBuildVersionArn property is set.
        /// </summary>
        internal bool IsSetImageBuildVersionArn() => this.ImageBuildVersionArn != null;
    }
}
