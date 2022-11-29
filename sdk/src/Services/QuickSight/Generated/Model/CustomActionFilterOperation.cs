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
    /// The filter operation that filters data included in a visual or in an entire sheet.
    /// </summary>
    public partial class CustomActionFilterOperation
    {
        private FilterOperationSelectedFieldsConfiguration _selectedFieldsConfiguration;
        private FilterOperationTargetVisualsConfiguration _targetVisualsConfiguration;

        /// <summary>
        /// Gets and sets the property SelectedFieldsConfiguration. 
        /// <para>
        /// The configuration that chooses the fields to be filtered.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FilterOperationSelectedFieldsConfiguration SelectedFieldsConfiguration
        {
            get { return this._selectedFieldsConfiguration; }
            set { this._selectedFieldsConfiguration = value; }
        }

        // Check to see if SelectedFieldsConfiguration property is set
        internal bool IsSetSelectedFieldsConfiguration()
        {
            return this._selectedFieldsConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property TargetVisualsConfiguration. 
        /// <para>
        /// The configuration that chooses the target visuals to be filtered.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FilterOperationTargetVisualsConfiguration TargetVisualsConfiguration
        {
            get { return this._targetVisualsConfiguration; }
            set { this._targetVisualsConfiguration = value; }
        }

        // Check to see if TargetVisualsConfiguration property is set
        internal bool IsSetTargetVisualsConfiguration()
        {
            return this._targetVisualsConfiguration != null;
        }

    }
}