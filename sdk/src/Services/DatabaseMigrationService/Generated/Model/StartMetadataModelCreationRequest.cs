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
    /// Queues the creation of a metadata model in the source metadata tree. If other requests
    /// created by <c>Start*</c> operations are already in the migration project's queue,
    /// the creation begins after they complete.
    /// 
    ///  <note> 
    /// <para>
    /// This operation supports only Microsoft SQL Server to Aurora PostgreSQL and Microsoft
    /// SQL Server to Amazon RDS for PostgreSQL conversion paths.
    /// </para>
    ///  </note> 
    /// <para>
    /// To check the status of the creation request, call <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_DescribeMetadataModelCreations.html">DescribeMetadataModelCreations</a>
    /// using the returned <c>RequestIdentifier</c> as a filter.
    /// </para>
    ///  
    /// <para>
    /// To cancel a queued or in-progress request, call <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_CancelMetadataModelCreation.html">CancelMetadataModelCreation</a>
    /// with the returned <c>RequestIdentifier</c>.
    /// </para>
    ///  <important> 
    /// <para>
    /// Calling <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_StartMetadataModelImport.html">StartMetadataModelImport</a>
    /// with <c>Refresh</c> deletes metadata models created by this operation.
    /// </para>
    ///  </important> 
    /// <para>
    /// After the creation completes successfully:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// To evaluate conversion complexity, call <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_StartMetadataModelAssessment.html">StartMetadataModelAssessment</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To convert to the target database format, call <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_StartMetadataModelConversion.html">StartMetadataModelConversion</a>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Required permissions:</b> <c>dms:StartMetadataModelCreation</c>. For more information,
    /// see <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsdatabasemigrationservice.html">Actions,
    /// resources, and condition keys for Database Migration Service</a>.
    /// </para>
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
        /// The name for the metadata model to use in subsequent operations.
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
        /// The properties of the metadata model.
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
        /// A JSON string that identifies the source schema for the metadata model. For the selection
        /// rule format and examples, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/sc-selection-rules.html">Selection
        /// rules in DMS Schema Conversion</a>.
        /// </para>
        ///  
        /// <para>
        /// Usage:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Accepts only source selection rules, where <c>server-name</c> in the object locator
        /// matches the source data provider.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Supports only <c>explicit</c> rule actions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Exactly one rule is allowed.
        /// </para>
        ///  </li> </ul>
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