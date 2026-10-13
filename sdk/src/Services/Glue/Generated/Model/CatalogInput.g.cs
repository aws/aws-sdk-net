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
    /// A structure that describes catalog properties.
    /// </summary>
    public partial class CatalogInput
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
        /// Gets and sets the property CatalogProperties. 
        /// <para>
        /// A <c>CatalogProperties</c> object that specifies data lake access properties and other
        /// custom properties.
        /// </para>
        /// </summary>
        public CatalogProperties CatalogProperties { get; set; }

        /// <summary>
        /// Checks to see if the CatalogProperties property is set.
        /// </summary>
        internal bool IsSetCatalogProperties() => this.CatalogProperties != null;

        /// <summary>
        /// Gets and sets the property CreateDatabaseDefaultPermissions. 
        /// <para>
        /// An array of <c>PrincipalPermissions</c> objects. Creates a set of default permissions
        /// on the database(s) for principals. Used by Amazon Web Services Lake Formation. Typically
        /// should be explicitly set as an empty list.
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
        /// on the table(s) for principals. Used by Amazon Web Services Lake Formation. Typically
        /// should be explicitly set as an empty list.
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
        /// A <c>FederatedCatalog</c> object. A <c>FederatedCatalog</c> structure that references
        /// an entity outside the Glue Data Catalog, for example a Redshift database.
        /// </para>
        /// </summary>
        public FederatedCatalog FederatedCatalog { get; set; }

        /// <summary>
        /// Checks to see if the FederatedCatalog property is set.
        /// </summary>
        internal bool IsSetFederatedCatalog() => this.FederatedCatalog != null;

        /// <summary>
        /// Gets and sets the property OverwriteChildResourcePermissionsWithDefault. 
        /// <para>
        ///  Overwrites existing Amazon Web Services Lake Formation permissions with <c>CatalogInput$CreateTableDefaultPermissions</c>
        /// and <c>CatalogInput$CreateDatabaseDefaultPermissions</c> for all child resources.
        /// 
        /// </para>
        /// </summary>
        public OverwriteChildResourcePermissionsWithDefaultEnum OverwriteChildResourcePermissionsWithDefault { get; set; }

        /// <summary>
        /// Checks to see if the OverwriteChildResourcePermissionsWithDefault property is set.
        /// </summary>
        internal bool IsSetOverwriteChildResourcePermissionsWithDefault() => this.OverwriteChildResourcePermissionsWithDefault != null;

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// A map array of key-value pairs that define the parameters and properties of the catalog.
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
        /// Gets and sets the property TargetRedshiftCatalog. 
        /// <para>
        /// A <c>TargetRedshiftCatalog</c> object that describes a target catalog for resource
        /// linking.
        /// </para>
        /// </summary>
        public TargetRedshiftCatalog TargetRedshiftCatalog { get; set; }

        /// <summary>
        /// Checks to see if the TargetRedshiftCatalog property is set.
        /// </summary>
        internal bool IsSetTargetRedshiftCatalog() => this.TargetRedshiftCatalog != null;
    }
}
