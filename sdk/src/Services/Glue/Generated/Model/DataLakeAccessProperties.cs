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
    /// Input properties to configure data lake access for your catalog resource in the Glue
    /// Data Catalog.
    /// </summary>
    public partial class DataLakeAccessProperties
    {
        private string _catalogType;
        private bool? _dataLakeAccess;
        private string _dataTransferRole;
        private string _kmsKey;

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
        /// Redshift databases in the Data Catalog from any non-Redshift engine, such as Amazon
        /// Athena, Amazon EMR, or Glue ETL.
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

    }
}