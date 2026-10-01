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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property DataCatalogInputDefinition. 
        /// <para>
        /// The Glue Data Catalog parameters for the data.
        /// </para>
        /// </summary>
        public DataCatalogInputDefinition DataCatalogInputDefinition { get; set; }

        /// <summary>
        /// Checks to see if the DataCatalogInputDefinition property is set.
        /// </summary>
        internal bool IsSetDataCatalogInputDefinition() => this.DataCatalogInputDefinition != null;

        /// <summary>
        /// Gets and sets the property DatabaseInputDefinition. 
        /// <para>
        /// Connection information for dataset input files stored in a database.
        /// </para>
        /// </summary>
        public DatabaseInputDefinition DatabaseInputDefinition { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseInputDefinition property is set.
        /// </summary>
        internal bool IsSetDatabaseInputDefinition() => this.DatabaseInputDefinition != null;

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// Contains additional resource information needed for specific datasets.
        /// </para>
        /// </summary>
        public Metadata Metadata { get; set; }

        /// <summary>
        /// Checks to see if the Metadata property is set.
        /// </summary>
        internal bool IsSetMetadata() => this.Metadata != null;

        /// <summary>
        /// Gets and sets the property S3InputDefinition. 
        /// <para>
        /// The Amazon S3 location where the data is stored.
        /// </para>
        /// </summary>
        public S3Location S3InputDefinition { get; set; }

        /// <summary>
        /// Checks to see if the S3InputDefinition property is set.
        /// </summary>
        internal bool IsSetS3InputDefinition() => this.S3InputDefinition != null;
    }
}
