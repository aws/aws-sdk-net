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
 * Do not modify this file. This file is generated from the vpc-lattice-2022-11-30.normal.json service model.
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
namespace Amazon.VPCLattice.Model
{
    /// <summary>
    /// Summary information about an association between a service network and a resource
    /// configuration.
    /// </summary>
    public partial class ServiceNetworkResourceAssociationSummary
    {
        private string _arn;
        private DateTime? _createdAt;
        private string _createdBy;
        private DnsEntry _dnsEntry;
        private string _failureCode;
        private string _id;
        private bool? _isManagedAssociation;
        private DnsEntry _privateDnsEntry;
        private string _resourceConfigurationArn;
        private string _resourceConfigurationId;
        private string _resourceConfigurationName;
        private string _serviceNetworkArn;
        private string _serviceNetworkId;
        private string _serviceNetworkName;
        private ServiceNetworkResourceAssociationStatus _status;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the association.
        /// </para>
        /// </summary>
        [AWSProperty(Min=22, Max=2048)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time that the association was created, in ISO-8601 format.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The account that created the association.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=12)]
        public string CreatedBy
        {
            get { return this._createdBy; }
            set { this._createdBy = value; }
        }

        // Check to see if CreatedBy property is set
        internal bool IsSetCreatedBy()
        {
            return this._createdBy != null;
        }

        /// <summary>
        /// Gets and sets the property DnsEntry. 
        /// <para>
        /// The DNS entry for the service.
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
        /// The failure code.
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
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the association between the service network and resource configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=22, Max=22)]
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
        /// Gets and sets the property IsManagedAssociation. 
        /// <para>
        /// Specifies whether the association is managed by Amazon.
        /// </para>
        /// </summary>
        public bool? IsManagedAssociation
        {
            get { return this._isManagedAssociation; }
            set { this._isManagedAssociation = value; }
        }

        // Check to see if IsManagedAssociation property is set
        internal bool IsSetIsManagedAssociation()
        {
            return this._isManagedAssociation.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PrivateDnsEntry. 
        /// <para>
        /// The private DNS entry for the service.
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
        /// Gets and sets the property ResourceConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the association.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string ResourceConfigurationArn
        {
            get { return this._resourceConfigurationArn; }
            set { this._resourceConfigurationArn = value; }
        }

        // Check to see if ResourceConfigurationArn property is set
        internal bool IsSetResourceConfigurationArn()
        {
            return this._resourceConfigurationArn != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceConfigurationId. 
        /// <para>
        /// The ID of the resource configuration associated with the service network.
        /// </para>
        /// </summary>
        [AWSProperty(Min=22, Max=22)]
        public string ResourceConfigurationId
        {
            get { return this._resourceConfigurationId; }
            set { this._resourceConfigurationId = value; }
        }

        // Check to see if ResourceConfigurationId property is set
        internal bool IsSetResourceConfigurationId()
        {
            return this._resourceConfigurationId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceConfigurationName. 
        /// <para>
        /// The name of the resource configuration associated with the service network.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=40)]
        public string ResourceConfigurationName
        {
            get { return this._resourceConfigurationName; }
            set { this._resourceConfigurationName = value; }
        }

        // Check to see if ResourceConfigurationName property is set
        internal bool IsSetResourceConfigurationName()
        {
            return this._resourceConfigurationName != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceNetworkArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the service network associated with the resource
        /// configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=2048)]
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
        /// Gets and sets the property ServiceNetworkId. 
        /// <para>
        /// The ID of the service network associated with the resource configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=2048)]
        public string ServiceNetworkId
        {
            get { return this._serviceNetworkId; }
            set { this._serviceNetworkId = value; }
        }

        // Check to see if ServiceNetworkId property is set
        internal bool IsSetServiceNetworkId()
        {
            return this._serviceNetworkId != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceNetworkName. 
        /// <para>
        /// The name of the service network associated with the resource configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=100)]
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the service network’s association with the resource configuration. If
        /// the deletion fails, try to delete again. 
        /// </para>
        /// </summary>
        public ServiceNetworkResourceAssociationStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}