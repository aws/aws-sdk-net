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
 * Do not modify this file. This file is generated from the swf-2012-01-25.normal.json service model.
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
namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// Contains details of a domain.
    /// </summary>
    public partial class DomainDetail
    {
        private DomainConfiguration _configuration;
        private DomainInfo _domainInfo;

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The domain configuration. Currently, this includes only the domain's retention period.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DomainConfiguration Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

        /// <summary>
        /// Gets and sets the property DomainInfo. 
        /// <para>
        /// The basic information about a domain, such as its name, status, and description.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DomainInfo DomainInfo
        {
            get { return this._domainInfo; }
            set { this._domainInfo = value; }
        }

        // Check to see if DomainInfo property is set
        internal bool IsSetDomainInfo()
        {
            return this._domainInfo != null;
        }

    }
}