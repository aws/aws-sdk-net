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
    /// The catalog object represents a logical grouping of databases in the Glue Data Catalog
    /// or a federated source. You can now create a Redshift-federated catalog or a catalog
    /// containing resource links to Redshift databases in another account or region.
    /// </summary>
    public partial class Catalog
    {
        /// <summary>
        /// Gets and sets the property AllowFullTableExternalDataAccess. 
        /// <para>
        ///  Allows third-party engines to access data in Amazon S3 locations that are registered
        /// with Lake Formation. 
        /// </para>
        /// </summary>
        public AllowFullTableExternalDataAccessEnum AllowFullTableExternalDataAccess { get; set; }

        /// <summary>
        /// Checks to see if the AllowFullTableExternalDataAccess property is set.
        /// </summary>
        internal bool IsSetAllowFullTableExternalDataAccess() => this.AllowFullTableExternalDataAccess != null;

        /// <summary>
        /// Gets and sets the property CatalogId. 
        /// <para>
        /// The ID of the catalog. To grant access to the default catalog, this field should not
        /// be provided.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string CatalogId { get; set; }

        /// <summary>
        /// Checks to see if the CatalogId property is set.
        /// </summary>
        internal bool IsSetCatalogId() => this.CatalogId != null;

        /// <summary>
        /// Gets and sets the property CatalogProperties. 
        /// <para>
        /// A <c>CatalogProperties</c> object that specifies data lake access properties and other
        /// custom properties.
        /// </para>
        /// </summary>
        public CatalogPropertiesOutput CatalogProperties { get; set; }

        /// <summary>
        /// Checks to see if the CatalogProperties property is set.
        /// </summary>
        internal bool IsSetCatalogProperties() => this.CatalogProperties != null;

        /// <summary>
        /// Gets and sets the property CreateDatabaseDefaultPermissions. 
        /// <para>
        /// An array of <c>PrincipalPermissions</c> objects. Creates a set of default permissions
        /// on the database(s) for principals. Used by Amazon Web Services Lake Formation. Not
        /// used in the normal course of Glue operations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PrincipalPermissions> CreateDatabaseDefaultPermissions { get; set; } = AWSConfigs.InitializeCollections ? new List<PrincipalPermissions>() : null;

        /// <summary>
        /// Checks to see if the CreateDatabaseDefaultPermissions property is set.
        /// </summary>
        internal bool IsSetCreateDatabaseDefaultPermissions() => this.CreateDatabaseDefaultPermissions != null && (this.CreateDatabaseDefaultPermissions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CreateTableDefaultPermissions. 
        /// <para>
        /// An array of <c>PrincipalPermissions</c> objects. Creates a set of default permissions
        /// on the table(s) for principals. Used by Amazon Web Services Lake Formation. Not used
        /// in the normal course of Glue operations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PrincipalPermissions> CreateTableDefaultPermissions { get; set; } = AWSConfigs.InitializeCollections ? new List<PrincipalPermissions>() : null;

        /// <summary>
        /// Checks to see if the CreateTableDefaultPermissions property is set.
        /// </summary>
        internal bool IsSetCreateTableDefaultPermissions() => this.CreateTableDefaultPermissions != null && (this.CreateTableDefaultPermissions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The time at which the catalog was created.
        /// </para>
        /// </summary>
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreateTime property is set.
        /// </summary>
        internal bool IsSetCreateTime() => this.CreateTime.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Description string, not more than 2048 bytes long, matching the URI address multi-line
        /// string pattern. A description of the catalog.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property FederatedCatalog. 
        /// <para>
        /// A <c>FederatedCatalog</c> object that points to an entity outside the Glue Data Catalog.
        /// </para>
        /// </summary>
        public FederatedCatalog FederatedCatalog { get; set; }

        /// <summary>
        /// Checks to see if the FederatedCatalog property is set.
        /// </summary>
        internal bool IsSetFederatedCatalog() => this.FederatedCatalog != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the catalog. Cannot be the same as the account ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        ///  A map array of key-value pairs that define parameters and properties of the catalog.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Parameters { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Parameters property is set.
        /// </summary>
        internal bool IsSetParameters() => this.Parameters != null && (this.Parameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) assigned to the catalog resource.
        /// </para>
        /// </summary>
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;

        /// <summary>
        /// Gets and sets the property TargetRedshiftCatalog. 
        /// <para>
        /// A <c>TargetRedshiftCatalog</c> object that describes a target catalog for database
        /// resource linking.
        /// </para>
        /// </summary>
        public TargetRedshiftCatalog TargetRedshiftCatalog { get; set; }

        /// <summary>
        /// Checks to see if the TargetRedshiftCatalog property is set.
        /// </summary>
        internal bool IsSetTargetRedshiftCatalog() => this.TargetRedshiftCatalog != null;

        /// <summary>
        /// Gets and sets the property UpdateTime. 
        /// <para>
        /// The time at which the catalog was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Checks to see if the UpdateTime property is set.
        /// </summary>
        internal bool IsSetUpdateTime() => this.UpdateTime.HasValue;
    }
}
