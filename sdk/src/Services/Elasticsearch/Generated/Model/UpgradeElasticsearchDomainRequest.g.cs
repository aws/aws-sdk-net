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
    /// Container for the parameters to the UpgradeElasticsearchDomain operation. Allows you
    /// to either upgrade your domain or perform an Upgrade eligibility check to a compatible
    /// Elasticsearch version.
    /// </summary>
    public partial class UpgradeElasticsearchDomainRequest : AmazonElasticsearchRequest
    {
        /// <summary>
        /// Gets and sets the property DomainName.
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 28)]
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property PerformCheckOnly. 
        /// <para>
        ///  This flag, when set to True, indicates that an Upgrade Eligibility Check needs to
        /// be performed. This will not actually perform the Upgrade. 
        /// </para>
        /// </summary>
        public bool? PerformCheckOnly { get; set; }

        /// <summary>
        /// Checks to see if the PerformCheckOnly property is set.
        /// </summary>
        internal bool IsSetPerformCheckOnly() => this.PerformCheckOnly.HasValue;

        /// <summary>
        /// Gets and sets the property TargetVersion. 
        /// <para>
        /// The version of Elasticsearch that you intend to upgrade the domain to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TargetVersion { get; set; }

        /// <summary>
        /// Checks to see if the TargetVersion property is set.
        /// </summary>
        internal bool IsSetTargetVersion() => this.TargetVersion != null;
    }
}
