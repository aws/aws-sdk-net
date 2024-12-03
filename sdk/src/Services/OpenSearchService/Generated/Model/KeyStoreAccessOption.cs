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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
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
namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// The configuration parameters to enable access to the key store required by the package.
    /// </summary>
    public partial class KeyStoreAccessOption
    {
        private string _keyAccessRoleArn;
        private bool? _keyStoreAccessEnabled;

        /// <summary>
        /// Gets and sets the property KeyAccessRoleArn. 
        /// <para>
        /// Role ARN to access the KeyStore Key
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string KeyAccessRoleArn
        {
            get { return this._keyAccessRoleArn; }
            set { this._keyAccessRoleArn = value; }
        }

        // Check to see if KeyAccessRoleArn property is set
        internal bool IsSetKeyAccessRoleArn()
        {
            return this._keyAccessRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property KeyStoreAccessEnabled. 
        /// <para>
        /// This indicates whether Key Store access is enabled 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? KeyStoreAccessEnabled
        {
            get { return this._keyStoreAccessEnabled; }
            set { this._keyStoreAccessEnabled = value; }
        }

        // Check to see if KeyStoreAccessEnabled property is set
        internal bool IsSetKeyStoreAccessEnabled()
        {
            return this._keyStoreAccessEnabled.HasValue; 
        }

    }
}