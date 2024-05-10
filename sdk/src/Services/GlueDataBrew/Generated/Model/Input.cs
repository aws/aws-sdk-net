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
 * Do not modify this file. This file is generated from the databrew-2017-07-25.normal.json service model.
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
namespace Amazon.GlueDataBrew.Model
{
    /// <summary>
    /// Represents information on how DataBrew can find data, in either the Glue Data Catalog
    /// or Amazon S3.
    /// </summary>
    public partial class Input
    {
        private DatabaseInputDefinition _databaseInputDefinition;
        private DataCatalogInputDefinition _dataCatalogInputDefinition;
        private Metadata _metadata;
        private S3Location _s3InputDefinition;

        /// <summary>
        /// Gets and sets the property DatabaseInputDefinition. 
        /// <para>
        /// Connection information for dataset input files stored in a database.
        /// </para>
        /// </summary>
        public DatabaseInputDefinition DatabaseInputDefinition
        {
            get { return this._databaseInputDefinition; }
            set { this._databaseInputDefinition = value; }
        }

        // Check to see if DatabaseInputDefinition property is set
        internal bool IsSetDatabaseInputDefinition()
        {
            return this._databaseInputDefinition != null;
        }

        /// <summary>
        /// Gets and sets the property DataCatalogInputDefinition. 
        /// <para>
        /// The Glue Data Catalog parameters for the data.
        /// </para>
        /// </summary>
        public DataCatalogInputDefinition DataCatalogInputDefinition
        {
            get { return this._dataCatalogInputDefinition; }
            set { this._dataCatalogInputDefinition = value; }
        }

        // Check to see if DataCatalogInputDefinition property is set
        internal bool IsSetDataCatalogInputDefinition()
        {
            return this._dataCatalogInputDefinition != null;
        }

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// Contains additional resource information needed for specific datasets.
        /// </para>
        /// </summary>
        public Metadata Metadata
        {
            get { return this._metadata; }
            set { this._metadata = value; }
        }

        // Check to see if Metadata property is set
        internal bool IsSetMetadata()
        {
            return this._metadata != null;
        }

        /// <summary>
        /// Gets and sets the property S3InputDefinition. 
        /// <para>
        /// The Amazon S3 location where the data is stored.
        /// </para>
        /// </summary>
        public S3Location S3InputDefinition
        {
            get { return this._s3InputDefinition; }
            set { this._s3InputDefinition = value; }
        }

        // Check to see if S3InputDefinition property is set
        internal bool IsSetS3InputDefinition()
        {
            return this._s3InputDefinition != null;
        }

    }
}