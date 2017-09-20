/*
 * Copyright 2010-2017 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
        private List<string> _ipRanges = new List<string>();
        private Dictionary<string, IpRange> _internalIpRangesCollection = new Dictionary<string, IpRange>();
        private bool _clearIpv4Ranges = false;
        private List<IpRange> _preIpv4Ranges = new List<IpRange>();
        /// <summary>
        /// Gets and sets the property IpRanges. 
        /// <para>
        /// One or more IPv4 ranges.
        /// </para>
        /// </summary>
        [Obsolete("Deprecated in favor of Ipv4Ranges. Setting this property instead of Ipv4Ranges for UpdateSecurityGroupRuleDescriptionsIngressRequest results in no change in the CidrIp's description. An argument exception is thrown if both IpRanges and Ipv4Ranges properties are set in the IpPermission request object.")]
        public List<string> IpRanges
        {
            get { return this._ipRanges; }
            set { this._ipRanges = value; }
        }

        // Check to see if IpRanges property is set
        internal bool IsSetIpRanges()
        {
            return this._ipRanges != null && this._ipRanges.Count > 0;
        }

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
        /// This method decides which of IpRanges/Ipv4Ranges property values will be used to make the request.
        /// If both IpRanges and Ipv4Ranges are set with the same Cidr values, Ipv4Range property is selected. 
        /// If no modifications have been made on either of IpRanges Ipv4ranges properties, Ipv4Ranges property is selected.
        /// If both IpRanges and Ipv4Ranges are set differently, an ArgumentException is thrown.
        /// </summary>
        /// <returns></returns>
        internal IpRangeValue CanModify()
        {
            List<string> ipv4Ranges = this._ipv4Ranges.Select(p => p.CidrIp).ToList();
            var equallyModified = !(ipv4Ranges.Except(this.IpRanges).ToList().Any() || this.IpRanges.Except(ipv4Ranges).ToList().Any());

            if (equallyModified)
                return IpRangeValue.Ipv4Ranges;

            List<string> internalRanges = this._internalIpRangesCollection.Select(p => p.Value.CidrIp).ToList();

            var ipRangeModified = internalRanges.Except(this.IpRanges).ToList().Any() || this.IpRanges.Except(internalRanges).ToList().Any();
            var iv4RangeModified = internalRanges.Except(ipv4Ranges).ToList().Any() || ipv4Ranges.Except(internalRanges).ToList().Any();
            
            if (ipRangeModified && iv4RangeModified)
                return IpRangeValue.Invalid;
            else if (ipRangeModified)
                return IpRangeValue.IpRanges;
            else
                return IpRangeValue.Ipv4Ranges;
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
        /// This method is used when the customer is using the deprecated IpRanges property to make the request.
        /// The Ipv4Ranges property is updated to the IpRanges property values. 
        /// The internal dictionary collection is updated to latest values in the Ipv4Ranges property.
        /// Inorder to ensure that the added customer descriptions are not lost, a CidrIp comparison is made on the 
        /// internal dictionary and if a description exists for the said CidrIp, it is retained.
        /// </summary>
        /// <param name="list"></param>
        internal void SelectIpRangeForMarshalling(List<string> list)
        {
            var tempInternalIpRangesCollection = new Dictionary<string, IpRange>();
            foreach (var iprange in list)
            {
                IpRange value = new IpRange();
                if (_internalIpRangesCollection.TryGetValue(iprange, out value))
                {
                    tempInternalIpRangesCollection.Add(iprange, value);
                }
                else
                    tempInternalIpRangesCollection.Add(iprange, new IpRange { CidrIp = iprange });
            }
            _internalIpRangesCollection = tempInternalIpRangesCollection;
            this.PreIpv4Ranges = this.Ipv4Ranges;
            this.Ipv4Ranges = _internalIpRangesCollection.Select(p => p.Value).ToList();
            this.RestoreOldIpV4Range = true;
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