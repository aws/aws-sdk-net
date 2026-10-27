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

namespace Amazon.MarketplaceDiscovery.Model
{
    /// <summary>
    /// Contains a recommended security group configuration for an AMI fulfillment option.
    /// </summary>
    public partial class AmazonMachineImageSecurityGroup
    {
        /// <summary>
        /// Gets and sets the property CidrIpAddresses. 
        /// <para>
        /// The IP address ranges in CIDR format.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> CidrIpAddresses { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the CidrIpAddresses property is set.
        /// </summary>
        internal bool IsSetCidrIpAddresses() => this.CidrIpAddresses != null && (this.CidrIpAddresses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FromPort. 
        /// <para>
        /// The start of the port range.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? FromPort { get; set; }

        /// <summary>
        /// Checks to see if the FromPort property is set.
        /// </summary>
        internal bool IsSetFromPort() => this.FromPort.HasValue;

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The IP protocol name, such as <c>tcp</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Protocol { get; set; }

        /// <summary>
        /// Checks to see if the Protocol property is set.
        /// </summary>
        internal bool IsSetProtocol() => this.Protocol != null;

        /// <summary>
        /// Gets and sets the property ToPort. 
        /// <para>
        /// The end of the port range.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? ToPort { get; set; }

        /// <summary>
        /// Checks to see if the ToPort property is set.
        /// </summary>
        internal bool IsSetToPort() => this.ToPort.HasValue;
    }
}
