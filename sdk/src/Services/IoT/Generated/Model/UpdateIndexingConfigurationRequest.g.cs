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
    /// Container for the parameters to the UpdateIndexingConfiguration operation. Updates
    /// the search configuration. <para> Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">UpdateIndexingConfiguration</a>
    /// action. </para>
    /// </summary>
    public partial class UpdateIndexingConfigurationRequest : AmazonIoTRequest
    {
        /// <summary>
        /// Gets and sets the property ThingGroupIndexingConfiguration. 
        /// <para>
        /// Thing group indexing configuration.
        /// </para>
        /// </summary>
        public ThingGroupIndexingConfiguration ThingGroupIndexingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ThingGroupIndexingConfiguration property is set.
        /// </summary>
        internal bool IsSetThingGroupIndexingConfiguration() => this.ThingGroupIndexingConfiguration != null;

        /// <summary>
        /// Gets and sets the property ThingIndexingConfiguration. 
        /// <para>
        /// Thing indexing configuration.
        /// </para>
        /// </summary>
        public ThingIndexingConfiguration ThingIndexingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ThingIndexingConfiguration property is set.
        /// </summary>
        internal bool IsSetThingIndexingConfiguration() => this.ThingIndexingConfiguration != null;
    }
}
