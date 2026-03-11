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
 * Do not modify this file. This file is generated from the connecthealth-2025-01-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.EventStreams;
using Amazon.Runtime.EventStreams.Internal;
using Amazon.ConnectHealth.Model.Internal.MarshallTransformations;
using Amazon.Runtime.EventStreams.Utils;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ConnectHealth.Model
{
    /// <summary>
    /// An event containing configuration for the Medical Scribe session
    /// </summary>
    public partial class MedicalScribeConfigurationEvent
        : IEventStreamEvent
    {
        private List<MedicalScribeChannelDefinition> _channelDefinitions = AWSConfigs.InitializeCollections ? new List<MedicalScribeChannelDefinition>() : null;
        private EncounterContext _encounterContext;
        private MedicalScribePostStreamActionSettings _postStreamActionSettings;

        /// <summary>
        /// Gets and sets the property ChannelDefinitions. 
        /// <para>
        /// Channel definitions for the audio stream
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=2, Max=2)]
        public List<MedicalScribeChannelDefinition> ChannelDefinitions
        {
            get { return this._channelDefinitions; }
            set { this._channelDefinitions = value; }
        }

        // Check to see if ChannelDefinitions property is set
        internal bool IsSetChannelDefinitions()
        {
            return this._channelDefinitions != null && (this._channelDefinitions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EncounterContext. 
        /// <para>
        /// Context information about the clinical encounter
        /// </para>
        /// </summary>
        public EncounterContext EncounterContext
        {
            get { return this._encounterContext; }
            set { this._encounterContext = value; }
        }

        // Check to see if EncounterContext property is set
        internal bool IsSetEncounterContext()
        {
            return this._encounterContext != null;
        }

        /// <summary>
        /// Gets and sets the property PostStreamActionSettings. 
        /// <para>
        /// Settings for actions to perform after the stream ends
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MedicalScribePostStreamActionSettings PostStreamActionSettings
        {
            get { return this._postStreamActionSettings; }
            set { this._postStreamActionSettings = value; }
        }

        // Check to see if PostStreamActionSettings property is set
        internal bool IsSetPostStreamActionSettings()
        {
            return this._postStreamActionSettings != null;
        }

    }
}