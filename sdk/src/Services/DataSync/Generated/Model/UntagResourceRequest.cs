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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DataSync.Model
{
    /// <summary>
    /// Container for the parameters to the UntagResource operation.
    /// Removes tags from an Amazon Web Services resource.
    /// </summary>
    public partial class UntagResourceRequest : AmazonDataSyncRequest
    {
        private List<string> _keys = new List<string>();
        private string _resourceArn;

        /// <summary>
        /// Gets and sets the property Keys. 
        /// <para>
        /// Specifies the keys in the tags that you want to remove.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public List<string> Keys
        {
            get { return this._keys; }
            set { this._keys = value; }
        }

        // Check to see if Keys property is set
        internal bool IsSetKeys()
        {
            return this._keys != null && this._keys.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// Specifies the Amazon Resource Name (ARN) of the resource to remove the tags from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=128)]
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

    }
}