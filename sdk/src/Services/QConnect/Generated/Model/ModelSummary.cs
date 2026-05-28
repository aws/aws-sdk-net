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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
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
namespace Amazon.QConnect.Model
{
    /// <summary>
    /// The summary of a model available to an Amazon Q in Connect assistant.
    /// </summary>
    public partial class ModelSummary
    {
        private CrossRegionStatus _crossRegionStatus;
        private string _displayName;
        private DateTime? _endOfLifeTimestamp;
        private DateTime? _legacyTimestamp;
        private string _modelId;
        private ModelLifecycle _modelLifecycle;
        private List<string> _supportedaiPromptTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _supportsPromptCaching;

        /// <summary>
        /// Gets and sets the property CrossRegionStatus. 
        /// <para>
        /// The cross-region availability status of the model. <c>NONE</c> indicates the model
        /// is only available in a single region, <c>REGIONAL</c> indicates the model is available
        /// through regional inference, and <c>GLOBAL</c> indicates the model is available through
        /// global cross-region inference.
        /// </para>
        /// </summary>
        public CrossRegionStatus CrossRegionStatus
        {
            get { return this._crossRegionStatus; }
            set { this._crossRegionStatus = value; }
        }

        // Check to see if CrossRegionStatus property is set
        internal bool IsSetCrossRegionStatus()
        {
            return this._crossRegionStatus != null;
        }

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The display name of the model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property EndOfLifeTimestamp. 
        /// <para>
        /// The timestamp when the model will reach end of life and no longer be available for
        /// use.
        /// </para>
        /// </summary>
        public DateTime? EndOfLifeTimestamp
        {
            get { return this._endOfLifeTimestamp; }
            set { this._endOfLifeTimestamp = value; }
        }

        // Check to see if EndOfLifeTimestamp property is set
        internal bool IsSetEndOfLifeTimestamp()
        {
            return this._endOfLifeTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LegacyTimestamp. 
        /// <para>
        /// The timestamp when the model lifecycle will transition from <c>ACTIVE</c> to <c>LEGACY</c>.
        /// </para>
        /// </summary>
        public DateTime? LegacyTimestamp
        {
            get { return this._legacyTimestamp; }
            set { this._legacyTimestamp = value; }
        }

        // Check to see if LegacyTimestamp property is set
        internal bool IsSetLegacyTimestamp()
        {
            return this._legacyTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ModelId. 
        /// <para>
        /// The identifier of the model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ModelId
        {
            get { return this._modelId; }
            set { this._modelId = value; }
        }

        // Check to see if ModelId property is set
        internal bool IsSetModelId()
        {
            return this._modelId != null;
        }

        /// <summary>
        /// Gets and sets the property ModelLifecycle. 
        /// <para>
        /// The current lifecycle of the model. <c>ACTIVE</c> indicates the model is recommended
        /// for use and <c>LEGACY</c> indicates the model is still usable but is deprecated.
        /// </para>
        /// </summary>
        public ModelLifecycle ModelLifecycle
        {
            get { return this._modelLifecycle; }
            set { this._modelLifecycle = value; }
        }

        // Check to see if ModelLifecycle property is set
        internal bool IsSetModelLifecycle()
        {
            return this._modelLifecycle != null;
        }

        /// <summary>
        /// Gets and sets the property SupportedAIPromptTypes. 
        /// <para>
        /// The list of AI Prompt types that the model supports.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedAIPromptTypes
        {
            get { return this._supportedaiPromptTypes; }
            set { this._supportedaiPromptTypes = value; }
        }

        // Check to see if SupportedAIPromptTypes property is set
        internal bool IsSetSupportedAIPromptTypes()
        {
            return this._supportedaiPromptTypes != null && (this._supportedaiPromptTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SupportsPromptCaching. 
        /// <para>
        /// Whether the model supports prompt caching.
        /// </para>
        /// </summary>
        public bool? SupportsPromptCaching
        {
            get { return this._supportsPromptCaching; }
            set { this._supportsPromptCaching = value; }
        }

        // Check to see if SupportsPromptCaching property is set
        internal bool IsSetSupportsPromptCaching()
        {
            return this._supportsPromptCaching.HasValue; 
        }

    }
}