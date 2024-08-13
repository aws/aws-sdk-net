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
    /// A structure containing migration status information.
    /// </summary>
    public partial class CatalogImportStatus
    {
        private bool? _importCompleted;
        private string _importedBy;
        private DateTime? _importTime;

        /// <summary>
        /// Gets and sets the property ImportCompleted. 
        /// <para>
        ///  <c>True</c> if the migration has completed, or <c>False</c> otherwise.
        /// </para>
        /// </summary>
        public bool? ImportCompleted
        {
            get { return this._importCompleted; }
            set { this._importCompleted = value; }
        }

        // Check to see if ImportCompleted property is set
        internal bool IsSetImportCompleted()
        {
            return this._importCompleted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ImportedBy. 
        /// <para>
        /// The name of the person who initiated the migration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string ImportedBy
        {
            get { return this._importedBy; }
            set { this._importedBy = value; }
        }

        // Check to see if ImportedBy property is set
        internal bool IsSetImportedBy()
        {
            return this._importedBy != null;
        }

        /// <summary>
        /// Gets and sets the property ImportTime. 
        /// <para>
        /// The time that the migration was started.
        /// </para>
        /// </summary>
        public DateTime? ImportTime
        {
            get { return this._importTime; }
            set { this._importTime = value; }
        }

        // Check to see if ImportTime property is set
        internal bool IsSetImportTime()
        {
            return this._importTime.HasValue; 
        }

    }
}