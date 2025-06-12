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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
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
namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// Filtering that specifies which web requests are kept in the logs and which are dropped,
    /// defined for a web ACL's <a>LoggingConfiguration</a>. 
    /// 
    ///  
    /// <para>
    /// You can filter on the rule action and on the web request labels that were applied
    /// by matching rules during web ACL evaluation. 
    /// </para>
    /// </summary>
    public partial class LoggingFilter
    {
        private FilterBehavior _defaultBehavior;
        private List<Filter> _filters = AWSConfigs.InitializeCollections ? new List<Filter>() : null;

        /// <summary>
        /// Gets and sets the property DefaultBehavior. 
        /// <para>
        /// Default handling for logs that don't match any of the specified filtering conditions.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FilterBehavior DefaultBehavior
        {
            get { return this._defaultBehavior; }
            set { this._defaultBehavior = value; }
        }

        // Check to see if DefaultBehavior property is set
        internal bool IsSetDefaultBehavior()
        {
            return this._defaultBehavior != null;
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The filters that you want to apply to the logs. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
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

    }
}