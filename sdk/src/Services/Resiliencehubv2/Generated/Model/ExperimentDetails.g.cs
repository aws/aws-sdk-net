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

namespace Amazon.Resiliencehubv2.Model
{
    /// <summary>
    /// Details about an AWS Fault Injection Service (AWS FIS) experiment run as part of a
    /// test run.
    /// </summary>
    public partial class ExperimentDetails
    {
        /// <summary>
        /// Gets and sets the property Details. 
        /// <para>
        /// Additional details about the experiment.
        /// </para>
        /// </summary>
        public string Details { get; set; }

        /// <summary>
        /// Checks to see if the Details property is set.
        /// </summary>
        internal bool IsSetDetails() => this.Details != null;

        /// <summary>
        /// Gets and sets the property ExperimentArn. 
        /// <para>
        /// The ARN of the AWS FIS experiment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 31)]
        public string ExperimentArn { get; set; }

        /// <summary>
        /// Checks to see if the ExperimentArn property is set.
        /// </summary>
        internal bool IsSetExperimentArn() => this.ExperimentArn != null;
    }
}
