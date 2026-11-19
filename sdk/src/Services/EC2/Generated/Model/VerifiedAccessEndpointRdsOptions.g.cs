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
    /// Describes the RDS options for a Verified Access endpoint.
    /// </summary>
    public partial class VerifiedAccessEndpointRdsOptions
    {
        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 65535)]
        public int? Port { get; set; }

        /// <summary>
        /// Checks to see if the Port property is set.
        /// </summary>
        internal bool IsSetPort() => this.Port.HasValue;

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol.
        /// </para>
        /// </summary>
        public VerifiedAccessEndpointProtocol Protocol { get; set; }

        /// <summary>
        /// Checks to see if the Protocol property is set.
        /// </summary>
        internal bool IsSetProtocol() => this.Protocol != null;

        /// <summary>
        /// Gets and sets the property RdsDbClusterArn. 
        /// <para>
        /// The ARN of the DB cluster.
        /// </para>
        /// </summary>
        public string RdsDbClusterArn { get; set; }

        /// <summary>
        /// Checks to see if the RdsDbClusterArn property is set.
        /// </summary>
        internal bool IsSetRdsDbClusterArn() => this.RdsDbClusterArn != null;

        /// <summary>
        /// Gets and sets the property RdsDbInstanceArn. 
        /// <para>
        /// The ARN of the RDS instance.
        /// </para>
        /// </summary>
        public string RdsDbInstanceArn { get; set; }

        /// <summary>
        /// Checks to see if the RdsDbInstanceArn property is set.
        /// </summary>
        internal bool IsSetRdsDbInstanceArn() => this.RdsDbInstanceArn != null;

        /// <summary>
        /// Gets and sets the property RdsDbProxyArn. 
        /// <para>
        /// The ARN of the RDS proxy.
        /// </para>
        /// </summary>
        public string RdsDbProxyArn { get; set; }

        /// <summary>
        /// Checks to see if the RdsDbProxyArn property is set.
        /// </summary>
        internal bool IsSetRdsDbProxyArn() => this.RdsDbProxyArn != null;

        /// <summary>
        /// Gets and sets the property RdsEndpoint. 
        /// <para>
        /// The RDS endpoint.
        /// </para>
        /// </summary>
        public string RdsEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the RdsEndpoint property is set.
        /// </summary>
        internal bool IsSetRdsEndpoint() => this.RdsEndpoint != null;

        /// <summary>
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// The IDs of the subnets.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SubnetIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SubnetIds property is set.
        /// </summary>
        internal bool IsSetSubnetIds() => this.SubnetIds != null && (this.SubnetIds.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
