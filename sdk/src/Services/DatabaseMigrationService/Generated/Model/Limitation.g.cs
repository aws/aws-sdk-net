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

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Provides information about the limitations of target Amazon Web Services engines.
    /// 
    ///  
    /// <para>
    /// Your source database might include features that the target Amazon Web Services engine
    /// doesn't support. Fleet Advisor lists these features as limitations. You should consider
    /// these limitations during database migration. For each limitation, Fleet Advisor recommends
    /// an action that you can take to address or avoid this limitation.
    /// </para>
    /// </summary>
    public partial class Limitation
    {
        /// <summary>
        /// Gets and sets the property DatabaseId. 
        /// <para>
        /// The identifier of the source database.
        /// </para>
        /// </summary>
        public string DatabaseId { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseId property is set.
        /// </summary>
        internal bool IsSetDatabaseId() => this.DatabaseId != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the limitation. Provides additional information about the limitation,
        /// and includes recommended actions that you can take to address or avoid this limitation.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EngineName. 
        /// <para>
        /// The name of the target engine that Fleet Advisor should use in the target engine recommendation.
        /// Valid values include <c>"rds-aurora-mysql"</c>, <c>"rds-aurora-postgresql"</c>, <c>"rds-mysql"</c>,
        /// <c>"rds-oracle"</c>, <c>"rds-sql-server"</c>, and <c>"rds-postgresql"</c>.
        /// </para>
        /// </summary>
        public string EngineName { get; set; }

        /// <summary>
        /// Checks to see if the EngineName property is set.
        /// </summary>
        internal bool IsSetEngineName() => this.EngineName != null;

        /// <summary>
        /// Gets and sets the property Impact. 
        /// <para>
        /// The impact of the limitation. You can use this parameter to prioritize limitations
        /// that you want to address. Valid values include <c>"Blocker"</c>, <c>"High"</c>, <c>"Medium"</c>,
        /// and <c>"Low"</c>.
        /// </para>
        /// </summary>
        public string Impact { get; set; }

        /// <summary>
        /// Checks to see if the Impact property is set.
        /// </summary>
        internal bool IsSetImpact() => this.Impact != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the limitation. Describes unsupported database features, migration action
        /// items, and other limitations.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the limitation, such as action required, upgrade required, and limited
        /// feature.
        /// </para>
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
