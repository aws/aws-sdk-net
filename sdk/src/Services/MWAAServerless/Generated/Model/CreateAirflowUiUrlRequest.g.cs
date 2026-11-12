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
    /// Container for the parameters to the CreateAirflowUiUrl operation. Creates a launch
    /// URL that opens the Apache Airflow UI for your workflows in Amazon Managed Workflows
    /// for Apache Airflow Serverless. The UI shows the workflows in your account in the current
    /// AWS Region. To start a UI session, open the URL in a browser before it expires. <para>
    /// The UI runs with the permissions of the IAM identity that you use to call this operation.
    /// You see only the workflows, workflow runs, and logs that the identity can read, and
    /// you can start a workflow run only if the identity has permission to start one. </para>
    /// <para> The UI session uses the caller's permissions. The session works only from the
    /// network address that opened the URL. It ends at <c>SessionExpiresAt</c> or when you
    /// sign out from the UI. </para>
    /// </summary>
    public partial class CreateAirflowUiUrlRequest : AmazonMWAAServerlessRequest
    {
        /// <summary>
        /// Gets and sets the property ExpiresInSeconds. 
        /// <para>
        /// Specifies the number of seconds that the launch URL stays valid. This value limits
        /// only the time to open the URL, not the length of the UI session. The default is 300.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 5, Max = 300)]
        public int? ExpiresInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the ExpiresInSeconds property is set.
        /// </summary>
        internal bool IsSetExpiresInSeconds() => this.ExpiresInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property SessionDurationInSeconds. 
        /// <para>
        /// Specifies the number of seconds that the UI session lasts, starting from when you
        /// call this operation. The default is 43200 (12 hours).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 43200)]
        public int? SessionDurationInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the SessionDurationInSeconds property is set.
        /// </summary>
        internal bool IsSetSessionDurationInSeconds() => this.SessionDurationInSeconds.HasValue;
    }
}
