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
 * Do not modify this file. This file is generated from the pca-connector-ad-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.PcaConnectorAd.Model
{
    /// <summary>
    /// Application policies describe what the certificate can be used for.
    /// </summary>
    public partial class ApplicationPolicies
    {
        private bool? _critical;
        private List<ApplicationPolicy> _policies = AWSConfigs.InitializeCollections ? new List<ApplicationPolicy>() : null;

        /// <summary>
        /// Gets and sets the property Critical. 
        /// <para>
        /// Marks the application policy extension as critical.
        /// </para>
        /// </summary>
        public bool Critical
        {
            get { return this._critical.GetValueOrDefault(); }
            set { this._critical = value; }
        }

        // Check to see if Critical property is set
        internal bool IsSetCritical()
        {
            return this._critical.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Policies. 
        /// <para>
        /// Application policies describe what the certificate can be used for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public List<ApplicationPolicy> Policies
        {
            get { return this._policies; }
            set { this._policies = value; }
        }

        // Check to see if Policies property is set
        internal bool IsSetPolicies()
        {
            return this._policies != null && (this._policies.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}