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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
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
namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the GetDeployablePatchSnapshotForInstance operation.
    /// Retrieves the current snapshot for the patch baseline the managed node uses. This
    /// API is primarily used by the <c>AWS-RunPatchBaseline</c> Systems Manager document
    /// (SSM document).
    /// 
    ///  <note> 
    /// <para>
    /// If you run the command locally, such as with the Command Line Interface (CLI), the
    /// system attempts to use your local Amazon Web Services credentials and the operation
    /// fails. To avoid this, you can run the command in the Amazon Web Services Systems Manager
    /// console. Use Run Command, a tool in Amazon Web Services Systems Manager, with an SSM
    /// document that enables you to target a managed node with a script or command. For example,
    /// run the command using the <c>AWS-RunShellScript</c> document or the <c>AWS-RunPowerShellScript</c>
    /// document.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class GetDeployablePatchSnapshotForInstanceRequest : AmazonSimpleSystemsManagementRequest
    {
        private BaselineOverride _baselineOverride;
        private string _instanceId;
        private string _snapshotId;
        private bool? _useS3DualStackEndpoint;

        /// <summary>
        /// Gets and sets the property BaselineOverride. 
        /// <para>
        /// Defines the basic information about a patch baseline override.
        /// </para>
        /// </summary>
        public BaselineOverride BaselineOverride
        {
            get { return this._baselineOverride; }
            set { this._baselineOverride = value; }
        }

        // Check to see if BaselineOverride property is set
        internal bool IsSetBaselineOverride()
        {
            return this._baselineOverride != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the managed node for which the appropriate patch snapshot should be retrieved.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotId. 
        /// <para>
        /// The snapshot ID provided by the user when running <c>AWS-RunPatchBaseline</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string SnapshotId
        {
            get { return this._snapshotId; }
            set { this._snapshotId = value; }
        }

        // Check to see if SnapshotId property is set
        internal bool IsSetSnapshotId()
        {
            return this._snapshotId != null;
        }

        /// <summary>
        /// Gets and sets the property UseS3DualStackEndpoint. 
        /// <para>
        /// Specifies whether to use S3 dualstack endpoints for the patch snapshot download URL.
        /// Set to <c>true</c> to receive a presigned URL that supports both IPv4 and IPv6 connectivity.
        /// Set to <c>false</c> to use standard IPv4-only endpoints. Default is <c>false</c>.
        /// This parameter is required for managed nodes in IPv6-only environments. 
        /// </para>
        /// </summary>
        public bool? UseS3DualStackEndpoint
        {
            get { return this._useS3DualStackEndpoint; }
            set { this._useS3DualStackEndpoint = value; }
        }

        // Check to see if UseS3DualStackEndpoint property is set
        internal bool IsSetUseS3DualStackEndpoint()
        {
            return this._useS3DualStackEndpoint.HasValue; 
        }

    }
}