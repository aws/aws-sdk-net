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
 * Do not modify this file. This file is generated from the athena-2017-05-18.normal.json service model.
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
namespace Amazon.Athena.Model
{
    /// <summary>
    /// Contains information about a data catalog in an Amazon Web Services account.
    /// 
    ///  <note> 
    /// <para>
    /// In the Athena console, data catalogs are listed as "data sources" on the <b>Data sources</b>
    /// page under the <b>Data source name</b> column.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DataCatalog
    {
        private ConnectionType _connectionType;
        private string _description;
        private string _error;
        private string _name;
        private Dictionary<string, string> _parameters = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private DataCatalogStatus _status;
        private DataCatalogType _type;

        /// <summary>
        /// Gets and sets the property ConnectionType. 
        /// <para>
        /// The type of connection for a <c>FEDERATED</c> data catalog (for example, <c>REDSHIFT</c>,
        /// <c>MYSQL</c>, or <c>SQLSERVER</c>). For information about individual connectors, see
        /// <a href="https://docs.aws.amazon.com/athena/latest/ug/connectors-available.html">Available
        /// data source connectors</a>.
        /// </para>
        /// </summary>
        public ConnectionType ConnectionType
        {
            get { return this._connectionType; }
            set { this._connectionType = value; }
        }

        // Check to see if ConnectionType property is set
        internal bool IsSetConnectionType()
        {
            return this._connectionType != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An optional description of the data catalog.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// Text of the error that occurred during data catalog creation or deletion.
        /// </para>
        /// </summary>
        public string Error
        {
            get { return this._error; }
            set { this._error = value; }
        }

        // Check to see if Error property is set
        internal bool IsSetError()
        {
            return this._error != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the data catalog. The catalog name must be unique for the Amazon Web Services
        /// account and can use a maximum of 127 alphanumeric, underscore, at sign, or hyphen
        /// characters. The remainder of the length constraint of 256 is reserved for use by Athena.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
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
        /// Gets and sets the property Parameters. 
        /// <para>
        /// Specifies the Lambda function or functions to use for the data catalog. This is a
        /// mapping whose values depend on the catalog type. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For the <c>HIVE</c> data catalog type, use the following syntax. The <c>metadata-function</c>
        /// parameter is required. <c>The sdk-version</c> parameter is optional and defaults to
        /// the currently supported version.
        /// </para>
        ///  
        /// <para>
        ///  <c>metadata-function=<i>lambda_arn</i>, sdk-version=<i>version_number</i> </c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the <c>LAMBDA</c> data catalog type, use one of the following sets of required
        /// parameters, but not both.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you have one Lambda function that processes metadata and another for reading the
        /// actual data, use the following syntax. Both parameters are required.
        /// </para>
        ///  
        /// <para>
        ///  <c>metadata-function=<i>lambda_arn</i>, record-function=<i>lambda_arn</i> </c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  If you have a composite Lambda function that processes both metadata and data, use
        /// the following syntax to specify your Lambda function.
        /// </para>
        ///  
        /// <para>
        ///  <c>function=<i>lambda_arn</i> </c> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// The <c>GLUE</c> type takes a catalog ID parameter and is required. The <c> <i>catalog_id</i>
        /// </c> is the account ID of the Amazon Web Services account to which the Glue catalog
        /// belongs.
        /// </para>
        ///  
        /// <para>
        ///  <c>catalog-id=<i>catalog_id</i> </c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The <c>GLUE</c> data catalog type also applies to the default <c>AwsDataCatalog</c>
        /// that already exists in your account, of which you can have only one and cannot modify.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// The <c>FEDERATED</c> data catalog type uses one of the following parameters, but not
        /// both. Use <c>connection-arn</c> for an existing Glue connection. Use <c>connection-type</c>
        /// and <c>connection-properties</c> to specify the configuration setting for a new connection.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>connection-arn:<i>&lt;glue_connection_arn_to_reuse&gt;</i> </c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>connection-type:MYSQL|REDSHIFT|...., connection-properties:"<i>&lt;json_string&gt;</i>"</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// For <i> <c>&lt;json_string&gt;</c> </i>, use escaped JSON text, as in the following
        /// example.
        /// </para>
        ///  
        /// <para>
        ///  <c>"{\"spill_bucket\":\"my_spill\",\"spill_prefix\":\"athena-spill\",\"host\":\"abc12345.snowflakecomputing.com\",\"port\":\"1234\",\"warehouse\":\"DEV_WH\",\"database\":\"TEST\",\"schema\":\"PUBLIC\",\"SecretArn\":\"arn:aws:secretsmanager:ap-south-1:111122223333:secret:snowflake-XHb67j\"}"</c>
        /// 
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && (this._parameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the creation or deletion of the data catalog.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The <c>LAMBDA</c>, <c>GLUE</c>, and <c>HIVE</c> data catalog types are created synchronously.
        /// Their status is either <c>CREATE_COMPLETE</c> or <c>CREATE_FAILED</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>FEDERATED</c> data catalog type is created asynchronously.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Data catalog creation status:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CREATE_IN_PROGRESS</c>: Federated data catalog creation in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATE_COMPLETE</c>: Data catalog creation complete.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATE_FAILED</c>: Data catalog could not be created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATE_FAILED_CLEANUP_IN_PROGRESS</c>: Federated data catalog creation failed
        /// and is being removed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATE_FAILED_CLEANUP_COMPLETE</c>: Federated data catalog creation failed and
        /// was removed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATE_FAILED_CLEANUP_FAILED</c>: Federated data catalog creation failed but could
        /// not be removed.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Data catalog deletion status:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DELETE_IN_PROGRESS</c>: Federated data catalog deletion in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETE_COMPLETE</c>: Federated data catalog deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETE_FAILED</c>: Federated data catalog could not be deleted.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DataCatalogStatus Status
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
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of data catalog to create: <c>LAMBDA</c> for a federated catalog, <c>GLUE</c>
        /// for an Glue Data Catalog, and <c>HIVE</c> for an external Apache Hive metastore. <c>FEDERATED</c>
        /// is a federated catalog for which Athena creates the connection and the Lambda function
        /// for you based on the parameters that you pass.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DataCatalogType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}