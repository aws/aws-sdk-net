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

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// This is the response object from the DescribeDataset operation.
    /// </summary>
    public partial class DescribeDatasetResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property DatasetArn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference-arns.html">ARN</a>
        /// of the dataset. The format is <c>arn:${Partition}:iotsitewise:${Region}:${Account}:dataset/${DatasetId}</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1600)]
        public string DatasetArn { get; set; }

        /// <summary>
        /// Checks to see if the DatasetArn property is set.
        /// </summary>
        internal bool IsSetDatasetArn() => this.DatasetArn != null;

        /// <summary>
        /// Gets and sets the property DatasetConfig. 
        /// <para>
        /// The configuration for the dataset.
        /// </para>
        /// </summary>
        public DatasetConfig DatasetConfig { get; set; }

        /// <summary>
        /// Checks to see if the DatasetConfig property is set.
        /// </summary>
        internal bool IsSetDatasetConfig() => this.DatasetConfig != null;

        /// <summary>
        /// Gets and sets the property DatasetCreationDate. 
        /// <para>
        /// The dataset creation date, in Unix epoch time.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? DatasetCreationDate { get; set; }

        /// <summary>
        /// Checks to see if the DatasetCreationDate property is set.
        /// </summary>
        internal bool IsSetDatasetCreationDate() => this.DatasetCreationDate.HasValue;

        /// <summary>
        /// Gets and sets the property DatasetDescription. 
        /// <para>
        /// A description about the dataset, and its functionality.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string DatasetDescription { get; set; }

        /// <summary>
        /// Checks to see if the DatasetDescription property is set.
        /// </summary>
        internal bool IsSetDatasetDescription() => this.DatasetDescription != null;

        /// <summary>
        /// Gets and sets the property DatasetId. 
        /// <para>
        /// The ID of the dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string DatasetId { get; set; }

        /// <summary>
        /// Checks to see if the DatasetId property is set.
        /// </summary>
        internal bool IsSetDatasetId() => this.DatasetId != null;

        /// <summary>
        /// Gets and sets the property DatasetLastUpdateDate. 
        /// <para>
        /// The date the dataset was last updated, in Unix epoch time.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? DatasetLastUpdateDate { get; set; }

        /// <summary>
        /// Checks to see if the DatasetLastUpdateDate property is set.
        /// </summary>
        internal bool IsSetDatasetLastUpdateDate() => this.DatasetLastUpdateDate.HasValue;

        /// <summary>
        /// Gets and sets the property DatasetName. 
        /// <para>
        /// The name of the dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string DatasetName { get; set; }

        /// <summary>
        /// Checks to see if the DatasetName property is set.
        /// </summary>
        internal bool IsSetDatasetName() => this.DatasetName != null;

        /// <summary>
        /// Gets and sets the property DatasetSource. 
        /// <para>
        /// The data source for the dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DatasetSource DatasetSource { get; set; }

        /// <summary>
        /// Checks to see if the DatasetSource property is set.
        /// </summary>
        internal bool IsSetDatasetSource() => this.DatasetSource != null;

        /// <summary>
        /// Gets and sets the property DatasetStatus. 
        /// <para>
        /// The status of the dataset. This contains the state and any error messages. State is
        /// <c>CREATING</c> after a successfull call to this API, and any associated error message.
        /// The state is <c>ACTIVE</c> when ready to use.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DatasetStatus DatasetStatus { get; set; }

        /// <summary>
        /// Checks to see if the DatasetStatus property is set.
        /// </summary>
        internal bool IsSetDatasetStatus() => this.DatasetStatus != null;

        /// <summary>
        /// Gets and sets the property DatasetType. 
        /// <para>
        /// The type of dataset: a session dataset, a curated dataset, or a connection to an external
        /// datasource.
        /// </para>
        /// </summary>
        public DatasetTypeEnum DatasetType { get; set; }

        /// <summary>
        /// Checks to see if the DatasetType property is set.
        /// </summary>
        internal bool IsSetDatasetType() => this.DatasetType != null;

        /// <summary>
        /// Gets and sets the property DatasetVersion. 
        /// <para>
        /// The version of the dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public string DatasetVersion { get; set; }

        /// <summary>
        /// Checks to see if the DatasetVersion property is set.
        /// </summary>
        internal bool IsSetDatasetVersion() => this.DatasetVersion != null;

        /// <summary>
        /// Gets and sets the property EnrichmentStatus. 
        /// <para>
        /// The enrichment status of the dataset.
        /// </para>
        /// </summary>
        public DatasetEnrichment EnrichmentStatus { get; set; }

        /// <summary>
        /// Checks to see if the EnrichmentStatus property is set.
        /// </summary>
        internal bool IsSetEnrichmentStatus() => this.EnrichmentStatus != null;

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// The metadata for the dataset.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Metadata { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Metadata property is set.
        /// </summary>
        internal bool IsSetMetadata() => this.Metadata != null && (this.Metadata.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property WorkspaceName. 
        /// <para>
        /// The name of the workspace that contains the dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string WorkspaceName { get; set; }

        /// <summary>
        /// Checks to see if the WorkspaceName property is set.
        /// </summary>
        internal bool IsSetWorkspaceName() => this.WorkspaceName != null;
    }
}
