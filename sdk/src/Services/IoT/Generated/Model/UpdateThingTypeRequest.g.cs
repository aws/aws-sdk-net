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
    /// Container for the parameters to the UpdateThingType operation. Updates a thing type.
    /// </summary>
    public partial class UpdateThingTypeRequest : AmazonIoTRequest
    {
        /// <summary>
        /// Gets and sets the property ThingTypeName. 
        /// <para>
        /// The name of a thing type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string ThingTypeName { get; set; }

        /// <summary>
        /// Checks to see if the ThingTypeName property is set.
        /// </summary>
        internal bool IsSetThingTypeName() => this.ThingTypeName != null;

        /// <summary>
        /// Gets and sets the property ThingTypeProperties.
        /// </summary>
        public ThingTypeProperties ThingTypeProperties { get; set; }

        /// <summary>
        /// Checks to see if the ThingTypeProperties property is set.
        /// </summary>
        internal bool IsSetThingTypeProperties() => this.ThingTypeProperties != null;
    }
}
