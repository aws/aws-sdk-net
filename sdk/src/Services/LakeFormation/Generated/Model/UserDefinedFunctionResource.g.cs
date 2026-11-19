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

namespace Amazon.LakeFormation.Model
{
    /// <summary>
    /// Identifies a user-defined function, or all user-defined functions in a database, as
    /// a resource that you can grant permissions on. You can grant permissions only on functions
    /// whose <c>GovernanceMode</c> is <c>LAKE_FORMATION</c>.
    /// </summary>
    public partial class UserDefinedFunctionResource
    {
        /// <summary>
        /// Gets and sets the property CatalogId. 
        /// <para>
        /// The ID of the Data Catalog. By default, it's your account ID.
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
        /// The name of the database that contains the function.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseName property is set.
        /// </summary>
        internal bool IsSetDatabaseName() => this.DatabaseName != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the function.
        /// </para>
        ///  
        /// <para>
        /// Exactly one of <c>UserDefinedFunctionResource$Name</c> or <c>UserDefinedFunctionResource$UserDefinedFunctionWildcard</c>
        /// is required.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property UserDefinedFunctionWildcard. 
        /// <para>
        /// A wildcard object representing every user-defined function in the database, including
        /// functions created after the grant.
        /// </para>
        ///  
        /// <para>
        /// Exactly one of <c>UserDefinedFunctionResource$Name</c> or <c>UserDefinedFunctionResource$UserDefinedFunctionWildcard</c>
        /// is required.
        /// </para>
        /// </summary>
        public UserDefinedFunctionWildcard UserDefinedFunctionWildcard { get; set; }

        /// <summary>
        /// Checks to see if the UserDefinedFunctionWildcard property is set.
        /// </summary>
        internal bool IsSetUserDefinedFunctionWildcard() => this.UserDefinedFunctionWildcard != null;
    }
}
