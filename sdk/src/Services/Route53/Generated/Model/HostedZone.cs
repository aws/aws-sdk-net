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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
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
namespace Amazon.Route53.Model
{
    /// <summary>
    /// A complex type that contains general information about the hosted zone.
    /// </summary>
    public partial class HostedZone
    {
        private string _id;
        private string _name;
        private string _callerReference;
        private HostedZoneConfig _config;
        private long? _resourceRecordSetCount;
        private LinkedService _linkedService;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public HostedZone() { }

        /// <summary>
        /// Instantiates HostedZone with the parameterized properties
        /// </summary>
        /// <param name="id">The ID that Amazon Route 53 assigned to the hosted zone when you created it.</param>
        /// <param name="name">The name of the domain. For public hosted zones, this is the name that you have registered with your DNS registrar. For information about how to specify characters other than <c>a-z</c>, <c>0-9</c>, and <c>-</c> (hyphen) and how to specify internationalized domain names, see <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_CreateHostedZone.html">CreateHostedZone</a>.</param>
        /// <param name="callerReference">The value that you specified for <c>CallerReference</c> when you created the hosted zone.</param>
        public HostedZone(string id, string name, string callerReference)
        {
            _id = id;
            _name = name;
            _callerReference = callerReference;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID that Amazon Route 53 assigned to the hosted zone when you created it.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=32)]
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
        /// The name of the domain. For public hosted zones, this is the name that you have registered
        /// with your DNS registrar.
        /// </para>
        ///  
        /// <para>
        /// For information about how to specify characters other than <c>a-z</c>, <c>0-9</c>,
        /// and <c>-</c> (hyphen) and how to specify internationalized domain names, see <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_CreateHostedZone.html">CreateHostedZone</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=1024)]
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
        /// The value that you specified for <c>CallerReference</c> when you created the hosted
        /// zone.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        /// A complex type that includes the <c>Comment</c> and <c>PrivateZone</c> elements. If
        /// you omitted the <c>HostedZoneConfig</c> and <c>Comment</c> elements from the request,
        /// the <c>Config</c> and <c>Comment</c> elements don't appear in the response.
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
        /// The number of resource record sets in the hosted zone.
        /// </para>
        /// </summary>
        public long? ResourceRecordSetCount
        {
            get { return this._resourceRecordSetCount; }
            set { this._resourceRecordSetCount = value; }
        }

        // Check to see if ResourceRecordSetCount property is set
        internal bool IsSetResourceRecordSetCount()
        {
            return this._resourceRecordSetCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LinkedService. 
        /// <para>
        /// If the hosted zone was created by another service, the service that created the hosted
        /// zone. When a hosted zone is created by another service, you can't edit or delete it
        /// using Route 53. 
        /// </para>
        /// </summary>
        public LinkedService LinkedService
        {
            get { return this._linkedService; }
            set { this._linkedService = value; }
        }

        // Check to see if LinkedService property is set
        internal bool IsSetLinkedService()
        {
            return this._linkedService != null;
        }

    }
}