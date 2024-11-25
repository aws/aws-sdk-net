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
 * Do not modify this file. This file is generated from the firehose-2015-08-04.normal.json service model.
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
        private BufferingHints _bufferingHints;
        private CatalogConfiguration _catalogConfiguration;
        private CloudWatchLoggingOptions _cloudWatchLoggingOptions;
        private List<DestinationTableConfiguration> _destinationTableConfigurationList = AWSConfigs.InitializeCollections ? new List<DestinationTableConfiguration>() : null;
        private ProcessingConfiguration _processingConfiguration;
        private RetryOptions _retryOptions;
        private string _roleARN;
        private IcebergS3BackupMode _s3BackupMode;
        private S3DestinationConfiguration _s3Configuration;
        private SchemaEvolutionConfiguration _schemaEvolutionConfiguration;
        private TableCreationConfiguration _tableCreationConfiguration;

        /// <summary>
        /// Gets and sets the property BufferingHints.
        /// </summary>
        public BufferingHints BufferingHints
        {
            get { return this._bufferingHints; }
            set { this._bufferingHints = value; }
        }

        // Check to see if BufferingHints property is set
        internal bool IsSetBufferingHints()
        {
            return this._bufferingHints != null;
        }

        /// <summary>
        /// Gets and sets the property CatalogConfiguration. 
        /// <para>
        ///  Configuration describing where the destination Iceberg tables are persisted. 
        /// </para>
        /// </summary>
        public CatalogConfiguration CatalogConfiguration
        {
            get { return this._catalogConfiguration; }
            set { this._catalogConfiguration = value; }
        }

        // Check to see if CatalogConfiguration property is set
        internal bool IsSetCatalogConfiguration()
        {
            return this._catalogConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property CloudWatchLoggingOptions.
        /// </summary>
        public CloudWatchLoggingOptions CloudWatchLoggingOptions
        {
            get { return this._cloudWatchLoggingOptions; }
            set { this._cloudWatchLoggingOptions = value; }
        }

        // Check to see if CloudWatchLoggingOptions property is set
        internal bool IsSetCloudWatchLoggingOptions()
        {
            return this._cloudWatchLoggingOptions != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationTableConfigurationList. 
        /// <para>
        ///  Provides a list of <c>DestinationTableConfigurations</c> which Firehose uses to deliver
        /// data to Apache Iceberg Tables. Firehose will write data with insert if table specific
        /// configuration is not provided here.
        /// </para>
        /// </summary>
        public List<DestinationTableConfiguration> DestinationTableConfigurationList
        {
            get { return this._destinationTableConfigurationList; }
            set { this._destinationTableConfigurationList = value; }
        }

        // Check to see if DestinationTableConfigurationList property is set
        internal bool IsSetDestinationTableConfigurationList()
        {
            return this._destinationTableConfigurationList != null && (this._destinationTableConfigurationList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ProcessingConfiguration.
        /// </summary>
        public ProcessingConfiguration ProcessingConfiguration
        {
            get { return this._processingConfiguration; }
            set { this._processingConfiguration = value; }
        }

        // Check to see if ProcessingConfiguration property is set
        internal bool IsSetProcessingConfiguration()
        {
            return this._processingConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property RetryOptions.
        /// </summary>
        public RetryOptions RetryOptions
        {
            get { return this._retryOptions; }
            set { this._retryOptions = value; }
        }

        // Check to see if RetryOptions property is set
        internal bool IsSetRetryOptions()
        {
            return this._retryOptions != null;
        }

        /// <summary>
        /// Gets and sets the property RoleARN. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the IAM role to be assumed by Firehose for calling
        /// Apache Iceberg Tables. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string RoleARN
        {
            get { return this._roleARN; }
            set { this._roleARN = value; }
        }

        // Check to see if RoleARN property is set
        internal bool IsSetRoleARN()
        {
            return this._roleARN != null;
        }

        /// <summary>
        /// Gets and sets the property S3BackupMode. 
        /// <para>
        ///  Describes how Firehose will backup records. Currently,Firehose only supports <c>FailedDataOnly</c>.
        /// 
        /// </para>
        /// </summary>
        public IcebergS3BackupMode S3BackupMode
        {
            get { return this._s3BackupMode; }
            set { this._s3BackupMode = value; }
        }

        // Check to see if S3BackupMode property is set
        internal bool IsSetS3BackupMode()
        {
            return this._s3BackupMode != null;
        }

        /// <summary>
        /// Gets and sets the property S3Configuration.
        /// </summary>
        public S3DestinationConfiguration S3Configuration
        {
            get { return this._s3Configuration; }
            set { this._s3Configuration = value; }
        }

        // Check to see if S3Configuration property is set
        internal bool IsSetS3Configuration()
        {
            return this._s3Configuration != null;
        }

        /// <summary>
        /// Gets and sets the property SchemaEvolutionConfiguration. 
        /// <para>
        ///  
        /// </para>
        ///  
        /// <para>
        /// Amazon Data Firehose is in preview release and is subject to change.
        /// </para>
        /// </summary>
        public SchemaEvolutionConfiguration SchemaEvolutionConfiguration
        {
            get { return this._schemaEvolutionConfiguration; }
            set { this._schemaEvolutionConfiguration = value; }
        }

        // Check to see if SchemaEvolutionConfiguration property is set
        internal bool IsSetSchemaEvolutionConfiguration()
        {
            return this._schemaEvolutionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property TableCreationConfiguration. 
        /// <para>
        ///  
        /// </para>
        ///  
        /// <para>
        /// Amazon Data Firehose is in preview release and is subject to change.
        /// </para>
        /// </summary>
        public TableCreationConfiguration TableCreationConfiguration
        {
            get { return this._tableCreationConfiguration; }
            set { this._tableCreationConfiguration = value; }
        }

        // Check to see if TableCreationConfiguration property is set
        internal bool IsSetTableCreationConfiguration()
        {
            return this._tableCreationConfiguration != null;
        }

    }
}