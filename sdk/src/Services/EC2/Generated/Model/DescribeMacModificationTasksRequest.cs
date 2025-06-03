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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeMacModificationTasks operation.
    /// Describes a System Integrity Protection (SIP) modification task or volume ownership
    /// delegation task for an Amazon EC2 Mac instance. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/mac-sip-settings.html#mac-sip-configure">Configure
    /// SIP for Amazon EC2 instances</a> in the <i>Amazon EC2 User Guide</i>.
    /// </summary>
    public partial class DescribeMacModificationTasksRequest : AmazonEC2Request
    {
        private bool? _dryRun;
        private List<Filter> _filters = AWSConfigs.InitializeCollections ? new List<Filter>() : null;
        private List<string> _macModificationTaskIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// Specifies one or more filters for the request:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>instance-id</c> - The ID of the instance for which the task was created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>task-state</c> - The state of the task (<c>successful</c> | <c>failed</c> | <c>in-progress</c>
        /// | <c>pending</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>mac-system-integrity-protection-configuration.sip-status</c> - The overall SIP
        /// state requested in the task (<c>enabled</c> | <c>disabled</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>start-time</c> - The date and time the task was created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>task-type</c> - The type of task (<c>sip-modification</c> | <c>volume-ownership-delegation</c>).
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && (this._filters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MacModificationTaskIds. 
        /// <para>
        /// The ID of task.
        /// </para>
        /// </summary>
        public List<string> MacModificationTaskIds
        {
            get { return this._macModificationTaskIds; }
            set { this._macModificationTaskIds = value; }
        }

        // Check to see if MacModificationTaskIds property is set
        internal bool IsSetMacModificationTaskIds()
        {
            return this._macModificationTaskIds != null && (this._macModificationTaskIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return for the request in a single page. The remaining
        /// results can be seen by sending another request with the returned <c>nextToken</c>
        /// value. This value can be between 5 and 500. If <c>maxResults</c> is given a larger
        /// value than 500, you receive an error.
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
        /// The token to use to retrieve the next page of results.
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

    }
}