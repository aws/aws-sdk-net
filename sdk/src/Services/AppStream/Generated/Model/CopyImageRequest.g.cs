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

namespace Amazon.AppStream.Model
{
    /// <summary>
    /// Container for the parameters to the CopyImage operation. Copies the image within the
    /// same region or to a new region within the same AWS account. Note that any tags you
    /// added to the image will not be copied.
    /// </summary>
    public partial class CopyImageRequest : AmazonAppStreamRequest
    {
        /// <summary>
        /// Gets and sets the property DestinationImageDescription. 
        /// <para>
        /// The description that the image will have when it is copied to the destination.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string DestinationImageDescription { get; set; }

        /// <summary>
        /// Checks to see if the DestinationImageDescription property is set.
        /// </summary>
        internal bool IsSetDestinationImageDescription() => this.DestinationImageDescription != null;

        /// <summary>
        /// Gets and sets the property DestinationImageName. 
        /// <para>
        /// The name that the image will have when it is copied to the destination.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DestinationImageName { get; set; }

        /// <summary>
        /// Checks to see if the DestinationImageName property is set.
        /// </summary>
        internal bool IsSetDestinationImageName() => this.DestinationImageName != null;

        /// <summary>
        /// Gets and sets the property DestinationRegion. 
        /// <para>
        /// The destination region to which the image will be copied. This parameter is required,
        /// even if you are copying an image within the same region.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 32)]
        public string DestinationRegion { get; set; }

        /// <summary>
        /// Checks to see if the DestinationRegion property is set.
        /// </summary>
        internal bool IsSetDestinationRegion() => this.DestinationRegion != null;

        /// <summary>
        /// Gets and sets the property SourceImageName. 
        /// <para>
        /// The name of the image to copy.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SourceImageName { get; set; }

        /// <summary>
        /// Checks to see if the SourceImageName property is set.
        /// </summary>
        internal bool IsSetSourceImageName() => this.SourceImageName != null;
    }
}
