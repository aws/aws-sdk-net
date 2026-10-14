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
    /// Represents the equivalent of a Hive user-defined function (<c>UDF</c>) definition.
    /// </summary>
    public partial class UserDefinedFunction
    {
        /// <summary>
        /// Gets and sets the property CatalogId. 
        /// <para>
        /// The ID of the Data Catalog in which the function resides.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string CatalogId { get; set; }

        /// <summary>
        /// Checks to see if the CatalogId property is set.
        /// </summary>
        internal bool IsSetCatalogId() => this.CatalogId != null;

        /// <summary>
        /// Gets and sets the property ClassName. 
        /// <para>
        /// The Java class that contains the function code.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string ClassName { get; set; }

        /// <summary>
        /// Checks to see if the ClassName property is set.
        /// </summary>
        internal bool IsSetClassName() => this.ClassName != null;

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The time at which the function was created.
        /// </para>
        /// </summary>
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreateTime property is set.
        /// </summary>
        internal bool IsSetCreateTime() => this.CreateTime.HasValue;

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The name of the catalog database that contains the function.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseName property is set.
        /// </summary>
        internal bool IsSetDatabaseName() => this.DatabaseName != null;

        /// <summary>
        /// Gets and sets the property FunctionName. 
        /// <para>
        /// The name of the function.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string FunctionName { get; set; }

        /// <summary>
        /// Checks to see if the FunctionName property is set.
        /// </summary>
        internal bool IsSetFunctionName() => this.FunctionName != null;

        /// <summary>
        /// Gets and sets the property FunctionType. 
        /// <para>
        /// The type of the function.
        /// </para>
        /// </summary>
        public FunctionType FunctionType { get; set; }

        /// <summary>
        /// Checks to see if the FunctionType property is set.
        /// </summary>
        internal bool IsSetFunctionType() => this.FunctionType != null;

        /// <summary>
        /// Gets and sets the property OwnerName. 
        /// <para>
        /// The owner of the function.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string OwnerName { get; set; }

        /// <summary>
        /// Checks to see if the OwnerName property is set.
        /// </summary>
        internal bool IsSetOwnerName() => this.OwnerName != null;

        /// <summary>
        /// Gets and sets the property OwnerType. 
        /// <para>
        /// The owner type.
        /// </para>
        /// </summary>
        public PrincipalType OwnerType { get; set; }

        /// <summary>
        /// Checks to see if the OwnerType property is set.
        /// </summary>
        internal bool IsSetOwnerType() => this.OwnerType != null;

        /// <summary>
        /// Gets and sets the property ResourceUris. 
        /// <para>
        /// The resource URIs for the function.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public List<ResourceUri> ResourceUris { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourceUri>() : null;

        /// <summary>
        /// Checks to see if the ResourceUris property is set.
        /// </summary>
        internal bool IsSetResourceUris() => this.ResourceUris != null && (this.ResourceUris.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
