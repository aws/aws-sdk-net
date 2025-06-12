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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
        private AwsGuardDutyDetectorDataSourcesDetails _dataSources;
        private List<AwsGuardDutyDetectorFeaturesDetails> _features = AWSConfigs.InitializeCollections ? new List<AwsGuardDutyDetectorFeaturesDetails>() : null;
        private string _findingPublishingFrequency;
        private string _serviceRole;
        private string _status;

        /// <summary>
        /// Gets and sets the property DataSources. 
        /// <para>
        ///  Describes which data sources are activated for the detector. 
        /// </para>
        /// </summary>
        public AwsGuardDutyDetectorDataSourcesDetails DataSources
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
        /// Gets and sets the property Features. 
        /// <para>
        ///  Describes which features are activated for the detector. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsGuardDutyDetectorFeaturesDetails> Features
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
        ///  The publishing frequency of the finding. 
        /// </para>
        /// </summary>
        public string FindingPublishingFrequency
        {
            get { return this._findingPublishingFrequency; }
            set { this._findingPublishingFrequency = value; }
        }

        // Check to see if FindingPublishingFrequency property is set
        internal bool IsSetFindingPublishingFrequency()
        {
            return this._findingPublishingFrequency != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceRole. 
        /// <para>
        ///  The GuardDuty service role. 
        /// </para>
        /// </summary>
        public string ServiceRole
        {
            get { return this._serviceRole; }
            set { this._serviceRole = value; }
        }

        // Check to see if ServiceRole property is set
        internal bool IsSetServiceRole()
        {
            return this._serviceRole != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The activation status of the detector. 
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}