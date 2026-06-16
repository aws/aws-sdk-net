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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The configuration of an <c>OfflineStore</c>.
    /// 
    ///  
    /// <para>
    /// Provide an <c>OfflineStoreConfig</c> in a request to <c>CreateFeatureGroup</c> to
    /// create an <c>OfflineStore</c>.
    /// </para>
    ///  
    /// <para>
    /// To encrypt an <c>OfflineStore</c> using at rest data encryption, specify Amazon Web
    /// Services Key Management Service (KMS) key ID, or <c>KMSKeyId</c>, in <c>S3StorageConfig</c>.
    /// </para>
    /// </summary>
    public partial class OfflineStoreConfig
    {
        private DataCatalogConfig _dataCatalogConfig;
        private bool? _disableGlueTableCreation;
        private S3StorageConfig _s3StorageConfig;
        private TableFormat _tableFormat;

        /// <summary>
        /// Gets and sets the property DataCatalogConfig. 
        /// <para>
        /// The meta data of the Glue table for the <c>OfflineStore</c>. If not provided, Feature
        /// Store auto-generates the table name, database, and catalog when the <c>OfflineStore</c>
        /// is created. You can optionally provide this configuration to specify custom values.
        /// This applies to both Glue and Apache Iceberg table formats.
        /// </para>
        /// </summary>
        public DataCatalogConfig DataCatalogConfig
        {
            get { return this._dataCatalogConfig; }
            set { this._dataCatalogConfig = value; }
        }

        // Check to see if DataCatalogConfig property is set
        internal bool IsSetDataCatalogConfig()
        {
            return this._dataCatalogConfig != null;
        }

        /// <summary>
        /// Gets and sets the property DisableGlueTableCreation. 
        /// <para>
        /// Set to <c>True</c> to disable the automatic creation of an Amazon Web Services Glue
        /// table when configuring an <c>OfflineStore</c>. If set to <c>True</c> and <c>DataCatalogConfig</c>
        /// is provided, Feature Store associates the provided catalog configuration with the
        /// feature group without creating a table. In this case, you are responsible for creating
        /// and managing the Glue table. If set to <c>True</c> without <c>DataCatalogConfig</c>,
        /// no Glue table is created or associated with the feature group. The <c>Iceberg</c>
        /// table format is only supported when this is set to <c>False</c>.
        /// </para>
        ///  
        /// <para>
        /// If set to <c>False</c> and <c>DataCatalogConfig</c> is provided, Feature Store creates
        /// the table using the specified names. If set to <c>False</c> without <c>DataCatalogConfig</c>,
        /// Feature Store auto-generates the table name following <a href="https://docs.aws.amazon.com/athena/latest/ug/tables-databases-columns-names.html">Athena's
        /// naming recommendations</a>. This applies to both Glue and Apache Iceberg table formats.
        /// </para>
        ///  
        /// <para>
        /// The default value is <c>False</c>.
        /// </para>
        /// </summary>
        public bool? DisableGlueTableCreation
        {
            get { return this._disableGlueTableCreation; }
            set { this._disableGlueTableCreation = value; }
        }

        // Check to see if DisableGlueTableCreation property is set
        internal bool IsSetDisableGlueTableCreation()
        {
            return this._disableGlueTableCreation.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property S3StorageConfig. 
        /// <para>
        /// The Amazon Simple Storage (Amazon S3) location of <c>OfflineStore</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public S3StorageConfig S3StorageConfig
        {
            get { return this._s3StorageConfig; }
            set { this._s3StorageConfig = value; }
        }

        // Check to see if S3StorageConfig property is set
        internal bool IsSetS3StorageConfig()
        {
            return this._s3StorageConfig != null;
        }

        /// <summary>
        /// Gets and sets the property TableFormat. 
        /// <para>
        /// Format for the offline store table. Supported formats are Glue (Default) and <a href="https://iceberg.apache.org/">Apache
        /// Iceberg</a>.
        /// </para>
        /// </summary>
        public TableFormat TableFormat
        {
            get { return this._tableFormat; }
            set { this._tableFormat = value; }
        }

        // Check to see if TableFormat property is set
        internal bool IsSetTableFormat()
        {
            return this._tableFormat != null;
        }

    }
}