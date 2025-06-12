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
 * Do not modify this file. This file is generated from the discovery-2015-11-01.normal.json service model.
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
namespace Amazon.ApplicationDiscoveryService.Model
{
    /// <summary>
    /// A list of continuous export descriptions.
    /// </summary>
    public partial class ContinuousExportDescription
    {
        private DataSource _dataSource;
        private string _exportId;
        private string _s3Bucket;
        private Dictionary<string, string> _schemaStorageConfig = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private DateTime? _startTime;
        private ContinuousExportStatus _status;
        private string _statusDetail;
        private DateTime? _stopTime;

        /// <summary>
        /// Gets and sets the property DataSource. 
        /// <para>
        /// The type of data collector used to gather this data (currently only offered for AGENT).
        /// </para>
        /// </summary>
        public DataSource DataSource
        {
            get { return this._dataSource; }
            set { this._dataSource = value; }
        }

        // Check to see if DataSource property is set
        internal bool IsSetDataSource()
        {
            return this._dataSource != null;
        }

        /// <summary>
        /// Gets and sets the property ExportId. 
        /// <para>
        /// The unique ID assigned to this export.
        /// </para>
        /// </summary>
        [AWSProperty(Max=200)]
        public string ExportId
        {
            get { return this._exportId; }
            set { this._exportId = value; }
        }

        // Check to see if ExportId property is set
        internal bool IsSetExportId()
        {
            return this._exportId != null;
        }

        /// <summary>
        /// Gets and sets the property S3Bucket. 
        /// <para>
        /// The name of the s3 bucket where the export data parquet files are stored.
        /// </para>
        /// </summary>
        public string S3Bucket
        {
            get { return this._s3Bucket; }
            set { this._s3Bucket = value; }
        }

        // Check to see if S3Bucket property is set
        internal bool IsSetS3Bucket()
        {
            return this._s3Bucket != null;
        }

        /// <summary>
        /// Gets and sets the property SchemaStorageConfig. 
        /// <para>
        /// An object which describes how the data is stored.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>databaseName</c> - the name of the Glue database used to store the schema.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> SchemaStorageConfig
        {
            get { return this._schemaStorageConfig; }
            set { this._schemaStorageConfig = value; }
        }

        // Check to see if SchemaStorageConfig property is set
        internal bool IsSetSchemaStorageConfig()
        {
            return this._schemaStorageConfig != null && (this._schemaStorageConfig.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The timestamp representing when the continuous export was started.
        /// </para>
        /// </summary>
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Describes the status of the export. Can be one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// START_IN_PROGRESS - setting up resources to start continuous export.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// START_FAILED - an error occurred setting up continuous export. To recover, call start-continuous-export
        /// again.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACTIVE - data is being exported to the customer bucket.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ERROR - an error occurred during export. To fix the issue, call stop-continuous-export
        /// and start-continuous-export.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// STOP_IN_PROGRESS - stopping the export.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// STOP_FAILED - an error occurred stopping the export. To recover, call stop-continuous-export
        /// again.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INACTIVE - the continuous export has been stopped. Data is no longer being exported
        /// to the customer bucket.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ContinuousExportStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusDetail. 
        /// <para>
        /// Contains information about any errors that have occurred. This data type can have
        /// the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// ACCESS_DENIED - You don’t have permission to start Data Exploration in Amazon Athena.
        /// Contact your Amazon Web Services administrator for help. For more information, see
        /// <a href="http://docs.aws.amazon.com/application-discovery/latest/userguide/setting-up.html">Setting
        /// Up Amazon Web Services Application Discovery Service</a> in the Application Discovery
        /// Service User Guide.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELIVERY_STREAM_LIMIT_FAILURE - You reached the limit for Amazon Kinesis Data Firehose
        /// delivery streams. Reduce the number of streams or request a limit increase and try
        /// again. For more information, see <a href="http://docs.aws.amazon.com/streams/latest/dev/service-sizes-and-limits.html">Kinesis
        /// Data Streams Limits</a> in the Amazon Kinesis Data Streams Developer Guide.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// FIREHOSE_ROLE_MISSING - The Data Exploration feature is in an error state because
        /// your user is missing the Amazon Web ServicesApplicationDiscoveryServiceFirehose role.
        /// Turn on Data Exploration in Amazon Athena and try again. For more information, see
        /// <a href="https://docs.aws.amazon.com/application-discovery/latest/userguide/security-iam-awsmanpol.html#security-iam-awsmanpol-create-firehose-role">Creating
        /// the Amazon Web ServicesApplicationDiscoveryServiceFirehose Role</a> in the Application
        /// Discovery Service User Guide.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// FIREHOSE_STREAM_DOES_NOT_EXIST - The Data Exploration feature is in an error state
        /// because your user is missing one or more of the Kinesis data delivery streams.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INTERNAL_FAILURE - The Data Exploration feature is in an error state because of an
        /// internal failure. Try again later. If this problem persists, contact Amazon Web Services
        /// Support.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// LAKE_FORMATION_ACCESS_DENIED - You don't have sufficient lake formation permissions
        /// to start continuous export. For more information, see <a href="http://docs.aws.amazon.com/lake-formation/latest/dg/upgrade-glue-lake-formation.html">
        /// Upgrading Amazon Web Services Glue Data Permissions to the Amazon Web Services Lake
        /// Formation Model </a> in the Amazon Web Services <i>Lake Formation Developer Guide</i>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// You can use one of the following two ways to resolve this issue.
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// If you don’t want to use the Lake Formation permission model, you can change the default
        /// Data Catalog settings to use only Amazon Web Services Identity and Access Management
        /// (IAM) access control for new databases. For more information, see <a href="https://docs.aws.amazon.com/lake-formation/latest/dg/getting-started-setup.html#setup-change-cat-settings">Change
        /// Data Catalog Settings</a> in the <i>Lake Formation Developer Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can give the service-linked IAM roles AWSServiceRoleForApplicationDiscoveryServiceContinuousExport
        /// and AWSApplicationDiscoveryServiceFirehose the required Lake Formation permissions.
        /// For more information, see <a href="https://docs.aws.amazon.com/lake-formation/latest/dg/granting-database-permissions.html">
        /// Granting Database Permissions</a> in the <i>Lake Formation Developer Guide</i>. 
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// AWSServiceRoleForApplicationDiscoveryServiceContinuousExport - Grant database creator
        /// permissions, which gives the role database creation ability and implicit permissions
        /// for any created tables. For more information, see <a href="https://docs.aws.amazon.com/lake-formation/latest/dg/implicit-permissions.html">
        /// Implicit Lake Formation Permissions </a> in the <i>Lake Formation Developer Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AWSApplicationDiscoveryServiceFirehose - Grant describe permissions for all tables
        /// in the database.
        /// </para>
        ///  </li> </ol> </li> </ol> </li> <li> 
        /// <para>
        /// S3_BUCKET_LIMIT_FAILURE - You reached the limit for Amazon S3 buckets. Reduce the
        /// number of S3 buckets or request a limit increase and try again. For more information,
        /// see <a href="http://docs.aws.amazon.com/AmazonS3/latest/dev/BucketRestrictions.html">Bucket
        /// Restrictions and Limitations</a> in the Amazon Simple Storage Service Developer Guide.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// S3_NOT_SIGNED_UP - Your account is not signed up for the Amazon S3 service. You must
        /// sign up before you can use Amazon S3. You can sign up at the following URL: <a href="https://aws.amazon.com/s3">https://aws.amazon.com/s3</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string StatusDetail
        {
            get { return this._statusDetail; }
            set { this._statusDetail = value; }
        }

        // Check to see if StatusDetail property is set
        internal bool IsSetStatusDetail()
        {
            return this._statusDetail != null;
        }

        /// <summary>
        /// Gets and sets the property StopTime. 
        /// <para>
        /// The timestamp that represents when this continuous export was stopped.
        /// </para>
        /// </summary>
        public DateTime? StopTime
        {
            get { return this._stopTime; }
            set { this._stopTime = value; }
        }

        // Check to see if StopTime property is set
        internal bool IsSetStopTime()
        {
            return this._stopTime.HasValue; 
        }

    }
}