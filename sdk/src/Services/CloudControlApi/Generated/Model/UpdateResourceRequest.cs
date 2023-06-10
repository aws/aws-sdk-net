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
 * Do not modify this file. This file is generated from the cloudcontrol-2021-09-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudControlApi.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateResource operation.
    /// Updates the specified property values in the resource.
    /// 
    ///  
    /// <para>
    /// You specify your resource property updates as a list of patch operations contained
    /// in a JSON patch document that adheres to the <a href="https://datatracker.ietf.org/doc/html/rfc6902">
    /// <i>RFC 6902 - JavaScript Object Notation (JSON) Patch</i> </a> standard.
    /// </para>
    ///  
    /// <para>
    /// For details on how Cloud Control API performs resource update operations, see <a href="https://docs.aws.amazon.com/cloudcontrolapi/latest/userguide/resource-operations-update.html">Updating
    /// a resource</a> in the <i>Amazon Web Services Cloud Control API User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// After you have initiated a resource update request, you can monitor the progress of
    /// your request by calling <a href="https://docs.aws.amazon.com/cloudcontrolapi/latest/APIReference/API_GetResourceRequestStatus.html">GetResourceRequestStatus</a>
    /// using the <code>RequestToken</code> of the <code>ProgressEvent</code> returned by
    /// <code>UpdateResource</code>.
    /// </para>
    ///  
    /// <para>
    /// For more information about the properties of a specific resource, refer to the related
    /// topic for the resource in the <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-template-resource-type-ref.html">Resource
    /// and property types reference</a> in the <i>CloudFormation Users Guide</i>.
    /// </para>
    /// </summary>
    public partial class UpdateResourceRequest : AmazonCloudControlApiRequest
    {
        private string _clientToken;
        private string _identifier;
        private string _patchDocument;
        private string _roleArn;
        private string _typeName;
        private string _typeVersionId;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique identifier to ensure the idempotency of the resource request. As a best practice,
        /// specify this token to ensure idempotency, so that Amazon Web Services Cloud Control
        /// API can accurately distinguish between request retries and new resource requests.
        /// You might retry a resource request to ensure that it was successfully received.
        /// </para>
        ///  
        /// <para>
        /// A client token is valid for 36 hours once used. After that, a resource request with
        /// the same client token is treated as a new request.
        /// </para>
        ///  
        /// <para>
        /// If you do not specify a client token, one is generated for inclusion in the request.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/cloudcontrolapi/latest/userguide/resource-operations.html#resource-operations-idempotency">Ensuring
        /// resource operation requests are unique</a> in the <i>Amazon Web Services Cloud Control
        /// API User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The identifier for the resource.
        /// </para>
        ///  
        /// <para>
        /// You can specify the primary identifier, or any secondary identifier defined for the
        /// resource type in its resource schema. You can only specify one identifier. Primary
        /// identifiers can be specified as a string or JSON; secondary identifiers must be specified
        /// as JSON.
        /// </para>
        ///  
        /// <para>
        /// For compound primary identifiers (that is, one that consists of multiple resource
        /// properties strung together), to specify the primary identifier as a string, list the
        /// property values <i>in the order they are specified</i> in the primary identifier definition,
        /// separated by <code>|</code>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/cloudcontrolapi/latest/userguide/resource-identifier.html">Identifying
        /// resources</a> in the <i>Amazon Web Services Cloud Control API User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

        /// <summary>
        /// Gets and sets the property PatchDocument. 
        /// <para>
        /// A JavaScript Object Notation (JSON) document listing the patch operations that represent
        /// the updates to apply to the current resource properties. For details, see <a href="https://docs.aws.amazon.com/cloudcontrolapi/latest/userguide/resource-operations-update.html#resource-operations-update-patch">Composing
        /// the patch document</a> in the <i>Amazon Web Services Cloud Control API User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=65536)]
        public string PatchDocument
        {
            get { return this._patchDocument; }
            set { this._patchDocument = value; }
        }

        // Check to see if PatchDocument property is set
        internal bool IsSetPatchDocument()
        {
            return this._patchDocument != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Identity and Access Management (IAM) role for
        /// Cloud Control API to use when performing this resource operation. The role specified
        /// must have the permissions required for this operation. The necessary permissions for
        /// each event handler are defined in the <code> <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/userguide/resource-type-schema.html#schema-properties-handlers">handlers</a>
        /// </code> section of the <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/userguide/resource-type-schema.html">resource
        /// type definition schema</a>.
        /// </para>
        ///  
        /// <para>
        /// If you do not specify a role, Cloud Control API uses a temporary session created using
        /// your Amazon Web Services user credentials.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/cloudcontrolapi/latest/userguide/resource-operations.html#resource-operations-permissions">Specifying
        /// credentials</a> in the <i>Amazon Web Services Cloud Control API User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property TypeName. 
        /// <para>
        /// The name of the resource type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=196)]
        public string TypeName
        {
            get { return this._typeName; }
            set { this._typeName = value; }
        }

        // Check to see if TypeName property is set
        internal bool IsSetTypeName()
        {
            return this._typeName != null;
        }

        /// <summary>
        /// Gets and sets the property TypeVersionId. 
        /// <para>
        /// For private resource types, the type version to use in this resource operation. If
        /// you do not specify a resource version, CloudFormation uses the default version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string TypeVersionId
        {
            get { return this._typeVersionId; }
            set { this._typeVersionId = value; }
        }

        // Check to see if TypeVersionId property is set
        internal bool IsSetTypeVersionId()
        {
            return this._typeVersionId != null;
        }

    }
}