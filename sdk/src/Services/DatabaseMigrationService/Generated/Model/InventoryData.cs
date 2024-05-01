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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Describes a Fleet Advisor collector inventory.
    /// </summary>
    public partial class InventoryData
    {
        private int? _numberOfDatabases;
        private int? _numberOfSchemas;

        /// <summary>
        /// Gets and sets the property NumberOfDatabases. 
        /// <para>
        /// The number of databases in the Fleet Advisor collector inventory.
        /// </para>
        /// </summary>
        public int? NumberOfDatabases
        {
            get { return this._numberOfDatabases; }
            set { this._numberOfDatabases = value; }
        }

        // Check to see if NumberOfDatabases property is set
        internal bool IsSetNumberOfDatabases()
        {
            return this._numberOfDatabases.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfSchemas. 
        /// <para>
        /// The number of schemas in the Fleet Advisor collector inventory.
        /// </para>
        /// </summary>
        public int? NumberOfSchemas
        {
            get { return this._numberOfSchemas; }
            set { this._numberOfSchemas = value; }
        }

        // Check to see if NumberOfSchemas property is set
        internal bool IsSetNumberOfSchemas()
        {
            return this._numberOfSchemas.HasValue; 
        }

    }
}