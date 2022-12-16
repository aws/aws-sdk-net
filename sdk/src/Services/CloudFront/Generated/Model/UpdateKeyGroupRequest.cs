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
    /// Container for the parameters to the UpdateKeyGroup operation.
    /// Updates a key group.
    /// 
    ///  
    /// <para>
    /// When you update a key group, all the fields are updated with the values provided in
    /// the request. You cannot update some fields independent of others. To update a key
    /// group:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// Get the current key group with <code>GetKeyGroup</code> or <code>GetKeyGroupConfig</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Locally modify the fields in the key group that you want to update. For example, add
    /// or remove public key IDs.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Call <code>UpdateKeyGroup</code> with the entire key group object, including the fields
    /// that you modified and those that you didn't.
    /// </para>
    ///  </li> </ol>
    /// </summary>
    public partial class UpdateKeyGroupRequest : AmazonCloudFrontRequest
    {
        private string _id;
        private string _ifMatch;
        private KeyGroupConfig _keyGroupConfig;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the key group that you are updating.
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
        /// The version of the key group that you are updating. The version is the key group's
        /// <code>ETag</code> value.
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

        /// <summary>
        /// Gets and sets the property KeyGroupConfig. 
        /// <para>
        /// The key group configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public KeyGroupConfig KeyGroupConfig
        {
            get { return this._keyGroupConfig; }
            set { this._keyGroupConfig = value; }
        }

        // Check to see if KeyGroupConfig property is set
        internal bool IsSetKeyGroupConfig()
        {
            return this._keyGroupConfig != null;
        }

    }
}