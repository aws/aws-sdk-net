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

namespace Amazon.IoTTwinMaker.Model
{
    /// <summary>
    /// The latest value of the property.
    /// </summary>
    public partial class PropertyLatestValue
    {
        /// <summary>
        /// Gets and sets the property PropertyReference. 
        /// <para>
        /// An object that specifies information about a property.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EntityPropertyReference PropertyReference { get; set; }

        /// <summary>
        /// Checks to see if the PropertyReference property is set.
        /// </summary>
        internal bool IsSetPropertyReference() => this.PropertyReference != null;

        /// <summary>
        /// Gets and sets the property PropertyValue. 
        /// <para>
        /// The value of the property.
        /// </para>
        /// </summary>
        public DataValue PropertyValue { get; set; }

        /// <summary>
        /// Checks to see if the PropertyValue property is set.
        /// </summary>
        internal bool IsSetPropertyValue() => this.PropertyValue != null;
    }
}
