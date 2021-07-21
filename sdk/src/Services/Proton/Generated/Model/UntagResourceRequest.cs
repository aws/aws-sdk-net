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
 * Do not modify this file. This file is generated from the proton-2020-07-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Proton.Model
{
    /// <summary>
    /// Container for the parameters to the UntagResource operation.
    /// Remove a tag from a resource. For more information, see <i>AWS Proton resources and
    /// tagging</i> in the <a href="https://docs.aws.amazon.com/proton/latest/adminguide/resources.html">AWS
    /// Proton Administrator Guide</a> or <a href="https://docs.aws.amazon.com/proton/latest/userguide/resources.html">AWS
    /// Proton User Guide</a>.
    /// </summary>
    public partial class UntagResourceRequest : AmazonProtonRequest
    {
        private string _resourceArn;
        private List<string> _tagKeys = new List<string>();

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource that the tag is to be removed from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
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
        /// An array of tag keys indicating the resource tags to be removed from the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=50)]
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