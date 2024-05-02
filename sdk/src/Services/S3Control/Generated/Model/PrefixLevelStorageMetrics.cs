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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
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
namespace Amazon.S3Control.Model
{
    /// <summary>
    /// A container for the prefix-level storage metrics for S3 Storage Lens.
    /// </summary>
    public partial class PrefixLevelStorageMetrics
    {
        private bool? _isEnabled;
        private SelectionCriteria _selectionCriteria;

        /// <summary>
        /// Gets and sets the property IsEnabled. 
        /// <para>
        /// A container for whether prefix-level storage metrics are enabled.
        /// </para>
        /// </summary>
        public bool? IsEnabled
        {
            get { return this._isEnabled; }
            set { this._isEnabled = value; }
        }

        // Check to see if IsEnabled property is set
        internal bool IsSetIsEnabled()
        {
            return this._isEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SelectionCriteria.
        /// </summary>
        public SelectionCriteria SelectionCriteria
        {
            get { return this._selectionCriteria; }
            set { this._selectionCriteria = value; }
        }

        // Check to see if SelectionCriteria property is set
        internal bool IsSetSelectionCriteria()
        {
            return this._selectionCriteria != null;
        }

    }
}