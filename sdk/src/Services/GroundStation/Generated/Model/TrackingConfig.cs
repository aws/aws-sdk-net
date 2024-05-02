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
    /// Object that determines whether tracking should be used during a contact executed with
    /// this <c>Config</c> in the mission profile.
    /// </summary>
    public partial class TrackingConfig
    {
        private Criticality _autotrack;

        /// <summary>
        /// Gets and sets the property Autotrack. 
        /// <para>
        /// Current setting for autotrack.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Criticality Autotrack
        {
            get { return this._autotrack; }
            set { this._autotrack = value; }
        }

        // Check to see if Autotrack property is set
        internal bool IsSetAutotrack()
        {
            return this._autotrack != null;
        }

    }
}