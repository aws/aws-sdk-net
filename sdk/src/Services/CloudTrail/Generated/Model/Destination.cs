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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// Contains information about the destination receiving events.
    /// </summary>
    public partial class Destination
    {
        private string _location;
        private DestinationType _type;

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        ///  For channels used for a CloudTrail Lake integration, the location is the ARN of an
        /// event data store that receives events from a channel. For service-linked channels,
        /// the location is the name of the Amazon Web Services service.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=1024)]
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of destination for events arriving from a channel. For channels used for
        /// a CloudTrail Lake integration, the value is <code>EventDataStore</code>. For service-linked
        /// channels, the value is <code>AWS_SERVICE</code>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DestinationType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}