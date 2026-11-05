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

namespace Amazon.SageMakerGeospatial.Model
{
    /// <summary>
    /// The input structure for Map Matching operation type.
    /// </summary>
    public partial class MapMatchingConfig
    {
        /// <summary>
        /// Gets and sets the property IdAttributeName. 
        /// <para>
        /// The field name for the data that describes the identifier representing a collection
        /// of GPS points belonging to an individual trace.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string IdAttributeName { get; set; }

        /// <summary>
        /// Checks to see if the IdAttributeName property is set.
        /// </summary>
        internal bool IsSetIdAttributeName() => this.IdAttributeName != null;

        /// <summary>
        /// Gets and sets the property TimestampAttributeName. 
        /// <para>
        /// The name of the timestamp attribute.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TimestampAttributeName { get; set; }

        /// <summary>
        /// Checks to see if the TimestampAttributeName property is set.
        /// </summary>
        internal bool IsSetTimestampAttributeName() => this.TimestampAttributeName != null;

        /// <summary>
        /// Gets and sets the property XAttributeName. 
        /// <para>
        /// The name of the X-attribute
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string XAttributeName { get; set; }

        /// <summary>
        /// Checks to see if the XAttributeName property is set.
        /// </summary>
        internal bool IsSetXAttributeName() => this.XAttributeName != null;

        /// <summary>
        /// Gets and sets the property YAttributeName. 
        /// <para>
        /// The name of the Y-attribute
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string YAttributeName { get; set; }

        /// <summary>
        /// Checks to see if the YAttributeName property is set.
        /// </summary>
        internal bool IsSetYAttributeName() => this.YAttributeName != null;
    }
}
