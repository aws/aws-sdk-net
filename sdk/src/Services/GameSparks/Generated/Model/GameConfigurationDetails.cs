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
 * Do not modify this file. This file is generated from the gamesparks-2021-08-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameSparks.Model
{
    /// <summary>
    /// Details about the game configuration.
    /// 
    ///  
    /// <para>
    ///  The game configuration is organized into named sections, where the schema of each
    /// section is defined by an extension. The schema for these sections can be retrieved
    /// using the <code>GetExtensionVersion</code> operation. 
    /// </para>
    /// </summary>
    public partial class GameConfigurationDetails
    {
        private DateTime? _created;
        private DateTime? _lastUpdated;
        private Dictionary<string, Section> _sections = new Dictionary<string, Section>();

        /// <summary>
        /// Gets and sets the property Created. 
        /// <para>
        /// The date when the game was created.
        /// </para>
        /// </summary>
        public DateTime Created
        {
            get { return this._created.GetValueOrDefault(); }
            set { this._created = value; }
        }

        // Check to see if Created property is set
        internal bool IsSetCreated()
        {
            return this._created.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdated. 
        /// <para>
        /// The date when the game was last modified.
        /// </para>
        /// </summary>
        public DateTime LastUpdated
        {
            get { return this._lastUpdated.GetValueOrDefault(); }
            set { this._lastUpdated = value; }
        }

        // Check to see if LastUpdated property is set
        internal bool IsSetLastUpdated()
        {
            return this._lastUpdated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Sections. 
        /// <para>
        /// Configuration data, organized by section name.
        /// </para>
        /// </summary>
        public Dictionary<string, Section> Sections
        {
            get { return this._sections; }
            set { this._sections = value; }
        }

        // Check to see if Sections property is set
        internal bool IsSetSections()
        {
            return this._sections != null && this._sections.Count > 0; 
        }

    }
}