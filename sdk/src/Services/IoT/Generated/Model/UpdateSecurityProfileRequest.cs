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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateSecurityProfile operation.
    /// Updates a Device Defender security profile.
    /// </summary>
    public partial class UpdateSecurityProfileRequest : AmazonIoTRequest
    {
        private List<string> _additionalMetricsToRetain = new List<string>();
        private List<MetricToRetain> _additionalMetricsToRetainV2 = new List<MetricToRetain>();
        private Dictionary<string, AlertTarget> _alertTargets = new Dictionary<string, AlertTarget>();
        private List<Behavior> _behaviors = new List<Behavior>();
        private bool? _deleteAdditionalMetricsToRetain;
        private bool? _deleteAlertTargets;
        private bool? _deleteBehaviors;
        private long? _expectedVersion;
        private string _securityProfileDescription;
        private string _securityProfileName;

        /// <summary>
        /// Gets and sets the property AdditionalMetricsToRetain. 
        /// <para>
        ///  <i>Please use <a>UpdateSecurityProfileRequest$additionalMetricsToRetainV2</a> instead.</i>
        /// 
        /// </para>
        ///  
        /// <para>
        /// A list of metrics whose data is retained (stored). By default, data is retained for
        /// any metric used in the profile's <code>behaviors</code>, but it is also retained for
        /// any metric specified here. Can be used with custom metrics; cannot be used with dimensions.
        /// </para>
        /// </summary>
        [Obsolete("Use additionalMetricsToRetainV2.")]
        public List<string> AdditionalMetricsToRetain
        {
            get { return this._additionalMetricsToRetain; }
            set { this._additionalMetricsToRetain = value; }
        }

        // Check to see if AdditionalMetricsToRetain property is set
        internal bool IsSetAdditionalMetricsToRetain()
        {
            return this._additionalMetricsToRetain != null && this._additionalMetricsToRetain.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AdditionalMetricsToRetainV2. 
        /// <para>
        /// A list of metrics whose data is retained (stored). By default, data is retained for
        /// any metric used in the profile's behaviors, but it is also retained for any metric
        /// specified here. Can be used with custom metrics; cannot be used with dimensions.
        /// </para>
        /// </summary>
        public List<MetricToRetain> AdditionalMetricsToRetainV2
        {
            get { return this._additionalMetricsToRetainV2; }
            set { this._additionalMetricsToRetainV2 = value; }
        }

        // Check to see if AdditionalMetricsToRetainV2 property is set
        internal bool IsSetAdditionalMetricsToRetainV2()
        {
            return this._additionalMetricsToRetainV2 != null && this._additionalMetricsToRetainV2.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AlertTargets. 
        /// <para>
        /// Where the alerts are sent. (Alerts are always sent to the console.)
        /// </para>
        /// </summary>
        public Dictionary<string, AlertTarget> AlertTargets
        {
            get { return this._alertTargets; }
            set { this._alertTargets = value; }
        }

        // Check to see if AlertTargets property is set
        internal bool IsSetAlertTargets()
        {
            return this._alertTargets != null && this._alertTargets.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Behaviors. 
        /// <para>
        /// Specifies the behaviors that, when violated by a device (thing), cause an alert.
        /// </para>
        /// </summary>
        [AWSProperty(Max=100)]
        public List<Behavior> Behaviors
        {
            get { return this._behaviors; }
            set { this._behaviors = value; }
        }

        // Check to see if Behaviors property is set
        internal bool IsSetBehaviors()
        {
            return this._behaviors != null && this._behaviors.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DeleteAdditionalMetricsToRetain. 
        /// <para>
        /// If true, delete all <code>additionalMetricsToRetain</code> defined for this security
        /// profile. If any <code>additionalMetricsToRetain</code> are defined in the current
        /// invocation, an exception occurs.
        /// </para>
        /// </summary>
        public bool DeleteAdditionalMetricsToRetain
        {
            get { return this._deleteAdditionalMetricsToRetain.GetValueOrDefault(); }
            set { this._deleteAdditionalMetricsToRetain = value; }
        }

        // Check to see if DeleteAdditionalMetricsToRetain property is set
        internal bool IsSetDeleteAdditionalMetricsToRetain()
        {
            return this._deleteAdditionalMetricsToRetain.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeleteAlertTargets. 
        /// <para>
        /// If true, delete all <code>alertTargets</code> defined for this security profile. If
        /// any <code>alertTargets</code> are defined in the current invocation, an exception
        /// occurs.
        /// </para>
        /// </summary>
        public bool DeleteAlertTargets
        {
            get { return this._deleteAlertTargets.GetValueOrDefault(); }
            set { this._deleteAlertTargets = value; }
        }

        // Check to see if DeleteAlertTargets property is set
        internal bool IsSetDeleteAlertTargets()
        {
            return this._deleteAlertTargets.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeleteBehaviors. 
        /// <para>
        /// If true, delete all <code>behaviors</code> defined for this security profile. If any
        /// <code>behaviors</code> are defined in the current invocation, an exception occurs.
        /// </para>
        /// </summary>
        public bool DeleteBehaviors
        {
            get { return this._deleteBehaviors.GetValueOrDefault(); }
            set { this._deleteBehaviors = value; }
        }

        // Check to see if DeleteBehaviors property is set
        internal bool IsSetDeleteBehaviors()
        {
            return this._deleteBehaviors.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExpectedVersion. 
        /// <para>
        /// The expected version of the security profile. A new version is generated whenever
        /// the security profile is updated. If you specify a value that is different from the
        /// actual version, a <code>VersionConflictException</code> is thrown.
        /// </para>
        /// </summary>
        public long ExpectedVersion
        {
            get { return this._expectedVersion.GetValueOrDefault(); }
            set { this._expectedVersion = value; }
        }

        // Check to see if ExpectedVersion property is set
        internal bool IsSetExpectedVersion()
        {
            return this._expectedVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SecurityProfileDescription. 
        /// <para>
        /// A description of the security profile.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1000)]
        public string SecurityProfileDescription
        {
            get { return this._securityProfileDescription; }
            set { this._securityProfileDescription = value; }
        }

        // Check to see if SecurityProfileDescription property is set
        internal bool IsSetSecurityProfileDescription()
        {
            return this._securityProfileDescription != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityProfileName. 
        /// <para>
        /// The name of the security profile you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string SecurityProfileName
        {
            get { return this._securityProfileName; }
            set { this._securityProfileName = value; }
        }

        // Check to see if SecurityProfileName property is set
        internal bool IsSetSecurityProfileName()
        {
            return this._securityProfileName != null;
        }

    }
}