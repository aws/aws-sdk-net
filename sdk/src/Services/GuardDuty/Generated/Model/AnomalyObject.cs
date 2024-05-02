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
    /// Contains information about the unusual anomalies.
    /// </summary>
    public partial class AnomalyObject
    {
        private Observations _observations;
        private ProfileSubtype _profileSubtype;
        private ProfileType _profileType;

        /// <summary>
        /// Gets and sets the property Observations. 
        /// <para>
        /// The recorded value.
        /// </para>
        /// </summary>
        public Observations Observations
        {
            get { return this._observations; }
            set { this._observations = value; }
        }

        // Check to see if Observations property is set
        internal bool IsSetObservations()
        {
            return this._observations != null;
        }

        /// <summary>
        /// Gets and sets the property ProfileSubtype. 
        /// <para>
        /// The frequency of the anomaly.
        /// </para>
        /// </summary>
        public ProfileSubtype ProfileSubtype
        {
            get { return this._profileSubtype; }
            set { this._profileSubtype = value; }
        }

        // Check to see if ProfileSubtype property is set
        internal bool IsSetProfileSubtype()
        {
            return this._profileSubtype != null;
        }

        /// <summary>
        /// Gets and sets the property ProfileType. 
        /// <para>
        /// The type of behavior of the profile.
        /// </para>
        /// </summary>
        public ProfileType ProfileType
        {
            get { return this._profileType; }
            set { this._profileType = value; }
        }

        // Check to see if ProfileType property is set
        internal bool IsSetProfileType()
        {
            return this._profileType != null;
        }

    }
}