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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Configuration information for a Amazon Kendra data source.
    /// </summary>
    public partial class DataSourceConfiguration
    {
        private ConfluenceConfiguration _confluenceConfiguration;
        private DatabaseConfiguration _databaseConfiguration;
        private GoogleDriveConfiguration _googleDriveConfiguration;
        private OneDriveConfiguration _oneDriveConfiguration;
        private S3DataSourceConfiguration _s3Configuration;
        private SalesforceConfiguration _salesforceConfiguration;
        private ServiceNowConfiguration _serviceNowConfiguration;
        private SharePointConfiguration _sharePointConfiguration;

        /// <summary>
        /// Gets and sets the property ConfluenceConfiguration. 
        /// <para>
        /// Provides configuration information for connecting to a Confluence data source.
        /// </para>
        /// </summary>
        public ConfluenceConfiguration ConfluenceConfiguration
        {
            get { return this._confluenceConfiguration; }
            set { this._confluenceConfiguration = value; }
        }

        // Check to see if ConfluenceConfiguration property is set
        internal bool IsSetConfluenceConfiguration()
        {
            return this._confluenceConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property DatabaseConfiguration. 
        /// <para>
        /// Provides information necessary to create a data source connector for a database.
        /// </para>
        /// </summary>
        public DatabaseConfiguration DatabaseConfiguration
        {
            get { return this._databaseConfiguration; }
            set { this._databaseConfiguration = value; }
        }

        // Check to see if DatabaseConfiguration property is set
        internal bool IsSetDatabaseConfiguration()
        {
            return this._databaseConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property GoogleDriveConfiguration. 
        /// <para>
        /// Provides configuration for data sources that connect to Google Drive. 
        /// </para>
        /// </summary>
        public GoogleDriveConfiguration GoogleDriveConfiguration
        {
            get { return this._googleDriveConfiguration; }
            set { this._googleDriveConfiguration = value; }
        }

        // Check to see if GoogleDriveConfiguration property is set
        internal bool IsSetGoogleDriveConfiguration()
        {
            return this._googleDriveConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property OneDriveConfiguration. 
        /// <para>
        /// Provides configuration for data sources that connect to Microsoft OneDrive.
        /// </para>
        /// </summary>
        public OneDriveConfiguration OneDriveConfiguration
        {
            get { return this._oneDriveConfiguration; }
            set { this._oneDriveConfiguration = value; }
        }

        // Check to see if OneDriveConfiguration property is set
        internal bool IsSetOneDriveConfiguration()
        {
            return this._oneDriveConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property S3Configuration. 
        /// <para>
        /// Provides information to create a data source connector for a document repository in
        /// an Amazon S3 bucket.
        /// </para>
        /// </summary>
        public S3DataSourceConfiguration S3Configuration
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
        /// Gets and sets the property SalesforceConfiguration. 
        /// <para>
        /// Provides configuration information for data sources that connect to a Salesforce site.
        /// </para>
        /// </summary>
        public SalesforceConfiguration SalesforceConfiguration
        {
            get { return this._salesforceConfiguration; }
            set { this._salesforceConfiguration = value; }
        }

        // Check to see if SalesforceConfiguration property is set
        internal bool IsSetSalesforceConfiguration()
        {
            return this._salesforceConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceNowConfiguration. 
        /// <para>
        /// Provides configuration for data sources that connect to ServiceNow instances.
        /// </para>
        /// </summary>
        public ServiceNowConfiguration ServiceNowConfiguration
        {
            get { return this._serviceNowConfiguration; }
            set { this._serviceNowConfiguration = value; }
        }

        // Check to see if ServiceNowConfiguration property is set
        internal bool IsSetServiceNowConfiguration()
        {
            return this._serviceNowConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property SharePointConfiguration. 
        /// <para>
        /// Provides information necessary to create a data source connector for a Microsoft SharePoint
        /// site.
        /// </para>
        /// </summary>
        public SharePointConfiguration SharePointConfiguration
        {
            get { return this._sharePointConfiguration; }
            set { this._sharePointConfiguration = value; }
        }

        // Check to see if SharePointConfiguration property is set
        internal bool IsSetSharePointConfiguration()
        {
            return this._sharePointConfiguration != null;
        }

    }
}