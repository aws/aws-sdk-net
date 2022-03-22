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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// Container for the parameters to the UntagResource operation.
    /// Removes one or more tags from a resource. Specify only tag key(s) in your request.
    /// Do not specify the value.
    /// </summary>
    public partial class UntagResourceRequest : AmazonCostExplorerRequest
    {
        private string _resourceArn;
        private List<string> _resourceTagKeys = new List<string>();

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the resource. For a list of supported resources,
        /// see <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_ResourceTag.html">ResourceTag</a>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
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
        /// Gets and sets the property ResourceTagKeys. 
        /// <para>
        ///  A list of tag keys associated with tags that need to be removed from the resource.
        /// If you specify a tag key that does not exist, it is ignored. Although the maximum
        /// number of array members is 200, user-tag maximum is 50. The remaining are reserved
        /// for Amazon Web Services use. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=200)]
        public List<string> ResourceTagKeys
        {
            get { return this._resourceTagKeys; }
            set { this._resourceTagKeys = value; }
        }

        // Check to see if ResourceTagKeys property is set
        internal bool IsSetResourceTagKeys()
        {
            return this._resourceTagKeys != null && this._resourceTagKeys.Count > 0; 
        }

    }
}