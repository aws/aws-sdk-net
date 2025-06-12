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
 * Do not modify this file. This file is generated from the appsync-2017-07-25.normal.json service model.
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
namespace Amazon.AppSync.Model
{
    /// <summary>
    /// Container for the parameters to the CreateApi operation.
    /// Creates an <c>Api</c> object. Use this operation to create an AppSync API with your
    /// preferred configuration, such as an Event API that provides real-time message publishing
    /// and message subscriptions over WebSockets.
    /// </summary>
    public partial class CreateApiRequest : AmazonAppSyncRequest
    {
        private EventConfig _eventConfig;
        private string _name;
        private string _ownerContact;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property EventConfig. 
        /// <para>
        /// The Event API configuration. This includes the default authorization configuration
        /// for connecting, publishing, and subscribing to an Event API.
        /// </para>
        /// </summary>
        public EventConfig EventConfig
        {
            get { return this._eventConfig; }
            set { this._eventConfig = value; }
        }

        // Check to see if EventConfig property is set
        internal bool IsSetEventConfig()
        {
            return this._eventConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name for the <c>Api</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property OwnerContact. 
        /// <para>
        /// The owner contact information for the <c>Api</c>.
        /// </para>
        /// </summary>
        public string OwnerContact
        {
            get { return this._ownerContact; }
            set { this._ownerContact = value; }
        }

        // Check to see if OwnerContact property is set
        internal bool IsSetOwnerContact()
        {
            return this._ownerContact != null;
        }

        /// <summary>
        /// Gets and sets the property Tags.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}