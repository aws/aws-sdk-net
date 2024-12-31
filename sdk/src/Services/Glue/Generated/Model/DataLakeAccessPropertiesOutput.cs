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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// The output properties of the data lake access configuration for your catalog resource
    /// in the Glue Data Catalog.
    /// </summary>
    public partial class DataLakeAccessPropertiesOutput
    {
        private string _catalogType;
        private bool? _dataLakeAccess;
        private string _dataTransferRole;
        private string _kmsKey;
        private string _managedWorkgroupName;
        private string _managedWorkgroupStatus;
        private string _redshiftDatabaseName;
        private string _statusMessage;

        /// <summary>
        /// Gets and sets the property CatalogType. 
        /// <para>
        /// Specifies a federated catalog type for the native catalog resource. The currently
        /// supported type is <c>aws:redshift</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string CatalogType
        {
            get { return this._catalogType; }
            set { this._catalogType = value; }
        }

        // Check to see if CatalogType property is set
        internal bool IsSetCatalogType()
        {
            return this._catalogType != null;
        }

        /// <summary>
        /// Gets and sets the property DataLakeAccess. 
        /// <para>
        /// Turns on or off data lake access for Apache Spark applications that access Amazon
        /// Redshift databases in the Data Catalog.
        /// </para>
        /// </summary>
        public bool? DataLakeAccess
        {
            get { return this._dataLakeAccess; }
            set { this._dataLakeAccess = value; }
        }

        // Check to see if DataLakeAccess property is set
        internal bool IsSetDataLakeAccess()
        {
            return this._dataLakeAccess.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DataTransferRole. 
        /// <para>
        /// A role that will be assumed by Glue for transferring data into/out of the staging
        /// bucket during a query.
        /// </para>
        /// </summary>
        public string DataTransferRole
        {
            get { return this._dataTransferRole; }
            set { this._dataTransferRole = value; }
        }

        // Check to see if DataTransferRole property is set
        internal bool IsSetDataTransferRole()
        {
            return this._dataTransferRole != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKey. 
        /// <para>
        /// An encryption key that will be used for the staging bucket that will be created along
        /// with the catalog.
        /// </para>
        /// </summary>
        public string KmsKey
        {
            get { return this._kmsKey; }
            set { this._kmsKey = value; }
        }

        // Check to see if KmsKey property is set
        internal bool IsSetKmsKey()
        {
            return this._kmsKey != null;
        }

        /// <summary>
        /// Gets and sets the property ManagedWorkgroupName. 
        /// <para>
        /// The managed Redshift Serverless compute name that is created for your catalog resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string ManagedWorkgroupName
        {
            get { return this._managedWorkgroupName; }
            set { this._managedWorkgroupName = value; }
        }

        // Check to see if ManagedWorkgroupName property is set
        internal bool IsSetManagedWorkgroupName()
        {
            return this._managedWorkgroupName != null;
        }

        /// <summary>
        /// Gets and sets the property ManagedWorkgroupStatus. 
        /// <para>
        /// The managed Redshift Serverless compute status.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string ManagedWorkgroupStatus
        {
            get { return this._managedWorkgroupStatus; }
            set { this._managedWorkgroupStatus = value; }
        }

        // Check to see if ManagedWorkgroupStatus property is set
        internal bool IsSetManagedWorkgroupStatus()
        {
            return this._managedWorkgroupStatus != null;
        }

        /// <summary>
        /// Gets and sets the property RedshiftDatabaseName. 
        /// <para>
        /// The default Redshift database resource name in the managed compute.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string RedshiftDatabaseName
        {
            get { return this._redshiftDatabaseName; }
            set { this._redshiftDatabaseName = value; }
        }

        // Check to see if RedshiftDatabaseName property is set
        internal bool IsSetRedshiftDatabaseName()
        {
            return this._redshiftDatabaseName != null;
        }

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// A message that gives more detailed information about the managed workgroup status.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

    }
}