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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// This is the response object from the DescribeStackResourceDrifts operation.
    /// </summary>
    public partial class DescribeStackResourceDriftsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<StackResourceDrift> _stackResourceDrifts = AWSConfigs.InitializeCollections ? new List<StackResourceDrift>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the request doesn't return all the remaining results, <c>NextToken</c> is set to
        /// a token. To retrieve the next set of results, call <c>DescribeStackResourceDrifts</c>
        /// again and assign that token to the request object's <c>NextToken</c> parameter. If
        /// the request returns all results, <c>NextToken</c> is set to <c>null</c>.
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
        /// Gets and sets the property StackResourceDrifts. 
        /// <para>
        /// Drift information for the resources that have been checked for drift in the specified
        /// stack. This includes actual and expected configuration values for resources where
        /// CloudFormation detects drift.
        /// </para>
        ///  
        /// <para>
        /// For a given stack, there will be one <c>StackResourceDrift</c> for each stack resource
        /// that has been checked for drift. Resources that haven't yet been checked for drift
        /// aren't included. Resources that do not currently support drift detection aren't checked,
        /// and so not included. For a list of resources that support drift detection, see <a
        /// href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/resource-import-supported-resources.html">Resource
        /// type support for imports and drift detection</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<StackResourceDrift> StackResourceDrifts
        {
            get { return this._stackResourceDrifts; }
            set { this._stackResourceDrifts = value; }
        }

        // Check to see if StackResourceDrifts property is set
        internal bool IsSetStackResourceDrifts()
        {
            return this._stackResourceDrifts != null && (this._stackResourceDrifts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}