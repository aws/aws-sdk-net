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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a supported Region.
    /// </summary>
    public partial class SupportedRegionDetail
    {
        private string _region;
        private string _serviceState;

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Region code.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property ServiceState. 
        /// <para>
        /// The service state. The possible values are <c>Pending</c>, <c>Available</c>, <c>Deleting</c>,
        /// <c>Deleted</c>, <c>Failed</c>, and <c>Closed</c>.
        /// </para>
        /// </summary>
        public string ServiceState
        {
            get { return this._serviceState; }
            set { this._serviceState = value; }
        }

        // Check to see if ServiceState property is set
        internal bool IsSetServiceState()
        {
            return this._serviceState != null;
        }

    }
}