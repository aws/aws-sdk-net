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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// The destination for an outbound web notification, specifying the communication widget
    /// that delivers the notification and the customer profile of the recipient.
    /// </summary>
    public partial class WidgetDestination
    {
        private string _profileId;
        private string _widgetId;

        /// <summary>
        /// Gets and sets the property ProfileId. 
        /// <para>
        /// The identifier of the customer profile associated with the browser session that should
        /// receive the notification.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
        public string ProfileId
        {
            get { return this._profileId; }
            set { this._profileId = value; }
        }

        // Check to see if ProfileId property is set
        internal bool IsSetProfileId()
        {
            return this._profileId != null;
        }

        /// <summary>
        /// Gets and sets the property WidgetId. 
        /// <para>
        /// The identifier of the communication widget that delivers the notification to the customer's
        /// browser.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=36)]
        public string WidgetId
        {
            get { return this._widgetId; }
            set { this._widgetId = value; }
        }

        // Check to see if WidgetId property is set
        internal bool IsSetWidgetId()
        {
            return this._widgetId != null;
        }

    }
}