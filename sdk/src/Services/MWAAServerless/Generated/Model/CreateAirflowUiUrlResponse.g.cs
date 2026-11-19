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

namespace Amazon.MWAAServerless.Model
{
    /// <summary>
    /// This is the response object from the CreateAirflowUiUrl operation.
    /// </summary>
    public partial class CreateAirflowUiUrlResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AuthorizedUrl. 
        /// <para>
        /// The launch URL that opens the Airflow UI. Open it in a browser before <c>UrlExpiresAt</c>.
        /// The UI session uses the permissions of the identity that called this operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 2048)]
        public string AuthorizedUrl { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizedUrl property is set.
        /// </summary>
        internal bool IsSetAuthorizedUrl() => this.AuthorizedUrl != null;

        /// <summary>
        /// Gets and sets the property SessionExpiresAt. 
        /// <para>
        /// The UI session ends at this time. The value is in ISO 8601 date-time format. After
        /// this time, create a new URL to open the UI again.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? SessionExpiresAt { get; set; }

        /// <summary>
        /// Checks to see if the SessionExpiresAt property is set.
        /// </summary>
        internal bool IsSetSessionExpiresAt() => this.SessionExpiresAt.HasValue;

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The URL starts a UI session that has this identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 32, Max = 32)]
        public string SessionId { get; set; }

        /// <summary>
        /// Checks to see if the SessionId property is set.
        /// </summary>
        internal bool IsSetSessionId() => this.SessionId != null;

        /// <summary>
        /// Gets and sets the property UrlExpiresAt. 
        /// <para>
        /// The launch URL stops being valid at this time. The value is in ISO 8601 date-time
        /// format.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UrlExpiresAt { get; set; }

        /// <summary>
        /// Checks to see if the UrlExpiresAt property is set.
        /// </summary>
        internal bool IsSetUrlExpiresAt() => this.UrlExpiresAt.HasValue;
    }
}
