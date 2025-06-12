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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.IoT.Model
{
    /// <summary>
    /// This is the response object from the UpdateSecurityProfile operation.
    /// </summary>
    public partial class UpdateSecurityProfileResponse : AmazonWebServiceResponse
    {
        private List<string> _additionalMetricsToRetain = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<MetricToRetain> _additionalMetricsToRetainV2 = AWSConfigs.InitializeCollections ? new List<MetricToRetain>() : null;
        private Dictionary<string, AlertTarget> _alertTargets = AWSConfigs.InitializeCollections ? new Dictionary<string, AlertTarget>() : null;
        private List<Behavior> _behaviors = AWSConfigs.InitializeCollections ? new List<Behavior>() : null;
        private DateTime? _creationDate;
        private DateTime? _lastModifiedDate;
        private MetricsExportConfig _metricsExportConfig;
        private string _securityProfileArn;
        private string _securityProfileDescription;
        private string _securityProfileName;
        private long? _version;

        /// <summary>
        /// Gets and sets the property AdditionalMetricsToRetain. 
        /// <para>
        ///  <i>Please use <a>UpdateSecurityProfileResponse$additionalMetricsToRetainV2</a> instead.</i>
        /// 
        /// </para>
        ///  
        /// <para>
        /// A list of metrics whose data is retained (stored). By default, data is retained for
        /// any metric used in the security profile's <c>behaviors</c>, but it is also retained
        /// for any metric specified here.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._additionalMetricsToRetain != null && (this._additionalMetricsToRetain.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AdditionalMetricsToRetainV2. 
        /// <para>
        /// A list of metrics whose data is retained (stored). By default, data is retained for
        /// any metric used in the profile's behaviors, but it is also retained for any metric
        /// specified here. Can be used with custom metrics; cannot be used with dimensions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MetricToRetain> AdditionalMetricsToRetainV2
        {
            get { return this._additionalMetricsToRetainV2; }
            set { this._additionalMetricsToRetainV2 = value; }
        }

        // Check to see if AdditionalMetricsToRetainV2 property is set
        internal bool IsSetAdditionalMetricsToRetainV2()
        {
            return this._additionalMetricsToRetainV2 != null && (this._additionalMetricsToRetainV2.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AlertTargets. 
        /// <para>
        /// Where the alerts are sent. (Alerts are always sent to the console.)
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, AlertTarget> AlertTargets
        {
            get { return this._alertTargets; }
            set { this._alertTargets = value; }
        }

        // Check to see if AlertTargets property is set
        internal bool IsSetAlertTargets()
        {
            return this._alertTargets != null && (this._alertTargets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Behaviors. 
        /// <para>
        /// Specifies the behaviors that, when violated by a device (thing), cause an alert.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._behaviors != null && (this._behaviors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The time the security profile was created.
        /// </para>
        /// </summary>
        public DateTime? CreationDate
        {
            get { return this._creationDate; }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The time the security profile was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedDate
        {
            get { return this._lastModifiedDate; }
            set { this._lastModifiedDate = value; }
        }

        // Check to see if LastModifiedDate property is set
        internal bool IsSetLastModifiedDate()
        {
            return this._lastModifiedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MetricsExportConfig. 
        /// <para>
        /// Specifies the MQTT topic and role ARN required for metric export.
        /// </para>
        /// </summary>
        public MetricsExportConfig MetricsExportConfig
        {
            get { return this._metricsExportConfig; }
            set { this._metricsExportConfig = value; }
        }

        // Check to see if MetricsExportConfig property is set
        internal bool IsSetMetricsExportConfig()
        {
            return this._metricsExportConfig != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityProfileArn. 
        /// <para>
        /// The ARN of the security profile that was updated.
        /// </para>
        /// </summary>
        public string SecurityProfileArn
        {
            get { return this._securityProfileArn; }
            set { this._securityProfileArn = value; }
        }

        // Check to see if SecurityProfileArn property is set
        internal bool IsSetSecurityProfileArn()
        {
            return this._securityProfileArn != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityProfileDescription. 
        /// <para>
        /// The description of the security profile.
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
        /// The name of the security profile that was updated.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The updated version of the security profile.
        /// </para>
        /// </summary>
        public long? Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version.HasValue; 
        }

    }
}