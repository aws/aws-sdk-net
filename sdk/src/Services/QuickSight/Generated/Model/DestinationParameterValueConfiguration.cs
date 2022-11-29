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
    /// The configuration of destination parameter values.
    /// 
    ///  
    /// <para>
    /// This is a union type structure. For this structure to be valid, only one of the attributes
    /// can be defined.
    /// </para>
    /// </summary>
    public partial class DestinationParameterValueConfiguration
    {
        private CustomValuesConfiguration _customValuesConfiguration;
        private SelectAllValueOptions _selectAllValueOptions;
        private string _sourceField;
        private string _sourceParameterName;

        /// <summary>
        /// Gets and sets the property CustomValuesConfiguration. 
        /// <para>
        /// The configuration of custom values for destination parameter in <code>DestinationParameterValueConfiguration</code>.
        /// </para>
        /// </summary>
        public CustomValuesConfiguration CustomValuesConfiguration
        {
            get { return this._customValuesConfiguration; }
            set { this._customValuesConfiguration = value; }
        }

        // Check to see if CustomValuesConfiguration property is set
        internal bool IsSetCustomValuesConfiguration()
        {
            return this._customValuesConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property SelectAllValueOptions. 
        /// <para>
        /// The configuration that selects all options.
        /// </para>
        /// </summary>
        public SelectAllValueOptions SelectAllValueOptions
        {
            get { return this._selectAllValueOptions; }
            set { this._selectAllValueOptions = value; }
        }

        // Check to see if SelectAllValueOptions property is set
        internal bool IsSetSelectAllValueOptions()
        {
            return this._selectAllValueOptions != null;
        }

        /// <summary>
        /// Gets and sets the property SourceField. 
        /// <para>
        /// The source field ID of the destination parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string SourceField
        {
            get { return this._sourceField; }
            set { this._sourceField = value; }
        }

        // Check to see if SourceField property is set
        internal bool IsSetSourceField()
        {
            return this._sourceField != null;
        }

        /// <summary>
        /// Gets and sets the property SourceParameterName. 
        /// <para>
        /// The source parameter name of the destination parameter.
        /// </para>
        /// </summary>
        public string SourceParameterName
        {
            get { return this._sourceParameterName; }
            set { this._sourceParameterName = value; }
        }

        // Check to see if SourceParameterName property is set
        internal bool IsSetSourceParameterName()
        {
            return this._sourceParameterName != null;
        }

    }
}