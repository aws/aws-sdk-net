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
 * Do not modify this file. This file is generated from the socialmessaging-2024-01-01.normal.json service model.
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
namespace Amazon.SocialMessaging.Model
{
    /// <summary>
    /// Contains the overall health status and per-entity breakdown for a WhatsApp Flow.
    /// </summary>
    public partial class MetaFlowHealthStatus
    {
        private string _canSendMessage;
        private List<MetaFlowHealthEntity> _entities = AWSConfigs.InitializeCollections ? new List<MetaFlowHealthEntity>() : null;

        /// <summary>
        /// Gets and sets the property CanSendMessage. 
        /// <para>
        /// The overall messaging availability status (for example, AVAILABLE, LIMITED, or BLOCKED).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public string CanSendMessage
        {
            get { return this._canSendMessage; }
            set { this._canSendMessage = value; }
        }

        // Check to see if CanSendMessage property is set
        internal bool IsSetCanSendMessage()
        {
            return this._canSendMessage != null;
        }

        /// <summary>
        /// Gets and sets the property Entities. 
        /// <para>
        /// A list of health status entities with per-entity availability information.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MetaFlowHealthEntity> Entities
        {
            get { return this._entities; }
            set { this._entities = value; }
        }

        // Check to see if Entities property is set
        internal bool IsSetEntities()
        {
            return this._entities != null && (this._entities.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}