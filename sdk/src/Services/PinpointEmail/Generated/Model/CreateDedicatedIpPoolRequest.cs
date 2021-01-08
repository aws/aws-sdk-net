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
 * Do not modify this file. This file is generated from the pinpoint-email-2018-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.PinpointEmail.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDedicatedIpPool operation.
    /// Create a new pool of dedicated IP addresses. A pool can include one or more dedicated
    /// IP addresses that are associated with your Amazon Pinpoint account. You can associate
    /// a pool with a configuration set. When you send an email that uses that configuration
    /// set, Amazon Pinpoint sends it using only the IP addresses in the associated pool.
    /// </summary>
    public partial class CreateDedicatedIpPoolRequest : AmazonPinpointEmailRequest
    {
        private string _poolName;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property PoolName. 
        /// <para>
        /// The name of the dedicated IP pool.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PoolName
        {
            get { return this._poolName; }
            set { this._poolName = value; }
        }

        // Check to see if PoolName property is set
        internal bool IsSetPoolName()
        {
            return this._poolName != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An object that defines the tags (keys and values) that you want to associate with
        /// the pool.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}