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
    /// Ephemeris item.
    /// </summary>
    public partial class EphemerisItem
    {
        private DateTime? _creationTime;
        private bool? _enabled;
        private string _ephemerisId;
        private string _name;
        private int? _priority;
        private S3Object _sources3Object;
        private EphemerisStatus _status;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time the ephemeris was uploaded in UTC.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Whether or not the ephemeris is enabled.
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
        /// Gets and sets the property EphemerisId. 
        /// <para>
        /// The AWS Ground Station ephemeris ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string EphemerisId
        {
            get { return this._ephemerisId; }
            set { this._ephemerisId = value; }
        }

        // Check to see if EphemerisId property is set
        internal bool IsSetEphemerisId()
        {
            return this._ephemerisId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name string associated with the ephemeris. Used as a human-readable identifier for
        /// the ephemeris.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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
        [AWSProperty(Min=0, Max=99999)]
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
        /// Gets and sets the property SourceS3Object. 
        /// <para>
        /// Source S3 object used for the ephemeris.
        /// </para>
        /// </summary>
        public S3Object SourceS3Object
        {
            get { return this._sources3Object; }
            set { this._sources3Object = value; }
        }

        // Check to see if SourceS3Object property is set
        internal bool IsSetSourceS3Object()
        {
            return this._sources3Object != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the ephemeris.
        /// </para>
        /// </summary>
        public EphemerisStatus Status
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