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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteKeyGroup operation.
    /// Deletes a key group.
    /// 
    ///  
    /// <para>
    /// You cannot delete a key group that is referenced in a cache behavior. First update
    /// your distributions to remove the key group from all cache behaviors, then delete the
    /// key group.
    /// </para>
    ///  
    /// <para>
    /// To delete a key group, you must provide the key group's identifier and version. To
    /// get these values, use <code>ListKeyGroups</code> followed by <code>GetKeyGroup</code>
    /// or <code>GetKeyGroupConfig</code>.
    /// </para>
    /// </summary>
    public partial class DeleteKeyGroupRequest : AmazonCloudFrontRequest
    {
        private string _id;
        private string _ifMatch;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the key group that you are deleting. To get the identifier, use
        /// <code>ListKeyGroups</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property IfMatch. 
        /// <para>
        /// The version of the key group that you are deleting. The version is the key group's
        /// <code>ETag</code> value. To get the <code>ETag</code>, use <code>GetKeyGroup</code>
        /// or <code>GetKeyGroupConfig</code>.
        /// </para>
        /// </summary>
        public string IfMatch
        {
            get { return this._ifMatch; }
            set { this._ifMatch = value; }
        }

        // Check to see if IfMatch property is set
        internal bool IsSetIfMatch()
        {
            return this._ifMatch != null;
        }

    }
}