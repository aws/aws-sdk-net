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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// An object that represents the connection attribute, thing attribute, and the user
    /// property key.
    /// </summary>
    public partial class PropagatingAttribute
    {
        /// <summary>
        /// Gets and sets the property ConnectionAttribute. 
        /// <para>
        /// The attribute associated with the connection between a device and Amazon Web Services
        /// IoT Core.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string ConnectionAttribute { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionAttribute property is set.
        /// </summary>
        internal bool IsSetConnectionAttribute() => this.ConnectionAttribute != null;

        /// <summary>
        /// Gets and sets the property ThingAttribute. 
        /// <para>
        /// The user-defined thing attribute that is propagating for MQTT 5 message enrichment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string ThingAttribute { get; set; }

        /// <summary>
        /// Checks to see if the ThingAttribute property is set.
        /// </summary>
        internal bool IsSetThingAttribute() => this.ThingAttribute != null;

        /// <summary>
        /// Gets and sets the property UserPropertyKey. 
        /// <para>
        /// The key of the user property key-value pair.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string UserPropertyKey { get; set; }

        /// <summary>
        /// Checks to see if the UserPropertyKey property is set.
        /// </summary>
        internal bool IsSetUserPropertyKey() => this.UserPropertyKey != null;
    }
}
