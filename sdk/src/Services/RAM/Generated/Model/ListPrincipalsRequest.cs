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
 * Do not modify this file. This file is generated from the ram-2018-01-04.normal.json service model.
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
    /// Container for the parameters to the ListPrincipals operation.
    /// Lists the principals that you are sharing resources with or that are sharing resources
    /// with you.
    /// </summary>
    public partial class ListPrincipalsRequest : AmazonRAMRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private List<string> _principals = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _resourceArn;
        private ResourceOwner _resourceOwner;
        private List<string> _resourceShareArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _resourceType;

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
        [AWSProperty(Min=1, Max=500)]
        public int? MaxResults
        {
            get { return this._maxResults; }
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
        /// Specifies that you want to receive the next page of results. Valid only if you received
        /// a <c>NextToken</c> response in the previous request. If you did, it indicates that
        /// more output is available. Set this parameter to the value provided by the previous
        /// call's <c>NextToken</c> response to request the next page of results.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Principals. 
        /// <para>
        /// Specifies that you want to list information for only the listed principals.
        /// </para>
        ///  
        /// <para>
        /// You can include the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// An Amazon Web Services account ID, for example: <c>123456789012</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> of an organization in Organizations, for example: <c>organizations::123456789012:organization/o-exampleorgid</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An ARN of an organizational unit (OU) in Organizations, for example: <c>organizations::123456789012:ou/o-exampleorgid/ou-examplerootid-exampleouid123</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An ARN of an IAM role, for example: <c>iam::123456789012:role/rolename</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An ARN of an IAM user, for example: <c>iam::123456789012user/username</c> 
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// Not all resource types can be shared with IAM roles and users. For more information,
        /// see <a href="https://docs.aws.amazon.com/ram/latest/userguide/permissions.html#permissions-rbp-supported-resource-types">Sharing
        /// with IAM roles and users</a> in the <i>Resource Access Manager User Guide</i>.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Principals
        {
            get { return this._principals; }
            set { this._principals = value; }
        }

        // Check to see if Principals property is set
        internal bool IsSetPrincipals()
        {
            return this._principals != null && (this._principals.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// Specifies that you want to list principal information for the resource share with
        /// the specified <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a>.
        /// </para>
        /// </summary>
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceOwner. 
        /// <para>
        /// Specifies that you want to list information for only resource shares that match the
        /// following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <c>SELF</c> </b> – principals that your account is sharing resources with
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>OTHER-ACCOUNTS</c> </b> – principals that are sharing resources with your
        /// account
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public ResourceOwner ResourceOwner
        {
            get { return this._resourceOwner; }
            set { this._resourceOwner = value; }
        }

        // Check to see if ResourceOwner property is set
        internal bool IsSetResourceOwner()
        {
            return this._resourceOwner != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceShareArns. 
        /// <para>
        /// Specifies that you want to list information for only principals associated with the
        /// resource shares specified by a list the <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs)</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ResourceShareArns
        {
            get { return this._resourceShareArns; }
            set { this._resourceShareArns = value; }
        }

        // Check to see if ResourceShareArns property is set
        internal bool IsSetResourceShareArns()
        {
            return this._resourceShareArns != null && (this._resourceShareArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// Specifies that you want to list information for only principals associated with resource
        /// shares that include the specified resource type.
        /// </para>
        ///  
        /// <para>
        /// For a list of valid values, query the <a>ListResourceTypes</a> operation.
        /// </para>
        /// </summary>
        public string ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

    }
}