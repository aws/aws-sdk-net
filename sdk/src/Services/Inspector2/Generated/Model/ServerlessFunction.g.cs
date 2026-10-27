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

namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// Contains details about a serverless function involved in a finding.
    /// </summary>
    public partial class ServerlessFunction
    {
        /// <summary>
        /// Gets and sets the property Architectures. 
        /// <para>
        /// The architectures of the serverless function.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public List<string> Architectures { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Architectures property is set.
        /// </summary>
        internal bool IsSetArchitectures() => this.Architectures != null && (this.Architectures.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CodeDigest. 
        /// <para>
        /// The code digest of the serverless function.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string CodeDigest { get; set; }

        /// <summary>
        /// Checks to see if the CodeDigest property is set.
        /// </summary>
        internal bool IsSetCodeDigest() => this.CodeDigest != null;

        /// <summary>
        /// Gets and sets the property ExecutionRole. 
        /// <para>
        /// The execution role of the serverless function.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string ExecutionRole { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionRole property is set.
        /// </summary>
        internal bool IsSetExecutionRole() => this.ExecutionRole != null;

        /// <summary>
        /// Gets and sets the property LastModifiedAt. 
        /// <para>
        /// The date and time the serverless function was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedAt property is set.
        /// </summary>
        internal bool IsSetLastModifiedAt() => this.LastModifiedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Layers. 
        /// <para>
        /// The layers of the serverless function.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Layers { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Layers property is set.
        /// </summary>
        internal bool IsSetLayers() => this.Layers != null && (this.Layers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NetworkId. 
        /// <para>
        /// The network ID associated with the serverless function.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string NetworkId { get; set; }

        /// <summary>
        /// Checks to see if the NetworkId property is set.
        /// </summary>
        internal bool IsSetNetworkId() => this.NetworkId != null;

        /// <summary>
        /// Gets and sets the property PackageType. 
        /// <para>
        /// The package type of the serverless function.
        /// </para>
        /// </summary>
        public PackageType PackageType { get; set; }

        /// <summary>
        /// Checks to see if the PackageType property is set.
        /// </summary>
        internal bool IsSetPackageType() => this.PackageType != null;

        /// <summary>
        /// Gets and sets the property Runtime. 
        /// <para>
        /// The runtime of the serverless function.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string Runtime { get; set; }

        /// <summary>
        /// Checks to see if the Runtime property is set.
        /// </summary>
        internal bool IsSetRuntime() => this.Runtime != null;

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// The security group IDs associated with the serverless function.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 5)]
        public List<string> SecurityGroupIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SecurityGroupIds property is set.
        /// </summary>
        internal bool IsSetSecurityGroupIds() => this.SecurityGroupIds != null && (this.SecurityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ServerlessFunctionName. 
        /// <para>
        /// The name of the serverless function.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string ServerlessFunctionName { get; set; }

        /// <summary>
        /// Checks to see if the ServerlessFunctionName property is set.
        /// </summary>
        internal bool IsSetServerlessFunctionName() => this.ServerlessFunctionName != null;

        /// <summary>
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// The subnet IDs associated with the serverless function.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 16)]
        public List<string> SubnetIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SubnetIds property is set.
        /// </summary>
        internal bool IsSetSubnetIds() => this.SubnetIds != null && (this.SubnetIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the serverless function.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}
