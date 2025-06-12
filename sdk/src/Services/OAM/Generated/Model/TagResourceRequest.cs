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
 * Do not modify this file. This file is generated from the oam-2022-06-10.normal.json service model.
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
namespace Amazon.OAM.Model
{
    /// <summary>
    /// Container for the parameters to the TagResource operation.
    /// Assigns one or more tags (key-value pairs) to the specified resource. Both sinks and
    /// links can be tagged. 
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
    /// You can use the <c>TagResource</c> action with a resource that already has tags. If
    /// you specify a new tag key for the alarm, this tag is appended to the list of tags
    /// associated with the alarm. If you specify a tag key that is already associated with
    /// the alarm, the new tag value that you specify replaces the previous value for that
    /// tag.
    /// </para>
    ///  
    /// <para>
    /// You can associate as many as 50 tags with a resource.
    /// </para>
    ///  <important> 
    /// <para>
    /// Unlike tagging permissions in other Amazon Web Services services, to tag or untag
    /// links and sinks you must have the <c>oam:ResourceTag</c> permission. The <c>iam:ResourceTag</c>
    /// permission does not allow you to tag and untag links and sinks.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class TagResourceRequest : AmazonOAMRequest
    {
        private string _resourceArn;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The ARN of the resource that you're adding tags to.
        /// </para>
        ///  
        /// <para>
        /// The ARN format of a sink is <c>arn:aws:oam:<i>Region</i>:<i>account-id</i>:sink/<i>sink-id</i>
        /// </c> 
        /// </para>
        ///  
        /// <para>
        /// The ARN format of a link is <c>arn:aws:oam:<i>Region</i>:<i>account-id</i>:link/<i>link-id</i>
        /// </c> 
        /// </para>
        ///  
        /// <para>
        /// For more information about ARN format, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/iam-access-control-overview-cwl.html">CloudWatch
        /// Logs resources and operations</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The list of key-value pairs to associate with the resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=50)]
        public Dictionary<string, string> Tags
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