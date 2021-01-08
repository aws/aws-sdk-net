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

namespace Amazon.CloudSearch.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeIndexFields operation.
    /// Gets information about the index fields configured for the search domain. Can be limited
    /// to specific fields by name. By default, shows all fields and includes any pending
    /// changes to the configuration. Set the <code>Deployed</code> option to <code>true</code>
    /// to show the active configuration and exclude pending changes. For more information,
    /// see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/getting-domain-info.html"
    /// target="_blank">Getting Domain Information</a> in the <i>Amazon CloudSearch Developer
    /// Guide</i>.
    /// </summary>
    public partial class DescribeIndexFieldsRequest : AmazonCloudSearchRequest
    {
        private bool? _deployed;
        private string _domainName;
        private List<string> _fieldNames = new List<string>();

        /// <summary>
        /// Gets and sets the property Deployed. 
        /// <para>
        /// Whether to display the deployed configuration (<code>true</code>) or include any pending
        /// changes (<code>false</code>). Defaults to <code>false</code>.
        /// </para>
        /// </summary>
        public bool Deployed
        {
            get { return this._deployed.GetValueOrDefault(); }
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
        /// Gets and sets the property FieldNames. 
        /// <para>
        /// A list of the index fields you want to describe. If not specified, information is
        /// returned for all configured index fields.
        /// </para>
        /// </summary>
        public List<string> FieldNames
        {
            get { return this._fieldNames; }
            set { this._fieldNames = value; }
        }

        // Check to see if FieldNames property is set
        internal bool IsSetFieldNames()
        {
            return this._fieldNames != null && this._fieldNames.Count > 0; 
        }

    }
}