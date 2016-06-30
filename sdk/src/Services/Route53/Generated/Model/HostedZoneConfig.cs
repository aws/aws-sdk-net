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
    /// A complex type that contains an optional comment about your hosted zone. If you don't
    /// want to specify a comment, you can omit the <code>HostedZoneConfig</code> and <code>Comment</code>
    /// elements from the XML document.
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
        /// An optional comment about your hosted zone. If you don't want to specify a comment,
        /// you can omit the <code>HostedZoneConfig</code> and <code>Comment</code> elements from
        /// the XML document.
        /// </para>
        /// </summary>
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
        /// <code>GetHostedZone</code> and <code>ListHostedZone</code> responses: A Boolean value
        /// that indicates whether a hosted zone is private.
        /// </para>
        ///  
        /// <para>
        /// <code>CreateHostedZone</code> requests: When you're creating a private hosted zone
        /// (when you specify values for VPCId and VPCRegion), you can optionally specify true
        /// for PrivateZone. 
        /// </para>
        /// </summary>
        public bool PrivateZone
        {
            get { return this._privateZone.GetValueOrDefault(); }
            set { this._privateZone = value; }
        }

        // Check to see if PrivateZone property is set
        internal bool IsSetPrivateZone()
        {
            return this._privateZone.HasValue; 
        }

    }
}