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
        private string _description;
        private string _name;
        private Dictionary<string, string> _parameters = new Dictionary<string, string>();
        private DataCatalogType _type;

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
        /// For the <code>HIVE</code> data catalog type, use the following syntax. The <code>metadata-function</code>
        /// parameter is required. <code>The sdk-version</code> parameter is optional and defaults
        /// to the currently supported version.
        /// </para>
        ///  
        /// <para>
        ///  <code>metadata-function=<i>lambda_arn</i>, sdk-version=<i>version_number</i> </code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the <code>LAMBDA</code> data catalog type, use one of the following sets of required
        /// parameters, but not both.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you have one Lambda function that processes metadata and another for reading the
        /// actual data, use the following syntax. Both parameters are required.
        /// </para>
        ///  
        /// <para>
        ///  <code>metadata-function=<i>lambda_arn</i>, record-function=<i>lambda_arn</i> </code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  If you have a composite Lambda function that processes both metadata and data, use
        /// the following syntax to specify your Lambda function.
        /// </para>
        ///  
        /// <para>
        ///  <code>function=<i>lambda_arn</i> </code> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// The <code>GLUE</code> type takes a catalog ID parameter and is required. The <code>
        /// <i>catalog_id</i> </code> is the account ID of the Amazon Web Services account to
        /// which the Glue catalog belongs.
        /// </para>
        ///  
        /// <para>
        ///  <code>catalog-id=<i>catalog_id</i> </code> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The <code>GLUE</code> data catalog type also applies to the default <code>AwsDataCatalog</code>
        /// that already exists in your account, of which you can have only one and cannot modify.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Queries that specify a Glue Data Catalog other than the default <code>AwsDataCatalog</code>
        /// must be run on Athena engine version 2.
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        public Dictionary<string, string> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && this._parameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of data catalog to create: <code>LAMBDA</code> for a federated catalog, <code>HIVE</code>
        /// for an external hive metastore, or <code>GLUE</code> for an Glue Data Catalog.
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