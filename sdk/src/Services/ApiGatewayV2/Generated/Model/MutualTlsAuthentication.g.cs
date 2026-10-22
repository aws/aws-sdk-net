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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// </summary>
    public partial class MutualTlsAuthentication
    {
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
        public string TruststoreUri { get; set; }

        /// <summary>
        /// Checks to see if the TruststoreUri property is set.
        /// </summary>
        internal bool IsSetTruststoreUri() => this.TruststoreUri != null;

        /// <summary>
        /// Gets and sets the property TruststoreVersion. 
        /// <para>
        /// The version of the S3 object that contains your truststore. To specify a version,
        /// you must have versioning enabled for the S3 bucket.
        /// </para>
        /// </summary>
        public string TruststoreVersion { get; set; }

        /// <summary>
        /// Checks to see if the TruststoreVersion property is set.
        /// </summary>
        internal bool IsSetTruststoreVersion() => this.TruststoreVersion != null;

        /// <summary>
        /// Gets and sets the property TruststoreWarnings. 
        /// <para>
        /// A list of warnings that API Gateway returns while processing your truststore. Invalid
        /// certificates produce warnings. Mutual TLS is still enabled, but some clients might
        /// not be able to access your API. To resolve warnings, upload a new truststore to S3,
        /// and then update you domain name to use the new version.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> TruststoreWarnings { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TruststoreWarnings property is set.
        /// </summary>
        internal bool IsSetTruststoreWarnings() => this.TruststoreWarnings != null && (this.TruststoreWarnings.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
