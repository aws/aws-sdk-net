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
    /// Describes the VPC resources, VPC endpoint services, Lattice services, or service networks
    /// associated with the VPC endpoint.
    /// </summary>
    public partial class VpcEndpointAssociation
    {
        private string _associatedResourceAccessibility;
        private string _associatedResourceArn;
        private DnsEntry _dnsEntry;
        private string _failureCode;
        private string _failureReason;
        private string _id;
        private DnsEntry _privateDnsEntry;
        private string _resourceConfigurationGroupArn;
        private string _serviceNetworkArn;
        private string _serviceNetworkName;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _vpcEndpointId;

        /// <summary>
        /// Gets and sets the property AssociatedResourceAccessibility. 
        /// <para>
        /// The connectivity status of the resources associated to a VPC endpoint. The resource
        /// is accessible if the associated resource configuration is <c>AVAILABLE</c>, otherwise
        /// the resource is inaccessible.
        /// </para>
        /// </summary>
        public string AssociatedResourceAccessibility
        {
            get { return this._associatedResourceAccessibility; }
            set { this._associatedResourceAccessibility = value; }
        }

        // Check to see if AssociatedResourceAccessibility property is set
        internal bool IsSetAssociatedResourceAccessibility()
        {
            return this._associatedResourceAccessibility != null;
        }

        /// <summary>
        /// Gets and sets the property AssociatedResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the associated resource.
        /// </para>
        /// </summary>
        public string AssociatedResourceArn
        {
            get { return this._associatedResourceArn; }
            set { this._associatedResourceArn = value; }
        }

        // Check to see if AssociatedResourceArn property is set
        internal bool IsSetAssociatedResourceArn()
        {
            return this._associatedResourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property DnsEntry. 
        /// <para>
        /// The DNS entry of the VPC endpoint association.
        /// </para>
        /// </summary>
        public DnsEntry DnsEntry
        {
            get { return this._dnsEntry; }
            set { this._dnsEntry = value; }
        }

        // Check to see if DnsEntry property is set
        internal bool IsSetDnsEntry()
        {
            return this._dnsEntry != null;
        }

        /// <summary>
        /// Gets and sets the property FailureCode. 
        /// <para>
        /// An error code related to why an VPC endpoint association failed.
        /// </para>
        /// </summary>
        public string FailureCode
        {
            get { return this._failureCode; }
            set { this._failureCode = value; }
        }

        // Check to see if FailureCode property is set
        internal bool IsSetFailureCode()
        {
            return this._failureCode != null;
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// A message related to why an VPC endpoint association failed.
        /// </para>
        /// </summary>
        public string FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the VPC endpoint association.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property PrivateDnsEntry. 
        /// <para>
        /// The private DNS entry of the VPC endpoint association.
        /// </para>
        /// </summary>
        public DnsEntry PrivateDnsEntry
        {
            get { return this._privateDnsEntry; }
            set { this._privateDnsEntry = value; }
        }

        // Check to see if PrivateDnsEntry property is set
        internal bool IsSetPrivateDnsEntry()
        {
            return this._privateDnsEntry != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceConfigurationGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource configuration group.
        /// </para>
        /// </summary>
        public string ResourceConfigurationGroupArn
        {
            get { return this._resourceConfigurationGroupArn; }
            set { this._resourceConfigurationGroupArn = value; }
        }

        // Check to see if ResourceConfigurationGroupArn property is set
        internal bool IsSetResourceConfigurationGroupArn()
        {
            return this._resourceConfigurationGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceNetworkArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the service network.
        /// </para>
        /// </summary>
        public string ServiceNetworkArn
        {
            get { return this._serviceNetworkArn; }
            set { this._serviceNetworkArn = value; }
        }

        // Check to see if ServiceNetworkArn property is set
        internal bool IsSetServiceNetworkArn()
        {
            return this._serviceNetworkArn != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceNetworkName. 
        /// <para>
        /// The name of the service network.
        /// </para>
        /// </summary>
        public string ServiceNetworkName
        {
            get { return this._serviceNetworkName; }
            set { this._serviceNetworkName = value; }
        }

        // Check to see if ServiceNetworkName property is set
        internal bool IsSetServiceNetworkName()
        {
            return this._serviceNetworkName != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to apply to the VPC endpoint association.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VpcEndpointId. 
        /// <para>
        /// The ID of the VPC endpoint.
        /// </para>
        /// </summary>
        public string VpcEndpointId
        {
            get { return this._vpcEndpointId; }
            set { this._vpcEndpointId = value; }
        }

        // Check to see if VpcEndpointId property is set
        internal bool IsSetVpcEndpointId()
        {
            return this._vpcEndpointId != null;
        }

    }
}