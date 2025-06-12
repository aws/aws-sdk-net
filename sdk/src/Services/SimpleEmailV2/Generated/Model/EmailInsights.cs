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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
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
namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// An email's insights contain metadata and delivery information about a specific email.
    /// </summary>
    public partial class EmailInsights
    {
        private string _destination;
        private List<InsightsEvent> _events = AWSConfigs.InitializeCollections ? new List<InsightsEvent>() : null;
        private string _isp;

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The recipient of the email.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=320)]
        public string Destination
        {
            get { return this._destination; }
            set { this._destination = value; }
        }

        // Check to see if Destination property is set
        internal bool IsSetDestination()
        {
            return this._destination != null;
        }

        /// <summary>
        /// Gets and sets the property Events. 
        /// <para>
        /// A list of events associated with the sent email.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InsightsEvent> Events
        {
            get { return this._events; }
            set { this._events = value; }
        }

        // Check to see if Events property is set
        internal bool IsSetEvents()
        {
            return this._events != null && (this._events.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Isp. 
        /// <para>
        /// The recipient's ISP (e.g., <c>Gmail</c>, <c>Yahoo</c>, etc.).
        /// </para>
        /// </summary>
        public string Isp
        {
            get { return this._isp; }
            set { this._isp = value; }
        }

        // Check to see if Isp property is set
        internal bool IsSetIsp()
        {
            return this._isp != null;
        }

    }
}