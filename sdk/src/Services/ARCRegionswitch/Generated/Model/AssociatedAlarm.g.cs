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

namespace Amazon.ARCRegionswitch.Model
{
    /// <summary>
    /// An Amazon CloudWatch alarm associated with a Region switch plan. These alarms can
    /// be used to trigger automatic execution of the plan.
    /// </summary>
    public partial class AssociatedAlarm
    {
        /// <summary>
        /// Gets and sets the property AlarmType. 
        /// <para>
        /// The alarm type for an associated alarm. An associated CloudWatch alarm can be an application
        /// health alarm or a trigger alarm.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AlarmType AlarmType { get; set; }

        /// <summary>
        /// Checks to see if the AlarmType property is set.
        /// </summary>
        internal bool IsSetAlarmType() => this.AlarmType != null;

        /// <summary>
        /// Gets and sets the property CrossAccountRole. 
        /// <para>
        /// The cross account role for the configuration.
        /// </para>
        /// </summary>
        public string CrossAccountRole { get; set; }

        /// <summary>
        /// Checks to see if the CrossAccountRole property is set.
        /// </summary>
        internal bool IsSetCrossAccountRole() => this.CrossAccountRole != null;

        /// <summary>
        /// Gets and sets the property ExternalId. 
        /// <para>
        /// The external ID (secret key) for the configuration.
        /// </para>
        /// </summary>
        public string ExternalId { get; set; }

        /// <summary>
        /// Checks to see if the ExternalId property is set.
        /// </summary>
        internal bool IsSetExternalId() => this.ExternalId != null;

        /// <summary>
        /// Gets and sets the property ResourceIdentifier. 
        /// <para>
        /// The resource identifier for alarms that you associate with a plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ResourceIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ResourceIdentifier property is set.
        /// </summary>
        internal bool IsSetResourceIdentifier() => this.ResourceIdentifier != null;
    }
}
