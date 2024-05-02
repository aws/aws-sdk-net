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
 * Do not modify this file. This file is generated from the keyspaces-2022-02-10.normal.json service model.
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
namespace Amazon.Keyspaces.Model
{
    /// <summary>
    /// The auto scaling settings of a multi-Region table in the specified Amazon Web Services
    /// Region.
    /// </summary>
    public partial class ReplicaAutoScalingSpecification
    {
        private AutoScalingSpecification _autoScalingSpecification;
        private string _region;

        /// <summary>
        /// Gets and sets the property AutoScalingSpecification. 
        /// <para>
        /// The auto scaling settings for a multi-Region table in the specified Amazon Web Services
        /// Region.
        /// </para>
        /// </summary>
        public AutoScalingSpecification AutoScalingSpecification
        {
            get { return this._autoScalingSpecification; }
            set { this._autoScalingSpecification = value; }
        }

        // Check to see if AutoScalingSpecification property is set
        internal bool IsSetAutoScalingSpecification()
        {
            return this._autoScalingSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Amazon Web Services Region.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=25)]
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

    }
}