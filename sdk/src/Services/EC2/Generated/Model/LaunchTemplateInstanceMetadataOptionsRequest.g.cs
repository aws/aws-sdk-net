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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// The metadata options for the instance. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instance-metadata.html">Use
    /// instance metadata to manage your EC2 instance</a> in the <i>Amazon EC2 User Guide</i>.
    /// </summary>
    public partial class LaunchTemplateInstanceMetadataOptionsRequest
    {
        /// <summary>
        /// Gets and sets the property HttpEndpoint. 
        /// <para>
        /// Enables or disables the HTTP metadata endpoint on your instances. If the parameter
        /// is not specified, the default state is <c>enabled</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you specify a value of <c>disabled</c>, you will not be able to access your instance
        /// metadata. 
        /// </para>
        ///  </note>
        /// </summary>
        public LaunchTemplateInstanceMetadataEndpointState HttpEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the HttpEndpoint property is set.
        /// </summary>
        internal bool IsSetHttpEndpoint() => this.HttpEndpoint != null;

        /// <summary>
        /// Gets and sets the property HttpProtocolIpv6. 
        /// <para>
        /// Enables or disables the IPv6 endpoint for the instance metadata service.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>disabled</c> 
        /// </para>
        /// </summary>
        public LaunchTemplateInstanceMetadataProtocolIpv6 HttpProtocolIpv6 { get; set; }

        /// <summary>
        /// Checks to see if the HttpProtocolIpv6 property is set.
        /// </summary>
        internal bool IsSetHttpProtocolIpv6() => this.HttpProtocolIpv6 != null;

        /// <summary>
        /// Gets and sets the property HttpPutResponseHopLimit. 
        /// <para>
        /// The desired HTTP PUT response hop limit for instance metadata requests. The larger
        /// the number, the further instance metadata requests can travel.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>1</c> 
        /// </para>
        ///  
        /// <para>
        /// Possible values: Integers from 1 to 64
        /// </para>
        /// </summary>
        public int? HttpPutResponseHopLimit { get; set; }

        /// <summary>
        /// Checks to see if the HttpPutResponseHopLimit property is set.
        /// </summary>
        internal bool IsSetHttpPutResponseHopLimit() => this.HttpPutResponseHopLimit.HasValue;

        /// <summary>
        /// Gets and sets the property HttpTokens. 
        /// <para>
        /// Indicates whether IMDSv2 is required.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>optional</c> - IMDSv2 is optional. You can choose whether to send a session token
        /// in your instance metadata retrieval requests. If you retrieve IAM role credentials
        /// without a session token, you receive the IMDSv1 role credentials. If you retrieve
        /// IAM role credentials using a valid session token, you receive the IMDSv2 role credentials.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>required</c> - IMDSv2 is required. You must send a session token in your instance
        /// metadata retrieval requests. With this option, retrieving the IAM role credentials
        /// always returns IMDSv2 credentials; IMDSv1 credentials are not available.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Default: If the value of <c>ImdsSupport</c> for the Amazon Machine Image (AMI) for
        /// your instance is <c>v2.0</c>, the default is <c>required</c>.
        /// </para>
        /// </summary>
        public LaunchTemplateHttpTokensState HttpTokens { get; set; }

        /// <summary>
        /// Checks to see if the HttpTokens property is set.
        /// </summary>
        internal bool IsSetHttpTokens() => this.HttpTokens != null;

        /// <summary>
        /// Gets and sets the property InstanceMetadataTags. 
        /// <para>
        /// Set to <c>enabled</c> to allow access to instance tags from the instance metadata.
        /// Set to <c>disabled</c> to turn off access to instance tags from the instance metadata.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/work-with-tags-in-IMDS.html">View
        /// tags for your EC2 instances using instance metadata</a>.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>disabled</c> 
        /// </para>
        /// </summary>
        public LaunchTemplateInstanceMetadataTagsState InstanceMetadataTags { get; set; }

        /// <summary>
        /// Checks to see if the InstanceMetadataTags property is set.
        /// </summary>
        internal bool IsSetInstanceMetadataTags() => this.InstanceMetadataTags != null;
    }
}
