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

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes a database image, or blueprint. A blueprint describes the major engine version
    /// of a database.
    /// </summary>
    public partial class RelationalDatabaseBlueprint
    {
        /// <summary>
        /// Gets and sets the property BlueprintId. 
        /// <para>
        /// The ID for the database blueprint.
        /// </para>
        /// </summary>
        public string BlueprintId { get; set; }

        /// <summary>
        /// Checks to see if the BlueprintId property is set.
        /// </summary>
        internal bool IsSetBlueprintId() => this.BlueprintId != null;

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// The database software of the database blueprint (for example, <c>MySQL</c>).
        /// </para>
        /// </summary>
        public RelationalDatabaseEngine Engine { get; set; }

        /// <summary>
        /// Checks to see if the Engine property is set.
        /// </summary>
        internal bool IsSetEngine() => this.Engine != null;

        /// <summary>
        /// Gets and sets the property EngineDescription. 
        /// <para>
        /// The description of the database engine for the database blueprint.
        /// </para>
        /// </summary>
        public string EngineDescription { get; set; }

        /// <summary>
        /// Checks to see if the EngineDescription property is set.
        /// </summary>
        internal bool IsSetEngineDescription() => this.EngineDescription != null;

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The database engine version for the database blueprint (for example, <c>5.7.23</c>).
        /// </para>
        /// </summary>
        public string EngineVersion { get; set; }

        /// <summary>
        /// Checks to see if the EngineVersion property is set.
        /// </summary>
        internal bool IsSetEngineVersion() => this.EngineVersion != null;

        /// <summary>
        /// Gets and sets the property EngineVersionDescription. 
        /// <para>
        /// The description of the database engine version for the database blueprint.
        /// </para>
        /// </summary>
        public string EngineVersionDescription { get; set; }

        /// <summary>
        /// Checks to see if the EngineVersionDescription property is set.
        /// </summary>
        internal bool IsSetEngineVersionDescription() => this.EngineVersionDescription != null;

        /// <summary>
        /// Gets and sets the property IsEngineDefault. 
        /// <para>
        /// A Boolean value indicating whether the engine version is the default for the database
        /// blueprint.
        /// </para>
        /// </summary>
        public bool? IsEngineDefault { get; set; }

        /// <summary>
        /// Checks to see if the IsEngineDefault property is set.
        /// </summary>
        internal bool IsSetIsEngineDefault() => this.IsEngineDefault.HasValue;
    }
}
