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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Container for the parameters to the ListTypeVersions operation.
    /// Returns summary information about the versions of a type.
    /// </summary>
    public partial class ListTypeVersionsRequest : AmazonCloudFormationRequest
    {
        private string _arn;
        private DeprecatedStatus _deprecatedStatus;
        private int? _maxResults;
        private string _nextToken;
        private RegistryType _type;
        private string _typeName;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the type for which you want version summary information.
        /// </para>
        ///  
        /// <para>
        /// Conditional: You must specify either <code>TypeName</code> and <code>Type</code>,
        /// or <code>Arn</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property DeprecatedStatus. 
        /// <para>
        /// The deprecation status of the type versions that you want to get summary information
        /// about.
        /// </para>
        ///  
        /// <para>
        /// Valid values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>LIVE</code>: The type version is registered and can be used in CloudFormation
        /// operations, dependent on its provisioning behavior and visibility scope.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DEPRECATED</code>: The type version has been deregistered and can no longer
        /// be used in CloudFormation operations. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The default is <code>LIVE</code>.
        /// </para>
        /// </summary>
        public DeprecatedStatus DeprecatedStatus
        {
            get { return this._deprecatedStatus; }
            set { this._deprecatedStatus = value; }
        }

        // Check to see if DeprecatedStatus property is set
        internal bool IsSetDeprecatedStatus()
        {
            return this._deprecatedStatus != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to be returned with a single call. If the number of
        /// available results exceeds this maximum, the response includes a <code>NextToken</code>
        /// value that you can assign to the <code>NextToken</code> request parameter to get the
        /// next set of results.
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
        [AWSProperty(Min=1, Max=1024)]
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
        /// Gets and sets the property Type. 
        /// <para>
        /// The kind of the type.
        /// </para>
        ///  
        /// <para>
        /// Currently the only valid value is <code>RESOURCE</code>.
        /// </para>
        ///  
        /// <para>
        /// Conditional: You must specify either <code>TypeName</code> and <code>Type</code>,
        /// or <code>Arn</code>.
        /// </para>
        /// </summary>
        public RegistryType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property TypeName. 
        /// <para>
        /// The name of the type for which you want version summary information.
        /// </para>
        ///  
        /// <para>
        /// Conditional: You must specify either <code>TypeName</code> and <code>Type</code>,
        /// or <code>Arn</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=204)]
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

    }
}