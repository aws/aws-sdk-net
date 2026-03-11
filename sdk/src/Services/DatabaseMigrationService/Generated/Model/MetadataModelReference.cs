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
    /// A reference to a metadata model, including its name and selection rules for location
    /// identification.
    /// </summary>
    public partial class MetadataModelReference
    {
        private string _metadataModelName;
        private string _selectionRules;

        /// <summary>
        /// Gets and sets the property MetadataModelName. 
        /// <para>
        /// The name of the metadata model.
        /// </para>
        /// </summary>
        public string MetadataModelName
        {
            get { return this._metadataModelName; }
            set { this._metadataModelName = value; }
        }

        // Check to see if MetadataModelName property is set
        internal bool IsSetMetadataModelName()
        {
            return this._metadataModelName != null;
        }

        /// <summary>
        /// Gets and sets the property SelectionRules. 
        /// <para>
        /// The JSON string representing metadata model location.
        /// </para>
        /// </summary>
        public string SelectionRules
        {
            get { return this._selectionRules; }
            set { this._selectionRules = value; }
        }

        // Check to see if SelectionRules property is set
        internal bool IsSetSelectionRules()
        {
            return this._selectionRules != null;
        }

    }
}