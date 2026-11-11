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

namespace Amazon.LakeFormation.Model
{
    /// <summary>
    /// Container for the parameters to the GetTemporaryGlueFunctionCredentials operation.
    /// Returns temporary credentials that you can use to download the artifacts of a user-defined
    /// function whose <c>GovernanceMode</c> is <c>LAKE_FORMATION</c>. Lake Formation assumes
    /// the role that you registered for the function's <c>ArtifactLocation</c>. The credentials
    /// have read-only access to that location in Amazon S3. <para> To use this operation,
    /// you must have the <c>EXECUTE</c> permission on the function. </para>
    /// </summary>
    public partial class GetTemporaryGlueFunctionCredentialsRequest : AmazonLakeFormationRequest
    {
        /// <summary>
        /// Gets and sets the property AuditContext. 
        /// <para>
        /// Context for the request, such as the column names and query ID, that Lake Formation
        /// uses for auditing.
        /// </para>
        /// </summary>
        public AuditContext AuditContext { get; set; }

        /// <summary>
        /// Checks to see if the AuditContext property is set.
        /// </summary>
        internal bool IsSetAuditContext() => this.AuditContext != null;

        /// <summary>
        /// Gets and sets the property UserDefinedFunctionArn. 
        /// <para>
        /// The ARN of the user-defined function whose artifacts you want to download, in the
        /// format <c>arn:aws:glue:<i>region</i>:<i>account-id</i>:userDefinedFunction/<i>database-name</i>/<i>function-name</i>
        /// </c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string UserDefinedFunctionArn { get; set; }

        /// <summary>
        /// Checks to see if the UserDefinedFunctionArn property is set.
        /// </summary>
        internal bool IsSetUserDefinedFunctionArn() => this.UserDefinedFunctionArn != null;
    }
}
