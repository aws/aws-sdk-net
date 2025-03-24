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
 * Do not modify this file. This file is generated from the application-signals-2024-04-15.normal.json service model.
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
namespace Amazon.ApplicationSignals.Model
{
    /// <summary>
    /// Container for the parameters to the BatchUpdateExclusionWindows operation.
    /// Add or remove time window exclusions for one or more Service Level Objectives (SLOs).
    /// </summary>
    public partial class BatchUpdateExclusionWindowsRequest : AmazonApplicationSignalsRequest
    {
        private List<ExclusionWindow> _addExclusionWindows = AWSConfigs.InitializeCollections ? new List<ExclusionWindow>() : null;
        private List<ExclusionWindow> _removeExclusionWindows = AWSConfigs.InitializeCollections ? new List<ExclusionWindow>() : null;
        private List<string> _sloIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AddExclusionWindows. 
        /// <para>
        /// A list of exclusion windows to add to the specified SLOs. You can add up to 10 exclusion
        /// windows per SLO.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<ExclusionWindow> AddExclusionWindows
        {
            get { return this._addExclusionWindows; }
            set { this._addExclusionWindows = value; }
        }

        // Check to see if AddExclusionWindows property is set
        internal bool IsSetAddExclusionWindows()
        {
            return this._addExclusionWindows != null && (this._addExclusionWindows.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RemoveExclusionWindows. 
        /// <para>
        /// A list of exclusion windows to remove from the specified SLOs. The window configuration
        /// must match an existing exclusion window.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<ExclusionWindow> RemoveExclusionWindows
        {
            get { return this._removeExclusionWindows; }
            set { this._removeExclusionWindows = value; }
        }

        // Check to see if RemoveExclusionWindows property is set
        internal bool IsSetRemoveExclusionWindows()
        {
            return this._removeExclusionWindows != null && (this._removeExclusionWindows.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SloIds. 
        /// <para>
        /// The list of SLO IDs to add or remove exclusion windows from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public List<string> SloIds
        {
            get { return this._sloIds; }
            set { this._sloIds = value; }
        }

        // Check to see if SloIds property is set
        internal bool IsSetSloIds()
        {
            return this._sloIds != null && (this._sloIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}