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
 * Do not modify this file. This file is generated from the networkmanager-2019-07-05.normal.json service model.
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
namespace Amazon.NetworkManager.Model
{
    /// <summary>
    /// Describes the segments associated with the service insertion action.
    /// </summary>
    public partial class ServiceInsertionSegments
    {
        private List<string> _sendTo = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _sendVia = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property SendTo. 
        /// <para>
        /// The list of segments associated with the <c>send-to</c> action.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SendTo
        {
            get { return this._sendTo; }
            set { this._sendTo = value; }
        }

        // Check to see if SendTo property is set
        internal bool IsSetSendTo()
        {
            return this._sendTo != null && (this._sendTo.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SendVia. 
        /// <para>
        /// The list of segments associated with the <c>send-via</c> action.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SendVia
        {
            get { return this._sendVia; }
            set { this._sendVia = value; }
        }

        // Check to see if SendVia property is set
        internal bool IsSetSendVia()
        {
            return this._sendVia != null && (this._sendVia.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}