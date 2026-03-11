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
 * Do not modify this file. This file is generated from the amp-2020-08-01.normal.json service model.
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
namespace Amazon.PrometheusService.Model
{
    /// <summary>
    /// Container for the parameters to the PutResourcePolicy operation.
    /// Creates or updates a resource-based policy for an Amazon Managed Service for Prometheus
    /// workspace. Use resource-based policies to grant permissions to other AWS accounts
    /// or services to access your workspace.
    /// 
    ///  
    /// <para>
    /// Only Prometheus-compatible APIs can be used for workspace sharing. You can add non-Prometheus-compatible
    /// APIs to the policy, but they will be ignored. For more information, see <a href="https://docs.aws.amazon.com/prometheus/latest/userguide/AMP-APIReference-Prometheus-Compatible-Apis.html">Prometheus-compatible
    /// APIs</a> in the <i>Amazon Managed Service for Prometheus User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// If your workspace uses customer-managed KMS keys for encryption, you must grant the
    /// principals in your resource-based policy access to those KMS keys. You can do this
    /// by creating KMS grants. For more information, see <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_CreateGrant.html">CreateGrant</a>
    /// in the <i>AWS Key Management Service API Reference</i> and <a href="https://docs.aws.amazon.com/prometheus/latest/userguide/encryption-at-rest-Amazon-Service-Prometheus.html">Encryption
    /// at rest</a> in the <i>Amazon Managed Service for Prometheus User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// For more information about working with IAM, see <a href="https://docs.aws.amazon.com/prometheus/latest/userguide/security_iam_service-with-iam.html">Using
    /// Amazon Managed Service for Prometheus with IAM</a> in the <i>Amazon Managed Service
    /// for Prometheus User Guide</i>.
    /// </para>
    /// </summary>
    public partial class PutResourcePolicyRequest : AmazonPrometheusServiceRequest
    {
        private string _clientToken;
        private string _policyDocument;
        private string _revisionId;
        private string _workspaceId;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the request is safe
        /// to retry (idempotent).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyDocument. 
        /// <para>
        /// The JSON policy document to use as the resource-based policy. This policy defines
        /// the permissions that other AWS accounts or services have to access your workspace.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PolicyDocument
        {
            get { return this._policyDocument; }
            set { this._policyDocument = value; }
        }

        // Check to see if PolicyDocument property is set
        internal bool IsSetPolicyDocument()
        {
            return this._policyDocument != null;
        }

        /// <summary>
        /// Gets and sets the property RevisionId. 
        /// <para>
        /// The revision ID of the policy to update. Use this parameter to ensure that you are
        /// updating the correct version of the policy. If you don't specify a revision ID, the
        /// policy is updated regardless of its current revision.
        /// </para>
        ///  
        /// <para>
        /// For the first <b>PUT</b> request on a workspace that doesn't have an existing resource
        /// policy, you can specify <c>NO_POLICY</c> as the revision ID.
        /// </para>
        /// </summary>
        public string RevisionId
        {
            get { return this._revisionId; }
            set { this._revisionId = value; }
        }

        // Check to see if RevisionId property is set
        internal bool IsSetRevisionId()
        {
            return this._revisionId != null;
        }

        /// <summary>
        /// Gets and sets the property WorkspaceId. 
        /// <para>
        /// The ID of the workspace to attach the resource-based policy to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string WorkspaceId
        {
            get { return this._workspaceId; }
            set { this._workspaceId = value; }
        }

        // Check to see if WorkspaceId property is set
        internal bool IsSetWorkspaceId()
        {
            return this._workspaceId != null;
        }

    }
}