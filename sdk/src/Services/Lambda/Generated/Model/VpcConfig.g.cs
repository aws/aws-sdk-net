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

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// The VPC security groups and subnets that are attached to a Lambda function. For more
    /// information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-vpc.html">Configuring
    /// a Lambda function to access resources in a VPC</a>.
    /// </summary>
    public partial class VpcConfig
    {
        /// <summary>
        /// Gets and sets the property Ipv6AllowedForDualStack. 
        /// <para>
        /// Allows outbound IPv6 traffic on VPC functions that are connected to dual-stack subnets.
        /// </para>
        /// </summary>
        public bool? Ipv6AllowedForDualStack { get; set; }

        /// <summary>
        /// Checks to see if the Ipv6AllowedForDualStack property is set.
        /// </summary>
        internal bool IsSetIpv6AllowedForDualStack() => this.Ipv6AllowedForDualStack.HasValue;

        private List<string> _SecurityGroupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// A list of VPC security group IDs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public List<string> SecurityGroupIds { get => this._SecurityGroupIds; set => this._SecurityGroupIds = value; }

        /// <summary>
        /// This property is set to true if the property <seealso cref="SecurityGroupIds"/>
        /// is set; false otherwise.
        /// This property can be used to determine if the related property
        /// was returned by a service response or if the related property
        /// should be sent to the service during a service call.
        /// <para>
        /// If this property is set to false the property <seealso cref="SecurityGroupIds"/> will be reset to null.
        /// </para>
        /// </summary>
        /// <returns>
        /// True if the related property was set or will be sent to a service; false otherwise.
        /// </returns>
        public bool IsSecurityGroupIdsSet
        {
            get => Amazon.Util.Internal.InternalSDKUtils.GetIsSet(this._SecurityGroupIds);
            set => Amazon.Util.Internal.InternalSDKUtils.SetIsSet(value, ref this._SecurityGroupIds);
        }

        /// <summary>
        /// Checks to see if the SecurityGroupIds property is set.
        /// </summary>
        internal bool IsSetSecurityGroupIds() => this.IsSecurityGroupIdsSet;

        private List<string> _SubnetIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// A list of VPC subnet IDs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 16)]
        public List<string> SubnetIds { get => this._SubnetIds; set => this._SubnetIds = value; }

        /// <summary>
        /// This property is set to true if the property <seealso cref="SubnetIds"/>
        /// is set; false otherwise.
        /// This property can be used to determine if the related property
        /// was returned by a service response or if the related property
        /// should be sent to the service during a service call.
        /// <para>
        /// If this property is set to false the property <seealso cref="SubnetIds"/> will be reset to null.
        /// </para>
        /// </summary>
        /// <returns>
        /// True if the related property was set or will be sent to a service; false otherwise.
        /// </returns>
        public bool IsSubnetIdsSet
        {
            get => Amazon.Util.Internal.InternalSDKUtils.GetIsSet(this._SubnetIds);
            set => Amazon.Util.Internal.InternalSDKUtils.SetIsSet(value, ref this._SubnetIds);
        }

        /// <summary>
        /// Checks to see if the SubnetIds property is set.
        /// </summary>
        internal bool IsSetSubnetIds() => this.IsSubnetIdsSet;
    }
}
