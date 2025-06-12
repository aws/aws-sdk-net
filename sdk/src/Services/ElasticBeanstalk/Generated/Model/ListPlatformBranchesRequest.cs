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
 * Do not modify this file. This file is generated from the elasticbeanstalk-2010-12-01.normal.json service model.
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
        private List<SearchFilter> _filters = AWSConfigs.InitializeCollections ? new List<SearchFilter>() : null;
        private int? _maxRecords;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// Criteria for restricting the resulting list of platform branches. The filter is evaluated
        /// as a logical conjunction (AND) of the separate <c>SearchFilter</c> terms.
        /// </para>
        ///  
        /// <para>
        /// The following list shows valid attribute values for each of the <c>SearchFilter</c>
        /// terms. Most operators take a single value. The <c>in</c> and <c>not_in</c> operators
        /// can take multiple values.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Attribute = BranchName</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Operator</c>: <c>=</c> | <c>!=</c> | <c>begins_with</c> | <c>ends_with</c> | <c>contains</c>
        /// | <c>in</c> | <c>not_in</c> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>Attribute = LifecycleState</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Operator</c>: <c>=</c> | <c>!=</c> | <c>in</c> | <c>not_in</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Values</c>: <c>beta</c> | <c>supported</c> | <c>deprecated</c> | <c>retired</c>
        /// 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>Attribute = PlatformName</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Operator</c>: <c>=</c> | <c>!=</c> | <c>begins_with</c> | <c>ends_with</c> | <c>contains</c>
        /// | <c>in</c> | <c>not_in</c> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>Attribute = TierType</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Operator</c>: <c>=</c> | <c>!=</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Values</c>: <c>WebServer/Standard</c> | <c>Worker/SQS/HTTP</c> 
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// Array size: limited to 10 <c>SearchFilter</c> objects.
        /// </para>
        ///  
        /// <para>
        /// Within each <c>SearchFilter</c> item, the <c>Values</c> array is limited to 10 items.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SearchFilter> Filters
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
        /// Gets and sets the property MaxRecords. 
        /// <para>
        /// The maximum number of platform branch values returned in one call.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? MaxRecords
        {
            get { return this._maxRecords; }
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
        /// If no <c>NextToken</c> is specified, the first page is retrieved.
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