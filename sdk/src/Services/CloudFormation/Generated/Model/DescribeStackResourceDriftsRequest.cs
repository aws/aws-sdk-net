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
    /// Container for the parameters to the DescribeStackResourceDrifts operation.
    /// Returns drift information for the resources that have been checked for drift in the
    /// specified stack. This includes actual and expected configuration values for resources
    /// where CloudFormation detects configuration drift.
    /// 
    ///  
    /// <para>
    /// For a given stack, there will be one <c>StackResourceDrift</c> for each stack resource
    /// that has been checked for drift. Resources that haven't yet been checked for drift
    /// aren't included. Resources that don't currently support drift detection aren't checked,
    /// and so not included. For a list of resources that support drift detection, see <a
    /// href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/resource-import-supported-resources.html">Resource
    /// type support for imports and drift detection</a>.
    /// </para>
    ///  
    /// <para>
    /// Use <a>DetectStackResourceDrift</a> to detect drift on individual resources, or <a>DetectStackDrift</a>
    /// to detect drift on all supported resources for a given stack.
    /// </para>
    /// </summary>
    public partial class DescribeStackResourceDriftsRequest : AmazonCloudFormationRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private string _stackName;
        private List<string> _stackResourceDriftStatusFilters = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to be returned with a single call. If the number of
        /// available results exceeds this maximum, the response includes a <c>NextToken</c> value
        /// that you can assign to the <c>NextToken</c> request parameter to get the next set
        /// of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// A string that identifies the next page of stack resource drift results.
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
        /// Gets and sets the property StackName. 
        /// <para>
        /// The name of the stack for which you want drift information.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string StackName
        {
            get { return this._stackName; }
            set { this._stackName = value; }
        }

        // Check to see if StackName property is set
        internal bool IsSetStackName()
        {
            return this._stackName != null;
        }

        /// <summary>
        /// Gets and sets the property StackResourceDriftStatusFilters. 
        /// <para>
        /// The resource drift status values to use as filters for the resource drift results
        /// returned.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DELETED</c>: The resource differs from its expected template configuration in
        /// that the resource has been deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MODIFIED</c>: One or more resource properties differ from their expected template
        /// values.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IN_SYNC</c>: The resource's actual configuration matches its expected template
        /// configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NOT_CHECKED</c>: CloudFormation doesn't currently return this value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UNKNOWN</c>: CloudFormation could not run drift detection for the resource.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=4)]
        public List<string> StackResourceDriftStatusFilters
        {
            get { return this._stackResourceDriftStatusFilters; }
            set { this._stackResourceDriftStatusFilters = value; }
        }

        // Check to see if StackResourceDriftStatusFilters property is set
        internal bool IsSetStackResourceDriftStatusFilters()
        {
            return this._stackResourceDriftStatusFilters != null && (this._stackResourceDriftStatusFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}