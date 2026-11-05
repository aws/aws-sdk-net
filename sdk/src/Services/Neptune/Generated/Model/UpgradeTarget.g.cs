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

namespace Amazon.Neptune.Model
{
    /// <summary>
    /// The version of the database engine that a DB instance can be upgraded to.
    /// </summary>
    public partial class UpgradeTarget
    {
        /// <summary>
        /// Gets and sets the property AutoUpgrade. 
        /// <para>
        /// A value that indicates whether the target version is applied to any source DB instances
        /// that have AutoMinorVersionUpgrade set to true.
        /// </para>
        /// </summary>
        public bool? AutoUpgrade { get; set; }

        /// <summary>
        /// Checks to see if the AutoUpgrade property is set.
        /// </summary>
        internal bool IsSetAutoUpgrade() => this.AutoUpgrade.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The version of the database engine that a DB instance can be upgraded to.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// The name of the upgrade target database engine.
        /// </para>
        /// </summary>
        public string Engine { get; set; }

        /// <summary>
        /// Checks to see if the Engine property is set.
        /// </summary>
        internal bool IsSetEngine() => this.Engine != null;

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The version number of the upgrade target database engine.
        /// </para>
        /// </summary>
        public string EngineVersion { get; set; }

        /// <summary>
        /// Checks to see if the EngineVersion property is set.
        /// </summary>
        internal bool IsSetEngineVersion() => this.EngineVersion != null;

        /// <summary>
        /// Gets and sets the property IsMajorVersionUpgrade. 
        /// <para>
        /// A value that indicates whether a database engine is upgraded to a major version.
        /// </para>
        /// </summary>
        public bool? IsMajorVersionUpgrade { get; set; }

        /// <summary>
        /// Checks to see if the IsMajorVersionUpgrade property is set.
        /// </summary>
        internal bool IsSetIsMajorVersionUpgrade() => this.IsMajorVersionUpgrade.HasValue;

        /// <summary>
        /// Gets and sets the property SupportsGlobalDatabases. 
        /// <para>
        /// A value that indicates whether you can use Neptune global databases with the target
        /// engine version.
        /// </para>
        /// </summary>
        public bool? SupportsGlobalDatabases { get; set; }

        /// <summary>
        /// Checks to see if the SupportsGlobalDatabases property is set.
        /// </summary>
        internal bool IsSetSupportsGlobalDatabases() => this.SupportsGlobalDatabases.HasValue;
    }
}
