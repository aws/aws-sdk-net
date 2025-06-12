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
 * Do not modify this file. This file is generated from the pinpoint-email-2018-07-26.normal.json service model.
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
namespace Amazon.PinpointEmail.Model
{
    /// <summary>
    /// An object that contains information about email that was sent from the selected domain.
    /// </summary>
    public partial class OverallVolume
    {
        private List<DomainIspPlacement> _domainIspPlacements = AWSConfigs.InitializeCollections ? new List<DomainIspPlacement>() : null;
        private double? _readRatePercent;
        private VolumeStatistics _volumeStatistics;

        /// <summary>
        /// Gets and sets the property DomainIspPlacements. 
        /// <para>
        /// An object that contains inbox and junk mail placement metrics for individual email
        /// providers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DomainIspPlacement> DomainIspPlacements
        {
            get { return this._domainIspPlacements; }
            set { this._domainIspPlacements = value; }
        }

        // Check to see if DomainIspPlacements property is set
        internal bool IsSetDomainIspPlacements()
        {
            return this._domainIspPlacements != null && (this._domainIspPlacements.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ReadRatePercent. 
        /// <para>
        /// The percentage of emails that were sent from the domain that were read by their recipients.
        /// </para>
        /// </summary>
        public double? ReadRatePercent
        {
            get { return this._readRatePercent; }
            set { this._readRatePercent = value; }
        }

        // Check to see if ReadRatePercent property is set
        internal bool IsSetReadRatePercent()
        {
            return this._readRatePercent.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VolumeStatistics. 
        /// <para>
        /// An object that contains information about the numbers of messages that arrived in
        /// recipients' inboxes and junk mail folders.
        /// </para>
        /// </summary>
        public VolumeStatistics VolumeStatistics
        {
            get { return this._volumeStatistics; }
            set { this._volumeStatistics = value; }
        }

        // Check to see if VolumeStatistics property is set
        internal bool IsSetVolumeStatistics()
        {
            return this._volumeStatistics != null;
        }

    }
}