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
    /// Describes a set of filters for a path analysis. Use path filters to scope the analysis
    /// when there can be multiple resulting paths.
    /// </summary>
    public partial class PathFilter
    {
        private string _destinationAddress;
        private FilterPortRange _destinationPortRange;
        private string _sourceAddress;
        private FilterPortRange _sourcePortRange;

        /// <summary>
        /// Gets and sets the property DestinationAddress. 
        /// <para>
        /// The destination IPv4 address.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=15)]
        public string DestinationAddress
        {
            get { return this._destinationAddress; }
            set { this._destinationAddress = value; }
        }

        // Check to see if DestinationAddress property is set
        internal bool IsSetDestinationAddress()
        {
            return this._destinationAddress != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationPortRange. 
        /// <para>
        /// The destination port range.
        /// </para>
        /// </summary>
        public FilterPortRange DestinationPortRange
        {
            get { return this._destinationPortRange; }
            set { this._destinationPortRange = value; }
        }

        // Check to see if DestinationPortRange property is set
        internal bool IsSetDestinationPortRange()
        {
            return this._destinationPortRange != null;
        }

        /// <summary>
        /// Gets and sets the property SourceAddress. 
        /// <para>
        /// The source IPv4 address.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=15)]
        public string SourceAddress
        {
            get { return this._sourceAddress; }
            set { this._sourceAddress = value; }
        }

        // Check to see if SourceAddress property is set
        internal bool IsSetSourceAddress()
        {
            return this._sourceAddress != null;
        }

        /// <summary>
        /// Gets and sets the property SourcePortRange. 
        /// <para>
        /// The source port range.
        /// </para>
        /// </summary>
        public FilterPortRange SourcePortRange
        {
            get { return this._sourcePortRange; }
            set { this._sourcePortRange = value; }
        }

        // Check to see if SourcePortRange property is set
        internal bool IsSetSourcePortRange()
        {
            return this._sourcePortRange != null;
        }

    }
}