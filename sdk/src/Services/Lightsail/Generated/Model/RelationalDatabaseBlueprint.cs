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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
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
        private string _blueprintId;
        private RelationalDatabaseEngine _engine;
        private string _engineDescription;
        private string _engineVersion;
        private string _engineVersionDescription;
        private bool? _isEngineDefault;

        /// <summary>
        /// Gets and sets the property BlueprintId. 
        /// <para>
        /// The ID for the database blueprint.
        /// </para>
        /// </summary>
        public string BlueprintId
        {
            get { return this._blueprintId; }
            set { this._blueprintId = value; }
        }

        // Check to see if BlueprintId property is set
        internal bool IsSetBlueprintId()
        {
            return this._blueprintId != null;
        }

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// The database software of the database blueprint (for example, <c>MySQL</c>).
        /// </para>
        /// </summary>
        public RelationalDatabaseEngine Engine
        {
            get { return this._engine; }
            set { this._engine = value; }
        }

        // Check to see if Engine property is set
        internal bool IsSetEngine()
        {
            return this._engine != null;
        }

        /// <summary>
        /// Gets and sets the property EngineDescription. 
        /// <para>
        /// The description of the database engine for the database blueprint.
        /// </para>
        /// </summary>
        public string EngineDescription
        {
            get { return this._engineDescription; }
            set { this._engineDescription = value; }
        }

        // Check to see if EngineDescription property is set
        internal bool IsSetEngineDescription()
        {
            return this._engineDescription != null;
        }

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The database engine version for the database blueprint (for example, <c>5.7.23</c>).
        /// </para>
        /// </summary>
        public string EngineVersion
        {
            get { return this._engineVersion; }
            set { this._engineVersion = value; }
        }

        // Check to see if EngineVersion property is set
        internal bool IsSetEngineVersion()
        {
            return this._engineVersion != null;
        }

        /// <summary>
        /// Gets and sets the property EngineVersionDescription. 
        /// <para>
        /// The description of the database engine version for the database blueprint.
        /// </para>
        /// </summary>
        public string EngineVersionDescription
        {
            get { return this._engineVersionDescription; }
            set { this._engineVersionDescription = value; }
        }

        // Check to see if EngineVersionDescription property is set
        internal bool IsSetEngineVersionDescription()
        {
            return this._engineVersionDescription != null;
        }

        /// <summary>
        /// Gets and sets the property IsEngineDefault. 
        /// <para>
        /// A Boolean value indicating whether the engine version is the default for the database
        /// blueprint.
        /// </para>
        /// </summary>
        public bool? IsEngineDefault
        {
            get { return this._isEngineDefault; }
            set { this._isEngineDefault = value; }
        }

        // Check to see if IsEngineDefault property is set
        internal bool IsSetIsEngineDefault()
        {
            return this._isEngineDefault.HasValue; 
        }

    }
}