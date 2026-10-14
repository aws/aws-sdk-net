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

namespace Amazon.ApplicationAutoScaling.Model
{
    /// <summary>
    /// Container for the parameters to the UntagResource operation. Deletes tags from an
    /// Application Auto Scaling scalable target. To delete a tag, specify the tag key and
    /// the Application Auto Scaling scalable target.
    /// </summary>
    public partial class UntagResourceRequest : AmazonApplicationAutoScalingRequest
    {
        /// <summary>
        /// Gets and sets the property ResourceARN. 
        /// <para>
        /// Identifies the Application Auto Scaling scalable target from which to remove tags.
        /// </para>
        ///  
        /// <para>
        /// For example: <c>arn:aws:application-autoscaling:us-east-1:123456789012:scalable-target/1234abcd56ab78cd901ef1234567890ab123</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// To get the ARN for a scalable target, use <a>DescribeScalableTargets</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1011)]
        public string ResourceARN { get; set; }

        /// <summary>
        /// Checks to see if the ResourceARN property is set.
        /// </summary>
        internal bool IsSetResourceARN() => this.ResourceARN != null;

        /// <summary>
        /// Gets and sets the property TagKeys. 
        /// <para>
        /// One or more tag keys. Specify only the tag keys, not the tag values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 200)]
        public List<string> TagKeys { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TagKeys property is set.
        /// </summary>
        internal bool IsSetTagKeys() => this.TagKeys != null && (this.TagKeys.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
