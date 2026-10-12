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

namespace Amazon.AppRunner.Model
{
    /// <summary>
    /// Provides summary information about an App Runner observability configuration resource.
    /// 
    ///  
    /// <para>
    /// This type contains limited information about an observability configuration. It includes
    /// only identification information, without configuration details. It's returned by the
    /// <a>ListObservabilityConfigurations</a> action. Complete configuration information
    /// is returned by the <a>CreateObservabilityConfiguration</a>, <a>DescribeObservabilityConfiguration</a>,
    /// and <a>DeleteObservabilityConfiguration</a> actions using the <a>ObservabilityConfiguration</a>
    /// type.
    /// </para>
    /// </summary>
    public partial class ObservabilityConfigurationSummary
    {
        /// <summary>
        /// Gets and sets the property ObservabilityConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of this observability configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1011)]
        public string ObservabilityConfigurationArn { get; set; }

        /// <summary>
        /// Checks to see if the ObservabilityConfigurationArn property is set.
        /// </summary>
        internal bool IsSetObservabilityConfigurationArn() => this.ObservabilityConfigurationArn != null;

        /// <summary>
        /// Gets and sets the property ObservabilityConfigurationName. 
        /// <para>
        /// The customer-provided observability configuration name. It can be used in multiple
        /// revisions of a configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 4, Max = 32)]
        public string ObservabilityConfigurationName { get; set; }

        /// <summary>
        /// Checks to see if the ObservabilityConfigurationName property is set.
        /// </summary>
        internal bool IsSetObservabilityConfigurationName() => this.ObservabilityConfigurationName != null;

        /// <summary>
        /// Gets and sets the property ObservabilityConfigurationRevision. 
        /// <para>
        /// The revision of this observability configuration. It's unique among all the active
        /// configurations (<c>"Status": "ACTIVE"</c>) that share the same <c>ObservabilityConfigurationName</c>.
        /// </para>
        /// </summary>
        public int? ObservabilityConfigurationRevision { get; set; }

        /// <summary>
        /// Checks to see if the ObservabilityConfigurationRevision property is set.
        /// </summary>
        internal bool IsSetObservabilityConfigurationRevision() => this.ObservabilityConfigurationRevision.HasValue;
    }
}
