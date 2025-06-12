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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
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
namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// Container for the parameters to the TagResource operation.
    /// Assigns one or more tags (key-value pairs) to the specified CloudWatch resource. Currently,
    /// the only CloudWatch resources that can be tagged are alarms and Contributor Insights
    /// rules.
    /// 
    ///  
    /// <para>
    /// Tags can help you organize and categorize your resources. You can also use them to
    /// scope user permissions by granting a user permission to access or change only resources
    /// with certain tag values.
    /// </para>
    ///  
    /// <para>
    /// Tags don't have any semantic meaning to Amazon Web Services and are interpreted strictly
    /// as strings of characters.
    /// </para>
    ///  
    /// <para>
    /// You can use the <c>TagResource</c> action with an alarm that already has tags. If
    /// you specify a new tag key for the alarm, this tag is appended to the list of tags
    /// associated with the alarm. If you specify a tag key that is already associated with
    /// the alarm, the new tag value that you specify replaces the previous value for that
    /// tag.
    /// </para>
    ///  
    /// <para>
    /// You can associate as many as 50 tags with a CloudWatch resource.
    /// </para>
    /// </summary>
    public partial class TagResourceRequest : AmazonCloudWatchRequest
    {
        private string _resourceARN;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property ResourceARN. 
        /// <para>
        /// The ARN of the CloudWatch resource that you're adding tags to.
        /// </para>
        ///  
        /// <para>
        /// The ARN format of an alarm is <c>arn:aws:cloudwatch:<i>Region</i>:<i>account-id</i>:alarm:<i>alarm-name</i>
        /// </c> 
        /// </para>
        ///  
        /// <para>
        /// The ARN format of a Contributor Insights rule is <c>arn:aws:cloudwatch:<i>Region</i>:<i>account-id</i>:insight-rule/<i>insight-rule-name</i>
        /// </c> 
        /// </para>
        ///  
        /// <para>
        /// For more information about ARN format, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/list_amazoncloudwatch.html#amazoncloudwatch-resources-for-iam-policies">
        /// Resource Types Defined by Amazon CloudWatch</a> in the <i>Amazon Web Services General
        /// Reference</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
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
        /// The list of key-value pairs to associate with the alarm.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}