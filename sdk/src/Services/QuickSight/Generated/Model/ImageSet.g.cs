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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The image set.
    /// </summary>
    public partial class ImageSet
    {
        /// <summary>
        /// Gets and sets the property Height32. 
        /// <para>
        /// The image with the height set to 32 pixels.
        /// </para>
        /// </summary>
        public Image Height32 { get; set; }

        /// <summary>
        /// Checks to see if the Height32 property is set.
        /// </summary>
        internal bool IsSetHeight32() => this.Height32 != null;

        /// <summary>
        /// Gets and sets the property Height64. 
        /// <para>
        /// The image with the height set to 64 pixels.
        /// </para>
        /// </summary>
        public Image Height64 { get; set; }

        /// <summary>
        /// Checks to see if the Height64 property is set.
        /// </summary>
        internal bool IsSetHeight64() => this.Height64 != null;

        /// <summary>
        /// Gets and sets the property Original. 
        /// <para>
        /// The original image.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Image Original { get; set; }

        /// <summary>
        /// Checks to see if the Original property is set.
        /// </summary>
        internal bool IsSetOriginal() => this.Original != null;
    }
}
