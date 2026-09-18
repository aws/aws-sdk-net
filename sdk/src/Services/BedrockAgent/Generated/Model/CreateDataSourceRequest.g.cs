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

namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDataSource operation. Connects a knowledge
    /// base to a data source. You specify the configuration for the specific data source
    /// service in the <c>dataSourceConfiguration</c> field. <important> <para> You can't
    /// change the <c>chunkingConfiguration</c> after you create the data source connector.
    /// </para> </important>
    /// </summary>
    public partial class CreateDataSourceRequest : AmazonBedrockAgentRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure that the API request completes no more
        /// than one time. If this token matches a previous request, Amazon Bedrock ignores the
        /// request, but does not return an error. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Ensuring
        /// idempotency</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 33, Max = 256)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property DataDeletionPolicy. 
        /// <para>
        /// The data deletion policy for the data source.
        /// </para>
        ///  
        /// <para>
        /// You can set the data deletion policy to:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// DELETE: Deletes all data from your data source that’s converted into vector embeddings
        /// upon deletion of a knowledge base or data source resource. Note that the <b>vector
        /// store itself is not deleted</b>, only the data. This flag is ignored if an Amazon
        /// Web Services account is deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RETAIN: Retains all data from your data source that’s converted into vector embeddings
        /// upon deletion of a knowledge base or data source resource. Note that the <b>vector
        /// store itself is not deleted</b> if you delete a knowledge base or data source resource.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// For managed knowledge bases, the only supported option is <c>DELETE</c>, which is
        /// also the default.
        /// </para>
        ///  </note>
        /// </summary>
        public DataDeletionPolicy DataDeletionPolicy { get; set; }

        /// <summary>
        /// Checks to see if the DataDeletionPolicy property is set.
        /// </summary>
        internal bool IsSetDataDeletionPolicy() => this.DataDeletionPolicy != null;

        /// <summary>
        /// Gets and sets the property DataSourceConfiguration. 
        /// <para>
        /// The connection configuration for the data source.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DataSourceConfiguration DataSourceConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DataSourceConfiguration property is set.
        /// </summary>
        internal bool IsSetDataSourceConfiguration() => this.DataSourceConfiguration != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the data source.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property KnowledgeBaseId. 
        /// <para>
        /// The unique identifier of the knowledge base to which to add the data source.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string KnowledgeBaseId { get; set; }

        /// <summary>
        /// Checks to see if the KnowledgeBaseId property is set.
        /// </summary>
        internal bool IsSetKnowledgeBaseId() => this.KnowledgeBaseId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the data source.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ServerSideEncryptionConfiguration. 
        /// <para>
        /// Contains details about the server-side encryption for the data source.
        /// </para>
        /// </summary>
        public ServerSideEncryptionConfiguration ServerSideEncryptionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ServerSideEncryptionConfiguration property is set.
        /// </summary>
        internal bool IsSetServerSideEncryptionConfiguration() => this.ServerSideEncryptionConfiguration != null;

        /// <summary>
        /// Gets and sets the property VectorIngestionConfiguration. 
        /// <para>
        /// Contains details about how to ingest the documents in the data source.
        /// </para>
        /// </summary>
        public VectorIngestionConfiguration VectorIngestionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the VectorIngestionConfiguration property is set.
        /// </summary>
        internal bool IsSetVectorIngestionConfiguration() => this.VectorIngestionConfiguration != null;
    }
}
