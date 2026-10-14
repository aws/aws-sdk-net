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

namespace Amazon.DataSync.Model
{
    /// <summary>
    /// This is the response object from the DescribeLocationHdfs operation.
    /// </summary>
    public partial class DescribeLocationHdfsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AgentArns. 
        /// <para>
        /// The ARNs of the DataSync agents that can connect with your HDFS cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 8)]
        public List<string> AgentArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AgentArns property is set.
        /// </summary>
        internal bool IsSetAgentArns() => this.AgentArns != null && (this.AgentArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AuthenticationType. 
        /// <para>
        /// The type of authentication used to determine the identity of the user. 
        /// </para>
        /// </summary>
        public HdfsAuthenticationType AuthenticationType { get; set; }

        /// <summary>
        /// Checks to see if the AuthenticationType property is set.
        /// </summary>
        internal bool IsSetAuthenticationType() => this.AuthenticationType != null;

        /// <summary>
        /// Gets and sets the property BlockSize. 
        /// <para>
        /// The size of the data blocks to write into the HDFS cluster. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1048576, Max = 1073741824)]
        public int? BlockSize { get; set; }

        /// <summary>
        /// Checks to see if the BlockSize property is set.
        /// </summary>
        internal bool IsSetBlockSize() => this.BlockSize.HasValue;

        /// <summary>
        /// Gets and sets the property CmkSecretConfig. 
        /// <para>
        /// Describes configuration information for a DataSync-managed secret, such as a <c>KerberosKeytab</c>
        /// that DataSync uses to access a specific storage location, with a customer-managed
        /// KMS key.
        /// </para>
        /// </summary>
        public CmkSecretConfig CmkSecretConfig { get; set; }

        /// <summary>
        /// Checks to see if the CmkSecretConfig property is set.
        /// </summary>
        internal bool IsSetCmkSecretConfig() => this.CmkSecretConfig != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time that the HDFS location was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property CustomSecretConfig. 
        /// <para>
        /// Describes configuration information for a customer-managed secret, such as a <c>KerberosKeytab</c>
        /// that DataSync uses to access a specific storage location, with a customer-managed
        /// Identity and Access Management (IAM) role that provides access to the secret.
        /// </para>
        /// </summary>
        public CustomSecretConfig CustomSecretConfig { get; set; }

        /// <summary>
        /// Checks to see if the CustomSecretConfig property is set.
        /// </summary>
        internal bool IsSetCustomSecretConfig() => this.CustomSecretConfig != null;

        /// <summary>
        /// Gets and sets the property KerberosPrincipal. 
        /// <para>
        /// The Kerberos principal with access to the files and folders on the HDFS cluster. This
        /// parameter is used if the <c>AuthenticationType</c> is defined as <c>KERBEROS</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string KerberosPrincipal { get; set; }

        /// <summary>
        /// Checks to see if the KerberosPrincipal property is set.
        /// </summary>
        internal bool IsSetKerberosPrincipal() => this.KerberosPrincipal != null;

        /// <summary>
        /// Gets and sets the property KmsKeyProviderUri. 
        /// <para>
        ///  The URI of the HDFS cluster's Key Management Server (KMS). 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string KmsKeyProviderUri { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyProviderUri property is set.
        /// </summary>
        internal bool IsSetKmsKeyProviderUri() => this.KmsKeyProviderUri != null;

        /// <summary>
        /// Gets and sets the property LocationArn. 
        /// <para>
        /// The ARN of the HDFS location.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string LocationArn { get; set; }

        /// <summary>
        /// Checks to see if the LocationArn property is set.
        /// </summary>
        internal bool IsSetLocationArn() => this.LocationArn != null;

        /// <summary>
        /// Gets and sets the property LocationUri. 
        /// <para>
        /// The URI of the HDFS location.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 4360)]
        public string LocationUri { get; set; }

        /// <summary>
        /// Checks to see if the LocationUri property is set.
        /// </summary>
        internal bool IsSetLocationUri() => this.LocationUri != null;

        /// <summary>
        /// Gets and sets the property ManagedSecretConfig. 
        /// <para>
        /// Describes configuration information for a DataSync-managed secret, such as a <c>KerberosKeytab</c>
        /// that DataSync uses to access a specific storage location. DataSync uses the default
        /// Amazon Web Services-managed KMS key to encrypt this secret in Secrets Manager.
        /// </para>
        /// </summary>
        public ManagedSecretConfig ManagedSecretConfig { get; set; }

        /// <summary>
        /// Checks to see if the ManagedSecretConfig property is set.
        /// </summary>
        internal bool IsSetManagedSecretConfig() => this.ManagedSecretConfig != null;

        /// <summary>
        /// Gets and sets the property NameNodes. 
        /// <para>
        /// The NameNode that manages the HDFS namespace. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<HdfsNameNode> NameNodes { get; set; } = AWSConfigs.InitializeCollections ? new List<HdfsNameNode>() : null;

        /// <summary>
        /// Checks to see if the NameNodes property is set.
        /// </summary>
        internal bool IsSetNameNodes() => this.NameNodes != null && (this.NameNodes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property QopConfiguration. 
        /// <para>
        /// The Quality of Protection (QOP) configuration, which specifies the Remote Procedure
        /// Call (RPC) and data transfer protection settings configured on the HDFS cluster. 
        /// </para>
        /// </summary>
        public QopConfiguration QopConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the QopConfiguration property is set.
        /// </summary>
        internal bool IsSetQopConfiguration() => this.QopConfiguration != null;

        /// <summary>
        /// Gets and sets the property ReplicationFactor. 
        /// <para>
        /// The number of DataNodes to replicate the data to when writing to the HDFS cluster.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public int? ReplicationFactor { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationFactor property is set.
        /// </summary>
        internal bool IsSetReplicationFactor() => this.ReplicationFactor.HasValue;

        /// <summary>
        /// Gets and sets the property SimpleUser. 
        /// <para>
        /// The user name to identify the client on the host operating system. This parameter
        /// is used if the <c>AuthenticationType</c> is defined as <c>SIMPLE</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string SimpleUser { get; set; }

        /// <summary>
        /// Checks to see if the SimpleUser property is set.
        /// </summary>
        internal bool IsSetSimpleUser() => this.SimpleUser != null;
    }
}
