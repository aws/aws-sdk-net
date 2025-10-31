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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
    /// Container for the parameters to the ModifyIpamPrefixListResolverTarget operation.
    /// Modifies an IPAM prefix list resolver target. You can update version tracking settings
    /// and the desired version of the target prefix list.
    /// </summary>
    public partial class ModifyIpamPrefixListResolverTargetRequest : AmazonEC2Request
    {
        private string _clientToken;
        private long? _desiredVersion;
        private string _ipamPrefixListResolverTargetId;
        private bool? _trackLatestVersion;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. For more information, see <a href="https://docs.aws.amazon.com/ec2/latest/devguide/ec2-api-idempotency.html">Ensuring
        /// idempotency</a>.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property DesiredVersion. 
        /// <para>
        /// The desired version of the prefix list to target. This allows you to pin the target
        /// to a specific version.
        /// </para>
        /// </summary>
        public long DesiredVersion
        {
            get { return this._desiredVersion.GetValueOrDefault(); }
            set { this._desiredVersion = value; }
        }

        // Check to see if DesiredVersion property is set
        internal bool IsSetDesiredVersion()
        {
            return this._desiredVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IpamPrefixListResolverTargetId. 
        /// <para>
        /// The ID of the IPAM prefix list resolver target to modify.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string IpamPrefixListResolverTargetId
        {
            get { return this._ipamPrefixListResolverTargetId; }
            set { this._ipamPrefixListResolverTargetId = value; }
        }

        // Check to see if IpamPrefixListResolverTargetId property is set
        internal bool IsSetIpamPrefixListResolverTargetId()
        {
            return this._ipamPrefixListResolverTargetId != null;
        }

        /// <summary>
        /// Gets and sets the property TrackLatestVersion. 
        /// <para>
        /// Indicates whether the resolver target should automatically track the latest version
        /// of the prefix list. When enabled, the target will always synchronize with the most
        /// current version.
        /// </para>
        ///  
        /// <para>
        /// Choose this for automatic updates when you want your prefix lists to stay current
        /// with infrastructure changes without manual intervention.
        /// </para>
        /// </summary>
        public bool TrackLatestVersion
        {
            get { return this._trackLatestVersion.GetValueOrDefault(); }
            set { this._trackLatestVersion = value; }
        }

        // Check to see if TrackLatestVersion property is set
        internal bool IsSetTrackLatestVersion()
        {
            return this._trackLatestVersion.HasValue; 
        }

    }
}