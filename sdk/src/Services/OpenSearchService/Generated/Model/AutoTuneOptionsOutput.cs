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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// The Auto-Tune settings for a domain, displayed when enabling or disabling Auto-Tune.
    /// </summary>
    public partial class AutoTuneOptionsOutput
    {
        private string _errorMessage;
        private AutoTuneState _state;
        private bool? _useOffPeakWindow;

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// Any errors that occurred while enabling or disabling Auto-Tune.
        /// </para>
        /// </summary>
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of Auto-Tune on the domain.
        /// </para>
        /// </summary>
        public AutoTuneState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property UseOffPeakWindow. 
        /// <para>
        /// Whether the domain's off-peak window will be used to deploy Auto-Tune changes rather
        /// than a maintenance schedule.
        /// </para>
        /// </summary>
        public bool UseOffPeakWindow
        {
            get { return this._useOffPeakWindow.GetValueOrDefault(); }
            set { this._useOffPeakWindow = value; }
        }

        // Check to see if UseOffPeakWindow property is set
        internal bool IsSetUseOffPeakWindow()
        {
            return this._useOffPeakWindow.HasValue; 
        }

    }
}