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

namespace Amazon.IoTThingsGraph.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateEntityToThing operation. Associates a
    /// device with a concrete thing that is in the user's registry. <para> A thing can be
    /// associated with only one device at a time. If you associate a thing with a new device
    /// id, its previous association will be removed. </para>
    /// </summary>
    public partial class AssociateEntityToThingRequest : AmazonIoTThingsGraphRequest
    {
        /// <summary>
        /// Gets and sets the property EntityId. 
        /// <para>
        /// The ID of the device to be associated with the thing.
        /// </para>
        ///  
        /// <para>
        /// The ID should be in the following format.
        /// </para>
        ///  
        /// <para>
        ///  <c>urn:tdm:REGION/ACCOUNT ID/default:device:DEVICENAME</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 160)]
        public string EntityId { get; set; }

        /// <summary>
        /// Checks to see if the EntityId property is set.
        /// </summary>
        internal bool IsSetEntityId() => this.EntityId != null;

        /// <summary>
        /// Gets and sets the property NamespaceVersion. 
        /// <para>
        /// The version of the user's namespace. Defaults to the latest version of the user's
        /// namespace.
        /// </para>
        /// </summary>
        public long? NamespaceVersion { get; set; }

        /// <summary>
        /// Checks to see if the NamespaceVersion property is set.
        /// </summary>
        internal bool IsSetNamespaceVersion() => this.NamespaceVersion.HasValue;

        /// <summary>
        /// Gets and sets the property ThingName. 
        /// <para>
        /// The name of the thing to which the entity is to be associated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string ThingName { get; set; }

        /// <summary>
        /// Checks to see if the ThingName property is set.
        /// </summary>
        internal bool IsSetThingName() => this.ThingName != null;
    }
}
