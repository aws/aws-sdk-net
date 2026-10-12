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

namespace Amazon.CodeStarconnections.Model
{
    /// <summary>
    /// A resource that represents the infrastructure where a third-party provider is installed.
    /// The host is used when you create connections to an installed third-party provider
    /// type, such as GitHub Enterprise Server. You create one host for all connections to
    /// that provider.
    /// 
    ///  <note> 
    /// <para>
    /// A host created through the CLI or the SDK is in `PENDING` status by default. You can
    /// make its status `AVAILABLE` by setting up the host in the console.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class Host
    {
        /// <summary>
        /// Gets and sets the property HostArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the host.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string HostArn { get; set; }

        /// <summary>
        /// Checks to see if the HostArn property is set.
        /// </summary>
        internal bool IsSetHostArn() => this.HostArn != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the host.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ProviderEndpoint. 
        /// <para>
        /// The endpoint of the infrastructure where your provider type is installed.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string ProviderEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the ProviderEndpoint property is set.
        /// </summary>
        internal bool IsSetProviderEndpoint() => this.ProviderEndpoint != null;

        /// <summary>
        /// Gets and sets the property ProviderType. 
        /// <para>
        /// The name of the installed provider to be associated with your connection. The host
        /// resource represents the infrastructure where your provider type is installed. The
        /// valid provider type is GitHub Enterprise Server.
        /// </para>
        /// </summary>
        public ProviderType ProviderType { get; set; }

        /// <summary>
        /// Checks to see if the ProviderType property is set.
        /// </summary>
        internal bool IsSetProviderType() => this.ProviderType != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the host, such as PENDING, AVAILABLE, VPC_CONFIG_DELETING, VPC_CONFIG_INITIALIZING,
        /// and VPC_CONFIG_FAILED_INITIALIZATION.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// The status description for the host.
        /// </para>
        /// </summary>
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;

        /// <summary>
        /// Gets and sets the property VpcConfiguration. 
        /// <para>
        /// The VPC configuration provisioned for the host.
        /// </para>
        /// </summary>
        public VpcConfiguration VpcConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the VpcConfiguration property is set.
        /// </summary>
        internal bool IsSetVpcConfiguration() => this.VpcConfiguration != null;
    }
}
