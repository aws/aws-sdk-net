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
    /// Container for the parameters to the ListResources operation.
    /// Returns information about the specified resources. For more information, see <a href="https://docs.aws.amazon.com/cloudcontrolapi/latest/userguide/resource-operations-list.html">Discovering
    /// resources</a> in the <i>Amazon Web Services Cloud Control API User Guide</i>.
    /// 
    ///  
    /// <para>
    /// You can use this action to return information about existing resources in your account
    /// and Amazon Web Services Region, whether those resources were provisioned using Cloud
    /// Control API.
    /// </para>
    /// </summary>
    public partial class ListResourcesRequest : AmazonCloudControlApiRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private string _resourceModel;
        private string _roleArn;
        private string _typeName;
        private string _typeVersionId;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Reserved.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the previous paginated request didn't return all of the remaining results, the
        /// response object's <code>NextToken</code> parameter value is set to a token. To retrieve
        /// the next set of results, call this action again and assign that token to the request
        /// object's <code>NextToken</code> parameter. If there are no remaining results, the
        /// previous response object's <code>NextToken</code> parameter is set to <code>null</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceModel. 
        /// <para>
        /// The resource model to use to select the resources to return.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=65536)]
        public string ResourceModel
        {
            get { return this._resourceModel; }
            set { this._resourceModel = value; }
        }

        // Check to see if ResourceModel property is set
        internal bool IsSetResourceModel()
        {
            return this._resourceModel != null;
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