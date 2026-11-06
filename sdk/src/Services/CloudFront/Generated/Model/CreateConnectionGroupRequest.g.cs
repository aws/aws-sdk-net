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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the CreateConnectionGroup operation. Creates a connection
    /// group.
    /// </summary>
    public partial class CreateConnectionGroupRequest : AmazonCloudFrontRequest
    {
        /// <summary>
        /// Gets and sets the property AnycastIpListId. 
        /// <para>
        /// The ID of the Anycast static IP list.
        /// </para>
        /// </summary>
        public string AnycastIpListId { get; set; }

        /// <summary>
        /// Checks to see if the AnycastIpListId property is set.
        /// </summary>
        internal bool IsSetAnycastIpListId() => this.AnycastIpListId != null;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Enable the connection group.
        /// </para>
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Enabled property is set.
        /// </summary>
        internal bool IsSetEnabled() => this.Enabled.HasValue;

        /// <summary>
        /// Gets and sets the property Ipv6Enabled. 
        /// <para>
        /// Enable IPv6 for the connection group. The default is <c>true</c>. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/distribution-web-values-specify.html#DownloadDistValuesEnableIPv6">Enable
        /// IPv6</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </summary>
        public bool? Ipv6Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Ipv6Enabled property is set.
        /// </summary>
        internal bool IsSetIpv6Enabled() => this.Ipv6Enabled.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the connection group. Enter a friendly identifier that is unique within
        /// your Amazon Web Services account. This name can't be updated after you create the
        /// connection group.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Tags.
        /// </summary>
        public Tags Tags { get; set; }

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null;
    }
}
