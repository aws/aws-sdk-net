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

namespace Amazon.KinesisFirehose.Model
{
    /// <summary>
    /// Describes an update for a destination in Apache Iceberg Tables.
    /// </summary>
    public partial class IcebergDestinationUpdate
    {
        /// <summary>
        /// Gets and sets the property AppendOnly. 
        /// <para>
        ///  Describes whether all incoming data for this delivery stream will be append only
        /// (inserts only and not for updates and deletes) for Iceberg delivery. This feature
        /// is only applicable for Apache Iceberg Tables. 
        /// </para>
        ///  
        /// <para>
        /// The default value is false. If you set this value to true, Firehose automatically
        /// increases the throughput limit of a stream based on the throttling levels of the stream.
        /// If you set this parameter to true for a stream with updates and deletes, you will
        /// see out of order delivery. 
        /// </para>
        /// </summary>
        public bool? AppendOnly { get; set; }

        /// <summary>
        /// Checks to see if the AppendOnly property is set.
        /// </summary>
        internal bool IsSetAppendOnly() => this.AppendOnly.HasValue;

        /// <summary>
        /// Gets and sets the property BufferingHints.
        /// </summary>
        public BufferingHints BufferingHints { get; set; }

        /// <summary>
        /// Checks to see if the BufferingHints property is set.
        /// </summary>
        internal bool IsSetBufferingHints() => this.BufferingHints != null;

        /// <summary>
        /// Gets and sets the property CatalogConfiguration. 
        /// <para>
        ///  Configuration describing where the destination Iceberg tables are persisted. 
        /// </para>
        /// </summary>
        public CatalogConfiguration CatalogConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the CatalogConfiguration property is set.
        /// </summary>
        internal bool IsSetCatalogConfiguration() => this.CatalogConfiguration != null;

        /// <summary>
        /// Gets and sets the property CloudWatchLoggingOptions.
        /// </summary>
        public CloudWatchLoggingOptions CloudWatchLoggingOptions { get; set; }

        /// <summary>
        /// Checks to see if the CloudWatchLoggingOptions property is set.
        /// </summary>
        internal bool IsSetCloudWatchLoggingOptions() => this.CloudWatchLoggingOptions != null;

        /// <summary>
        /// Gets and sets the property DestinationTableConfigurationList. 
        /// <para>
        ///  Provides a list of <c>DestinationTableConfigurations</c> which Firehose uses to deliver
        /// data to Apache Iceberg Tables. Firehose will write data with insert if table specific
        /// configuration is not provided here.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DestinationTableConfiguration> DestinationTableConfigurationList { get; set; } = AWSConfigs.InitializeCollections ? new List<DestinationTableConfiguration>() : null;

        /// <summary>
        /// Checks to see if the DestinationTableConfigurationList property is set.
        /// </summary>
        internal bool IsSetDestinationTableConfigurationList() => this.DestinationTableConfigurationList != null && (this.DestinationTableConfigurationList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ProcessingConfiguration.
        /// </summary>
        public ProcessingConfiguration ProcessingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ProcessingConfiguration property is set.
        /// </summary>
        internal bool IsSetProcessingConfiguration() => this.ProcessingConfiguration != null;

        /// <summary>
        /// Gets and sets the property RetryOptions.
        /// </summary>
        public RetryOptions RetryOptions { get; set; }

        /// <summary>
        /// Checks to see if the RetryOptions property is set.
        /// </summary>
        internal bool IsSetRetryOptions() => this.RetryOptions != null;

        /// <summary>
        /// Gets and sets the property RoleARN. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the IAM role to be assumed by Firehose for calling
        /// Apache Iceberg Tables. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string RoleARN { get; set; }

        /// <summary>
        /// Checks to see if the RoleARN property is set.
        /// </summary>
        internal bool IsSetRoleARN() => this.RoleARN != null;

        /// <summary>
        /// Gets and sets the property S3BackupMode. 
        /// <para>
        ///  Describes how Firehose will backup records. Currently,Firehose only supports <c>FailedDataOnly</c>.
        /// 
        /// </para>
        /// </summary>
        public IcebergS3BackupMode S3BackupMode { get; set; }

        /// <summary>
        /// Checks to see if the S3BackupMode property is set.
        /// </summary>
        internal bool IsSetS3BackupMode() => this.S3BackupMode != null;

        /// <summary>
        /// Gets and sets the property S3Configuration.
        /// </summary>
        public S3DestinationConfiguration S3Configuration { get; set; }

        /// <summary>
        /// Checks to see if the S3Configuration property is set.
        /// </summary>
        internal bool IsSetS3Configuration() => this.S3Configuration != null;

        /// <summary>
        /// Gets and sets the property SchemaEvolutionConfiguration. 
        /// <para>
        ///  The configuration to enable automatic schema evolution. 
        /// </para>
        ///  
        /// <para>
        /// Amazon Data Firehose is in preview release and is subject to change.
        /// </para>
        /// </summary>
        public SchemaEvolutionConfiguration SchemaEvolutionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SchemaEvolutionConfiguration property is set.
        /// </summary>
        internal bool IsSetSchemaEvolutionConfiguration() => this.SchemaEvolutionConfiguration != null;

        /// <summary>
        /// Gets and sets the property TableCreationConfiguration. 
        /// <para>
        ///  The configuration to enable automatic table creation. 
        /// </para>
        ///  
        /// <para>
        /// Amazon Data Firehose is in preview release and is subject to change.
        /// </para>
        /// </summary>
        public TableCreationConfiguration TableCreationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the TableCreationConfiguration property is set.
        /// </summary>
        internal bool IsSetTableCreationConfiguration() => this.TableCreationConfiguration != null;
    }
}
