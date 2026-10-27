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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Avail Blanking
    /// </summary>
    public partial class AvailBlanking
    {
        /// <summary>
        /// Gets and sets the property AvailBlankingImage. Blanking image to be used. Leave empty
        /// for solid black. Only bmp and png images are supported.
        /// </summary>
        public InputLocation AvailBlankingImage { get; set; }

        /// <summary>
        /// Checks to see if the AvailBlankingImage property is set.
        /// </summary>
        internal bool IsSetAvailBlankingImage() => this.AvailBlankingImage != null;

        /// <summary>
        /// Gets and sets the property State. When set to enabled, causes video, audio and captions
        /// to be blanked when insertion metadata is added.
        /// </summary>
        public AvailBlankingState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
