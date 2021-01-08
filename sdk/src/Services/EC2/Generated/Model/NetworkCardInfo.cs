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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes the network card support of the instance type.
    /// </summary>
    public partial class NetworkCardInfo
    {
        private int? _maximumNetworkInterfaces;
        private int? _networkCardIndex;
        private string _networkPerformance;

        /// <summary>
        /// Gets and sets the property MaximumNetworkInterfaces. 
        /// <para>
        /// The maximum number of network interfaces for the network card.
        /// </para>
        /// </summary>
        public int MaximumNetworkInterfaces
        {
            get { return this._maximumNetworkInterfaces.GetValueOrDefault(); }
            set { this._maximumNetworkInterfaces = value; }
        }

        // Check to see if MaximumNetworkInterfaces property is set
        internal bool IsSetMaximumNetworkInterfaces()
        {
            return this._maximumNetworkInterfaces.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NetworkCardIndex. 
        /// <para>
        /// The index of the network card.
        /// </para>
        /// </summary>
        public int NetworkCardIndex
        {
            get { return this._networkCardIndex.GetValueOrDefault(); }
            set { this._networkCardIndex = value; }
        }

        // Check to see if NetworkCardIndex property is set
        internal bool IsSetNetworkCardIndex()
        {
            return this._networkCardIndex.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NetworkPerformance. 
        /// <para>
        /// The network performance of the network card.
        /// </para>
        /// </summary>
        public string NetworkPerformance
        {
            get { return this._networkPerformance; }
            set { this._networkPerformance = value; }
        }

        // Check to see if NetworkPerformance property is set
        internal bool IsSetNetworkPerformance()
        {
            return this._networkPerformance != null;
        }

    }
}