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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDetector operation.
    /// Updates the GuardDuty detector specified by the detector ID.
    /// 
    ///  
    /// <para>
    /// Specifying both EKS Runtime Monitoring (<c>EKS_RUNTIME_MONITORING</c>) and Runtime
    /// Monitoring (<c>RUNTIME_MONITORING</c>) will cause an error. You can add only one of
    /// these two features because Runtime Monitoring already includes the threat detection
    /// for Amazon EKS resources. For more information, see <a href="https://docs.aws.amazon.com/guardduty/latest/ug/runtime-monitoring.html">Runtime
    /// Monitoring</a>.
    /// </para>
    ///  
    /// <para>
    /// There might be regional differences because some data sources might not be available
    /// in all the Amazon Web Services Regions where GuardDuty is presently supported. For
    /// more information, see <a href="https://docs.aws.amazon.com/guardduty/latest/ug/guardduty_regions.html">Regions
    /// and endpoints</a>.
    /// </para>
    /// </summary>
    public partial class UpdateDetectorRequest : AmazonGuardDutyRequest
    {
        private DataSourceConfigurations _dataSources;
        private string _detectorId;
        private bool? _enable;
        private List<DetectorFeatureConfiguration> _features = AWSConfigs.InitializeCollections ? new List<DetectorFeatureConfiguration>() : null;
        private FindingPublishingFrequency _findingPublishingFrequency;

        /// <summary>
        /// Gets and sets the property DataSources. 
        /// <para>
        /// Describes which data sources will be updated.
        /// </para>
        ///  
        /// <para>
        /// There might be regional differences because some data sources might not be available
        /// in all the Amazon Web Services Regions where GuardDuty is presently supported. For
        /// more information, see <a href="https://docs.aws.amazon.com/guardduty/latest/ug/guardduty_regions.html">Regions
        /// and endpoints</a>.
        /// </para>
        /// </summary>
        [Obsolete("This parameter is deprecated, use Features instead")]
        public DataSourceConfigurations DataSources
        {
            get { return this._dataSources; }
            set { this._dataSources = value; }
        }

        // Check to see if DataSources property is set
        internal bool IsSetDataSources()
        {
            return this._dataSources != null;
        }

        /// <summary>
        /// Gets and sets the property DetectorId. 
        /// <para>
        /// The unique ID of the detector to update.
        /// </para>
        ///  
        /// <para>
        /// To find the <c>detectorId</c> in the current Region, see the Settings page in the
        /// GuardDuty console, or run the <a href="https://docs.aws.amazon.com/guardduty/latest/APIReference/API_ListDetectors.html">ListDetectors</a>
        /// API.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=300)]
        public string DetectorId
        {
            get { return this._detectorId; }
            set { this._detectorId = value; }
        }

        // Check to see if DetectorId property is set
        internal bool IsSetDetectorId()
        {
            return this._detectorId != null;
        }

        /// <summary>
        /// Gets and sets the property Enable. 
        /// <para>
        /// Specifies whether the detector is enabled or not enabled.
        /// </para>
        /// </summary>
        public bool? Enable
        {
            get { return this._enable; }
            set { this._enable = value; }
        }

        // Check to see if Enable property is set
        internal bool IsSetEnable()
        {
            return this._enable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Features. 
        /// <para>
        /// Provides the features that will be updated for the detector.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DetectorFeatureConfiguration> Features
        {
            get { return this._features; }
            set { this._features = value; }
        }

        // Check to see if Features property is set
        internal bool IsSetFeatures()
        {
            return this._features != null && (this._features.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FindingPublishingFrequency. 
        /// <para>
        /// An enum value that specifies how frequently findings are exported, such as to CloudWatch
        /// Events.
        /// </para>
        /// </summary>
        public FindingPublishingFrequency FindingPublishingFrequency
        {
            get { return this._findingPublishingFrequency; }
            set { this._findingPublishingFrequency = value; }
        }

        // Check to see if FindingPublishingFrequency property is set
        internal bool IsSetFindingPublishingFrequency()
        {
            return this._findingPublishingFrequency != null;
        }

    }
}