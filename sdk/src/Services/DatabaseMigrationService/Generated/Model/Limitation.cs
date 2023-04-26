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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

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
        private string _databaseId;
        private string _description;
        private string _engineName;
        private string _impact;
        private string _name;
        private string _type;

        /// <summary>
        /// Gets and sets the property DatabaseId. 
        /// <para>
        /// The identifier of the source database.
        /// </para>
        /// </summary>
        public string DatabaseId
        {
            get { return this._databaseId; }
            set { this._databaseId = value; }
        }

        // Check to see if DatabaseId property is set
        internal bool IsSetDatabaseId()
        {
            return this._databaseId != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the limitation. Provides additional information about the limitation,
        /// and includes recommended actions that you can take to address or avoid this limitation.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property EngineName. 
        /// <para>
        /// The name of the target engine that Fleet Advisor should use in the target engine recommendation.
        /// Valid values include <code>"rds-aurora-mysql"</code>, <code>"rds-aurora-postgresql"</code>,
        /// <code>"rds-mysql"</code>, <code>"rds-oracle"</code>, <code>"rds-sql-server"</code>,
        /// and <code>"rds-postgresql"</code>.
        /// </para>
        /// </summary>
        public string EngineName
        {
            get { return this._engineName; }
            set { this._engineName = value; }
        }

        // Check to see if EngineName property is set
        internal bool IsSetEngineName()
        {
            return this._engineName != null;
        }

        /// <summary>
        /// Gets and sets the property Impact. 
        /// <para>
        /// The impact of the limitation. You can use this parameter to prioritize limitations
        /// that you want to address. Valid values include <code>"Blocker"</code>, <code>"High"</code>,
        /// <code>"Medium"</code>, and <code>"Low"</code>.
        /// </para>
        /// </summary>
        public string Impact
        {
            get { return this._impact; }
            set { this._impact = value; }
        }

        // Check to see if Impact property is set
        internal bool IsSetImpact()
        {
            return this._impact != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the limitation. Describes unsupported database features, migration action
        /// items, and other limitations.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the limitation, such as action required, upgrade required, and limited
        /// feature.
        /// </para>
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}