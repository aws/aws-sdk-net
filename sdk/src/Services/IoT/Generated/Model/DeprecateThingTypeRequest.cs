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
    /// Container for the parameters to the DeprecateThingType operation.
    /// Deprecates a thing type. You can not associate new things with deprecated thing type.
    /// 
    ///  
    /// <para>
    /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DeprecateThingType</a>
    /// action.
    /// </para>
    /// </summary>
    public partial class DeprecateThingTypeRequest : AmazonIoTRequest
    {
        private string _thingTypeName;
        private bool? _undoDeprecate;

        /// <summary>
        /// Gets and sets the property ThingTypeName. 
        /// <para>
        /// The name of the thing type to deprecate.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ThingTypeName
        {
            get { return this._thingTypeName; }
            set { this._thingTypeName = value; }
        }

        // Check to see if ThingTypeName property is set
        internal bool IsSetThingTypeName()
        {
            return this._thingTypeName != null;
        }

        /// <summary>
        /// Gets and sets the property UndoDeprecate. 
        /// <para>
        /// Whether to undeprecate a deprecated thing type. If <b>true</b>, the thing type will
        /// not be deprecated anymore and you can associate it with things.
        /// </para>
        /// </summary>
        public bool? UndoDeprecate
        {
            get { return this._undoDeprecate; }
            set { this._undoDeprecate = value; }
        }

        // Check to see if UndoDeprecate property is set
        internal bool IsSetUndoDeprecate()
        {
            return this._undoDeprecate.HasValue; 
        }

    }
}