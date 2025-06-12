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
    /// Represents the equivalent of a Hive user-defined function (<c>UDF</c>) definition.
    /// </summary>
    public partial class UserDefinedFunction
    {
        private string _catalogId;
        private string _className;
        private DateTime? _createTime;
        private string _databaseName;
        private string _functionName;
        private string _ownerName;
        private PrincipalType _ownerType;
        private List<ResourceUri> _resourceUris = AWSConfigs.InitializeCollections ? new List<ResourceUri>() : null;

        /// <summary>
        /// Gets and sets the property CatalogId. 
        /// <para>
        /// The ID of the Data Catalog in which the function resides.
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
        /// Gets and sets the property ClassName. 
        /// <para>
        /// The Java class that contains the function code.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string ClassName
        {
            get { return this._className; }
            set { this._className = value; }
        }

        // Check to see if ClassName property is set
        internal bool IsSetClassName()
        {
            return this._className != null;
        }

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The time at which the function was created.
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
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The name of the catalog database that contains the function.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property FunctionName. 
        /// <para>
        /// The name of the function.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string FunctionName
        {
            get { return this._functionName; }
            set { this._functionName = value; }
        }

        // Check to see if FunctionName property is set
        internal bool IsSetFunctionName()
        {
            return this._functionName != null;
        }

        /// <summary>
        /// Gets and sets the property OwnerName. 
        /// <para>
        /// The owner of the function.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string OwnerName
        {
            get { return this._ownerName; }
            set { this._ownerName = value; }
        }

        // Check to see if OwnerName property is set
        internal bool IsSetOwnerName()
        {
            return this._ownerName != null;
        }

        /// <summary>
        /// Gets and sets the property OwnerType. 
        /// <para>
        /// The owner type.
        /// </para>
        /// </summary>
        public PrincipalType OwnerType
        {
            get { return this._ownerType; }
            set { this._ownerType = value; }
        }

        // Check to see if OwnerType property is set
        internal bool IsSetOwnerType()
        {
            return this._ownerType != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceUris. 
        /// <para>
        /// The resource URIs for the function.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public List<ResourceUri> ResourceUris
        {
            get { return this._resourceUris; }
            set { this._resourceUris = value; }
        }

        // Check to see if ResourceUris property is set
        internal bool IsSetResourceUris()
        {
            return this._resourceUris != null && (this._resourceUris.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}