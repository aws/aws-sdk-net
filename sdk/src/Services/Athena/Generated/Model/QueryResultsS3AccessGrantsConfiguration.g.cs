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

namespace Amazon.Athena.Model
{
    /// <summary>
    /// Specifies whether Amazon S3 access grants are enabled for query results.
    /// </summary>
    public partial class QueryResultsS3AccessGrantsConfiguration
    {
        /// <summary>
        /// Gets and sets the property AuthenticationType. 
        /// <para>
        /// The authentication type used for Amazon S3 access grants. Currently, only <c>DIRECTORY_IDENTITY</c>
        /// is supported.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AuthenticationType AuthenticationType { get; set; }

        /// <summary>
        /// Checks to see if the AuthenticationType property is set.
        /// </summary>
        internal bool IsSetAuthenticationType() => this.AuthenticationType != null;

        /// <summary>
        /// Gets and sets the property CreateUserLevelPrefix. 
        /// <para>
        /// When enabled, appends the user ID as an Amazon S3 path prefix to the query result
        /// output location.
        /// </para>
        /// </summary>
        public bool? CreateUserLevelPrefix { get; set; }

        /// <summary>
        /// Checks to see if the CreateUserLevelPrefix property is set.
        /// </summary>
        internal bool IsSetCreateUserLevelPrefix() => this.CreateUserLevelPrefix.HasValue;

        /// <summary>
        /// Gets and sets the property EnableS3AccessGrants. 
        /// <para>
        /// Specifies whether Amazon S3 access grants are enabled for query results.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? EnableS3AccessGrants { get; set; }

        /// <summary>
        /// Checks to see if the EnableS3AccessGrants property is set.
        /// </summary>
        internal bool IsSetEnableS3AccessGrants() => this.EnableS3AccessGrants.HasValue;
    }
}
