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
    /// The metadata transfer job AWS IoT TwinMaker source configuration filter.
    /// </summary>
    public partial class IotTwinMakerSourceConfigurationFilter
    {
        /// <summary>
        /// Gets and sets the property FilterByComponentType. 
        /// <para>
        /// Filter by component type.
        /// </para>
        /// </summary>
        public FilterByComponentType FilterByComponentType { get; set; }

        /// <summary>
        /// Checks to see if the FilterByComponentType property is set.
        /// </summary>
        internal bool IsSetFilterByComponentType() => this.FilterByComponentType != null;

        /// <summary>
        /// Gets and sets the property FilterByEntity. 
        /// <para>
        /// Filter by entity.
        /// </para>
        /// </summary>
        public FilterByEntity FilterByEntity { get; set; }

        /// <summary>
        /// Checks to see if the FilterByEntity property is set.
        /// </summary>
        internal bool IsSetFilterByEntity() => this.FilterByEntity != null;
    }
}
