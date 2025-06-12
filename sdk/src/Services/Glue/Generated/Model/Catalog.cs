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
    /// The catalog object represents a logical grouping of databases in the Glue Data Catalog
    /// or a federated source. You can now create a Redshift-federated catalog or a catalog
    /// containing resource links to Redshift databases in another account or region.
    /// </summary>
    public partial class Catalog
    {
        private AllowFullTableExternalDataAccessEnum _allowFullTableExternalDataAccess;
        private string _catalogId;
        private CatalogPropertiesOutput _catalogProperties;
        private List<PrincipalPermissions> _createDatabaseDefaultPermissions = AWSConfigs.InitializeCollections ? new List<PrincipalPermissions>() : null;
        private List<PrincipalPermissions> _createTableDefaultPermissions = AWSConfigs.InitializeCollections ? new List<PrincipalPermissions>() : null;
        private DateTime? _createTime;
        private string _description;
        private FederatedCatalog _federatedCatalog;
        private string _name;
        private Dictionary<string, string> _parameters = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _resourceArn;
        private TargetRedshiftCatalog _targetRedshiftCatalog;
        private DateTime? _updateTime;

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
        /// Gets and sets the property CatalogId. 
        /// <para>
        /// The ID of the catalog. To grant access to the default catalog, this field should not
        /// be provided.
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
        /// Gets and sets the property CatalogProperties. 
        /// <para>
        /// A <c>CatalogProperties</c> object that specifies data lake access properties and other
        /// custom properties.
        /// </para>
        /// </summary>
        public CatalogPropertiesOutput CatalogProperties
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
        /// on the database(s) for principals. Used by Amazon Web Services Lake Formation. Not
        /// used in the normal course of Glue operations.
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
        /// on the table(s) for principals. Used by Amazon Web Services Lake Formation. Not used
        /// in the normal course of Glue operations.
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
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The time at which the catalog was created.
        /// </para>
        /// </summary>
        public DateTime? CreateTime
        {
            get { return this._createTime; }
            set { this._createTime = value; }
        }

        // Check to see if CreateTime property is set
        internal bool IsSetCreateTime()
        {
            return this._createTime.HasValue; 
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
        /// A <c>FederatedCatalog</c> object that points to an entity outside the Glue Data Catalog.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the catalog. Cannot be the same as the account ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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
        ///  A map array of key-value pairs that define parameters and properties of the catalog.
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
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) assigned to the catalog resource.
        /// </para>
        /// </summary>
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property TargetRedshiftCatalog. 
        /// <para>
        /// A <c>TargetRedshiftCatalog</c> object that describes a target catalog for database
        /// resource linking.
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

        /// <summary>
        /// Gets and sets the property UpdateTime. 
        /// <para>
        /// The time at which the catalog was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdateTime
        {
            get { return this._updateTime; }
            set { this._updateTime = value; }
        }

        // Check to see if UpdateTime property is set
        internal bool IsSetUpdateTime()
        {
            return this._updateTime.HasValue; 
        }

    }
}