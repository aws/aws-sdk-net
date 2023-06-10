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
    /// Container for the parameters to the CreateResource operation.
    /// Creates the specified resource. For more information, see <a href="https://docs.aws.amazon.com/cloudcontrolapi/latest/userguide/resource-operations-create.html">Creating
    /// a resource</a> in the <i>Amazon Web Services Cloud Control API User Guide</i>.
    /// 
    ///  
    /// <para>
    /// After you have initiated a resource creation request, you can monitor the progress
    /// of your request by calling <a href="https://docs.aws.amazon.com/cloudcontrolapi/latest/APIReference/API_GetResourceRequestStatus.html">GetResourceRequestStatus</a>
    /// using the <code>RequestToken</code> of the <code>ProgressEvent</code> type returned
    /// by <code>CreateResource</code>.
    /// </para>
    /// </summary>
    public partial class CreateResourceRequest : AmazonCloudControlApiRequest
    {
        private string _clientToken;
        private string _desiredState;
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
        /// Gets and sets the property DesiredState. 
        /// <para>
        /// Structured data format representing the desired state of the resource, consisting
        /// of that resource's properties and their desired values.
        /// </para>
        ///  <note> 
        /// <para>
        /// Cloud Control API currently supports JSON as a structured data format.
        /// </para>
        ///  </note> <pre><code> &lt;p&gt;Specify the desired state as one of the following:&lt;/p&gt;
        /// &lt;ul&gt; &lt;li&gt; &lt;p&gt;A JSON blob&lt;/p&gt; &lt;/li&gt; &lt;li&gt; &lt;p&gt;A
        /// local path containing the desired state in JSON data format&lt;/p&gt; &lt;/li&gt;
        /// &lt;/ul&gt; &lt;p&gt;For more information, see &lt;a href=&quot;https://docs.aws.amazon.com/cloudcontrolapi/latest/userguide/resource-operations-create.html#resource-operations-create-desiredstate&quot;&gt;Composing
        /// the desired state of the resource&lt;/a&gt; in the &lt;i&gt;Amazon Web Services Cloud
        /// Control API User Guide&lt;/i&gt;.&lt;/p&gt; &lt;p&gt;For more information about the
        /// properties of a specific resource, refer to the related topic for the resource in
        /// the &lt;a href=&quot;https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-template-resource-type-ref.html&quot;&gt;Resource
        /// and property types reference&lt;/a&gt; in the &lt;i&gt;CloudFormation Users Guide&lt;/i&gt;.&lt;/p&gt;
        /// </code></pre>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=65536)]
        public string DesiredState
        {
            get { return this._desiredState; }
            set { this._desiredState = value; }
        }

        // Check to see if DesiredState property is set
        internal bool IsSetDesiredState()
        {
            return this._desiredState != null;
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