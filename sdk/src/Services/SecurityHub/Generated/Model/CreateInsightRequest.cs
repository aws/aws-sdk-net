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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Container for the parameters to the CreateInsight operation.
    /// Creates a custom insight in Security Hub. An insight is a consolidation of findings
    /// that relate to a security issue that requires attention or remediation.
    /// 
    ///  
    /// <para>
    /// To group the related findings in the insight, use the <code>GroupByAttribute</code>.
    /// </para>
    /// </summary>
    public partial class CreateInsightRequest : AmazonSecurityHubRequest
    {
        private AwsSecurityFindingFilters _filters;
        private string _groupByAttribute;
        private string _name;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// One or more attributes used to filter the findings included in the insight. The insight
        /// only includes findings that match the criteria defined in the filters.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AwsSecurityFindingFilters Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null;
        }

        /// <summary>
        /// Gets and sets the property GroupByAttribute. 
        /// <para>
        /// The attribute used as the aggregator to group related findings for the insight.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string GroupByAttribute
        {
            get { return this._groupByAttribute; }
            set { this._groupByAttribute = value; }
        }

        // Check to see if GroupByAttribute property is set
        internal bool IsSetGroupByAttribute()
        {
            return this._groupByAttribute != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the custom insight to create.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}