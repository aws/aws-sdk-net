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

namespace Amazon.KinesisVideo.Model
{
    /// <summary>
    /// The structure that contains the information required to deliver images to a customer.
    /// </summary>
    public partial class ImageGenerationDestinationConfig
    {
        /// <summary>
        /// Gets and sets the property DestinationRegion. 
        /// <para>
        /// The Amazon Web Services Region of the S3 bucket where images will be delivered. This
        /// <c>DestinationRegion</c> must match the Region where the stream is located.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 9, Max = 14)]
        public string DestinationRegion { get; set; }

        /// <summary>
        /// Checks to see if the DestinationRegion property is set.
        /// </summary>
        internal bool IsSetDestinationRegion() => this.DestinationRegion != null;

        /// <summary>
        /// Gets and sets the property Uri. 
        /// <para>
        /// The Uniform Resource Identifier (URI) that identifies where the images will be delivered.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Uri { get; set; }

        /// <summary>
        /// Checks to see if the Uri property is set.
        /// </summary>
        internal bool IsSetUri() => this.Uri != null;
    }
}
