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
    /// Container for the parameters to the GetKeyGroup operation.
    /// Gets a key group, including the date and time when the key group was last modified.
    /// 
    ///  
    /// <para>
    /// To get a key group, you must provide the key group's identifier. If the key group
    /// is referenced in a distribution's cache behavior, you can get the key group's identifier
    /// using <code>ListDistributions</code> or <code>GetDistribution</code>. If the key group
    /// is not referenced in a cache behavior, you can get the identifier using <code>ListKeyGroups</code>.
    /// </para>
    /// </summary>
    public partial class GetKeyGroupRequest : AmazonCloudFrontRequest
    {
        private string _id;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the key group that you are getting. To get the identifier, use <code>ListKeyGroups</code>.
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

    }
}