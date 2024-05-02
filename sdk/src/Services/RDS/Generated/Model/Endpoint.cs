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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
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
namespace Amazon.RDS.Model
{
    /// <summary>
    /// This data type represents the information you need to connect to an Amazon RDS DB
    /// instance. This data type is used as a response element in the following actions:
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <c>CreateDBInstance</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>DescribeDBInstances</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>DeleteDBInstance</c> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For the data structure that represents Amazon Aurora DB cluster endpoints, see <c>DBClusterEndpoint</c>.
    /// </para>
    /// </summary>
    public partial class Endpoint
    {
        private string _address;
        private string _hostedZoneId;
        private int? _port;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public Endpoint() { }

        /// <summary>
        /// Gets and sets the property Address. 
        /// <para>
        /// Specifies the DNS address of the DB instance.
        /// </para>
        /// </summary>
        public string Address
        {
            get { return this._address; }
            set { this._address = value; }
        }

        // Check to see if Address property is set
        internal bool IsSetAddress()
        {
            return this._address != null;
        }

        /// <summary>
        /// Gets and sets the property HostedZoneId. 
        /// <para>
        /// Specifies the ID that Amazon Route 53 assigns when you create a hosted zone.
        /// </para>
        /// </summary>
        public string HostedZoneId
        {
            get { return this._hostedZoneId; }
            set { this._hostedZoneId = value; }
        }

        // Check to see if HostedZoneId property is set
        internal bool IsSetHostedZoneId()
        {
            return this._hostedZoneId != null;
        }

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// Specifies the port that the database engine is listening on.
        /// </para>
        /// </summary>
        public int? Port
        {
            get { return this._port; }
            set { this._port = value; }
        }

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this._port.HasValue; 
        }

    }
}