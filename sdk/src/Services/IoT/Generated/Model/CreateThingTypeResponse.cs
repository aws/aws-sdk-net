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
    /// The output of the CreateThingType operation.
    /// </summary>
    public partial class CreateThingTypeResponse : AmazonWebServiceResponse
    {
        private string _thingTypeArn;
        private string _thingTypeId;
        private string _thingTypeName;

        /// <summary>
        /// Gets and sets the property ThingTypeArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the thing type.
        /// </para>
        /// </summary>
        public string ThingTypeArn
        {
            get { return this._thingTypeArn; }
            set { this._thingTypeArn = value; }
        }

        // Check to see if ThingTypeArn property is set
        internal bool IsSetThingTypeArn()
        {
            return this._thingTypeArn != null;
        }

        /// <summary>
        /// Gets and sets the property ThingTypeId. 
        /// <para>
        /// The thing type ID.
        /// </para>
        /// </summary>
        public string ThingTypeId
        {
            get { return this._thingTypeId; }
            set { this._thingTypeId = value; }
        }

        // Check to see if ThingTypeId property is set
        internal bool IsSetThingTypeId()
        {
            return this._thingTypeId != null;
        }

        /// <summary>
        /// Gets and sets the property ThingTypeName. 
        /// <para>
        /// The name of the thing type.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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

    }
}