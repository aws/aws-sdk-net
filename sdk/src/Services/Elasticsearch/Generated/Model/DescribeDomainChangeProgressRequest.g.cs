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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.Elasticsearch.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeDomainChangeProgress operation. Returns
    /// information about the current blue/green deployment happening on a domain, including
    /// a change ID, status, and progress stages.
    /// </summary>
    public partial class DescribeDomainChangeProgressRequest : AmazonElasticsearchRequest
    {
        /// <summary>
        /// Gets and sets the property ChangeId. 
        /// <para>
        /// The specific change ID for which you want to get progress information. This is an
        /// optional parameter. If omitted, the service returns information about the most recent
        /// configuration change. 
        /// </para>
        /// </summary>
        public string ChangeId { get; set; }

        /// <summary>
        /// Checks to see if the ChangeId property is set.
        /// </summary>
        internal bool IsSetChangeId() => this.ChangeId != null;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The domain you want to get the progress information about.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 28)]
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;
    }
}
