/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the GetPlan operation.
    /// Gets a Python script to perform a specified mapping.
    /// </summary>
    public partial class GetPlanRequest : AmazonGlueRequest
    {
        private Location _location;
        private List<MappingEntry> _mapping = new List<MappingEntry>();
        private List<CatalogEntry> _sinks = new List<CatalogEntry>();
        private CatalogEntry _source;

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// Parameters for the mapping.
        /// </para>
        /// </summary>
        public Location Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

        /// <summary>
        /// Gets and sets the property Mapping. 
        /// <para>
        /// The list of mappings from a source table to target tables.
        /// </para>
        /// </summary>
        public List<MappingEntry> Mapping
        {
            get { return this._mapping; }
            set { this._mapping = value; }
        }

        // Check to see if Mapping property is set
        internal bool IsSetMapping()
        {
            return this._mapping != null && this._mapping.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Sinks. 
        /// <para>
        /// The target tables.
        /// </para>
        /// </summary>
        public List<CatalogEntry> Sinks
        {
            get { return this._sinks; }
            set { this._sinks = value; }
        }

        // Check to see if Sinks property is set
        internal bool IsSetSinks()
        {
            return this._sinks != null && this._sinks.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The source table.
        /// </para>
        /// </summary>
        public CatalogEntry Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

    }
}