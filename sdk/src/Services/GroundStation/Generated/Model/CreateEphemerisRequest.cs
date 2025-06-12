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
 * Do not modify this file. This file is generated from the groundstation-2019-05-23.normal.json service model.
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
    /// Container for the parameters to the CreateEphemeris operation.
    /// Creates an Ephemeris with the specified <c>EphemerisData</c>.
    /// </summary>
    public partial class CreateEphemerisRequest : AmazonGroundStationRequest
    {
        private bool? _enabled;
        private EphemerisData _ephemeris;
        private DateTime? _expirationTime;
        private string _kmsKeyArn;
        private string _name;
        private int? _priority;
        private string _satelliteId;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Whether to set the ephemeris status to <c>ENABLED</c> after validation.
        /// </para>
        ///  
        /// <para>
        /// Setting this to false will set the ephemeris status to <c>DISABLED</c> after validation.
        /// </para>
        /// </summary>
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Ephemeris. 
        /// <para>
        /// Ephemeris data.
        /// </para>
        /// </summary>
        public EphemerisData Ephemeris
        {
            get { return this._ephemeris; }
            set { this._ephemeris = value; }
        }

        // Check to see if Ephemeris property is set
        internal bool IsSetEphemeris()
        {
            return this._ephemeris != null;
        }

        /// <summary>
        /// Gets and sets the property ExpirationTime. 
        /// <para>
        /// An overall expiration time for the ephemeris in UTC, after which it will become <c>EXPIRED</c>.
        /// </para>
        /// </summary>
        public DateTime? ExpirationTime
        {
            get { return this._expirationTime; }
            set { this._expirationTime = value; }
        }

        // Check to see if ExpirationTime property is set
        internal bool IsSetExpirationTime()
        {
            return this._expirationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The ARN of a KMS key used to encrypt the ephemeris in Ground Station.
        /// </para>
        /// </summary>
        public string KmsKeyArn
        {
            get { return this._kmsKeyArn; }
            set { this._kmsKeyArn = value; }
        }

        // Check to see if KmsKeyArn property is set
        internal bool IsSetKmsKeyArn()
        {
            return this._kmsKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name string associated with the ephemeris. Used as a human-readable identifier for
        /// the ephemeris.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// Customer-provided priority score to establish the order in which overlapping ephemerides
        /// should be used.
        /// </para>
        ///  
        /// <para>
        /// The default for customer-provided ephemeris priority is 1, and higher numbers take
        /// precedence.
        /// </para>
        ///  
        /// <para>
        /// Priority must be 1 or greater
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=99999)]
        public int? Priority
        {
            get { return this._priority; }
            set { this._priority = value; }
        }

        // Check to see if Priority property is set
        internal bool IsSetPriority()
        {
            return this._priority.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SatelliteId. 
        /// <para>
        /// AWS Ground Station satellite ID for this ephemeris.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string SatelliteId
        {
            get { return this._satelliteId; }
            set { this._satelliteId = value; }
        }

        // Check to see if SatelliteId property is set
        internal bool IsSetSatelliteId()
        {
            return this._satelliteId != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags assigned to an ephemeris.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}