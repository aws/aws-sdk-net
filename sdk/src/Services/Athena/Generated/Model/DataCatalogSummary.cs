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
    /// The summary information for the data catalog, which includes its name and type.
    /// </summary>
    public partial class DataCatalogSummary
    {
        private string _catalogName;
        private ConnectionType _connectionType;
        private string _error;
        private DataCatalogStatus _status;
        private DataCatalogType _type;

        /// <summary>
        /// Gets and sets the property CatalogName. 
        /// <para>
        /// The name of the data catalog. The catalog name is unique for the Amazon Web Services
        /// account and can use a maximum of 127 alphanumeric, underscore, at sign, or hyphen
        /// characters. The remainder of the length constraint of 256 is reserved for use by Athena.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string CatalogName
        {
            get { return this._catalogName; }
            set { this._catalogName = value; }
        }

        // Check to see if CatalogName property is set
        internal bool IsSetCatalogName()
        {
            return this._catalogName != null;
        }

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
        /// The data catalog type.
        /// </para>
        /// </summary>
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