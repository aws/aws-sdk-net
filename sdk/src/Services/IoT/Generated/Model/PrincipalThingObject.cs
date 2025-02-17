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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
    /// An object that represents the thing and the type of relation it has with the principal.
    /// </summary>
    public partial class PrincipalThingObject
    {
        private string _thingName;
        private ThingPrincipalType _thingPrincipalType;

        /// <summary>
        /// Gets and sets the property ThingName. 
        /// <para>
        /// The name of the thing.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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

        /// <summary>
        /// Gets and sets the property ThingPrincipalType. 
        /// <para>
        /// The type of the relation you want to specify when you attach a principal to a thing.
        /// The value defaults to <c>NON_EXCLUSIVE_THING</c>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>EXCLUSIVE_THING</c> - Attaches the specified principal to the specified thing,
        /// exclusively. The thing will be the only thing that’s attached to the principal.
        /// </para>
        ///  </li> </ul> <ul> <li> 
        /// <para>
        ///  <c>NON_EXCLUSIVE_THING</c> - Attaches the specified principal to the specified thing.
        /// Multiple things can be attached to the principal.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ThingPrincipalType ThingPrincipalType
        {
            get { return this._thingPrincipalType; }
            set { this._thingPrincipalType = value; }
        }

        // Check to see if ThingPrincipalType property is set
        internal bool IsSetThingPrincipalType()
        {
            return this._thingPrincipalType != null;
        }

    }
}