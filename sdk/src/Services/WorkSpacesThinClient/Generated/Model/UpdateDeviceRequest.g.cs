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

namespace Amazon.WorkSpacesThinClient.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDevice operation. Updates a thin client
    /// device.
    /// </summary>
    public partial class UpdateDeviceRequest : AmazonWorkSpacesThinClientRequest
    {
        /// <summary>
        /// Gets and sets the property DesiredSoftwareSetId. 
        /// <para>
        /// The ID of the software set to apply.
        /// </para>
        /// </summary>
        public string DesiredSoftwareSetId { get; set; }

        /// <summary>
        /// Checks to see if the DesiredSoftwareSetId property is set.
        /// </summary>
        internal bool IsSetDesiredSoftwareSetId() => this.DesiredSoftwareSetId != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the device to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the device to update.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property SoftwareSetUpdateSchedule. 
        /// <para>
        /// An option to define if software updates should be applied within a maintenance window.
        /// </para>
        /// </summary>
        public SoftwareSetUpdateSchedule SoftwareSetUpdateSchedule { get; set; }

        /// <summary>
        /// Checks to see if the SoftwareSetUpdateSchedule property is set.
        /// </summary>
        internal bool IsSetSoftwareSetUpdateSchedule() => this.SoftwareSetUpdateSchedule != null;
    }
}
