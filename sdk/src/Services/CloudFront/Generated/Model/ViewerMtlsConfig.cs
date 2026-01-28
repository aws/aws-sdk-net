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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
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
namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// A viewer mTLS configuration.
    /// </summary>
    public partial class ViewerMtlsConfig
    {
        private ViewerMtlsMode _mode;
        private TrustStoreConfig _trustStoreConfig;

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// The viewer mTLS mode.
        /// </para>
        /// </summary>
        public ViewerMtlsMode Mode
        {
            get { return this._mode; }
            set { this._mode = value; }
        }

        // Check to see if Mode property is set
        internal bool IsSetMode()
        {
            return this._mode != null;
        }

        /// <summary>
        /// Gets and sets the property TrustStoreConfig. 
        /// <para>
        /// The trust store configuration associated with the viewer mTLS configuration.
        /// </para>
        /// </summary>
        public TrustStoreConfig TrustStoreConfig
        {
            get { return this._trustStoreConfig; }
            set { this._trustStoreConfig = value; }
        }

        // Check to see if TrustStoreConfig property is set
        internal bool IsSetTrustStoreConfig()
        {
            return this._trustStoreConfig != null;
        }

    }
}