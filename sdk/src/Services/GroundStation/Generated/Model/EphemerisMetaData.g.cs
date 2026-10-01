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
    /// Metadata describing a particular ephemeris.
    /// </summary>
    public partial class EphemerisMetaData
    {
        /// <summary>
        /// Gets and sets the property EphemerisId. 
        /// <para>
        /// UUID of a customer-provided ephemeris.
        /// </para>
        ///  
        /// <para>
        /// This field is not populated for default ephemerides from Space Track.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string EphemerisId { get; set; }

        /// <summary>
        /// Checks to see if the EphemerisId property is set.
        /// </summary>
        internal bool IsSetEphemerisId() => this.EphemerisId != null;

        /// <summary>
        /// Gets and sets the property Epoch. 
        /// <para>
        /// The epoch of a default, ephemeris from Space Track in UTC.
        /// </para>
        ///  
        /// <para>
        /// This field is not populated for customer-provided ephemerides.
        /// </para>
        /// </summary>
        public DateTime? Epoch { get; set; }

        /// <summary>
        /// Checks to see if the Epoch property is set.
        /// </summary>
        internal bool IsSetEpoch() => this.Epoch.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name string associated with the ephemeris. Used as a human-readable identifier for
        /// the ephemeris.
        /// </para>
        ///  
        /// <para>
        /// A name is only returned for customer-provider ephemerides that have a name associated.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The <c>EphemerisSource</c> that generated a given ephemeris.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EphemerisSource Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;
    }
}
