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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
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
namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// In-app message configuration.
    /// </summary>
    public partial class CampaignInAppMessage
    {
        private string _body;
        private List<InAppMessageContent> _content = AWSConfigs.InitializeCollections ? new List<InAppMessageContent>() : null;
        private Dictionary<string, string> _customConfig = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private Layout _layout;

        /// <summary>
        /// Gets and sets the property Body. 
        /// <para>
        /// The message body of the notification, the email body or the text message.
        /// </para>
        /// </summary>
        public string Body
        {
            get { return this._body; }
            set { this._body = value; }
        }

        // Check to see if Body property is set
        internal bool IsSetBody()
        {
            return this._body != null;
        }

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// In-app message content.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InAppMessageContent> Content
        {
            get { return this._content; }
            set { this._content = value; }
        }

        // Check to see if Content property is set
        internal bool IsSetContent()
        {
            return this._content != null && (this._content.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CustomConfig. 
        /// <para>
        /// Custom config to be sent to client.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> CustomConfig
        {
            get { return this._customConfig; }
            set { this._customConfig = value; }
        }

        // Check to see if CustomConfig property is set
        internal bool IsSetCustomConfig()
        {
            return this._customConfig != null && (this._customConfig.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Layout. 
        /// <para>
        /// In-app message layout.
        /// </para>
        /// </summary>
        public Layout Layout
        {
            get { return this._layout; }
            set { this._layout = value; }
        }

        // Check to see if Layout property is set
        internal bool IsSetLayout()
        {
            return this._layout != null;
        }

    }
}