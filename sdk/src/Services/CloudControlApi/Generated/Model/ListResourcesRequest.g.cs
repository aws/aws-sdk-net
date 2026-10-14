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

namespace Amazon.CloudControlApi.Model
{
    /// <summary>
    /// Container for the parameters to the ListResources operation. Returns information about
    /// the specified resources. For more information, see <a href="https://docs.aws.amazon.com/cloudcontrolapi/latest/userguide/resource-operations-list.html">Discovering
    /// resources</a> in the <i>Amazon Web Services Cloud Control API User Guide</i>. <para>
    /// You can use this action to return information about existing resources in your account
    /// and Amazon Web Services Region, whether those resources were provisioned using Cloud
    /// Control API. </para>
    /// </summary>
    public partial class ListResourcesRequest : AmazonCloudControlApiRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Reserved.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the previous paginated request didn't return all of the remaining results, the
        /// response object's <c>NextToken</c> parameter value is set to a token. To retrieve
        /// the next set of results, call this action again and assign that token to the request
        /// object's <c>NextToken</c> parameter. If there are no remaining results, the previous
        /// response object's <c>NextToken</c> parameter is set to <c>null</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ResourceModel. 
        /// <para>
        /// The resource model to use to select the resources to return.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 262144)]
        public string ResourceModel { get; set; }

        /// <summary>
        /// Checks to see if the ResourceModel property is set.
        /// </summary>
        internal bool IsSetResourceModel() => this.ResourceModel != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Identity and Access Management (IAM) role for
        /// Cloud Control API to use when performing this resource operation. The role specified
        /// must have the permissions required for this operation. The necessary permissions for
        /// each event handler are defined in the <c> <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/userguide/resource-type-schema.html#schema-properties-handlers">handlers</a>
        /// </c> section of the <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/userguide/resource-type-schema.html">resource
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
        [AWSProperty(Min = 20, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property TypeName. 
        /// <para>
        /// The name of the resource type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 196)]
        public string TypeName { get; set; }

        /// <summary>
        /// Checks to see if the TypeName property is set.
        /// </summary>
        internal bool IsSetTypeName() => this.TypeName != null;

        /// <summary>
        /// Gets and sets the property TypeVersionId. 
        /// <para>
        /// For private resource types, the type version to use in this resource operation. If
        /// you do not specify a resource version, CloudFormation uses the default version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string TypeVersionId { get; set; }

        /// <summary>
        /// Checks to see if the TypeVersionId property is set.
        /// </summary>
        internal bool IsSetTypeVersionId() => this.TypeVersionId != null;
    }
}
