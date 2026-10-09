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
    /// This is the response object from the CreatePresignedNotebookUrl operation.
    /// </summary>
    public partial class CreatePresignedNotebookUrlResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AuthToken. 
        /// <para>
        /// The authentication token for the notebook.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 2048)]
        public string AuthToken { get; set; }

        /// <summary>
        /// Checks to see if the AuthToken property is set.
        /// </summary>
        internal bool IsSetAuthToken() => this.AuthToken != null;

        /// <summary>
        /// Gets and sets the property AuthTokenExpirationTime. 
        /// <para>
        /// The UTC epoch time when the authentication token expires.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? AuthTokenExpirationTime { get; set; }

        /// <summary>
        /// Checks to see if the AuthTokenExpirationTime property is set.
        /// </summary>
        internal bool IsSetAuthTokenExpirationTime() => this.AuthTokenExpirationTime.HasValue;

        /// <summary>
        /// Gets and sets the property NotebookUrl. 
        /// <para>
        /// The URL of the notebook. The URL includes the authentication token and notebook file
        /// name and points directly to the opened notebook.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string NotebookUrl { get; set; }

        /// <summary>
        /// Checks to see if the NotebookUrl property is set.
        /// </summary>
        internal bool IsSetNotebookUrl() => this.NotebookUrl != null;
    }
}
