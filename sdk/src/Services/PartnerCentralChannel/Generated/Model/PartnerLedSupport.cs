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
 * Do not modify this file. This file is generated from the partnercentral-channel-2024-03-18.normal.json service model.
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
namespace Amazon.PartnerCentralChannel.Model
{
    /// <summary>
    /// Configuration for partner-led support plans.
    /// </summary>
    public partial class PartnerLedSupport
    {
        private Coverage _coverage;
        private Provider _provider;
        private string _tamLocation;

        /// <summary>
        /// Gets and sets the property Coverage. 
        /// <para>
        /// The coverage level for partner-led support.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Coverage Coverage
        {
            get { return this._coverage; }
            set { this._coverage = value; }
        }

        // Check to see if Coverage property is set
        internal bool IsSetCoverage()
        {
            return this._coverage != null;
        }

        /// <summary>
        /// Gets and sets the property Provider. 
        /// <para>
        /// The provider of the partner-led support.
        /// </para>
        /// </summary>
        public Provider Provider
        {
            get { return this._provider; }
            set { this._provider = value; }
        }

        // Check to see if Provider property is set
        internal bool IsSetProvider()
        {
            return this._provider != null;
        }

        /// <summary>
        /// Gets and sets the property TamLocation. 
        /// <para>
        /// The location of the Technical Account Manager (TAM).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TamLocation
        {
            get { return this._tamLocation; }
            set { this._tamLocation = value; }
        }

        // Check to see if TamLocation property is set
        internal bool IsSetTamLocation()
        {
            return this._tamLocation != null;
        }

    }
}