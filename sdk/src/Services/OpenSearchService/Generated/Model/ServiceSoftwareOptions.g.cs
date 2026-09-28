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

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// The current status of the service software for an Amazon OpenSearch Service domain.
    /// For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/service-software.html">Service
    /// software updates in Amazon OpenSearch Service</a>.
    /// </summary>
    public partial class ServiceSoftwareOptions
    {
        /// <summary>
        /// Gets and sets the property AutomatedUpdateDate. 
        /// <para>
        /// The timestamp, in Epoch time, until which you can manually request a service software
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
        ///  True if you're able to cancel your service software version update. False if you
        /// can't cancel your service software update.
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
        /// The current service software version present on the domain.
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
        /// A description of the service software update status.
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
        /// The new service software version, if one is available.
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
        /// True if a service software is never automatically updated. False if a service software
        /// is automatically updated after the automated update date.
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
        /// True if you're able to update your service software version. False if you can't update
        /// your service software version.
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
        /// The status of your service software update.
        /// </para>
        /// </summary>
        public DeploymentStatus UpdateStatus { get; set; }

        /// <summary>
        /// Checks to see if the UpdateStatus property is set.
        /// </summary>
        internal bool IsSetUpdateStatus() => this.UpdateStatus != null;
    }
}
