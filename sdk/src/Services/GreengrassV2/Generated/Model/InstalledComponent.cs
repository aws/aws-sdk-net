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
 * Do not modify this file. This file is generated from the greengrassv2-2020-11-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GreengrassV2.Model
{
    /// <summary>
    /// Contains information about a component on a Greengrass core device.
    /// </summary>
    public partial class InstalledComponent
    {
        private string _componentName;
        private string _componentVersion;
        private bool? _isRoot;
        private string _lastInstallationSource;
        private DateTime? _lastReportedTimestamp;
        private DateTime? _lastStatusChangeTimestamp;
        private InstalledComponentLifecycleState _lifecycleState;
        private string _lifecycleStateDetails;
        private List<string> _lifecycleStatusCodes = new List<string>();

        /// <summary>
        /// Gets and sets the property ComponentName. 
        /// <para>
        /// The name of the component.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ComponentName
        {
            get { return this._componentName; }
            set { this._componentName = value; }
        }

        // Check to see if ComponentName property is set
        internal bool IsSetComponentName()
        {
            return this._componentName != null;
        }

        /// <summary>
        /// Gets and sets the property ComponentVersion. 
        /// <para>
        /// The version of the component.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ComponentVersion
        {
            get { return this._componentVersion; }
            set { this._componentVersion = value; }
        }

        // Check to see if ComponentVersion property is set
        internal bool IsSetComponentVersion()
        {
            return this._componentVersion != null;
        }

        /// <summary>
        /// Gets and sets the property IsRoot. 
        /// <para>
        /// Whether or not the component is a root component.
        /// </para>
        /// </summary>
        public bool IsRoot
        {
            get { return this._isRoot.GetValueOrDefault(); }
            set { this._isRoot = value; }
        }

        // Check to see if IsRoot property is set
        internal bool IsSetIsRoot()
        {
            return this._isRoot.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastInstallationSource. 
        /// <para>
        /// The most recent deployment source that brought the component to the Greengrass core
        /// device. For a thing group deployment or thing deployment, the source will be the The
        /// ID of the deployment. and for local deployments it will be <code>LOCAL</code>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Any deployment will attempt to reinstall currently broken components on the device,
        /// which will update the last installation source.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1)]
        public string LastInstallationSource
        {
            get { return this._lastInstallationSource; }
            set { this._lastInstallationSource = value; }
        }

        // Check to see if LastInstallationSource property is set
        internal bool IsSetLastInstallationSource()
        {
            return this._lastInstallationSource != null;
        }

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
        public DateTime LastReportedTimestamp
        {
            get { return this._lastReportedTimestamp.GetValueOrDefault(); }
            set { this._lastReportedTimestamp = value; }
        }

        // Check to see if LastReportedTimestamp property is set
        internal bool IsSetLastReportedTimestamp()
        {
            return this._lastReportedTimestamp.HasValue; 
        }

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
        public DateTime LastStatusChangeTimestamp
        {
            get { return this._lastStatusChangeTimestamp.GetValueOrDefault(); }
            set { this._lastStatusChangeTimestamp = value; }
        }

        // Check to see if LastStatusChangeTimestamp property is set
        internal bool IsSetLastStatusChangeTimestamp()
        {
            return this._lastStatusChangeTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LifecycleState. 
        /// <para>
        /// The lifecycle state of the component.
        /// </para>
        /// </summary>
        public InstalledComponentLifecycleState LifecycleState
        {
            get { return this._lifecycleState; }
            set { this._lifecycleState = value; }
        }

        // Check to see if LifecycleState property is set
        internal bool IsSetLifecycleState()
        {
            return this._lifecycleState != null;
        }

        /// <summary>
        /// Gets and sets the property LifecycleStateDetails. 
        /// <para>
        /// A detailed response about the lifecycle state of the component that explains the reason
        /// why a component has an error or is broken.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public string LifecycleStateDetails
        {
            get { return this._lifecycleStateDetails; }
            set { this._lifecycleStateDetails = value; }
        }

        // Check to see if LifecycleStateDetails property is set
        internal bool IsSetLifecycleStateDetails()
        {
            return this._lifecycleStateDetails != null;
        }

        /// <summary>
        /// Gets and sets the property LifecycleStatusCodes. 
        /// <para>
        /// The status codes that indicate the reason for failure whenever the <code>lifecycleState</code>
        /// has an error or is in a broken state.
        /// </para>
        ///  <note> 
        /// <para>
        /// Greengrass nucleus v2.8.0 or later is required to get an accurate <code>lifecycleStatusCodes</code>
        /// response. This response can be inaccurate in earlier Greengrass nucleus versions.
        /// </para>
        ///  </note>
        /// </summary>
        public List<string> LifecycleStatusCodes
        {
            get { return this._lifecycleStatusCodes; }
            set { this._lifecycleStatusCodes = value; }
        }

        // Check to see if LifecycleStatusCodes property is set
        internal bool IsSetLifecycleStatusCodes()
        {
            return this._lifecycleStatusCodes != null && this._lifecycleStatusCodes.Count > 0; 
        }

    }
}