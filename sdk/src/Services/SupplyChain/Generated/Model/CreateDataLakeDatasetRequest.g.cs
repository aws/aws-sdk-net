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

namespace Amazon.SupplyChain.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDataLakeDataset operation. Enables you to
    /// programmatically create an Amazon Web Services Supply Chain data lake dataset. Developers
    /// can create the datasets using their pre-defined or custom schema for a given instance
    /// ID, namespace, and dataset name.
    /// </summary>
    public partial class CreateDataLakeDatasetRequest : AmazonSupplyChainRequest
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 500)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The Amazon Web Services Supply Chain instance identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the dataset. For <b>asc</b> name space, the name must be one of the supported
        /// data entities under <a href="https://docs.aws.amazon.com/aws-supply-chain/latest/userguide/data-model-asc.html">https://docs.aws.amazon.com/aws-supply-chain/latest/userguide/data-model-asc.html</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 75)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The namespace of the dataset, besides the custom defined namespace, every instance
        /// comes with below pre-defined namespaces:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>asc</b> - For information on the Amazon Web Services Supply Chain supported datasets
        /// see <a href="https://docs.aws.amazon.com/aws-supply-chain/latest/userguide/data-model-asc.html">https://docs.aws.amazon.com/aws-supply-chain/latest/userguide/data-model-asc.html</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>default</b> - For datasets with custom user-defined schemas.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 50)]
        public string Namespace { get; set; }

        /// <summary>
        /// Checks to see if the Namespace property is set.
        /// </summary>
        internal bool IsSetNamespace() => this.Namespace != null;

        /// <summary>
        /// Gets and sets the property PartitionSpec. 
        /// <para>
        /// The partition specification of the dataset. Partitioning can effectively improve the
        /// dataset query performance by reducing the amount of data scanned during query execution.
        /// But partitioning or not will affect how data get ingested by data ingestion methods,
        /// such as SendDataIntegrationEvent's dataset UPSERT will upsert records within partition
        /// (instead of within whole dataset). For more details, refer to those data ingestion
        /// documentations.
        /// </para>
        /// </summary>
        public DataLakeDatasetPartitionSpec PartitionSpec { get; set; }

        /// <summary>
        /// Checks to see if the PartitionSpec property is set.
        /// </summary>
        internal bool IsSetPartitionSpec() => this.PartitionSpec != null;

        /// <summary>
        /// Gets and sets the property Schema. 
        /// <para>
        /// The custom schema of the data lake dataset and required for dataset in <b>default</b>
        /// and custom namespaces.
        /// </para>
        /// </summary>
        public DataLakeDatasetSchema Schema { get; set; }

        /// <summary>
        /// Checks to see if the Schema property is set.
        /// </summary>
        internal bool IsSetSchema() => this.Schema != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags of the dataset.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
