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
    /// A complex type that contains an optional comment about your hosted zone. If you don't
    /// want to specify a comment, omit both the <c>HostedZoneConfig</c> and <c>Comment</c>
    /// elements.
    /// </summary>
    public partial class HostedZoneConfig
    {
        private string _comment;
        private bool? _privateZone;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public HostedZoneConfig() { }

        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// Any comments that you want to include about the hosted zone.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string Comment
        {
            get { return this._comment; }
            set { this._comment = value; }
        }

        // Check to see if Comment property is set
        internal bool IsSetComment()
        {
            return this._comment != null;
        }

        /// <summary>
        /// Gets and sets the property PrivateZone. 
        /// <para>
        /// A value that indicates whether this is a private hosted zone.
        /// </para>
        /// </summary>
        public bool? PrivateZone
        {
            get { return this._privateZone; }
            set { this._privateZone = value; }
        }

        // Check to see if PrivateZone property is set
        internal bool IsSetPrivateZone()
        {
            return this._privateZone.HasValue; 
        }

    }
}