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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// Contains information about the destination receiving events.
    /// </summary>
    public partial class Destination
    {
        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        ///  For channels used for a CloudTrail Lake integration, the location is the ARN of an
        /// event data store that receives events from a channel. For service-linked channels,
        /// the location is the name of the Amazon Web Services service.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 1024)]
        public string Location { get; set; }

        /// <summary>
        /// Checks to see if the Location property is set.
        /// </summary>
        internal bool IsSetLocation() => this.Location != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of destination for events arriving from a channel. For channels used for
        /// a CloudTrail Lake integration, the value is <c>EVENT_DATA_STORE</c>. For service-linked
        /// channels, the value is <c>AWS_SERVICE</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DestinationType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
