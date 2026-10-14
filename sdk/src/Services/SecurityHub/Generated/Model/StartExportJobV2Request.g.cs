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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Container for the parameters to the StartExportJobV2 operation. Starts an ad hoc export
    /// job that writes Security Hub findings to an Amazon Simple Storage Service (Amazon
    /// S3) bucket that you own. Because the export runs asynchronously, this operation returns
    /// only the <c>ExportJobId</c> of the new job; it doesn't wait for the export to finish.
    /// Use <c>GetExportJobV2</c> to poll the job, and <c>ListExportJobsV2</c> to view the
    /// export jobs in your account. <para> Security Hub allows only one export job in the
    /// <c>RUNNING</c> state per account at a time. If an export job is already running, this
    /// operation returns a <c>ServiceQuotaExceededException</c>. Wait for the running job
    /// to finish, or cancel it with <c>CancelExportJobV2</c>, before you start a new one.
    /// </para> <para> Specify the destination bucket and Amazon Web Services Key Management
    /// Service (Amazon Web Services KMS) key in the <c>Destination</c> parameter, and the
    /// output format (<c>CSV</c> or <c>OCSF_JSON</c>), optional filters, and field selection
    /// in the <c>OutputConfiguration</c> parameter. Before you call this operation, you must
    /// grant Security Hub permission to write to your bucket and use your Amazon Web Services
    /// KMS key by adding the bucket policy and key policy statements shown in the Examples
    /// section. </para> <para> Two identities use your Amazon Web Services KMS key, and each
    /// needs its own permission. Security Hub uses the key when it writes the export objects
    /// to your bucket. The IAM principal that calls <c>StartExportJobV2</c> must also have
    /// <c>kms:GenerateDataKey</c> and <c>kms:Decrypt</c> permissions on the key. The Examples
    /// section shows both grants. </para> <para> A delegated administrator can use the optional
    /// <c>Scopes</c> parameter to export findings for specific organizations or organizational
    /// units (OUs). </para> <para> To make the request idempotent, provide a <c>ClientToken</c>.
    /// If you retry a <c>StartExportJobV2</c> request with the same <c>ClientToken</c> and
    /// the same request parameters, Security Hub returns the <c>ExportJobId</c> of the original
    /// job instead of starting a new one. If you reuse a <c>ClientToken</c> with different
    /// request parameters, this operation returns a <c>ConflictException</c>. </para>
    /// </summary>
    public partial class StartExportJobV2Request : AmazonSecurityHubRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique identifier used to ensure idempotency.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The destination that Security Hub writes the export to. You must specify exactly one
        /// destination type. Currently, the only supported type is Amazon S3.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ExportDestination Destination { get; set; }

        /// <summary>
        /// Checks to see if the Destination property is set.
        /// </summary>
        internal bool IsSetDestination() => this.Destination != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// An optional, user-provided name for the export job that helps you identify it in <c>ListExportJobsV2</c>
        /// results. The value can be 1–256 characters. Alphanumeric characters, spaces, and the
        /// following ASCII characters are permitted: <c>. _ , : ( ) / + -</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OutputConfiguration. 
        /// <para>
        /// Specifies what data to export and how to format it. You must specify exactly one output
        /// type. Currently, the only supported type is <c>Findings</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ExportOutput OutputConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the OutputConfiguration property is set.
        /// </summary>
        internal bool IsSetOutputConfiguration() => this.OutputConfiguration != null;

        /// <summary>
        /// Gets and sets the property Scopes. 
        /// <para>
        /// Limits the export to findings from specific organizational units (OUs) or from the
        /// delegated administrator's organization. Only the delegated administrator account can
        /// use this parameter; other accounts that specify it receive an <c>AccessDeniedException</c>.
        /// </para>
        ///  
        /// <para>
        /// This parameter is optional. If you omit it, the delegated administrator exports findings
        /// from all accounts across the entire organization, and other accounts export only their
        /// own findings.
        /// </para>
        ///  
        /// <para>
        /// You can specify up to 10 entries in <c>Scopes.AwsOrganizations</c>. If you specify
        /// multiple entries, Security Hub combines them using OR logic.
        /// </para>
        /// </summary>
        public ExportScopes Scopes { get; set; }

        /// <summary>
        /// Checks to see if the Scopes property is set.
        /// </summary>
        internal bool IsSetScopes() => this.Scopes != null;
    }
}
