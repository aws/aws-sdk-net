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
    /// Container for the parameters to the CreateIpamPrefixListResolverTarget operation.
    /// Creates an IPAM prefix list resolver target.
    /// 
    ///  
    /// <para>
    /// An IPAM prefix list resolver target is an association between a specific customer-managed
    /// prefix list and an IPAM prefix list resolver. The target enables the resolver to synchronize
    /// CIDRs selected by its rules into the specified prefix list, which can then be referenced
    /// in Amazon Web Services resources.
    /// </para>
    ///  
    /// <para>
    /// For more information about IPAM prefix list resolver, see <a href="https://docs.aws.amazon.com/vpc/latest/ipam/automate-prefix-list-updates.html">Automate
    /// prefix list updates with IPAM</a> in the <i>Amazon VPC IPAM User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateIpamPrefixListResolverTargetRequest : AmazonEC2Request
    {
        private string _clientToken;
        private long? _desiredVersion;
        private string _ipamPrefixListResolverId;
        private string _prefixListId;
        private string _prefixListRegion;
        private List<TagSpecification> _tagSpecifications = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;
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
        /// The specific version of the prefix list to target. If not specified, the resolver
        /// will target the latest version.
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
        /// Gets and sets the property IpamPrefixListResolverId. 
        /// <para>
        /// The ID of the IPAM prefix list resolver that will manage the synchronization of CIDRs
        /// to the target prefix list.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string IpamPrefixListResolverId
        {
            get { return this._ipamPrefixListResolverId; }
            set { this._ipamPrefixListResolverId = value; }
        }

        // Check to see if IpamPrefixListResolverId property is set
        internal bool IsSetIpamPrefixListResolverId()
        {
            return this._ipamPrefixListResolverId != null;
        }

        /// <summary>
        /// Gets and sets the property PrefixListId. 
        /// <para>
        /// The ID of the managed prefix list that will be synchronized with CIDRs selected by
        /// the IPAM prefix list resolver. This prefix list becomes an IPAM managed prefix list.
        /// </para>
        ///  
        /// <para>
        /// An IPAM-managed prefix list is a customer-managed prefix list that has been associated
        /// with an IPAM prefix list resolver target. When a prefix list becomes IPAM managed,
        /// its CIDRs are automatically synchronized based on the IPAM prefix list resolver's
        /// CIDR selection rules, and direct CIDR modifications are restricted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PrefixListId
        {
            get { return this._prefixListId; }
            set { this._prefixListId = value; }
        }

        // Check to see if PrefixListId property is set
        internal bool IsSetPrefixListId()
        {
            return this._prefixListId != null;
        }

        /// <summary>
        /// Gets and sets the property PrefixListRegion. 
        /// <para>
        /// The Amazon Web Services Region where the prefix list is located. This is required
        /// when referencing a prefix list in a different Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PrefixListRegion
        {
            get { return this._prefixListRegion; }
            set { this._prefixListRegion = value; }
        }

        // Check to see if PrefixListRegion property is set
        internal bool IsSetPrefixListRegion()
        {
            return this._prefixListRegion != null;
        }

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to apply to the IPAM prefix list resolver target during creation. Tags help
        /// you organize and manage your Amazon Web Services resources.
        /// </para>
        /// </summary>
        public List<TagSpecification> TagSpecifications
        {
            get { return this._tagSpecifications; }
            set { this._tagSpecifications = value; }
        }

        // Check to see if TagSpecifications property is set
        internal bool IsSetTagSpecifications()
        {
            return this._tagSpecifications != null && (this._tagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TrackLatestVersion. 
        /// <para>
        /// Indicates whether the resolver target should automatically track the latest version
        /// of the prefix list. When enabled, the target will always synchronize with the most
        /// current version of the prefix list.
        /// </para>
        ///  
        /// <para>
        /// Choose this for automatic updates when you want your prefix lists to stay current
        /// with infrastructure changes without manual intervention.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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