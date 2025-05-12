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
    /// Container for the parameters to the CreateConnectionGroup operation.
    /// Creates a connection group.
    /// </summary>
    public partial class CreateConnectionGroupRequest : AmazonCloudFrontRequest
    {
        private string _anycastIpListId;
        private bool? _enabled;
        private bool? _ipv6Enabled;
        private string _name;
        private Tags _tags;

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
        /// Enable the connection group.
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
        /// Gets and sets the property Ipv6Enabled. 
        /// <para>
        /// Enable IPv6 for the connection group. The default is <c>true</c>. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/distribution-web-values-specify.html#DownloadDistValuesEnableIPv6">Enable
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

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the connection group. Enter a friendly identifier that is unique within
        /// your Amazon Web Services account. This name can't be updated after you create the
        /// connection group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Tags.
        /// </summary>
        public Tags Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null;
        }

    }
}