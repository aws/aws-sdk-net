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

namespace Amazon.Continuum.Model
{
    /// <summary>
    /// Container for the parameters to the CreateCodeFinding operation. Ingests a customer-supplied
    /// security finding into an environment. Continuum validates the document synchronously
    /// against the required overlay fields for the declared format; invalid documents are
    /// rejected with a ValidationException. The maximum accepted document size is 256 KB.
    /// The environment must have a source configured, and the finding must identify a code
    /// location so Continuum can tie it to a repository in the environment's build. Continuum
    /// assigns a findingId and stores the verbatim document. When no successful build yet
    /// contains the finding's repository, the finding stays SUBMITTED until the next successful
    /// build; if that build does not contain it either, the finding is DISCARDED with discardReason
    /// SOURCE_REPO_NOT_FOUND.
    /// </summary>
    public partial class CreateCodeFindingRequest : AmazonContinuumRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. Caller-provided idempotency token. A retry
        /// with the same token and an identical finding document replays the original result;
        /// the same token with different content is rejected.
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property EnvironmentId. The environment to ingest the finding into.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentId property is set.
        /// </summary>
        internal bool IsSetEnvironmentId() => this.EnvironmentId != null;

        /// <summary>
        /// Gets and sets the property OcsfDocument. The OCSF finding document to ingest, verbatim.
        /// Must declare a class_uid Continuum supports (2002 Vulnerability Finding, or 2007 Application
        /// Security Posture Finding) and validate against the vendored OCSF JSON Schema for that
        /// class, including the Continuum overlay requirements that finding_info.uid be present
        /// and that vulnerabilities[0].affected_code[0].file identify the code location. With
        /// several repositories in the environment, the file path must begin with the repository
        /// name. Maximum size 256 KB. Stored verbatim and normalized into the typed Finding members
        /// returned by GetCodeFinding. GetCodeFinding does not return the document itself.
        /// </summary>
        [AWSProperty(Required = true)]
        public Amazon.Runtime.Documents.Document OcsfDocument { get; set; }

        /// <summary>
        /// Checks to see if the OcsfDocument property is set.
        /// </summary>
        internal bool IsSetOcsfDocument() => !this.OcsfDocument.IsNull();
    }
}
