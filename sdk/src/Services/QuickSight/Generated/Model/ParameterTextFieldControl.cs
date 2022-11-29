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
    /// A control to display a text box that is used to enter a single entry.
    /// </summary>
    public partial class ParameterTextFieldControl
    {
        private TextFieldControlDisplayOptions _displayOptions;
        private string _parameterControlId;
        private string _sourceParameterName;
        private string _title;

        /// <summary>
        /// Gets and sets the property DisplayOptions. 
        /// <para>
        /// The display options of a control.
        /// </para>
        /// </summary>
        public TextFieldControlDisplayOptions DisplayOptions
        {
            get { return this._displayOptions; }
            set { this._displayOptions = value; }
        }

        // Check to see if DisplayOptions property is set
        internal bool IsSetDisplayOptions()
        {
            return this._displayOptions != null;
        }

        /// <summary>
        /// Gets and sets the property ParameterControlId. 
        /// <para>
        /// The ID of the <code>ParameterTextFieldControl</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string ParameterControlId
        {
            get { return this._parameterControlId; }
            set { this._parameterControlId = value; }
        }

        // Check to see if ParameterControlId property is set
        internal bool IsSetParameterControlId()
        {
            return this._parameterControlId != null;
        }

        /// <summary>
        /// Gets and sets the property SourceParameterName. 
        /// <para>
        /// The source parameter name of the <code>ParameterTextFieldControl</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
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

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the <code>ParameterTextFieldControl</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

    }
}