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
 * Do not modify this file. This file is generated from the xray-2016-04-12.normal.json service model.
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
namespace Amazon.XRay.Model
{
    /// <summary>
    /// A collection of segments and corresponding subsegments associated to a response time
    /// warning.
    /// </summary>
    public partial class ResponseTimeRootCauseEntity
    {
        private double? _coverage;
        private string _name;
        private bool? _remote;

        /// <summary>
        /// Gets and sets the property Coverage. 
        /// <para>
        /// The type and messages of the exceptions.
        /// </para>
        /// </summary>
        public double? Coverage
        {
            get { return this._coverage; }
            set { this._coverage = value; }
        }

        // Check to see if Coverage property is set
        internal bool IsSetCoverage()
        {
            return this._coverage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the entity.
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
        /// Gets and sets the property Remote. 
        /// <para>
        /// A flag that denotes a remote subsegment.
        /// </para>
        /// </summary>
        public bool? Remote
        {
            get { return this._remote; }
            set { this._remote = value; }
        }

        // Check to see if Remote property is set
        internal bool IsSetRemote()
        {
            return this._remote.HasValue; 
        }

    }
}