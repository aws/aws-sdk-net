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

namespace Amazon.IVS.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateFailoverSlateConfiguration operation. Updates
    /// a specified failover slate configuration.
    /// </summary>
    public partial class UpdateFailoverSlateConfigurationRequest : AmazonIVSRequest
    {
        /// <summary>
        /// Gets and sets the property ActivationThresholdSeconds. 
        /// <para>
        /// Number of seconds of ingest interruption before the failover slate activates. Default:
        /// <c>3</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 5)]
        public int? ActivationThresholdSeconds { get; set; }

        /// <summary>
        /// Checks to see if the ActivationThresholdSeconds property is set.
        /// </summary>
        internal bool IsSetActivationThresholdSeconds() => this.ActivationThresholdSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// ARN of the failover slate configuration to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 128)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property MaxSlateDisplaySeconds. 
        /// <para>
        /// Maximum number of seconds that the failover slate displays. Default: <c>60</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 60, Max = 180)]
        public int? MaxSlateDisplaySeconds { get; set; }

        /// <summary>
        /// Checks to see if the MaxSlateDisplaySeconds property is set.
        /// </summary>
        internal bool IsSetMaxSlateDisplaySeconds() => this.MaxSlateDisplaySeconds.HasValue;

        /// <summary>
        /// Gets and sets the property MinSlateDisplaySeconds. 
        /// <para>
        /// Minimum number of seconds that the failover slate displays after activation. Default:
        /// <c>3</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 10)]
        public int? MinSlateDisplaySeconds { get; set; }

        /// <summary>
        /// Checks to see if the MinSlateDisplaySeconds property is set.
        /// </summary>
        internal bool IsSetMinSlateDisplaySeconds() => this.MinSlateDisplaySeconds.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Failover-slate-configuration name. The value does not need to be unique.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
