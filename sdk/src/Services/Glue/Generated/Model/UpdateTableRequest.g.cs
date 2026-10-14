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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateTable operation. Updates a metadata table
    /// in the Data Catalog.
    /// </summary>
    public partial class UpdateTableRequest : AmazonGlueRequest
    {
        /// <summary>
        /// Gets and sets the property CatalogId. 
        /// <para>
        /// The ID of the Data Catalog where the table resides. If none is provided, the Amazon
        /// Web Services account ID is used by default.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string CatalogId { get; set; }

        /// <summary>
        /// Checks to see if the CatalogId property is set.
        /// </summary>
        internal bool IsSetCatalogId() => this.CatalogId != null;

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The name of the catalog database in which the table resides. For Hive compatibility,
        /// this name is entirely lowercase.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseName property is set.
        /// </summary>
        internal bool IsSetDatabaseName() => this.DatabaseName != null;

        /// <summary>
        /// Gets and sets the property Force. 
        /// <para>
        /// A flag that can be set to true to ignore matching storage descriptor and subobject
        /// matching requirements.
        /// </para>
        /// </summary>
        public bool? Force { get; set; }

        /// <summary>
        /// Checks to see if the Force property is set.
        /// </summary>
        internal bool IsSetForce() => this.Force.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The unique identifier for the table within the specified database that will be created
        /// in the Glue Data Catalog.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property SkipArchive. 
        /// <para>
        /// By default, <c>UpdateTable</c> always creates an archived version of the table before
        /// updating it. However, if <c>skipArchive</c> is set to true, <c>UpdateTable</c> does
        /// not create the archived version.
        /// </para>
        /// </summary>
        public bool? SkipArchive { get; set; }

        /// <summary>
        /// Checks to see if the SkipArchive property is set.
        /// </summary>
        internal bool IsSetSkipArchive() => this.SkipArchive.HasValue;

        /// <summary>
        /// Gets and sets the property TableInput. 
        /// <para>
        /// An updated <c>TableInput</c> object to define the metadata table in the catalog.
        /// </para>
        /// </summary>
        public TableInput TableInput { get; set; }

        /// <summary>
        /// Checks to see if the TableInput property is set.
        /// </summary>
        internal bool IsSetTableInput() => this.TableInput != null;

        /// <summary>
        /// Gets and sets the property TransactionId. 
        /// <para>
        /// The transaction ID at which to update the table contents. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string TransactionId { get; set; }

        /// <summary>
        /// Checks to see if the TransactionId property is set.
        /// </summary>
        internal bool IsSetTransactionId() => this.TransactionId != null;

        /// <summary>
        /// Gets and sets the property UpdateOpenTableFormatInput. 
        /// <para>
        /// Input parameters for updating open table format tables in GlueData Catalog, serving
        /// as a wrapper for format-specific update operations such as Apache Iceberg.
        /// </para>
        /// </summary>
        public UpdateOpenTableFormatInput UpdateOpenTableFormatInput { get; set; }

        /// <summary>
        /// Checks to see if the UpdateOpenTableFormatInput property is set.
        /// </summary>
        internal bool IsSetUpdateOpenTableFormatInput() => this.UpdateOpenTableFormatInput != null;

        /// <summary>
        /// Gets and sets the property VersionId. 
        /// <para>
        /// The version ID at which to update the table contents. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string VersionId { get; set; }

        /// <summary>
        /// Checks to see if the VersionId property is set.
        /// </summary>
        internal bool IsSetVersionId() => this.VersionId != null;

        /// <summary>
        /// Gets and sets the property ViewUpdateAction. 
        /// <para>
        /// The operation to be performed when updating the view.
        /// </para>
        /// </summary>
        public ViewUpdateAction ViewUpdateAction { get; set; }

        /// <summary>
        /// Checks to see if the ViewUpdateAction property is set.
        /// </summary>
        internal bool IsSetViewUpdateAction() => this.ViewUpdateAction != null;
    }
}
