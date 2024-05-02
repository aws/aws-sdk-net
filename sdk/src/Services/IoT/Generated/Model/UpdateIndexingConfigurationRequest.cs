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
    /// Container for the parameters to the UpdateIndexingConfiguration operation.
    /// Updates the search configuration.
    /// 
    ///  
    /// <para>
    /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">UpdateIndexingConfiguration</a>
    /// action.
    /// </para>
    /// </summary>
    public partial class UpdateIndexingConfigurationRequest : AmazonIoTRequest
    {
        private ThingGroupIndexingConfiguration _thingGroupIndexingConfiguration;
        private ThingIndexingConfiguration _thingIndexingConfiguration;

        /// <summary>
        /// Gets and sets the property ThingGroupIndexingConfiguration. 
        /// <para>
        /// Thing group indexing configuration.
        /// </para>
        /// </summary>
        public ThingGroupIndexingConfiguration ThingGroupIndexingConfiguration
        {
            get { return this._thingGroupIndexingConfiguration; }
            set { this._thingGroupIndexingConfiguration = value; }
        }

        // Check to see if ThingGroupIndexingConfiguration property is set
        internal bool IsSetThingGroupIndexingConfiguration()
        {
            return this._thingGroupIndexingConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ThingIndexingConfiguration. 
        /// <para>
        /// Thing indexing configuration.
        /// </para>
        /// </summary>
        public ThingIndexingConfiguration ThingIndexingConfiguration
        {
            get { return this._thingIndexingConfiguration; }
            set { this._thingIndexingConfiguration = value; }
        }

        // Check to see if ThingIndexingConfiguration property is set
        internal bool IsSetThingIndexingConfiguration()
        {
            return this._thingIndexingConfiguration != null;
        }

    }
}