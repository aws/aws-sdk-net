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
    /// In IPAM, a scope is the highest-level container within IPAM. An IPAM contains two
    /// default scopes. Each scope represents the IP space for a single network. The private
    /// scope is intended for all private IP address space. The public scope is intended for
    /// all public IP address space. Scopes enable you to reuse IP addresses across multiple
    /// unconnected networks without causing IP address overlap or conflict.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/ipam/how-it-works-ipam.html">How
    /// IPAM works</a> in the <i>Amazon VPC IPAM User Guide</i>.
    /// </para>
    /// </summary>
    public partial class IpamScope
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the scope.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property ExternalAuthorityConfiguration. 
        /// <para>
        /// The external authority configuration for this IPAM scope, if configured.
        /// </para>
        ///  
        /// <para>
        /// The configuration that links an Amazon VPC IPAM scope to an external authority system.
        /// It specifies the type of external system and the external resource identifier that
        /// identifies your account or instance in that system.
        /// </para>
        ///  
        /// <para>
        /// In IPAM, an external authority is a third-party IP address management system that
        /// provides CIDR blocks when you provision address space for top-level IPAM pools. This
        /// allows you to use your existing IP management system to control which address ranges
        /// are allocated to Amazon Web Services while using Amazon VPC IPAM to manage subnets
        /// within those ranges.
        /// </para>
        /// </summary>
        public IpamScopeExternalAuthorityConfiguration ExternalAuthorityConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ExternalAuthorityConfiguration property is set.
        /// </summary>
        internal bool IsSetExternalAuthorityConfiguration() => this.ExternalAuthorityConfiguration != null;

        /// <summary>
        /// Gets and sets the property IpamArn. 
        /// <para>
        /// The ARN of the IPAM.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1283)]
        public string IpamArn { get; set; }

        /// <summary>
        /// Checks to see if the IpamArn property is set.
        /// </summary>
        internal bool IsSetIpamArn() => this.IpamArn != null;

        /// <summary>
        /// Gets and sets the property IpamRegion. 
        /// <para>
        /// The Amazon Web Services Region of the IPAM scope.
        /// </para>
        /// </summary>
        public string IpamRegion { get; set; }

        /// <summary>
        /// Checks to see if the IpamRegion property is set.
        /// </summary>
        internal bool IsSetIpamRegion() => this.IpamRegion != null;

        /// <summary>
        /// Gets and sets the property IpamScopeArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the scope.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1283)]
        public string IpamScopeArn { get; set; }

        /// <summary>
        /// Checks to see if the IpamScopeArn property is set.
        /// </summary>
        internal bool IsSetIpamScopeArn() => this.IpamScopeArn != null;

        /// <summary>
        /// Gets and sets the property IpamScopeId. 
        /// <para>
        /// The ID of the scope.
        /// </para>
        /// </summary>
        public string IpamScopeId { get; set; }

        /// <summary>
        /// Checks to see if the IpamScopeId property is set.
        /// </summary>
        internal bool IsSetIpamScopeId() => this.IpamScopeId != null;

        /// <summary>
        /// Gets and sets the property IpamScopeType. 
        /// <para>
        /// The type of the scope.
        /// </para>
        /// </summary>
        public IpamScopeType IpamScopeType { get; set; }

        /// <summary>
        /// Checks to see if the IpamScopeType property is set.
        /// </summary>
        internal bool IsSetIpamScopeType() => this.IpamScopeType != null;

        /// <summary>
        /// Gets and sets the property IsDefault. 
        /// <para>
        /// Defines if the scope is the default scope or not.
        /// </para>
        /// </summary>
        public bool? IsDefault { get; set; }

        /// <summary>
        /// Checks to see if the IsDefault property is set.
        /// </summary>
        internal bool IsSetIsDefault() => this.IsDefault.HasValue;

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The Amazon Web Services account ID of the owner of the scope.
        /// </para>
        /// </summary>
        public string OwnerId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerId property is set.
        /// </summary>
        internal bool IsSetOwnerId() => this.OwnerId != null;

        /// <summary>
        /// Gets and sets the property PoolCount. 
        /// <para>
        /// The number of pools in the scope.
        /// </para>
        /// </summary>
        public int? PoolCount { get; set; }

        /// <summary>
        /// Checks to see if the PoolCount property is set.
        /// </summary>
        internal bool IsSetPoolCount() => this.PoolCount.HasValue;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the IPAM scope.
        /// </para>
        /// </summary>
        public IpamScopeState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The key/value combination of a tag assigned to the resource. Use the tag key in the
        /// filter name and the tag value as the filter value. For example, to find all resources
        /// that have a tag with the key <c>Owner</c> and the value <c>TeamA</c>, specify <c>tag:Owner</c>
        /// for the filter name and <c>TeamA</c> for the filter value.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
