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

namespace Amazon.LambdaMicrovms.Model
{
    /// <summary>
    /// Contains summary information about a MicroVM image.
    /// </summary>
    public partial class MicrovmImageSummary
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the MicroVM image was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ImageArn. 
        /// <para>
        /// The ARN of the MicroVM image.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string ImageArn { get; set; }

        /// <summary>
        /// Checks to see if the ImageArn property is set.
        /// </summary>
        internal bool IsSetImageArn() => this.ImageArn != null;

        /// <summary>
        /// Gets and sets the property LatestActiveImageVersion. 
        /// <para>
        /// The latest active version of the MicroVM image.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string LatestActiveImageVersion { get; set; }

        /// <summary>
        /// Checks to see if the LatestActiveImageVersion property is set.
        /// </summary>
        internal bool IsSetLatestActiveImageVersion() => this.LatestActiveImageVersion != null;

        /// <summary>
        /// Gets and sets the property LatestFailedImageVersion. 
        /// <para>
        /// The latest failed version of the MicroVM image, if any.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string LatestFailedImageVersion { get; set; }

        /// <summary>
        /// Checks to see if the LatestFailedImageVersion property is set.
        /// </summary>
        internal bool IsSetLatestFailedImageVersion() => this.LatestFailedImageVersion != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the MicroVM image.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the MicroVM image.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MicrovmImageState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
