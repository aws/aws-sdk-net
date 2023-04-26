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
 * Do not modify this file. This file is generated from the application-autoscaling-2016-02-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ApplicationAutoScaling.Model
{
    /// <summary>
    /// Container for the parameters to the TagResource operation.
    /// Adds or edits tags on an Application Auto Scaling scalable target.
    /// 
    ///  
    /// <para>
    /// Each tag consists of a tag key and a tag value, which are both case-sensitive strings.
    /// To add a tag, specify a new tag key and a tag value. To edit a tag, specify an existing
    /// tag key and a new tag value.
    /// </para>
    ///  
    /// <para>
    /// You can use this operation to tag an Application Auto Scaling scalable target, but
    /// you cannot tag a scaling policy or scheduled action.
    /// </para>
    ///  
    /// <para>
    /// You can also add tags to an Application Auto Scaling scalable target while creating
    /// it (<code>RegisterScalableTarget</code>).
    /// </para>
    ///  
    /// <para>
    /// For general information about tags, including the format and syntax, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
    /// Amazon Web Services resources</a> in the <i>Amazon Web Services General Reference</i>.
    /// </para>
    ///  
    /// <para>
    /// Use tags to control access to a scalable target. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/application/userguide/resource-tagging-support.html">Tagging
    /// support for Application Auto Scaling</a> in the <i>Application Auto Scaling User Guide</i>.
    /// </para>
    /// </summary>
    public partial class TagResourceRequest : AmazonApplicationAutoScalingRequest
    {
        private string _resourceARN;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property ResourceARN. 
        /// <para>
        /// Identifies the Application Auto Scaling scalable target that you want to apply tags
        /// to.
        /// </para>
        ///  
        /// <para>
        /// For example: <code>arn:aws:application-autoscaling:us-east-1:123456789012:scalable-target/1234abcd56ab78cd901ef1234567890ab123</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// To get the ARN for a scalable target, use <a>DescribeScalableTargets</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1011)]
        public string ResourceARN
        {
            get { return this._resourceARN; }
            set { this._resourceARN = value; }
        }

        // Check to see if ResourceARN property is set
        internal bool IsSetResourceARN()
        {
            return this._resourceARN != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags assigned to the resource. A tag is a label that you assign to an AWS resource.
        /// </para>
        ///  
        /// <para>
        /// Each tag consists of a tag key and a tag value.
        /// </para>
        ///  
        /// <para>
        /// You cannot have more than one tag on an Application Auto Scaling scalable target with
        /// the same tag key. If you specify an existing tag key with a different tag value, Application
        /// Auto Scaling replaces the current tag value with the specified one.
        /// </para>
        ///  
        /// <para>
        /// For information about the rules that apply to tag keys and tag values, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/allocation-tag-restrictions.html">User-defined
        /// tag restrictions</a> in the <i>Amazon Web Services Billing and Cost Management User
        /// Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}