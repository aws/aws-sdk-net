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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Appflow.Model
{
    /// <summary>
    /// The connector-specific profile properties required when using Salesforce Pardot.
    /// </summary>
    public partial class PardotConnectorProfileProperties
    {
        private string _businessUnitId;
        private string _instanceUrl;
        private bool? _isSandboxEnvironment;

        /// <summary>
        /// Gets and sets the property BusinessUnitId. 
        /// <para>
        /// The business unit id of Salesforce Pardot instance.
        /// </para>
        /// </summary>
        [AWSProperty(Max=18)]
        public string BusinessUnitId
        {
            get { return this._businessUnitId; }
            set { this._businessUnitId = value; }
        }

        // Check to see if BusinessUnitId property is set
        internal bool IsSetBusinessUnitId()
        {
            return this._businessUnitId != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceUrl. 
        /// <para>
        /// The location of the Salesforce Pardot resource.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string InstanceUrl
        {
            get { return this._instanceUrl; }
            set { this._instanceUrl = value; }
        }

        // Check to see if InstanceUrl property is set
        internal bool IsSetInstanceUrl()
        {
            return this._instanceUrl != null;
        }

        /// <summary>
        /// Gets and sets the property IsSandboxEnvironment. 
        /// <para>
        /// Indicates whether the connector profile applies to a sandbox or production environment.
        /// </para>
        /// </summary>
        public bool IsSandboxEnvironment
        {
            get { return this._isSandboxEnvironment.GetValueOrDefault(); }
            set { this._isSandboxEnvironment = value; }
        }

        // Check to see if IsSandboxEnvironment property is set
        internal bool IsSetIsSandboxEnvironment()
        {
            return this._isSandboxEnvironment.HasValue; 
        }

    }
}