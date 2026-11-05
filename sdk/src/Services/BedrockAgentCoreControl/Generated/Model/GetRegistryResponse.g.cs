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

namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// This is the response object from the GetRegistry operation.
    /// </summary>
    public partial class GetRegistryResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ApprovalConfiguration. 
        /// <para>
        /// The approval configuration for registry records. For details, see the <c>ApprovalConfiguration</c>
        /// data type.
        /// </para>
        /// </summary>
        public ApprovalConfiguration ApprovalConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ApprovalConfiguration property is set.
        /// </summary>
        internal bool IsSetApprovalConfiguration() => this.ApprovalConfiguration != null;

        /// <summary>
        /// Gets and sets the property AuthorizerConfiguration. 
        /// <para>
        /// The authorizer configuration for the registry. For details, see the <c>AuthorizerConfiguration</c>
        /// data type.
        /// </para>
        /// </summary>
        public AuthorizerConfiguration AuthorizerConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizerConfiguration property is set.
        /// </summary>
        internal bool IsSetAuthorizerConfiguration() => this.AuthorizerConfiguration != null;

        /// <summary>
        /// Gets and sets the property AuthorizerType. 
        /// <para>
        /// The type of authorizer used by the registry. This controls the authorization method
        /// for the Search and Invoke APIs used by consumers.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CUSTOM_JWT</c> - Authorize with a bearer token.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS_IAM</c> - Authorize with your Amazon Web Services IAM credentials.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public RegistryAuthorizerType AuthorizerType { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizerType property is set.
        /// </summary>
        internal bool IsSetAuthorizerType() => this.AuthorizerType != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the registry was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the registry.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 4096)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the registry.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RegistryArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the registry.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RegistryArn { get; set; }

        /// <summary>
        /// Checks to see if the RegistryArn property is set.
        /// </summary>
        internal bool IsSetRegistryArn() => this.RegistryArn != null;

        /// <summary>
        /// Gets and sets the property RegistryId. 
        /// <para>
        /// The unique identifier of the registry.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 16)]
        public string RegistryId { get; set; }

        /// <summary>
        /// Checks to see if the RegistryId property is set.
        /// </summary>
        internal bool IsSetRegistryId() => this.RegistryId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the registry. Possible values include <c>CREATING</c>, <c>READY</c>,
        /// <c>UPDATING</c>, <c>CREATE_FAILED</c>, <c>UPDATE_FAILED</c>, <c>DELETING</c>, and
        /// <c>DELETE_FAILED</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RegistryStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// The reason for the current status, typically set when the status is a failure state.
        /// </para>
        /// </summary>
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the registry was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
