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
 * Do not modify this file. This file is generated from the interconnect-2022-07-26.normal.json service model.
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
namespace Amazon.Interconnect.Model
{
    /// <summary>
    /// Describes the respective AWS Interconnect Partner organization.
    /// </summary>
    public partial class Provider
    {
        private string _cloudServiceProvider;
        private string _lastMileProvider;

        /// <summary>
        /// Gets and sets the property CloudServiceProvider. 
        /// <para>
        /// The provider's name. Specifically, connections to/from this Cloud Service Provider
        /// will be considered Multicloud connections.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=32)]
        public string CloudServiceProvider
        {
            get { return this._cloudServiceProvider; }
            set { this._cloudServiceProvider = value; }
        }

        // Check to see if CloudServiceProvider property is set
        internal bool IsSetCloudServiceProvider()
        {
            return this._cloudServiceProvider != null;
        }

        /// <summary>
        /// Gets and sets the property LastMileProvider. 
        /// <para>
        /// The provider's name. Specifically, connections to/from this Last Mile Provider will
        /// be considered LastMile connections.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=32)]
        public string LastMileProvider
        {
            get { return this._lastMileProvider; }
            set { this._lastMileProvider = value; }
        }

        // Check to see if LastMileProvider property is set
        internal bool IsSetLastMileProvider()
        {
            return this._lastMileProvider != null;
        }

    }
}