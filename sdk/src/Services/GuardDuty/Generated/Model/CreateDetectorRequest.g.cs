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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDetector operation. Creates a single GuardDuty
    /// detector. A detector is a resource that represents the GuardDuty service. To start
    /// using GuardDuty, you must create a detector in each Region where you enable the service.
    /// You can have only one detector per account per Region. All data sources are enabled
    /// in a new detector by default. <ul> <li> <para> When you don't specify any <c>features</c>,
    /// with an exception to <c>RUNTIME_MONITORING</c>, all the optional features are enabled
    /// by default. </para> </li> <li> <para> When you specify some of the <c>features</c>,
    /// any feature that is not specified in the API call gets enabled by default, with an
    /// exception to <c>RUNTIME_MONITORING</c>. </para> </li> </ul> <para> Specifying both
    /// EKS Runtime Monitoring (<c>EKS_RUNTIME_MONITORING</c>) and Runtime Monitoring (<c>RUNTIME_MONITORING</c>)
    /// will cause an error. You can add only one of these two features because Runtime Monitoring
    /// already includes the threat detection for Amazon EKS resources. For more information,
    /// see <a href="https://docs.aws.amazon.com/guardduty/latest/ug/runtime-monitoring.html">Runtime
    /// Monitoring</a>. </para> <para> There might be regional differences because some data
    /// sources might not be available in all the Amazon Web Services Regions where GuardDuty
    /// is presently supported. For more information, see <a href="https://docs.aws.amazon.com/guardduty/latest/ug/guardduty_regions.html">Regions
    /// and endpoints</a>. </para>
    /// </summary>
    public partial class CreateDetectorRequest : AmazonGuardDutyRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The idempotency token for the create request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property DataSources. 
        /// <para>
        /// Describes which data sources will be enabled for the detector.
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
        public DataSourceConfigurations DataSources { get; set; }

        /// <summary>
        /// Checks to see if the DataSources property is set.
        /// </summary>
        internal bool IsSetDataSources() => this.DataSources != null;

        /// <summary>
        /// Gets and sets the property Enable. 
        /// <para>
        /// A Boolean value that specifies whether the detector is to be enabled.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? Enable { get; set; }

        /// <summary>
        /// Checks to see if the Enable property is set.
        /// </summary>
        internal bool IsSetEnable() => this.Enable.HasValue;

        /// <summary>
        /// Gets and sets the property Features. 
        /// <para>
        /// A list of features that will be configured for the detector.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DetectorFeatureConfiguration> Features { get; set; } = AWSConfigs.InitializeCollections ? new List<DetectorFeatureConfiguration>() : null;

        /// <summary>
        /// Checks to see if the Features property is set.
        /// </summary>
        internal bool IsSetFeatures() => this.Features != null && (this.Features.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FindingPublishingFrequency. 
        /// <para>
        /// A value that specifies how frequently updated findings are exported.
        /// </para>
        /// </summary>
        public FindingPublishingFrequency FindingPublishingFrequency { get; set; }

        /// <summary>
        /// Checks to see if the FindingPublishingFrequency property is set.
        /// </summary>
        internal bool IsSetFindingPublishingFrequency() => this.FindingPublishingFrequency != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to be added to a new detector resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
