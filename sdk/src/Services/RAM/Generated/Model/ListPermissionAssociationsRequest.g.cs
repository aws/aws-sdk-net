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
    /// Container for the parameters to the ListPermissionAssociations operation. Lists information
    /// about the managed permission and its associations to any resource shares that use
    /// this managed permission. This lets you see which resource shares use which versions
    /// of the specified managed permission. <note> <para> Always check the <c>NextToken</c>
    /// response parameter for a <c>null</c> value when calling a paginated operation. These
    /// operations can occasionally return an empty set of results even when there are more
    /// results available. The <c>NextToken</c> response parameter value is <c>null</c> <i>only</i>
    /// when there are no more results to display. </para> </note>
    /// </summary>
    public partial class ListPermissionAssociationsRequest : AmazonRAMRequest
    {
        /// <summary>
        /// Gets and sets the property AssociationStatus. 
        /// <para>
        /// Specifies that you want to list only those associations with resource shares that
        /// match this status.
        /// </para>
        /// </summary>
        public ResourceShareAssociationStatus AssociationStatus { get; set; }

        /// <summary>
        /// Checks to see if the AssociationStatus property is set.
        /// </summary>
        internal bool IsSetAssociationStatus() => this.AssociationStatus != null;

        /// <summary>
        /// Gets and sets the property DefaultVersion. 
        /// <para>
        /// When <c>true</c>, specifies that you want to list only those associations with resource
        /// shares that use the default version of the specified managed permission.
        /// </para>
        ///  
        /// <para>
        /// When <c>false</c> (the default value), lists associations with resource shares that
        /// use any version of the specified managed permission.
        /// </para>
        /// </summary>
        public bool? DefaultVersion { get; set; }

        /// <summary>
        /// Checks to see if the DefaultVersion property is set.
        /// </summary>
        internal bool IsSetDefaultVersion() => this.DefaultVersion.HasValue;

        /// <summary>
        /// Gets and sets the property FeatureSet. 
        /// <para>
        /// Specifies that you want to list only those associations with resource shares that
        /// have a <c>featureSet</c> with this value.
        /// </para>
        /// </summary>
        public PermissionFeatureSet FeatureSet { get; set; }

        /// <summary>
        /// Checks to see if the FeatureSet property is set.
        /// </summary>
        internal bool IsSetFeatureSet() => this.FeatureSet != null;

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
        /// Gets and sets the property PermissionArn. 
        /// <para>
        /// Specifies the <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> of the managed permission.
        /// </para>
        /// </summary>
        public string PermissionArn { get; set; }

        /// <summary>
        /// Checks to see if the PermissionArn property is set.
        /// </summary>
        internal bool IsSetPermissionArn() => this.PermissionArn != null;

        /// <summary>
        /// Gets and sets the property PermissionVersion. 
        /// <para>
        /// Specifies that you want to list only those associations with resource shares that
        /// use this version of the managed permission. If you don't provide a value for this
        /// parameter, then the operation returns information about associations with resource
        /// shares that use any version of the managed permission.
        /// </para>
        /// </summary>
        public int? PermissionVersion { get; set; }

        /// <summary>
        /// Checks to see if the PermissionVersion property is set.
        /// </summary>
        internal bool IsSetPermissionVersion() => this.PermissionVersion.HasValue;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// Specifies that you want to list only those associations with resource shares that
        /// include at least one resource of this resource type.
        /// </para>
        /// </summary>
        public string ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;
    }
}
