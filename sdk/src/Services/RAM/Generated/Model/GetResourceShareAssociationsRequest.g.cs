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

namespace Amazon.RAM.Model
{
    /// <summary>
    /// Container for the parameters to the GetResourceShareAssociations operation. Retrieves
    /// the lists of resources and principals that associated for resource shares that you
    /// own. <note> <para> Always check the <c>NextToken</c> response parameter for a <c>null</c>
    /// value when calling a paginated operation. These operations can occasionally return
    /// an empty set of results even when there are more results available. The <c>NextToken</c>
    /// response parameter value is <c>null</c> <i>only</i> when there are no more results
    /// to display. </para> </note>
    /// </summary>
    public partial class GetResourceShareAssociationsRequest : AmazonRAMRequest
    {
        /// <summary>
        /// Gets and sets the property AssociationStatus. 
        /// <para>
        /// Specifies that you want to retrieve only associations that have this status.
        /// </para>
        /// </summary>
        public ResourceShareAssociationStatus AssociationStatus { get; set; }

        /// <summary>
        /// Checks to see if the AssociationStatus property is set.
        /// </summary>
        internal bool IsSetAssociationStatus() => this.AssociationStatus != null;

        /// <summary>
        /// Gets and sets the property AssociationType. 
        /// <para>
        /// Specifies whether you want to retrieve the associations that involve a specified resource
        /// or principal.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PRINCIPAL</c> – list the principals whose associations you want to see.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RESOURCE</c> – list the resources whose associations you want to see.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public ResourceShareAssociationType AssociationType { get; set; }

        /// <summary>
        /// Checks to see if the AssociationType property is set.
        /// </summary>
        internal bool IsSetAssociationType() => this.AssociationType != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Specifies the total number of results that you want included on each page of the response.
        /// If you do not include this parameter, it defaults to a value that is specific to the
        /// operation. If additional items exist beyond the number you specify, the <c>NextToken</c>
        /// response element is returned with a value (not null). Include the specified value
        /// as the <c>NextToken</c> request parameter in the next call to the operation to get
        /// the next part of the results. Note that the service might return fewer results than
        /// the maximum even when there are more results available. You should check <c>NextToken</c>
        /// after every operation to ensure that you receive all of the results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 500)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Specifies that you want to receive the next page of results. Valid only if you received
        /// a <c>NextToken</c> response in the previous request. If you did, it indicates that
        /// more output is available. Set this parameter to the value provided by the previous
        /// call's <c>NextToken</c> response to request the next page of results.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property Principal. 
        /// <para>
        /// Specifies the ID of the principal whose resource shares you want to retrieve. This
        /// can be an Amazon Web Services account ID, an organization ID, an organizational unit
        /// ID, or the <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> of an individual IAM role or user.
        /// </para>
        ///  
        /// <para>
        /// You cannot specify this parameter if the association type is <c>RESOURCE</c>.
        /// </para>
        /// </summary>
        public string Principal { get; set; }

        /// <summary>
        /// Checks to see if the Principal property is set.
        /// </summary>
        internal bool IsSetPrincipal() => this.Principal != null;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// Specifies the <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> of a resource whose resource shares you want to retrieve.
        /// </para>
        ///  
        /// <para>
        /// You cannot specify this parameter if the association type is <c>PRINCIPAL</c>.
        /// </para>
        /// </summary>
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;

        /// <summary>
        /// Gets and sets the property ResourceShareArns. 
        /// <para>
        /// Specifies a list of <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs)</a> of the resource share whose associations you want to retrieve.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ResourceShareArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ResourceShareArns property is set.
        /// </summary>
        internal bool IsSetResourceShareArns() => this.ResourceShareArns != null && (this.ResourceShareArns.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
