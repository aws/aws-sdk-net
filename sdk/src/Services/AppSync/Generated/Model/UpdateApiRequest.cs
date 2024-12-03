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
    /// Container for the parameters to the UpdateApi operation.
    /// Updates an <c>Api</c>.
    /// </summary>
    public partial class UpdateApiRequest : AmazonAppSyncRequest
    {
        private string _apiId;
        private EventConfig _eventConfig;
        private string _name;
        private string _ownerContact;

        /// <summary>
        /// Gets and sets the property ApiId. 
        /// <para>
        /// The <c>Api</c> ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ApiId
        {
            get { return this._apiId; }
            set { this._apiId = value; }
        }

        // Check to see if ApiId property is set
        internal bool IsSetApiId()
        {
            return this._apiId != null;
        }

        /// <summary>
        /// Gets and sets the property EventConfig. 
        /// <para>
        /// The new event configuration. This includes the default authorization configuration
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
        /// The name of the Api.
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

    }
}