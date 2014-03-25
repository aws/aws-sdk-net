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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudSearch.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeServiceAccessPolicies operation.
    /// <para>Gets information about the access policies that control access to the domain's document and search endpoints. By default, shows the
    /// configuration with any pending changes. Set the <c>Deployed</c> option to <c>true</c> to show the active configuration and exclude pending
    /// changes. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-access.html"
    /// >Configuring Access for a Search Domain</a> in the <i>Amazon CloudSearch Developer Guide</i> .</para>
    /// </summary>
    public partial class DescribeServiceAccessPoliciesRequest : AmazonCloudSearchRequest
    {
        private string domainName;
        private bool? deployed;


        /// <summary>
        /// The name of the domain you want to describe.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>3 - 28</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[a-z][a-z0-9\-]+</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string DomainName
        {
            get { return this.domainName; }
            set { this.domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this.domainName != null;
        }

        /// <summary>
        /// Whether to display the deployed configuration (<c>true</c>) or include any pending changes (<c>false</c>). Defaults to <c>false</c>.
        ///  
        /// </summary>
        public bool Deployed
        {
            get { return this.deployed ?? default(bool); }
            set { this.deployed = value; }
        }

        // Check to see if Deployed property is set
        internal bool IsSetDeployed()
        {
            return this.deployed.HasValue;
        }

    }
}
    
