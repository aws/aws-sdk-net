/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.CloudSearch.Model
{
    /// <summary>
    /// <para>Identifies the source data for an index field. An optional data transformation can be applied to the source data when populating the
    /// index field. By default, the value of the source attribute is copied to the index field.</para>
    /// </summary>
    public class SourceAttribute
    {
        
        private SourceDataFunction sourceDataFunction;
        private SourceData sourceDataCopy;
        private SourceDataTrimTitle sourceDataTrimTitle;
        private SourceDataMap sourceDataMap;


        /// <summary>
        /// Identifies the transformation to apply when copying data from a source attribute.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>Copy, TrimTitle, Map</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public SourceDataFunction SourceDataFunction
        {
            get { return this.sourceDataFunction; }
            set { this.sourceDataFunction = value; }
        }

        // Check to see if SourceDataFunction property is set
        internal bool IsSetSourceDataFunction()
        {
            return this.sourceDataFunction != null;
        }

        /// <summary>
        /// Copies data from a source document attribute to an <c>IndexField</c>.
        ///  
        /// </summary>
        public SourceData SourceDataCopy
        {
            get { return this.sourceDataCopy; }
            set { this.sourceDataCopy = value; }
        }

        // Check to see if SourceDataCopy property is set
        internal bool IsSetSourceDataCopy()
        {
            return this.sourceDataCopy != null;
        }

        /// <summary>
        /// Trims common title words from a source document attribute when populating an <c>IndexField</c>. This can be used to create an
        /// <c>IndexField</c> you can use for sorting.
        ///  
        /// </summary>
        public SourceDataTrimTitle SourceDataTrimTitle
        {
            get { return this.sourceDataTrimTitle; }
            set { this.sourceDataTrimTitle = value; }
        }

        // Check to see if SourceDataTrimTitle property is set
        internal bool IsSetSourceDataTrimTitle()
        {
            return this.sourceDataTrimTitle != null;
        }

        /// <summary>
        /// Maps source document attribute values to new values when populating the <c>IndexField</c>.
        ///  
        /// </summary>
        public SourceDataMap SourceDataMap
        {
            get { return this.sourceDataMap; }
            set { this.sourceDataMap = value; }
        }

        // Check to see if SourceDataMap property is set
        internal bool IsSetSourceDataMap()
        {
            return this.sourceDataMap != null;
        }
    }
}
