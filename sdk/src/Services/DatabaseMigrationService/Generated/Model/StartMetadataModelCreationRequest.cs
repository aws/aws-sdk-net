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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
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
namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Container for the parameters to the StartMetadataModelCreation operation.
    /// Creates source metadata model of the given type with the specified properties for
    /// schema conversion operations.
    /// 
    ///  <note> 
    /// <para>
    /// This action supports only these directions: from SQL Server to Aurora PostgreSQL,
    /// or from SQL Server to RDS for PostgreSQL.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class StartMetadataModelCreationRequest : AmazonDatabaseMigrationServiceRequest
    {
        private string _metadataModelName;
        private string _migrationProjectIdentifier;
        private MetadataModelProperties _properties;
        private string _selectionRules;

        /// <summary>
        /// Gets and sets the property MetadataModelName. 
        /// <para>
        /// The name of the metadata model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string MetadataModelName
        {
            get { return this._metadataModelName; }
            set { this._metadataModelName = value; }
        }

        // Check to see if MetadataModelName property is set
        internal bool IsSetMetadataModelName()
        {
            return this._metadataModelName != null;
        }

        /// <summary>
        /// Gets and sets the property MigrationProjectIdentifier. 
        /// <para>
        /// The migration project name or Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=255)]
        public string MigrationProjectIdentifier
        {
            get { return this._migrationProjectIdentifier; }
            set { this._migrationProjectIdentifier = value; }
        }

        // Check to see if MigrationProjectIdentifier property is set
        internal bool IsSetMigrationProjectIdentifier()
        {
            return this._migrationProjectIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Properties. 
        /// <para>
        /// The properties of metadata model in JSON format. This object is a Union. Only one
        /// member of this object can be specified or returned.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MetadataModelProperties Properties
        {
            get { return this._properties; }
            set { this._properties = value; }
        }

        // Check to see if Properties property is set
        internal bool IsSetProperties()
        {
            return this._properties != null;
        }

        /// <summary>
        /// Gets and sets the property SelectionRules. 
        /// <para>
        /// The JSON string that specifies the location where the metadata model will be created.
        /// Selection rules must specify a single schema. For more information, see Selection
        /// Rules in the DMS User Guide.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SelectionRules
        {
            get { return this._selectionRules; }
            set { this._selectionRules = value; }
        }

        // Check to see if SelectionRules property is set
        internal bool IsSetSelectionRules()
        {
            return this._selectionRules != null;
        }

    }
}