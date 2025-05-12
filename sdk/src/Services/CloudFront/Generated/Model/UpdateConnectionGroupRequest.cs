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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateConnectionGroup operation.
    /// Updates a connection group.
    /// </summary>
    public partial class UpdateConnectionGroupRequest : AmazonCloudFrontRequest
    {
        private string _anycastIpListId;
        private bool? _enabled;
        private string _id;
        private string _ifMatch;
        private bool? _ipv6Enabled;

        /// <summary>
        /// Gets and sets the property AnycastIpListId. 
        /// <para>
        /// The ID of the Anycast static IP list.
        /// </para>
        /// </summary>
        public string AnycastIpListId
        {
            get { return this._anycastIpListId; }
            set { this._anycastIpListId = value; }
        }

        // Check to see if AnycastIpListId property is set
        internal bool IsSetAnycastIpListId()
        {
            return this._anycastIpListId != null;
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Whether the connection group is enabled.
        /// </para>
        /// </summary>
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the connection group.
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
        /// The value of the <c>ETag</c> header that you received when retrieving the connection
        /// group that you're updating.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Ipv6Enabled. 
        /// <para>
        /// Enable IPv6 for the connection group. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/distribution-web-values-specify.html#DownloadDistValuesEnableIPv6">Enable
        /// IPv6</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </summary>
        public bool? Ipv6Enabled
        {
            get { return this._ipv6Enabled; }
            set { this._ipv6Enabled = value; }
        }

        // Check to see if Ipv6Enabled property is set
        internal bool IsSetIpv6Enabled()
        {
            return this._ipv6Enabled.HasValue; 
        }

    }
}