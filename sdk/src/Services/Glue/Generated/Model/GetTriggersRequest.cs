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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the GetTriggers operation.
    /// Gets all the triggers associated with a job.
    /// </summary>
    public partial class GetTriggersRequest : AmazonGlueRequest
    {
        private string _dependentJobName;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property DependentJobName. 
        /// <para>
        /// The name of the job to retrieve triggers for. The trigger that can start this job
        /// is returned, and if there is no such trigger, all triggers are returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string DependentJobName
        {
            get { return this._dependentJobName; }
            set { this._dependentJobName = value; }
        }

        // Check to see if DependentJobName property is set
        internal bool IsSetDependentJobName()
        {
            return this._dependentJobName != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum size of the response.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
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
        /// A continuation token, if this is a continuation call.
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