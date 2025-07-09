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
    /// Container for the parameters to the UpdateTable operation.
    /// Updates a metadata table in the Data Catalog.
    /// </summary>
    public partial class UpdateTableRequest : AmazonGlueRequest
    {
        private string _catalogId;
        private string _databaseName;
        private bool? _force;
        private string _name;
        private bool? _skipArchive;
        private TableInput _tableInput;
        private string _transactionId;
        private UpdateOpenTableFormatInput _updateOpenTableFormatInput;
        private string _versionId;
        private ViewUpdateAction _viewUpdateAction;

        /// <summary>
        /// Gets and sets the property CatalogId. 
        /// <para>
        /// The ID of the Data Catalog where the table resides. If none is provided, the Amazon
        /// Web Services account ID is used by default.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string CatalogId
        {
            get { return this._catalogId; }
            set { this._catalogId = value; }
        }

        // Check to see if CatalogId property is set
        internal bool IsSetCatalogId()
        {
            return this._catalogId != null;
        }

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The name of the catalog database in which the table resides. For Hive compatibility,
        /// this name is entirely lowercase.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string DatabaseName
        {
            get { return this._databaseName; }
            set { this._databaseName = value; }
        }

        // Check to see if DatabaseName property is set
        internal bool IsSetDatabaseName()
        {
            return this._databaseName != null;
        }

        /// <summary>
        /// Gets and sets the property Force. 
        /// <para>
        /// A flag that can be set to true to ignore matching storage descriptor and subobject
        /// matching requirements.
        /// </para>
        /// </summary>
        public bool? Force
        {
            get { return this._force; }
            set { this._force = value; }
        }

        // Check to see if Force property is set
        internal bool IsSetForce()
        {
            return this._force.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The unique identifier for the table within the specified database that will be created
        /// in the Glue Data Catalog.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property SkipArchive. 
        /// <para>
        /// By default, <c>UpdateTable</c> always creates an archived version of the table before
        /// updating it. However, if <c>skipArchive</c> is set to true, <c>UpdateTable</c> does
        /// not create the archived version.
        /// </para>
        /// </summary>
        public bool? SkipArchive
        {
            get { return this._skipArchive; }
            set { this._skipArchive = value; }
        }

        // Check to see if SkipArchive property is set
        internal bool IsSetSkipArchive()
        {
            return this._skipArchive.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TableInput. 
        /// <para>
        /// An updated <c>TableInput</c> object to define the metadata table in the catalog.
        /// </para>
        /// </summary>
        public TableInput TableInput
        {
            get { return this._tableInput; }
            set { this._tableInput = value; }
        }

        // Check to see if TableInput property is set
        internal bool IsSetTableInput()
        {
            return this._tableInput != null;
        }

        /// <summary>
        /// Gets and sets the property TransactionId. 
        /// <para>
        /// The transaction ID at which to update the table contents. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string TransactionId
        {
            get { return this._transactionId; }
            set { this._transactionId = value; }
        }

        // Check to see if TransactionId property is set
        internal bool IsSetTransactionId()
        {
            return this._transactionId != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateOpenTableFormatInput.
        /// </summary>
        public UpdateOpenTableFormatInput UpdateOpenTableFormatInput
        {
            get { return this._updateOpenTableFormatInput; }
            set { this._updateOpenTableFormatInput = value; }
        }

        // Check to see if UpdateOpenTableFormatInput property is set
        internal bool IsSetUpdateOpenTableFormatInput()
        {
            return this._updateOpenTableFormatInput != null;
        }

        /// <summary>
        /// Gets and sets the property VersionId. 
        /// <para>
        /// The version ID at which to update the table contents. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string VersionId
        {
            get { return this._versionId; }
            set { this._versionId = value; }
        }

        // Check to see if VersionId property is set
        internal bool IsSetVersionId()
        {
            return this._versionId != null;
        }

        /// <summary>
        /// Gets and sets the property ViewUpdateAction. 
        /// <para>
        /// The operation to be performed when updating the view.
        /// </para>
        /// </summary>
        public ViewUpdateAction ViewUpdateAction
        {
            get { return this._viewUpdateAction; }
            set { this._viewUpdateAction = value; }
        }

        // Check to see if ViewUpdateAction property is set
        internal bool IsSetViewUpdateAction()
        {
            return this._viewUpdateAction != null;
        }

    }
}