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
    /// The options for a table field.
    /// </summary>
    public partial class TableFieldOption
    {
        private string _customLabel;
        private string _fieldId;
        private TableFieldURLConfiguration _urlStyling;
        private Visibility _visibility;
        private string _width;

        /// <summary>
        /// Gets and sets the property CustomLabel. 
        /// <para>
        /// The custom label for a table field.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string CustomLabel
        {
            get { return this._customLabel; }
            set { this._customLabel = value; }
        }

        // Check to see if CustomLabel property is set
        internal bool IsSetCustomLabel()
        {
            return this._customLabel != null;
        }

        /// <summary>
        /// Gets and sets the property FieldId. 
        /// <para>
        /// The field ID for a table field.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string FieldId
        {
            get { return this._fieldId; }
            set { this._fieldId = value; }
        }

        // Check to see if FieldId property is set
        internal bool IsSetFieldId()
        {
            return this._fieldId != null;
        }

        /// <summary>
        /// Gets and sets the property URLStyling. 
        /// <para>
        /// The URL configuration for a table field.
        /// </para>
        /// </summary>
        public TableFieldURLConfiguration URLStyling
        {
            get { return this._urlStyling; }
            set { this._urlStyling = value; }
        }

        // Check to see if URLStyling property is set
        internal bool IsSetURLStyling()
        {
            return this._urlStyling != null;
        }

        /// <summary>
        /// Gets and sets the property Visibility. 
        /// <para>
        /// The visibility of a table field.
        /// </para>
        /// </summary>
        public Visibility Visibility
        {
            get { return this._visibility; }
            set { this._visibility = value; }
        }

        // Check to see if Visibility property is set
        internal bool IsSetVisibility()
        {
            return this._visibility != null;
        }

        /// <summary>
        /// Gets and sets the property Width. 
        /// <para>
        /// The width for a table field.
        /// </para>
        /// </summary>
        public string Width
        {
            get { return this._width; }
            set { this._width = value; }
        }

        // Check to see if Width property is set
        internal bool IsSetWidth()
        {
            return this._width != null;
        }

    }
}