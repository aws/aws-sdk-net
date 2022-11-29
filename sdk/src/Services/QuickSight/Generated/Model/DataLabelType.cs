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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The option that determines the data label type.
    /// 
    ///  
    /// <para>
    /// This is a union type structure. For this structure to be valid, only one of the attributes
    /// can be defined.
    /// </para>
    /// </summary>
    public partial class DataLabelType
    {
        private DataPathLabelType _dataPathLabelType;
        private FieldLabelType _fieldLabelType;
        private MaximumLabelType _maximumLabelType;
        private MinimumLabelType _minimumLabelType;
        private RangeEndsLabelType _rangeEndsLabelType;

        /// <summary>
        /// Gets and sets the property DataPathLabelType. 
        /// <para>
        /// The option that specifies individual data values for labels.
        /// </para>
        /// </summary>
        public DataPathLabelType DataPathLabelType
        {
            get { return this._dataPathLabelType; }
            set { this._dataPathLabelType = value; }
        }

        // Check to see if DataPathLabelType property is set
        internal bool IsSetDataPathLabelType()
        {
            return this._dataPathLabelType != null;
        }

        /// <summary>
        /// Gets and sets the property FieldLabelType. 
        /// <para>
        /// Determines the label configuration for the entire field.
        /// </para>
        /// </summary>
        public FieldLabelType FieldLabelType
        {
            get { return this._fieldLabelType; }
            set { this._fieldLabelType = value; }
        }

        // Check to see if FieldLabelType property is set
        internal bool IsSetFieldLabelType()
        {
            return this._fieldLabelType != null;
        }

        /// <summary>
        /// Gets and sets the property MaximumLabelType. 
        /// <para>
        /// Determines the label configuration for the maximum value in a visual.
        /// </para>
        /// </summary>
        public MaximumLabelType MaximumLabelType
        {
            get { return this._maximumLabelType; }
            set { this._maximumLabelType = value; }
        }

        // Check to see if MaximumLabelType property is set
        internal bool IsSetMaximumLabelType()
        {
            return this._maximumLabelType != null;
        }

        /// <summary>
        /// Gets and sets the property MinimumLabelType. 
        /// <para>
        /// Determines the label configuration for the minimum value in a visual.
        /// </para>
        /// </summary>
        public MinimumLabelType MinimumLabelType
        {
            get { return this._minimumLabelType; }
            set { this._minimumLabelType = value; }
        }

        // Check to see if MinimumLabelType property is set
        internal bool IsSetMinimumLabelType()
        {
            return this._minimumLabelType != null;
        }

        /// <summary>
        /// Gets and sets the property RangeEndsLabelType. 
        /// <para>
        /// Determines the label configuration for range end value in a visual.
        /// </para>
        /// </summary>
        public RangeEndsLabelType RangeEndsLabelType
        {
            get { return this._rangeEndsLabelType; }
            set { this._rangeEndsLabelType = value; }
        }

        // Check to see if RangeEndsLabelType property is set
        internal bool IsSetRangeEndsLabelType()
        {
            return this._rangeEndsLabelType != null;
        }

    }
}