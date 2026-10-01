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
    /// Provides details about an Amazon GuardDuty detector. A detector is an object that
    /// represents the GuardDuty service. A detector is required for GuardDuty to become operational.
    /// </summary>
    public partial class AwsGuardDutyDetectorDetails
    {
        /// <summary>
        /// Gets and sets the property DataSources. 
        /// <para>
        ///  Describes which data sources are activated for the detector. 
        /// </para>
        /// </summary>
        public AwsGuardDutyDetectorDataSourcesDetails DataSources { get; set; }

        /// <summary>
        /// Checks to see if the DataSources property is set.
        /// </summary>
        internal bool IsSetDataSources() => this.DataSources != null;

        /// <summary>
        /// Gets and sets the property Features. 
        /// <para>
        ///  Describes which features are activated for the detector. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsGuardDutyDetectorFeaturesDetails> Features { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsGuardDutyDetectorFeaturesDetails>() : null;

        /// <summary>
        /// Checks to see if the Features property is set.
        /// </summary>
        internal bool IsSetFeatures() => this.Features != null && (this.Features.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FindingPublishingFrequency. 
        /// <para>
        ///  The publishing frequency of the finding. 
        /// </para>
        /// </summary>
        public string FindingPublishingFrequency { get; set; }

        /// <summary>
        /// Checks to see if the FindingPublishingFrequency property is set.
        /// </summary>
        internal bool IsSetFindingPublishingFrequency() => this.FindingPublishingFrequency != null;

        /// <summary>
        /// Gets and sets the property ServiceRole. 
        /// <para>
        ///  The GuardDuty service role. 
        /// </para>
        /// </summary>
        public string ServiceRole { get; set; }

        /// <summary>
        /// Checks to see if the ServiceRole property is set.
        /// </summary>
        internal bool IsSetServiceRole() => this.ServiceRole != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The activation status of the detector. 
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
