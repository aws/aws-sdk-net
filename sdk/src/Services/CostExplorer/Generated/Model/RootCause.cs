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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// The combination of AWS service, linked account, Region, and usage type where a cost
    /// anomaly is observed.
    /// </summary>
    public partial class RootCause
    {
        private string _linkedAccount;
        private string _region;
        private string _service;
        private string _usageType;

        /// <summary>
        /// Gets and sets the property LinkedAccount. 
        /// <para>
        ///  The linked account value associated with the cost anomaly. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string LinkedAccount
        {
            get { return this._linkedAccount; }
            set { this._linkedAccount = value; }
        }

        // Check to see if LinkedAccount property is set
        internal bool IsSetLinkedAccount()
        {
            return this._linkedAccount != null;
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        ///  The AWS Region associated with the cost anomaly. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Region
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
        /// Gets and sets the property Service. 
        /// <para>
        ///  The AWS service name associated with the cost anomaly. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Service
        {
            get { return this._service; }
            set { this._service = value; }
        }

        // Check to see if Service property is set
        internal bool IsSetService()
        {
            return this._service != null;
        }

        /// <summary>
        /// Gets and sets the property UsageType. 
        /// <para>
        ///  The <code>UsageType</code> value associated with the cost anomaly. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string UsageType
        {
            get { return this._usageType; }
            set { this._usageType = value; }
        }

        // Check to see if UsageType property is set
        internal bool IsSetUsageType()
        {
            return this._usageType != null;
        }

    }
}