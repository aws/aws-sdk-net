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

namespace Amazon.PrometheusService.Model
{
    /// <summary>
    /// The source of collected metrics for a scraper.
    /// </summary>
    public partial class Source
    {
        /// <summary>
        /// Gets and sets the property EksConfiguration. 
        /// <para>
        /// The Amazon EKS cluster from which a scraper collects metrics.
        /// </para>
        /// </summary>
        public EksConfiguration EksConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EksConfiguration property is set.
        /// </summary>
        internal bool IsSetEksConfiguration() => this.EksConfiguration != null;

        /// <summary>
        /// Gets and sets the property VpcConfiguration. 
        /// <para>
        /// The Amazon VPC configuration for the Prometheus collector when connecting to Amazon
        /// MSK clusters. This configuration enables secure, private network connectivity between
        /// the collector and your Amazon MSK cluster within your Amazon VPC.
        /// </para>
        /// </summary>
        public VpcConfiguration VpcConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the VpcConfiguration property is set.
        /// </summary>
        internal bool IsSetVpcConfiguration() => this.VpcConfiguration != null;
    }
}
