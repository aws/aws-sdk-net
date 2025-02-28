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

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Linq;

using Amazon.Runtime;
using Amazon.Runtime.Internal;
using System.Collections;
using static Amazon.EC2.Internal.AmazonEC2PreMarshallHandler;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a security group rule.
    /// </summary>
    public partial class IpPermission
    {
        private Dictionary<string, IpRange> _internalIpRangesCollection = new Dictionary<string, IpRange>();
        private bool _clearIpv4Ranges = false;
        private List<IpRange> _preIpv4Ranges = new List<IpRange>();

        /// <summary>
        /// Internal property to store the original Ipv4Range values, before they are overwritten. 
        /// The Ipv4Ranges property is overwritten when the customer is using the deprected IpRanges property.
        /// </summary>
        internal List<IpRange> PreIpv4Ranges
        {
            get { return _preIpv4Ranges; }
            set { _preIpv4Ranges = value; }
        }

        /// <summary>
        /// This method is used when the customer is using the Ipv4Ranges property to make the request.
        /// The internal dictionary collection is updated to latest values in the Ipv4Ranges property.
        /// </summary>
        /// <param name="list"></param>
        internal void SelectIpV4RangeForMarshalling(List<IpRange> list)
        {
            CopyIpv4RangesToInternalCollection(list);

            this.RestoreOldIpV4Range = false;
        }

        /// <summary>
        /// This method is used to copy the IpRange on the Ipv4Ranges collection to the internal dictionary collection.
        /// </summary>
        /// <param name="list"></param>
        internal void CopyIpv4RangesToInternalCollection(List<IpRange> list)
        {
            _internalIpRangesCollection = new Dictionary<string, IpRange>();
            foreach (var ipv4Range in list)
            {
                _internalIpRangesCollection.Add(ipv4Range.CidrIp, new IpRange { CidrIp = ipv4Range.CidrIp, Description = ipv4Range.Description });
            }
        }

        /// <summary>
        /// Flag to indicate if Ipv4Ranges property has been overwritten.
        /// This property will be used to restore the Ipv4Ranges to its original value,
        /// in the response object.
        /// </summary>
        internal bool RestoreOldIpV4Range
        {
            get { return _clearIpv4Ranges; }
            set { _clearIpv4Ranges = value; }
        }
    }
}