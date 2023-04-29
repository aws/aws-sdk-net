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
 * Do not modify this file. This file is generated from the internetmonitor-2021-06-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.InternetMonitor.Model
{
    /// <summary>
    /// An internet service provider (ISP) or network in Amazon CloudWatch Internet Monitor.
    /// </summary>
    public partial class Network
    {
        private string _asName;
        private long? _asNumber;

        /// <summary>
        /// Gets and sets the property ASName. 
        /// <para>
        /// The internet provider name or network name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ASName
        {
            get { return this._asName; }
            set { this._asName = value; }
        }

        // Check to see if ASName property is set
        internal bool IsSetASName()
        {
            return this._asName != null;
        }

        /// <summary>
        /// Gets and sets the property ASNumber. 
        /// <para>
        /// The Autonomous System Number (ASN) of the internet provider or network.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long ASNumber
        {
            get { return this._asNumber.GetValueOrDefault(); }
            set { this._asNumber = value; }
        }

        // Check to see if ASNumber property is set
        internal bool IsSetASNumber()
        {
            return this._asNumber.HasValue; 
        }

    }
}