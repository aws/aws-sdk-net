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
 * Do not modify this file. This file is generated from the apigatewayv2-2018-11-29.normal.json service model.
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
namespace Amazon.ApiGatewayV2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class MutualTlsAuthenticationInput
    {
        private string _truststoreUri;
        private string _truststoreVersion;

        /// <summary>
        /// Gets and sets the property TruststoreUri. 
        /// <para>
        /// An Amazon S3 URL that specifies the truststore for mutual TLS authentication, for
        /// example, s3://<replaceable>bucket-name</replaceable>/<replaceable>key-name</replaceable>.
        /// The truststore can contain certificates from public or private certificate authorities.
        /// To update the truststore, upload a new version to S3, and then update your custom
        /// domain name to use the new version. To update the truststore, you must have permissions
        /// to access the S3 object.
        /// </para>
        /// </summary>
        public string TruststoreUri
        {
            get { return this._truststoreUri; }
            set { this._truststoreUri = value; }
        }

        // Check to see if TruststoreUri property is set
        internal bool IsSetTruststoreUri()
        {
            return this._truststoreUri != null;
        }

        /// <summary>
        /// Gets and sets the property TruststoreVersion. 
        /// <para>
        /// The version of the S3 object that contains your truststore. To specify a version,
        /// you must have versioning enabled for the S3 bucket.
        /// </para>
        /// </summary>
        public string TruststoreVersion
        {
            get { return this._truststoreVersion; }
            set { this._truststoreVersion = value; }
        }

        // Check to see if TruststoreVersion property is set
        internal bool IsSetTruststoreVersion()
        {
            return this._truststoreVersion != null;
        }

    }
}