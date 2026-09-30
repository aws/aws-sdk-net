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

namespace Amazon.GreengrassV2.Model
{
    /// <summary>
    /// Contains information about a component on a Greengrass core device.
    /// </summary>
    public partial class InstalledComponent
    {
        /// <summary>
        /// Gets and sets the property ComponentName. 
        /// <para>
        /// The name of the component.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ComponentName { get; set; }

        /// <summary>
        /// Checks to see if the ComponentName property is set.
        /// </summary>
        internal bool IsSetComponentName() => this.ComponentName != null;

        /// <summary>
        /// Gets and sets the property ComponentVersion. 
        /// <para>
        /// The version of the component.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ComponentVersion { get; set; }

        /// <summary>
        /// Checks to see if the ComponentVersion property is set.
        /// </summary>
        internal bool IsSetComponentVersion() => this.ComponentVersion != null;

        /// <summary>
        /// Gets and sets the property IsRoot. 
        /// <para>
        /// Whether or not the component is a root component.
        /// </para>
        /// </summary>
        public bool? IsRoot { get; set; }

        /// <summary>
        /// Checks to see if the IsRoot property is set.
        /// </summary>
        internal bool IsSetIsRoot() => this.IsRoot.HasValue;

        /// <summary>
        /// Gets and sets the property LastInstallationSource. 
        /// <para>
        /// The most recent deployment source that brought the component to the Greengrass core
        /// device. For a thing group deployment or thing deployment, the source will be the ID
        /// of the last deployment that contained the component. For local deployments it will
        /// be <c>LOCAL</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Any deployment will attempt to reinstall currently broken components on the device,
        /// which will update the last installation source.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string LastInstallationSource { get; set; }

        /// <summary>
        /// Checks to see if the LastInstallationSource property is set.
        /// </summary>
        internal bool IsSetLastInstallationSource() => this.LastInstallationSource != null;

        /// <summary>
        /// Gets and sets the property LastReportedTimestamp. 
        /// <para>
        /// The last time the Greengrass core device sent a message containing a component's state
        /// to the Amazon Web Services Cloud.
        /// </para>
        ///  
        /// <para>
        /// A component does not need to see a state change for this field to update.
        /// </para>
        /// </summary>
        public DateTime? LastReportedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the LastReportedTimestamp property is set.
        /// </summary>
        internal bool IsSetLastReportedTimestamp() => this.LastReportedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property LastStatusChangeTimestamp. 
        /// <para>
        /// The status of how current the data is.
        /// </para>
        ///  
        /// <para>
        /// This response is based off of component state changes. The status reflects component
        /// disruptions and deployments. If a component only sees a configuration update during
        /// a deployment, it might not undergo a state change and this status would not be updated.
        /// </para>
        /// </summary>
        public DateTime? LastStatusChangeTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the LastStatusChangeTimestamp property is set.
        /// </summary>
        internal bool IsSetLastStatusChangeTimestamp() => this.LastStatusChangeTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property LifecycleState. 
        /// <para>
        /// The lifecycle state of the component.
        /// </para>
        /// </summary>
        public InstalledComponentLifecycleState LifecycleState { get; set; }

        /// <summary>
        /// Checks to see if the LifecycleState property is set.
        /// </summary>
        internal bool IsSetLifecycleState() => this.LifecycleState != null;

        /// <summary>
        /// Gets and sets the property LifecycleStateDetails. 
        /// <para>
        /// A detailed response about the lifecycle state of the component that explains the reason
        /// why a component has an error or is broken.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public string LifecycleStateDetails { get; set; }

        /// <summary>
        /// Checks to see if the LifecycleStateDetails property is set.
        /// </summary>
        internal bool IsSetLifecycleStateDetails() => this.LifecycleStateDetails != null;

        /// <summary>
        /// Gets and sets the property LifecycleStatusCodes. 
        /// <para>
        /// The status codes that indicate the reason for failure whenever the <c>lifecycleState</c>
        /// has an error or is in a broken state.
        /// </para>
        ///  <note> 
        /// <para>
        /// Greengrass nucleus v2.8.0 or later is required to get an accurate <c>lifecycleStatusCodes</c>
        /// response. This response can be inaccurate in earlier Greengrass nucleus versions.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> LifecycleStatusCodes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the LifecycleStatusCodes property is set.
        /// </summary>
        internal bool IsSetLifecycleStatusCodes() => this.LifecycleStatusCodes != null && (this.LifecycleStatusCodes.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
