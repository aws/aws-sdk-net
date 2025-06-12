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
 * Do not modify this file. This file is generated from the migrationhubstrategy-2020-02-19.normal.json service model.
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
namespace Amazon.MigrationHubStrategyRecommendations.Model
{
    /// <summary>
    /// Container for the parameters to the StartImportFileTask operation.
    /// Starts a file import.
    /// </summary>
    public partial class StartImportFileTaskRequest : AmazonMigrationHubStrategyRecommendationsRequest
    {
        private DataSourceType _dataSourceType;
        private List<Group> _groupId = AWSConfigs.InitializeCollections ? new List<Group>() : null;
        private string _name;
        private string _s3Bucket;
        private string _s3bucketForReportData;
        private string _s3key;

        /// <summary>
        /// Gets and sets the property DataSourceType. 
        /// <para>
        /// Specifies the source that the servers are coming from. By default, Strategy Recommendations
        /// assumes that the servers specified in the import file are available in AWS Application
        /// Discovery Service. 
        /// </para>
        /// </summary>
        public DataSourceType DataSourceType
        {
            get { return this._dataSourceType; }
            set { this._dataSourceType = value; }
        }

        // Check to see if DataSourceType property is set
        internal bool IsSetDataSourceType()
        {
            return this._dataSourceType != null;
        }

        /// <summary>
        /// Gets and sets the property GroupId. 
        /// <para>
        /// Groups the resources in the import file together with a unique name. This ID can be
        /// as filter in <c>ListApplicationComponents</c> and <c>ListServers</c>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Group> GroupId
        {
            get { return this._groupId; }
            set { this._groupId = value; }
        }

        // Check to see if GroupId property is set
        internal bool IsSetGroupId()
        {
            return this._groupId != null && (this._groupId.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  A descriptive name for the request. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property S3Bucket. 
        /// <para>
        ///  The S3 bucket where the import file is located. The bucket name is required to begin
        /// with <c>migrationhub-strategy-</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=63)]
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
        /// Gets and sets the property S3bucketForReportData. 
        /// <para>
        ///  The S3 bucket where Strategy Recommendations uploads import results. The bucket name
        /// is required to begin with migrationhub-strategy-. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=63)]
        public string S3bucketForReportData
        {
            get { return this._s3bucketForReportData; }
            set { this._s3bucketForReportData = value; }
        }

        // Check to see if S3bucketForReportData property is set
        internal bool IsSetS3bucketForReportData()
        {
            return this._s3bucketForReportData != null;
        }

        /// <summary>
        /// Gets and sets the property S3key. 
        /// <para>
        ///  The Amazon S3 key name of the import file. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1024)]
        public string S3key
        {
            get { return this._s3key; }
            set { this._s3key = value; }
        }

        // Check to see if S3key property is set
        internal bool IsSetS3key()
        {
            return this._s3key != null;
        }

    }
}