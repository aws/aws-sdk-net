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

namespace Amazon.OAM.Model
{
    /// <summary>
    /// Container for the parameters to the UntagResource operation.
    /// Removes one or more tags from the specified resource.
    /// 
    ///  <important> 
    /// <para>
    /// Unlike tagging permissions in other Amazon Web Services services, to tag or untag
    /// links and sinks you must have the <code>oam:ResourceTag</code> permission. The <code>iam:TagResource</code>
    /// permission does not allow you to tag and untag links and sinks.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class UntagResourceRequest : AmazonOAMRequest
    {
        private string _resourceArn;
        private List<string> _tagKeys = new List<string>();

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The ARN of the resource that you're removing tags from.
        /// </para>
        ///  
        /// <para>
        /// The ARN format of a sink is <code>arn:aws:oam:<i>Region</i>:<i>account-id</i>:sink/<i>sink-id</i>
        /// </code> 
        /// </para>
        ///  
        /// <para>
        /// The ARN format of a link is <code>arn:aws:oam:<i>Region</i>:<i>account-id</i>:link/<i>link-id</i>
        /// </code> 
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
        /// Gets and sets the property TagKeys. 
        /// <para>
        /// The list of tag keys to remove from the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> TagKeys
        {
            get { return this._tagKeys; }
            set { this._tagKeys = value; }
        }

        // Check to see if TagKeys property is set
        internal bool IsSetTagKeys()
        {
            return this._tagKeys != null && this._tagKeys.Count > 0; 
        }

    }
}