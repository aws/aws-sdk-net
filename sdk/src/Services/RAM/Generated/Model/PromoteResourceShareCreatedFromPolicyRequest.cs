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
 * Do not modify this file. This file is generated from the ram-2018-01-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RAM.Model
{
    /// <summary>
    /// Container for the parameters to the PromoteResourceShareCreatedFromPolicy operation.
    /// When you attach a resource-based permission policy to a resource, it automatically
    /// creates a resource share. However, resource shares created this way are visible only
    /// to the resource share owner, and the resource share can't be modified in RAM.
    /// 
    ///  
    /// <para>
    /// You can use this operation to promote the resource share to a full RAM resource share.
    /// When you promote a resource share, you can then manage the resource share in RAM and
    /// it becomes visible to all of the principals you shared it with.
    /// </para>
    /// </summary>
    public partial class PromoteResourceShareCreatedFromPolicyRequest : AmazonRAMRequest
    {
        private string _resourceShareArn;

        /// <summary>
        /// Gets and sets the property ResourceShareArn. 
        /// <para>
        /// Specifies the <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resoure Name (ARN)</a> of the resource share to promote.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ResourceShareArn
        {
            get { return this._resourceShareArn; }
            set { this._resourceShareArn = value; }
        }

        // Check to see if ResourceShareArn property is set
        internal bool IsSetResourceShareArn()
        {
            return this._resourceShareArn != null;
        }

    }
}