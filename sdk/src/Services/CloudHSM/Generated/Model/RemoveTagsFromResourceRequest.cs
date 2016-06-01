/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the cloudhsm-2014-05-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudHSM.Model
{
    /// <summary>
    /// Container for the parameters to the RemoveTagsFromResource operation.
    /// Removes one or more tags from the specified AWS CloudHSM resource.
    /// 
    ///  
    /// <para>
    /// To remove a tag, specify only the tag key to remove (not the value). To overwrite
    /// the value for an existing tag, use <a>AddTagsToResource</a>.
    /// </para>
    /// </summary>
    public partial class RemoveTagsFromResourceRequest : AmazonCloudHSMRequest
    {
        private string _resourceArn;
        private List<string> _tagKeyList = new List<string>();

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the AWS CloudHSM resource.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property TagKeyList. 
        /// <para>
        /// The tag key or keys to remove.
        /// </para>
        ///  
        /// <para>
        /// Specify only the tag key to remove (not the value). To overwrite the value for an
        /// existing tag, use <a>AddTagsToResource</a>.
        /// </para>
        /// </summary>
        public List<string> TagKeyList
        {
            get { return this._tagKeyList; }
            set { this._tagKeyList = value; }
        }

        // Check to see if TagKeyList property is set
        internal bool IsSetTagKeyList()
        {
            return this._tagKeyList != null && this._tagKeyList.Count > 0; 
        }

    }
}