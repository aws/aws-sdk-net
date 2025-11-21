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
 * Do not modify this file. This file is generated from the servicediscovery-2017-03-14.normal.json service model.
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
namespace Amazon.ServiceDiscovery.Model
{
    /// <summary>
    /// A complex type that contains information about a specified service.
    /// </summary>
    public partial class ServiceSummary
    {
        private string _arn;
        private DateTime? _createDate;
        private string _createdByAccount;
        private string _description;
        private DnsConfig _dnsConfig;
        private HealthCheckConfig _healthCheckConfig;
        private HealthCheckCustomConfig _healthCheckCustomConfig;
        private string _id;
        private int? _instanceCount;
        private string _name;
        private string _resourceOwner;
        private ServiceType _type;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that Cloud Map assigns to the service when you create
        /// it.
        /// </para>
        /// </summary>
        [AWSProperty(Max=255)]
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
        /// Gets and sets the property CreateDate. 
        /// <para>
        /// The date and time that the service was created.
        /// </para>
        /// </summary>
        public DateTime? CreateDate
        {
            get { return this._createDate; }
            set { this._createDate = value; }
        }

        // Check to see if CreateDate property is set
        internal bool IsSetCreateDate()
        {
            return this._createDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedByAccount. 
        /// <para>
        /// The ID of the Amazon Web Services account that created the service. If this isn't
        /// your account ID, it is the account ID of the namespace owner or of another account
        /// with which the namespace has been shared. For more information about shared namespaces,
        /// see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/sharing-namespaces.html">Cross-account
        /// Cloud Map namespace sharing</a> in the <i>Cloud Map Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string CreatedByAccount
        {
            get { return this._createdByAccount; }
            set { this._createdByAccount = value; }
        }

        // Check to see if CreatedByAccount property is set
        internal bool IsSetCreatedByAccount()
        {
            return this._createdByAccount != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description that you specify when you create the service.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DnsConfig. 
        /// <para>
        /// Information about the Route 53 DNS records that you want Cloud Map to create when
        /// you register an instance.
        /// </para>
        /// </summary>
        public DnsConfig DnsConfig
        {
            get { return this._dnsConfig; }
            set { this._dnsConfig = value; }
        }

        // Check to see if DnsConfig property is set
        internal bool IsSetDnsConfig()
        {
            return this._dnsConfig != null;
        }

        /// <summary>
        /// Gets and sets the property HealthCheckConfig. 
        /// <para>
        ///  <i>Public DNS and HTTP namespaces only.</i> Settings for an optional health check.
        /// If you specify settings for a health check, Cloud Map associates the health check
        /// with the records that you specify in <c>DnsConfig</c>.
        /// </para>
        /// </summary>
        public HealthCheckConfig HealthCheckConfig
        {
            get { return this._healthCheckConfig; }
            set { this._healthCheckConfig = value; }
        }

        // Check to see if HealthCheckConfig property is set
        internal bool IsSetHealthCheckConfig()
        {
            return this._healthCheckConfig != null;
        }

        /// <summary>
        /// Gets and sets the property HealthCheckCustomConfig. 
        /// <para>
        /// Information about an optional custom health check. A custom health check, which requires
        /// that you use a third-party health checker to evaluate the health of your resources,
        /// is useful in the following circumstances:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You can't use a health check that's defined by <c>HealthCheckConfig</c> because the
        /// resource isn't available over the internet. For example, you can use a custom health
        /// check when the instance is in an Amazon VPC. (To check the health of resources in
        /// a VPC, the health checker must also be in the VPC.)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You want to use a third-party health checker regardless of where your resources are
        /// located.
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// If you specify a health check configuration, you can specify either <c>HealthCheckCustomConfig</c>
        /// or <c>HealthCheckConfig</c> but not both.
        /// </para>
        ///  </important>
        /// </summary>
        public HealthCheckCustomConfig HealthCheckCustomConfig
        {
            get { return this._healthCheckCustomConfig; }
            set { this._healthCheckCustomConfig = value; }
        }

        // Check to see if HealthCheckCustomConfig property is set
        internal bool IsSetHealthCheckCustomConfig()
        {
            return this._healthCheckCustomConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID that Cloud Map assigned to the service when you created it.
        /// </para>
        /// </summary>
        [AWSProperty(Max=64)]
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
        /// Gets and sets the property InstanceCount. 
        /// <para>
        /// The number of instances that are currently associated with the service. Instances
        /// that were previously associated with the service but that are deleted aren't included
        /// in the count. The count might not reflect pending registrations and deregistrations.
        /// </para>
        /// </summary>
        public int? InstanceCount
        {
            get { return this._instanceCount; }
            set { this._instanceCount = value; }
        }

        // Check to see if InstanceCount property is set
        internal bool IsSetInstanceCount()
        {
            return this._instanceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the service.
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
        /// Gets and sets the property ResourceOwner. 
        /// <para>
        /// The ID of the Amazon Web Services account that created the namespace with which the
        /// service is associated. If this isn't your account ID, it is the ID of the account
        /// that shared the namespace with your account. For more information about shared namespaces,
        /// see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/sharing-namespaces.html">Cross-account
        /// Cloud Map namespace sharing</a> in the <i>Cloud Map Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string ResourceOwner
        {
            get { return this._resourceOwner; }
            set { this._resourceOwner = value; }
        }

        // Check to see if ResourceOwner property is set
        internal bool IsSetResourceOwner()
        {
            return this._resourceOwner != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Describes the systems that can be used to discover the service instances.
        /// </para>
        ///  <dl> <dt>DNS_HTTP</dt> <dd> 
        /// <para>
        /// The service instances can be discovered using either DNS queries or the <c>DiscoverInstances</c>
        /// API operation.
        /// </para>
        ///  </dd> <dt>HTTP</dt> <dd> 
        /// <para>
        /// The service instances can only be discovered using the <c>DiscoverInstances</c> API
        /// operation.
        /// </para>
        ///  </dd> <dt>DNS</dt> <dd> 
        /// <para>
        /// Reserved.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public ServiceType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}