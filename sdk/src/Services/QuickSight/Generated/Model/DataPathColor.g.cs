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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The color map that determines the color options for a particular element.
    /// </summary>
    public partial class DataPathColor
    {
        /// <summary>
        /// Gets and sets the property Color. 
        /// <para>
        /// The color that needs to be applied to the element.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Color { get; set; }

        /// <summary>
        /// Checks to see if the Color property is set.
        /// </summary>
        internal bool IsSetColor() => this.Color != null;

        /// <summary>
        /// Gets and sets the property Element. 
        /// <para>
        /// The element that the color needs to be applied to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DataPathValue Element { get; set; }

        /// <summary>
        /// Checks to see if the Element property is set.
        /// </summary>
        internal bool IsSetElement() => this.Element != null;

        /// <summary>
        /// Gets and sets the property TimeGranularity. 
        /// <para>
        /// The time granularity of the field that the color needs to be applied to.
        /// </para>
        /// </summary>
        public TimeGranularity TimeGranularity { get; set; }

        /// <summary>
        /// Checks to see if the TimeGranularity property is set.
        /// </summary>
        internal bool IsSetTimeGranularity() => this.TimeGranularity != null;
    }
}
