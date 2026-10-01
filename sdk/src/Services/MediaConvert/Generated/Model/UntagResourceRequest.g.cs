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

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Container for the parameters to the UntagResource operation. Remove tags from a MediaConvert
    /// queue, preset, job, or job template. For information about tagging, see the User Guide
    /// at https://docs.aws.amazon.com/mediaconvert/latest/ug/tagging-mediaconvert-resources.html.
    /// </summary>
    public partial class UntagResourceRequest : AmazonMediaConvertRequest
    {
        /// <summary>
        /// Gets and sets the property Arn. The Amazon Resource Name (ARN) of the resource that
        /// you want to remove tags from. To get the ARN, send a GET request with the resource
        /// name.
        /// </summary>
        [AWSProperty(Required = true)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property TagKeys. The keys of the tags that you want to remove from
        /// the resource.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> TagKeys { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TagKeys property is set.
        /// </summary>
        internal bool IsSetTagKeys() => this.TagKeys != null && (this.TagKeys.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
