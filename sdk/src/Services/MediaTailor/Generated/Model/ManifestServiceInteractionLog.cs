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
 * Do not modify this file. This file is generated from the mediatailor-2018-04-23.normal.json service model.
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
namespace Amazon.MediaTailor.Model
{
    /// <summary>
    /// Settings for customizing what events are included in logs for interactions with the
    /// origin server.
    /// 
    ///  
    /// <para>
    /// For more information about manifest service logs, including descriptions of the event
    /// types, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/log-types.html">MediaTailor
    /// manifest logs description and event types</a> in Elemental MediaTailor User Guide.
    /// </para>
    /// </summary>
    public partial class ManifestServiceInteractionLog
    {
        private List<string> _excludeEventTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ExcludeEventTypes. 
        /// <para>
        /// Indicates that MediaTailor won't emit the selected events in the logs for playback
        /// sessions that are initialized with this configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ExcludeEventTypes
        {
            get { return this._excludeEventTypes; }
            set { this._excludeEventTypes = value; }
        }

        // Check to see if ExcludeEventTypes property is set
        internal bool IsSetExcludeEventTypes()
        {
            return this._excludeEventTypes != null && (this._excludeEventTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}