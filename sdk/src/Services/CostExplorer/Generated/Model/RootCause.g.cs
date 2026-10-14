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

namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// The combination of Amazon Web Services service, linked account, linked account name,
    /// Region, and usage type where a cost anomaly is observed, along with the dollar and
    /// percentage amount of the anomaly impact. The linked account name will only be available
    /// when the account name can be identified.
    /// </summary>
    public partial class RootCause
    {
        /// <summary>
        /// Gets and sets the property Impact. 
        /// <para>
        /// The dollar impact for the root cause.
        /// </para>
        /// </summary>
        public RootCauseImpact Impact { get; set; }

        /// <summary>
        /// Checks to see if the Impact property is set.
        /// </summary>
        internal bool IsSetImpact() => this.Impact != null;

        /// <summary>
        /// Gets and sets the property LinkedAccount. 
        /// <para>
        /// The member account value that's associated with the cost anomaly. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string LinkedAccount { get; set; }

        /// <summary>
        /// Checks to see if the LinkedAccount property is set.
        /// </summary>
        internal bool IsSetLinkedAccount() => this.LinkedAccount != null;

        /// <summary>
        /// Gets and sets the property LinkedAccountName. 
        /// <para>
        /// The member account name value that's associated with the cost anomaly.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string LinkedAccountName { get; set; }

        /// <summary>
        /// Checks to see if the LinkedAccountName property is set.
        /// </summary>
        internal bool IsSetLinkedAccountName() => this.LinkedAccountName != null;

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Amazon Web Services Region that's associated with the cost anomaly. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;

        /// <summary>
        /// Gets and sets the property Service. 
        /// <para>
        /// The Amazon Web Services service name that's associated with the cost anomaly. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Service { get; set; }

        /// <summary>
        /// Checks to see if the Service property is set.
        /// </summary>
        internal bool IsSetService() => this.Service != null;

        /// <summary>
        /// Gets and sets the property UsageType. 
        /// <para>
        /// The <c>UsageType</c> value that's associated with the cost anomaly. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string UsageType { get; set; }

        /// <summary>
        /// Checks to see if the UsageType property is set.
        /// </summary>
        internal bool IsSetUsageType() => this.UsageType != null;
    }
}
