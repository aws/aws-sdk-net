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
    /// Container for the parameters to the UpdateThingGroup operation. Update a thing group.
    /// <para> Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">UpdateThingGroup</a>
    /// action. </para>
    /// </summary>
    public partial class UpdateThingGroupRequest : AmazonIoTRequest
    {
        /// <summary>
        /// Gets and sets the property ExpectedVersion. 
        /// <para>
        /// The expected version of the thing group. If this does not match the version of the
        /// thing group being updated, the update will fail.
        /// </para>
        /// </summary>
        public long? ExpectedVersion { get; set; }

        /// <summary>
        /// Checks to see if the ExpectedVersion property is set.
        /// </summary>
        internal bool IsSetExpectedVersion() => this.ExpectedVersion.HasValue;

        /// <summary>
        /// Gets and sets the property ThingGroupName. 
        /// <para>
        /// The thing group to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string ThingGroupName { get; set; }

        /// <summary>
        /// Checks to see if the ThingGroupName property is set.
        /// </summary>
        internal bool IsSetThingGroupName() => this.ThingGroupName != null;

        /// <summary>
        /// Gets and sets the property ThingGroupProperties. 
        /// <para>
        /// The thing group properties.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ThingGroupProperties ThingGroupProperties { get; set; }

        /// <summary>
        /// Checks to see if the ThingGroupProperties property is set.
        /// </summary>
        internal bool IsSetThingGroupProperties() => this.ThingGroupProperties != null;
    }
}
