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

namespace Amazon.CloudWatchRUM.Model
{
    /// <summary>
    /// A structure that includes some data about app monitors and their settings.
    /// </summary>
    public partial class AppMonitorSummary
    {
        /// <summary>
        /// Gets and sets the property Created. 
        /// <para>
        /// The date and time that the app monitor was created.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 19, Max = 19)]
        public string Created { get; set; }

        /// <summary>
        /// Checks to see if the Created property is set.
        /// </summary>
        internal bool IsSetCreated() => this.Created != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique ID of this app monitor.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property LastModified. 
        /// <para>
        /// The date and time of the most recent changes to this app monitor's configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 19, Max = 19)]
        public string LastModified { get; set; }

        /// <summary>
        /// Checks to see if the LastModified property is set.
        /// </summary>
        internal bool IsSetLastModified() => this.LastModified != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of this app monitor.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Platform. 
        /// <para>
        /// The platform type for this app monitor. Valid values are <c>Web</c> for web applications,
        /// <c>Android</c> for Android applications, and <c>iOS</c> for IOS applications.
        /// </para>
        /// </summary>
        public AppMonitorPlatform Platform { get; set; }

        /// <summary>
        /// Checks to see if the Platform property is set.
        /// </summary>
        internal bool IsSetPlatform() => this.Platform != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of this app monitor.
        /// </para>
        /// </summary>
        public StateEnum State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
