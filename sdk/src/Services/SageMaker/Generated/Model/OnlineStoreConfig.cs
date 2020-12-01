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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Use this to specify the AWS Key Management Service (KMS) Key ID, or <code>KMSKeyId</code>,
    /// for at rest data encryption. You can turn <code>OnlineStore</code> on or off by specifying
    /// the <code>EnableOnlineStore</code> flag at General Assembly; the default value is
    /// <code>False</code>.
    /// </summary>
    public partial class OnlineStoreConfig
    {
        private bool? _enableOnlineStore;
        private OnlineStoreSecurityConfig _securityConfig;

        /// <summary>
        /// Gets and sets the property EnableOnlineStore. 
        /// <para>
        /// Turn <code>OnlineStore</code> off by specifying <code>False</code> for the <code>EnableOnlineStore</code>
        /// flag. Turn <code>OnlineStore</code> on by specifying <code>True</code> for the <code>EnableOnlineStore</code>
        /// flag. 
        /// </para>
        ///  
        /// <para>
        /// The default value is <code>False</code>.
        /// </para>
        /// </summary>
        public bool EnableOnlineStore
        {
            get { return this._enableOnlineStore.GetValueOrDefault(); }
            set { this._enableOnlineStore = value; }
        }

        // Check to see if EnableOnlineStore property is set
        internal bool IsSetEnableOnlineStore()
        {
            return this._enableOnlineStore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SecurityConfig. 
        /// <para>
        /// Use to specify KMS Key ID (<code>KMSKeyId</code>) for at-rest encryption of your <code>OnlineStore</code>.
        /// </para>
        /// </summary>
        public OnlineStoreSecurityConfig SecurityConfig
        {
            get { return this._securityConfig; }
            set { this._securityConfig = value; }
        }

        // Check to see if SecurityConfig property is set
        internal bool IsSetSecurityConfig()
        {
            return this._securityConfig != null;
        }

    }
}