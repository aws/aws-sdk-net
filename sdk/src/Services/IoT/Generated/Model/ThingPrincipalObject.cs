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
    /// An object that represents the principal and the type of relation it has with the thing.
    /// </summary>
    public partial class ThingPrincipalObject
    {
        private string _principal;
        private ThingPrincipalType _thingPrincipalType;

        /// <summary>
        /// Gets and sets the property Principal. 
        /// <para>
        /// The principal of the thing principal object.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Principal
        {
            get { return this._principal; }
            set { this._principal = value; }
        }

        // Check to see if Principal property is set
        internal bool IsSetPrincipal()
        {
            return this._principal != null;
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