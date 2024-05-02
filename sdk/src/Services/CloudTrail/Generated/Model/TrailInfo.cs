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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
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
namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// Information about a CloudTrail trail, including the trail's name, home Region, and
    /// Amazon Resource Name (ARN).
    /// </summary>
    public partial class TrailInfo
    {
        private string _homeRegion;
        private string _name;
        private string _trailARN;

        /// <summary>
        /// Gets and sets the property HomeRegion. 
        /// <para>
        /// The Amazon Web Services Region in which a trail was created.
        /// </para>
        /// </summary>
        public string HomeRegion
        {
            get { return this._homeRegion; }
            set { this._homeRegion = value; }
        }

        // Check to see if HomeRegion property is set
        internal bool IsSetHomeRegion()
        {
            return this._homeRegion != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of a trail.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property TrailARN. 
        /// <para>
        /// The ARN of a trail.
        /// </para>
        /// </summary>
        public string TrailARN
        {
            get { return this._trailARN; }
            set { this._trailARN = value; }
        }

        // Check to see if TrailARN property is set
        internal bool IsSetTrailARN()
        {
            return this._trailARN != null;
        }

    }
}