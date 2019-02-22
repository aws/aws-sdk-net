/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the ListTriggers operation.
    /// Retrieves the names of all trigger resources in this AWS account, or the resources
    /// with the specified tag. This operation allows you to see which resources are available
    /// in your account, and their names.
    /// 
    ///  
    /// <para>
    /// This operation takes the optional <code>Tags</code> field which you can use as a filter
    /// on the response so that tagged resources can be retrieved as a group. If you choose
    /// to use tags filtering, only resources with the tag will be retrieved.
    /// </para>
    /// </summary>
    public partial class ListTriggersRequest : AmazonGlueRequest
    {
        private string _dependentJobName;
        private int? _maxResults;
        private string _nextToken;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property DependentJobName. 
        /// <para>
        ///  The name of the job for which to retrieve triggers. The trigger that can start this
        /// job will be returned, and if there is no such trigger, all triggers will be returned.
        /// </para>
        /// </summary>
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
        /// The maximum size of a list to return.
        /// </para>
        /// </summary>
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
        /// A continuation token, if this is a continuation request.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Specifies to return only these tagged resources.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}