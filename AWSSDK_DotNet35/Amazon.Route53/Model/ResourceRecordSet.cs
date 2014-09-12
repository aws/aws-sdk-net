/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53.Model
{
    /// <summary>
    /// A complex type that contains information about the current resource record set.
    /// </summary>
    public partial class ResourceRecordSet
    {
        private string _name;
        private RRType _type;
        private string _setIdentifier;
        private long? _weight;
        private ResourceRecordSetRegion _region;
        private GeoLocation _geoLocation;
        private ResourceRecordSetFailover _failover;
        private long? _tTL;
        private List<ResourceRecord> _resourceRecords = new List<ResourceRecord>();
        private AliasTarget _aliasTarget;
        private string _healthCheckId;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public ResourceRecordSet() { }

        /// <summary>
        /// Instantiates ResourceRecordSet with the parameterized properties
        /// </summary>
        /// <param name="name">The domain name of the current resource record set.</param>
        /// <param name="type">The type of the current resource record set.</param>
        public ResourceRecordSet(string name, RRType type)
        {
            _name = name;
            _type = type;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The domain name of the current resource record set.
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
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the current resource record set.
        /// </para>
        /// </summary>
        public RRType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property SetIdentifier. 
        /// <para>
        /// <i>Weighted, Latency, Geo, and Failover resource record sets only:</i> An identifier
        /// that differentiates among multiple resource record sets that have the same combination
        /// of DNS name and type.
        /// </para>
        /// </summary>
        public string SetIdentifier
        {
            get { return this._setIdentifier; }
            set { this._setIdentifier = value; }
        }

        // Check to see if SetIdentifier property is set
        internal bool IsSetSetIdentifier()
        {
            return this._setIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Weight. 
        /// <para>
        /// <i>Weighted resource record sets only:</i> Among resource record sets that have the
        /// same combination of DNS name and type, a value that determines what portion of traffic
        /// for the current resource record set is routed to the associated location.
        /// </para>
        /// </summary>
        public long Weight
        {
            get { return this._weight.GetValueOrDefault(); }
            set { this._weight = value; }
        }

        // Check to see if Weight property is set
        internal bool IsSetWeight()
        {
            return this._weight.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// <i>Latency-based resource record sets only:</i> Among resource record sets that have
        /// the same combination of DNS name and type, a value that specifies the AWS region for
        /// the current resource record set.
        /// </para>
        /// </summary>
        public ResourceRecordSetRegion Region
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
        /// Gets and sets the property GeoLocation. 
        /// <para>
        /// <i>Geo location resource record sets only:</i> Among resource record sets that have
        /// the same combination of DNS name and type, a value that specifies the geo location
        /// for the current resource record set.
        /// </para>
        /// </summary>
        public GeoLocation GeoLocation
        {
            get { return this._geoLocation; }
            set { this._geoLocation = value; }
        }

        // Check to see if GeoLocation property is set
        internal bool IsSetGeoLocation()
        {
            return this._geoLocation != null;
        }

        /// <summary>
        /// Gets and sets the property Failover. 
        /// <para>
        /// <i>Failover resource record sets only:</i> Among resource record sets that have the
        /// same combination of DNS name and type, a value that indicates whether the current
        /// resource record set is a primary or secondary resource record set. A failover set
        /// may contain at most one resource record set marked as primary and one resource record
        /// set marked as secondary. A resource record set marked as primary will be returned
        /// if any of the following are true: (1) an associated health check is passing, (2) if
        /// the resource record set is an alias with the evaluate target health and at least one
        /// target resource record set is healthy, (3) both the primary and secondary resource
        /// record set are failing health checks or (4) there is no secondary resource record
        /// set. A secondary resource record set will be returned if: (1) the primary is failing
        /// a health check and either the secondary is passing a health check or has no associated
        /// health check, or (2) there is no primary resource record set. 
        /// </para>
        ///  
        /// <para>
        /// Valid values: <code>PRIMARY</code> | <code>SECONDARY</code>
        /// </para>
        /// </summary>
        public ResourceRecordSetFailover Failover
        {
            get { return this._failover; }
            set { this._failover = value; }
        }

        // Check to see if Failover property is set
        internal bool IsSetFailover()
        {
            return this._failover != null;
        }

        /// <summary>
        /// Gets and sets the property TTL. 
        /// <para>
        /// The cache time to live for the current resource record set.
        /// </para>
        /// </summary>
        public long TTL
        {
            get { return this._tTL.GetValueOrDefault(); }
            set { this._tTL = value; }
        }

        // Check to see if TTL property is set
        internal bool IsSetTTL()
        {
            return this._tTL.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceRecords. 
        /// <para>
        /// A complex type that contains the resource records for the current resource record
        /// set.
        /// </para>
        /// </summary>
        public List<ResourceRecord> ResourceRecords
        {
            get { return this._resourceRecords; }
            set { this._resourceRecords = value; }
        }

        // Check to see if ResourceRecords property is set
        internal bool IsSetResourceRecords()
        {
            return this._resourceRecords != null && this._resourceRecords.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AliasTarget. 
        /// <para>
        /// <i>Alias resource record sets only:</i> Information about the AWS resource to which
        /// you are redirecting traffic.
        /// </para>
        /// </summary>
        public AliasTarget AliasTarget
        {
            get { return this._aliasTarget; }
            set { this._aliasTarget = value; }
        }

        // Check to see if AliasTarget property is set
        internal bool IsSetAliasTarget()
        {
            return this._aliasTarget != null;
        }

        /// <summary>
        /// Gets and sets the property HealthCheckId. 
        /// <para>
        /// <i>Health Check resource record sets only, not required for alias resource record
        /// sets:</i> An identifier that is used to identify health check associated with the
        /// resource record set.
        /// </para>
        /// </summary>
        public string HealthCheckId
        {
            get { return this._healthCheckId; }
            set { this._healthCheckId = value; }
        }

        // Check to see if HealthCheckId property is set
        internal bool IsSetHealthCheckId()
        {
            return this._healthCheckId != null;
        }

    }
}