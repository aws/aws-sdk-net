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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Information about the state of the domain relative to the latest service software.
    /// </summary>
    public partial class AwsElasticsearchDomainServiceSoftwareOptions
    {
        /// <summary>
        /// Gets and sets the property AutomatedUpdateDate. 
        /// <para>
        /// The epoch time when the deployment window closes for required updates. After this
        /// time, Amazon OpenSearch Service schedules the software upgrade automatically.
        /// </para>
        /// </summary>
        public string AutomatedUpdateDate { get; set; }

        /// <summary>
        /// Checks to see if the AutomatedUpdateDate property is set.
        /// </summary>
        internal bool IsSetAutomatedUpdateDate() => this.AutomatedUpdateDate != null;

        /// <summary>
        /// Gets and sets the property Cancellable. 
        /// <para>
        /// Whether a request to update the domain can be canceled.
        /// </para>
        /// </summary>
        public bool? Cancellable { get; set; }

        /// <summary>
        /// Checks to see if the Cancellable property is set.
        /// </summary>
        internal bool IsSetCancellable() => this.Cancellable.HasValue;

        /// <summary>
        /// Gets and sets the property CurrentVersion. 
        /// <para>
        /// The version of the service software that is currently installed on the domain.
        /// </para>
        /// </summary>
        public string CurrentVersion { get; set; }

        /// <summary>
        /// Checks to see if the CurrentVersion property is set.
        /// </summary>
        internal bool IsSetCurrentVersion() => this.CurrentVersion != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A more detailed description of the service software status.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property NewVersion. 
        /// <para>
        /// The most recent version of the service software.
        /// </para>
        /// </summary>
        public string NewVersion { get; set; }

        /// <summary>
        /// Checks to see if the NewVersion property is set.
        /// </summary>
        internal bool IsSetNewVersion() => this.NewVersion != null;

        /// <summary>
        /// Gets and sets the property UpdateAvailable. 
        /// <para>
        /// Whether a service software update is available for the domain.
        /// </para>
        /// </summary>
        public bool? UpdateAvailable { get; set; }

        /// <summary>
        /// Checks to see if the UpdateAvailable property is set.
        /// </summary>
        internal bool IsSetUpdateAvailable() => this.UpdateAvailable.HasValue;

        /// <summary>
        /// Gets and sets the property UpdateStatus. 
        /// <para>
        /// The status of the service software update. Valid values are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>COMPLETED</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ELIGIBLE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IN_PROGRESS</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NOT_ELIGIBLE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PENDING_UPDATE</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string UpdateStatus { get; set; }

        /// <summary>
        /// Checks to see if the UpdateStatus property is set.
        /// </summary>
        internal bool IsSetUpdateStatus() => this.UpdateStatus != null;
    }
}
