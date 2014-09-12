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
 * Do not modify this file. This file is generated from the cloudsearch-2011-02-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudSearch_2011_02_01.Model
{
    /// <summary>
    /// Identifies the source data for an index field. An optional data transformation can
    /// be applied to the source data when populating the index field. By default, the value
    /// of the source attribute is copied to the index field.
    /// </summary>
    public partial class SourceAttribute
    {
        private SourceData _sourceDataCopy;
        private SourceDataFunction _sourceDataFunction;
        private SourceDataMap _sourceDataMap;
        private SourceDataTrimTitle _sourceDataTrimTitle;

        /// <summary>
        /// Gets and sets the property SourceDataCopy. 
        /// <para>
        /// Copies data from a source document attribute to an <code>IndexField</code>.
        /// </para>
        /// </summary>
        public SourceData SourceDataCopy
        {
            get { return this._sourceDataCopy; }
            set { this._sourceDataCopy = value; }
        }

        // Check to see if SourceDataCopy property is set
        internal bool IsSetSourceDataCopy()
        {
            return this._sourceDataCopy != null;
        }

        /// <summary>
        /// Gets and sets the property SourceDataFunction. 
        /// <para>
        /// Identifies the transformation to apply when copying data from a source attribute.
        /// </para>
        /// </summary>
        public SourceDataFunction SourceDataFunction
        {
            get { return this._sourceDataFunction; }
            set { this._sourceDataFunction = value; }
        }

        // Check to see if SourceDataFunction property is set
        internal bool IsSetSourceDataFunction()
        {
            return this._sourceDataFunction != null;
        }

        /// <summary>
        /// Gets and sets the property SourceDataMap. 
        /// <para>
        /// Maps source document attribute values to new values when populating the <code>IndexField</code>.
        /// </para>
        /// </summary>
        public SourceDataMap SourceDataMap
        {
            get { return this._sourceDataMap; }
            set { this._sourceDataMap = value; }
        }

        // Check to see if SourceDataMap property is set
        internal bool IsSetSourceDataMap()
        {
            return this._sourceDataMap != null;
        }

        /// <summary>
        /// Gets and sets the property SourceDataTrimTitle. 
        /// <para>
        /// Trims common title words from a source document attribute when populating an <code>IndexField</code>.
        /// This can be used to create an <code>IndexField</code> you can use for sorting.
        /// </para>
        /// </summary>
        public SourceDataTrimTitle SourceDataTrimTitle
        {
            get { return this._sourceDataTrimTitle; }
            set { this._sourceDataTrimTitle = value; }
        }

        // Check to see if SourceDataTrimTitle property is set
        internal bool IsSetSourceDataTrimTitle()
        {
            return this._sourceDataTrimTitle != null;
        }

    }
}