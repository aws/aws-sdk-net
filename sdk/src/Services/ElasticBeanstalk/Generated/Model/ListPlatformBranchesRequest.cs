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
 * Do not modify this file. This file is generated from the elasticbeanstalk-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// Container for the parameters to the ListPlatformBranches operation.
    /// Lists the platform branches available for your account in an AWS Region. Provides
    /// summary information about each platform branch.
    /// 
    ///  
    /// <para>
    /// For definitions of platform branch and other platform-related terms, see <a href="https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/platforms-glossary.html">AWS
    /// Elastic Beanstalk Platforms Glossary</a>.
    /// </para>
    /// </summary>
    public partial class ListPlatformBranchesRequest : AmazonElasticBeanstalkRequest
    {
        private List<SearchFilter> _filters = new List<SearchFilter>();
        private int? _maxRecords;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// Criteria for restricting the resulting list of platform branches. The filter is evaluated
        /// as a logical conjunction (AND) of the separate <code>SearchFilter</code> terms.
        /// </para>
        ///  
        /// <para>
        /// The following list shows valid attribute values for each of the <code>SearchFilter</code>
        /// terms. Most operators take a single value. The <code>in</code> and <code>not_in</code>
        /// operators can take multiple values.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Attribute = BranchName</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Operator</code>: <code>=</code> | <code>!=</code> | <code>begins_with</code>
        /// | <code>ends_with</code> | <code>contains</code> | <code>in</code> | <code>not_in</code>
        /// 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <code>Attribute = LifecycleState</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Operator</code>: <code>=</code> | <code>!=</code> | <code>in</code> | <code>not_in</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Values</code>: <code>beta</code> | <code>supported</code> | <code>deprecated</code>
        /// | <code>retired</code> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <code>Attribute = PlatformName</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Operator</code>: <code>=</code> | <code>!=</code> | <code>begins_with</code>
        /// | <code>ends_with</code> | <code>contains</code> | <code>in</code> | <code>not_in</code>
        /// 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <code>Attribute = TierType</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Operator</code>: <code>=</code> | <code>!=</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Values</code>: <code>WebServer/Standard</code> | <code>Worker/SQS/HTTP</code>
        /// 
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// Array size: limited to 10 <code>SearchFilter</code> objects.
        /// </para>
        ///  
        /// <para>
        /// Within each <code>SearchFilter</code> item, the <code>Values</code> array is limited
        /// to 10 items.
        /// </para>
        /// </summary>
        public List<SearchFilter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxRecords. 
        /// <para>
        /// The maximum number of platform branch values returned in one call.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int MaxRecords
        {
            get { return this._maxRecords.GetValueOrDefault(); }
            set { this._maxRecords = value; }
        }

        // Check to see if MaxRecords property is set
        internal bool IsSetMaxRecords()
        {
            return this._maxRecords.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// For a paginated request. Specify a token from a previous response page to retrieve
        /// the next response page. All other parameter values must be identical to the ones specified
        /// in the initial request.
        /// </para>
        ///  
        /// <para>
        /// If no <code>NextToken</code> is specified, the first page is retrieved.
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