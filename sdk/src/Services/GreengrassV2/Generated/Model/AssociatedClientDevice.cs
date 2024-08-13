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
 * Do not modify this file. This file is generated from the greengrassv2-2020-11-30.normal.json service model.
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
namespace Amazon.GreengrassV2.Model
{
    /// <summary>
    /// Contains information about a client device that is associated to a core device for
    /// cloud discovery.
    /// </summary>
    public partial class AssociatedClientDevice
    {
        private DateTime? _associationTimestamp;
        private string _thingName;

        /// <summary>
        /// Gets and sets the property AssociationTimestamp. 
        /// <para>
        /// The time that the client device was associated, expressed in ISO 8601 format.
        /// </para>
        /// </summary>
        public DateTime? AssociationTimestamp
        {
            get { return this._associationTimestamp; }
            set { this._associationTimestamp = value; }
        }

        // Check to see if AssociationTimestamp property is set
        internal bool IsSetAssociationTimestamp()
        {
            return this._associationTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ThingName. 
        /// <para>
        /// The name of the IoT thing that represents the associated client device.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ThingName
        {
            get { return this._thingName; }
            set { this._thingName = value; }
        }

        // Check to see if ThingName property is set
        internal bool IsSetThingName()
        {
            return this._thingName != null;
        }

    }
}