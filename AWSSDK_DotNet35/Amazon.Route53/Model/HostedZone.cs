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
    /// A complex type that contain information about the specified hosted zone.
    /// </summary>
    public partial class HostedZone
    {
        private string _id;
        private string _name;
        private string _callerReference;
        private HostedZoneConfig _config;
        private long? _resourceRecordSetCount;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public HostedZone() { }

        /// <summary>
        /// Instantiates HostedZone with the parameterized properties
        /// </summary>
        /// <param name="id">The ID of the specified hosted zone.</param>
        /// <param name="name">The name of the domain. This must be a fully-specified domain, for example, www.example.com. The trailing dot is optional; Route 53 assumes that the domain name is fully qualified. This means that Route 53 treats www.example.com (without a trailing dot) and www.example.com. (with a trailing dot) as identical. This is the name you have registered with your DNS registrar. You should ask your registrar to change the authoritative name servers for your domain to the set of <code>NameServers</code> elements returned in <code>DelegationSet</code>.</param>
        /// <param name="callerReference">A unique string that identifies the request to create the hosted zone.</param>
        public HostedZone(string id, string name, string callerReference)
        {
            _id = id;
            _name = name;
            _callerReference = callerReference;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the specified hosted zone.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the domain. This must be a fully-specified domain, for example, www.example.com.
        /// The trailing dot is optional; Route 53 assumes that the domain name is fully qualified.
        /// This means that Route 53 treats www.example.com (without a trailing dot) and www.example.com.
        /// (with a trailing dot) as identical.
        /// </para>
        ///  
        /// <para>
        /// This is the name you have registered with your DNS registrar. You should ask your
        /// registrar to change the authoritative name servers for your domain to the set of <code>NameServers</code>
        /// elements returned in <code>DelegationSet</code>.
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
        /// Gets and sets the property CallerReference. 
        /// <para>
        /// A unique string that identifies the request to create the hosted zone.
        /// </para>
        /// </summary>
        public string CallerReference
        {
            get { return this._callerReference; }
            set { this._callerReference = value; }
        }

        // Check to see if CallerReference property is set
        internal bool IsSetCallerReference()
        {
            return this._callerReference != null;
        }

        /// <summary>
        /// Gets and sets the property Config. 
        /// <para>
        /// A complex type that contains the <code>Comment</code> element.
        /// </para>
        /// </summary>
        public HostedZoneConfig Config
        {
            get { return this._config; }
            set { this._config = value; }
        }

        // Check to see if Config property is set
        internal bool IsSetConfig()
        {
            return this._config != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceRecordSetCount. 
        /// <para>
        /// Total number of resource record sets in the hosted zone.
        /// </para>
        /// </summary>
        public long ResourceRecordSetCount
        {
            get { return this._resourceRecordSetCount.GetValueOrDefault(); }
            set { this._resourceRecordSetCount = value; }
        }

        // Check to see if ResourceRecordSetCount property is set
        internal bool IsSetResourceRecordSetCount()
        {
            return this._resourceRecordSetCount.HasValue; 
        }

    }
}