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
 * Do not modify this file. This file is generated from the cloudsearch-2013-01-01.normal.json service model.
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
namespace Amazon.CloudSearch.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeExpressions operation.
    /// Gets the expressions configured for the search domain. Can be limited to specific
    /// expressions by name. By default, shows all expressions and includes any pending changes
    /// to the configuration. Set the <c>Deployed</c> option to <c>true</c> to show the active
    /// configuration and exclude pending changes. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-expressions.html"
    /// target="_blank">Configuring Expressions</a> in the <i>Amazon CloudSearch Developer
    /// Guide</i>.
    /// </summary>
    public partial class DescribeExpressionsRequest : AmazonCloudSearchRequest
    {
        private bool? _deployed;
        private string _domainName;
        private List<string> _expressionNames = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Deployed. 
        /// <para>
        /// Whether to display the deployed configuration (<c>true</c>) or include any pending
        /// changes (<c>false</c>). Defaults to <c>false</c>.
        /// </para>
        /// </summary>
        public bool? Deployed
        {
            get { return this._deployed; }
            set { this._deployed = value; }
        }

        // Check to see if Deployed property is set
        internal bool IsSetDeployed()
        {
            return this._deployed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The name of the domain you want to describe.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=28)]
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

        /// <summary>
        /// Gets and sets the property ExpressionNames. 
        /// <para>
        /// Limits the <c><a>DescribeExpressions</a></c> response to the specified expressions.
        /// If not specified, all expressions are shown.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ExpressionNames
        {
            get { return this._expressionNames; }
            set { this._expressionNames = value; }
        }

        // Check to see if ExpressionNames property is set
        internal bool IsSetExpressionNames()
        {
            return this._expressionNames != null && (this._expressionNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}