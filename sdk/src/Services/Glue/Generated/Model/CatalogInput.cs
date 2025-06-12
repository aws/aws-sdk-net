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
    /// A structure that describes catalog properties.
    /// </summary>
    public partial class CatalogInput
    {
        private AllowFullTableExternalDataAccessEnum _allowFullTableExternalDataAccess;
        private CatalogProperties _catalogProperties;
        private List<PrincipalPermissions> _createDatabaseDefaultPermissions = AWSConfigs.InitializeCollections ? new List<PrincipalPermissions>() : null;
        private List<PrincipalPermissions> _createTableDefaultPermissions = AWSConfigs.InitializeCollections ? new List<PrincipalPermissions>() : null;
        private string _description;
        private FederatedCatalog _federatedCatalog;
        private Dictionary<string, string> _parameters = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private TargetRedshiftCatalog _targetRedshiftCatalog;

        /// <summary>
        /// Gets and sets the property AllowFullTableExternalDataAccess. 
        /// <para>
        ///  Allows third-party engines to access data in Amazon S3 locations that are registered
        /// with Lake Formation. 
        /// </para>
        /// </summary>
        public AllowFullTableExternalDataAccessEnum AllowFullTableExternalDataAccess
        {
            get { return this._allowFullTableExternalDataAccess; }
            set { this._allowFullTableExternalDataAccess = value; }
        }

        // Check to see if AllowFullTableExternalDataAccess property is set
        internal bool IsSetAllowFullTableExternalDataAccess()
        {
            return this._allowFullTableExternalDataAccess != null;
        }

        /// <summary>
        /// Gets and sets the property CatalogProperties. 
        /// <para>
        /// A <c>CatalogProperties</c> object that specifies data lake access properties and other
        /// custom properties.
        /// </para>
        /// </summary>
        public CatalogProperties CatalogProperties
        {
            get { return this._catalogProperties; }
            set { this._catalogProperties = value; }
        }

        // Check to see if CatalogProperties property is set
        internal bool IsSetCatalogProperties()
        {
            return this._catalogProperties != null;
        }

        /// <summary>
        /// Gets and sets the property CreateDatabaseDefaultPermissions. 
        /// <para>
        /// An array of <c>PrincipalPermissions</c> objects. Creates a set of default permissions
        /// on the database(s) for principals. Used by Amazon Web Services Lake Formation. Typically
        /// should be explicitly set as an empty list.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PrincipalPermissions> CreateDatabaseDefaultPermissions
        {
            get { return this._createDatabaseDefaultPermissions; }
            set { this._createDatabaseDefaultPermissions = value; }
        }

        // Check to see if CreateDatabaseDefaultPermissions property is set
        internal bool IsSetCreateDatabaseDefaultPermissions()
        {
            return this._createDatabaseDefaultPermissions != null && (this._createDatabaseDefaultPermissions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CreateTableDefaultPermissions. 
        /// <para>
        /// An array of <c>PrincipalPermissions</c> objects. Creates a set of default permissions
        /// on the table(s) for principals. Used by Amazon Web Services Lake Formation. Typically
        /// should be explicitly set as an empty list.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PrincipalPermissions> CreateTableDefaultPermissions
        {
            get { return this._createTableDefaultPermissions; }
            set { this._createTableDefaultPermissions = value; }
        }

        // Check to see if CreateTableDefaultPermissions property is set
        internal bool IsSetCreateTableDefaultPermissions()
        {
            return this._createTableDefaultPermissions != null && (this._createTableDefaultPermissions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Description string, not more than 2048 bytes long, matching the URI address multi-line
        /// string pattern. A description of the catalog.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
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
        /// Gets and sets the property FederatedCatalog. 
        /// <para>
        /// A <c>FederatedCatalog</c> object. A <c>FederatedCatalog</c> structure that references
        /// an entity outside the Glue Data Catalog, for example a Redshift database.
        /// </para>
        /// </summary>
        public FederatedCatalog FederatedCatalog
        {
            get { return this._federatedCatalog; }
            set { this._federatedCatalog = value; }
        }

        // Check to see if FederatedCatalog property is set
        internal bool IsSetFederatedCatalog()
        {
            return this._federatedCatalog != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// A map array of key-value pairs that define the parameters and properties of the catalog.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && (this._parameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TargetRedshiftCatalog. 
        /// <para>
        /// A <c>TargetRedshiftCatalog</c> object that describes a target catalog for resource
        /// linking.
        /// </para>
        /// </summary>
        public TargetRedshiftCatalog TargetRedshiftCatalog
        {
            get { return this._targetRedshiftCatalog; }
            set { this._targetRedshiftCatalog = value; }
        }

        // Check to see if TargetRedshiftCatalog property is set
        internal bool IsSetTargetRedshiftCatalog()
        {
            return this._targetRedshiftCatalog != null;
        }

    }
}