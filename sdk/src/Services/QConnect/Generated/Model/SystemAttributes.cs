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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
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
namespace Amazon.QConnect.Model
{
    /// <summary>
    /// The system attributes that are used with the message template.
    /// </summary>
    public partial class SystemAttributes
    {
        private SystemEndpointAttributes _customerEndpoint;
        private string _name;
        private SystemEndpointAttributes _systemEndpoint;

        /// <summary>
        /// Gets and sets the property CustomerEndpoint. 
        /// <para>
        /// The CustomerEndpoint attribute.
        /// </para>
        /// </summary>
        public SystemEndpointAttributes CustomerEndpoint
        {
            get { return this._customerEndpoint; }
            set { this._customerEndpoint = value; }
        }

        // Check to see if CustomerEndpoint property is set
        internal bool IsSetCustomerEndpoint()
        {
            return this._customerEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the task.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=32767)]
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
        /// Gets and sets the property SystemEndpoint. 
        /// <para>
        /// The SystemEndpoint attribute.
        /// </para>
        /// </summary>
        public SystemEndpointAttributes SystemEndpoint
        {
            get { return this._systemEndpoint; }
            set { this._systemEndpoint = value; }
        }

        // Check to see if SystemEndpoint property is set
        internal bool IsSetSystemEndpoint()
        {
            return this._systemEndpoint != null;
        }

    }
}