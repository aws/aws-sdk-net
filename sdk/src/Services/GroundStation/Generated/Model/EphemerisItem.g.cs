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
    /// Ephemeris item.
    /// </summary>
    public partial class EphemerisItem
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time the ephemeris was uploaded in UTC.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Whether or not the ephemeris is enabled.
        /// </para>
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Enabled property is set.
        /// </summary>
        internal bool IsSetEnabled() => this.Enabled.HasValue;

        /// <summary>
        /// Gets and sets the property EphemerisId. 
        /// <para>
        /// The AWS Ground Station ephemeris ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string EphemerisId { get; set; }

        /// <summary>
        /// Checks to see if the EphemerisId property is set.
        /// </summary>
        internal bool IsSetEphemerisId() => this.EphemerisId != null;

        /// <summary>
        /// Gets and sets the property EphemerisType. 
        /// <para>
        /// The type of ephemeris.
        /// </para>
        /// </summary>
        public EphemerisType EphemerisType { get; set; }

        /// <summary>
        /// Checks to see if the EphemerisType property is set.
        /// </summary>
        internal bool IsSetEphemerisType() => this.EphemerisType != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name that you can use to identify the ephemeris.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
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
        [AWSProperty(Min = 0, Max = 99999)]
        public int? Priority { get; set; }

        /// <summary>
        /// Checks to see if the Priority property is set.
        /// </summary>
        internal bool IsSetPriority() => this.Priority.HasValue;

        /// <summary>
        /// Gets and sets the property SourceS3Object. 
        /// <para>
        /// Source Amazon S3 object used for the ephemeris.
        /// </para>
        /// </summary>
        public S3Object SourceS3Object { get; set; }

        /// <summary>
        /// Checks to see if the SourceS3Object property is set.
        /// </summary>
        internal bool IsSetSourceS3Object() => this.SourceS3Object != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the ephemeris.
        /// </para>
        /// </summary>
        public EphemerisStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
