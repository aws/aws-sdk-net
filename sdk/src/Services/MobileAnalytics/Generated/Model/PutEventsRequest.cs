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
 * Do not modify this file. This file is generated from the mobileanalytics-2014-06-05.normal.json service model.
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
namespace Amazon.MobileAnalytics.Model
{
    /// <summary>
    /// Container for the parameters to the PutEvents operation.
    /// The PutEvents operation records one or more events. You can have up to 1,500 unique
    /// custom events per app, any combination of up to 40 attributes and metrics per custom
    /// event, and any number of attribute or metric values.
    /// </summary>
    public partial class PutEventsRequest : AmazonMobileAnalyticsRequest
    {
        private string _clientContext;
        private string _clientContextEncoding;
        private List<Event> _events = AWSConfigs.InitializeCollections ? new List<Event>() : null;

        /// <summary>
        /// Gets and sets the property ClientContext. 
        /// <para>
        /// The client context including the client ID, app title, app version and package name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ClientContext
        {
            get { return this._clientContext; }
            set { this._clientContext = value; }
        }

        // Check to see if ClientContext property is set
        internal bool IsSetClientContext()
        {
            return this._clientContext != null;
        }

        /// <summary>
        /// Gets and sets the property ClientContextEncoding. 
        /// <para>
        /// The encoding used for the client context.
        /// </para>
        /// </summary>
        public string ClientContextEncoding
        {
            get { return this._clientContextEncoding; }
            set { this._clientContextEncoding = value; }
        }

        // Check to see if ClientContextEncoding property is set
        internal bool IsSetClientContextEncoding()
        {
            return this._clientContextEncoding != null;
        }

        /// <summary>
        /// Gets and sets the property Events. 
        /// <para>
        /// An array of Event JSON objects
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Event> Events
        {
            get { return this._events; }
            set { this._events = value; }
        }

        // Check to see if Events property is set
        internal bool IsSetEvents()
        {
            return this._events != null && (this._events.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}