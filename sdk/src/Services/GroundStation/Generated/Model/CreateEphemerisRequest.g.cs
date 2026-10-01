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

namespace Amazon.GroundStation.Model
{
    /// <summary>
    /// Container for the parameters to the CreateEphemeris operation. Create an ephemeris
    /// with your specified <a>EphemerisData</a>.
    /// </summary>
    public partial class CreateEphemerisRequest : AmazonGroundStationRequest
    {
        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Set to <c>true</c> to enable the ephemeris after validation. Set to <c>false</c> to
        /// keep it disabled.
        /// </para>
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Enabled property is set.
        /// </summary>
        internal bool IsSetEnabled() => this.Enabled.HasValue;

        /// <summary>
        /// Gets and sets the property Ephemeris. 
        /// <para>
        /// Ephemeris data.
        /// </para>
        /// </summary>
        public EphemerisData Ephemeris { get; set; }

        /// <summary>
        /// Checks to see if the Ephemeris property is set.
        /// </summary>
        internal bool IsSetEphemeris() => this.Ephemeris != null;

        /// <summary>
        /// Gets and sets the property ExpirationTime. 
        /// <para>
        /// An overall expiration time for the ephemeris in UTC, after which it will become <c>EXPIRED</c>.
        /// </para>
        /// </summary>
        public DateTime? ExpirationTime { get; set; }

        /// <summary>
        /// Checks to see if the ExpirationTime property is set.
        /// </summary>
        internal bool IsSetExpirationTime() => this.ExpirationTime.HasValue;

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The ARN of the KMS key to use for encrypting the ephemeris.
        /// </para>
        /// </summary>
        public string KmsKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyArn property is set.
        /// </summary>
        internal bool IsSetKmsKeyArn() => this.KmsKeyArn != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name that you can use to identify the ephemeris.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// A priority score that determines which ephemeris to use when multiple ephemerides
        /// overlap.
        /// </para>
        ///  
        /// <para>
        /// Higher numbers take precedence. The default is 1. Must be 1 or greater.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 99999)]
        public int? Priority { get; set; }

        /// <summary>
        /// Checks to see if the Priority property is set.
        /// </summary>
        internal bool IsSetPriority() => this.Priority.HasValue;

        /// <summary>
        /// Gets and sets the property SatelliteId. 
        /// <para>
        /// The satellite ID that associates this ephemeris with a satellite in AWS Ground Station.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string SatelliteId { get; set; }

        /// <summary>
        /// Checks to see if the SatelliteId property is set.
        /// </summary>
        internal bool IsSetSatelliteId() => this.SatelliteId != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags assigned to an ephemeris.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
