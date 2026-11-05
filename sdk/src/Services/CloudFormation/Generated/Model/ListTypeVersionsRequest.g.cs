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

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Container for the parameters to the ListTypeVersions operation. Returns summary information
    /// about the versions of an extension.
    /// </summary>
    public partial class ListTypeVersionsRequest : AmazonCloudFormationRequest
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the extension for which you want version summary
        /// information.
        /// </para>
        ///  
        /// <para>
        /// Conditional: You must specify either <c>TypeName</c> and <c>Type</c>, or <c>Arn</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property DeprecatedStatus. 
        /// <para>
        /// The deprecation status of the extension versions that you want to get summary information
        /// about.
        /// </para>
        ///  
        /// <para>
        /// Valid values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>LIVE</c>: The extension version is registered and can be used in CloudFormation
        /// operations, dependent on its provisioning behavior and visibility scope.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DEPRECATED</c>: The extension version has been deregistered and can no longer
        /// be used in CloudFormation operations.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The default is <c>LIVE</c>.
        /// </para>
        /// </summary>
        public DeprecatedStatus DeprecatedStatus { get; set; }

        /// <summary>
        /// Checks to see if the DeprecatedStatus property is set.
        /// </summary>
        internal bool IsSetDeprecatedStatus() => this.DeprecatedStatus != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to be returned with a single call. If the number of
        /// available results exceeds this maximum, the response includes a <c>NextToken</c> value
        /// that you can assign to the <c>NextToken</c> request parameter to get the next set
        /// of results.
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
        /// The token for the next set of items to return. (You received this token from a previous
        /// call.)
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property PublisherId. 
        /// <para>
        /// The publisher ID of the extension publisher.
        /// </para>
        ///  
        /// <para>
        /// Extensions published by Amazon aren't assigned a publisher ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 40)]
        public string PublisherId { get; set; }

        /// <summary>
        /// Checks to see if the PublisherId property is set.
        /// </summary>
        internal bool IsSetPublisherId() => this.PublisherId != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The kind of the extension.
        /// </para>
        ///  
        /// <para>
        /// Conditional: You must specify either <c>TypeName</c> and <c>Type</c>, or <c>Arn</c>.
        /// </para>
        /// </summary>
        public RegistryType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property TypeName. 
        /// <para>
        /// The name of the extension for which you want version summary information.
        /// </para>
        ///  
        /// <para>
        /// Conditional: You must specify either <c>TypeName</c> and <c>Type</c>, or <c>Arn</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 204)]
        public string TypeName { get; set; }

        /// <summary>
        /// Checks to see if the TypeName property is set.
        /// </summary>
        internal bool IsSetTypeName() => this.TypeName != null;
    }
}
