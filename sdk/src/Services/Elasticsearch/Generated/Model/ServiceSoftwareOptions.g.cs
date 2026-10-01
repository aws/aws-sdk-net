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

namespace Amazon.Elasticsearch.Model
{
    /// <summary>
    /// The current options of an Elasticsearch domain service software options.
    /// </summary>
    public partial class ServiceSoftwareOptions
    {
        /// <summary>
        /// Gets and sets the property AutomatedUpdateDate. 
        /// <para>
        /// Timestamp, in Epoch time, until which you can manually request a service software
        /// update. After this date, we automatically update your service software.
        /// </para>
        /// </summary>
        public DateTime? AutomatedUpdateDate { get; set; }

        /// <summary>
        /// Checks to see if the AutomatedUpdateDate property is set.
        /// </summary>
        internal bool IsSetAutomatedUpdateDate() => this.AutomatedUpdateDate.HasValue;

        /// <summary>
        /// Gets and sets the property Cancellable. 
        /// <para>
        /// <c>True</c> if you are able to cancel your service software version update. <c>False</c>
        /// if you are not able to cancel your service software version. 
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
        /// The current service software version that is present on the domain.
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
        /// The description of the <c>UpdateStatus</c>.
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
        /// The new service software version if one is available.
        /// </para>
        /// </summary>
        public string NewVersion { get; set; }

        /// <summary>
        /// Checks to see if the NewVersion property is set.
        /// </summary>
        internal bool IsSetNewVersion() => this.NewVersion != null;

        /// <summary>
        /// Gets and sets the property OptionalDeployment. 
        /// <para>
        /// <c>True</c> if a service software is never automatically updated. <c>False</c> if
        /// a service software is automatically updated after <c>AutomatedUpdateDate</c>. 
        /// </para>
        /// </summary>
        public bool? OptionalDeployment { get; set; }

        /// <summary>
        /// Checks to see if the OptionalDeployment property is set.
        /// </summary>
        internal bool IsSetOptionalDeployment() => this.OptionalDeployment.HasValue;

        /// <summary>
        /// Gets and sets the property UpdateAvailable. 
        /// <para>
        /// <c>True</c> if you are able to update you service software version. <c>False</c> if
        /// you are not able to update your service software version. 
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
        /// The status of your service software update. This field can take the following values:
        /// <c>ELIGIBLE</c>, <c>PENDING_UPDATE</c>, <c>IN_PROGRESS</c>, <c>COMPLETED</c>, and
        /// <c>NOT_ELIGIBLE</c>.
        /// </para>
        /// </summary>
        public DeploymentStatus UpdateStatus { get; set; }

        /// <summary>
        /// Checks to see if the UpdateStatus property is set.
        /// </summary>
        internal bool IsSetUpdateStatus() => this.UpdateStatus != null;
    }
}
