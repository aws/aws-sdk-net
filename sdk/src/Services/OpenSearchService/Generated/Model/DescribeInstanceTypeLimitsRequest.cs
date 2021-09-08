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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeInstanceTypeLimits operation.
    /// Describe the limits for a given instance type and OpenSearch or Elasticsearch version.
    /// When modifying an existing domain, specify the <code> <a>DomainName</a> </code> to
    /// see which limits you can modify.
    /// </summary>
    public partial class DescribeInstanceTypeLimitsRequest : AmazonOpenSearchServiceRequest
    {
        private string _domainName;
        private string _engineVersion;
        private OpenSearchPartitionInstanceType _instanceType;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        ///  The name of the domain you want to modify. Only include this value if you're querying
        /// OpenSearch <code> <a>Limits</a> </code> for an existing domain. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=28)]
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
        /// Gets and sets the property EngineVersion. 
        /// <para>
        ///  Version of OpenSearch for which <code> <a>Limits</a> </code> are needed. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=14, Max=18)]
        public string EngineVersion
        {
            get { return this._engineVersion; }
            set { this._engineVersion = value; }
        }

        // Check to see if EngineVersion property is set
        internal bool IsSetEngineVersion()
        {
            return this._engineVersion != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        ///  The instance type for an OpenSearch cluster for which OpenSearch <code> <a>Limits</a>
        /// </code> are needed. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OpenSearchPartitionInstanceType InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

    }
}