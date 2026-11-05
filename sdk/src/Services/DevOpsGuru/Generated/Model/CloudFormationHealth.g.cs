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

namespace Amazon.DevOpsGuru.Model
{
    /// <summary>
    /// Information about the health of Amazon Web Services resources in your account that
    /// are specified by an Amazon Web Services CloudFormation stack.
    /// </summary>
    public partial class CloudFormationHealth
    {
        /// <summary>
        /// Gets and sets the property AnalyzedResourceCount. 
        /// <para>
        ///  Number of resources that DevOps Guru is monitoring in your account that are specified
        /// by an Amazon Web Services CloudFormation stack. 
        /// </para>
        /// </summary>
        public long? AnalyzedResourceCount { get; set; }

        /// <summary>
        /// Checks to see if the AnalyzedResourceCount property is set.
        /// </summary>
        internal bool IsSetAnalyzedResourceCount() => this.AnalyzedResourceCount.HasValue;

        /// <summary>
        /// Gets and sets the property Insight. 
        /// <para>
        ///  Information about the health of the Amazon Web Services resources in your account
        /// that are specified by an Amazon Web Services CloudFormation stack, including the number
        /// of open proactive, open reactive insights, and the Mean Time to Recover (MTTR) of
        /// closed insights. 
        /// </para>
        /// </summary>
        public InsightHealth Insight { get; set; }

        /// <summary>
        /// Checks to see if the Insight property is set.
        /// </summary>
        internal bool IsSetInsight() => this.Insight != null;

        /// <summary>
        /// Gets and sets the property StackName. 
        /// <para>
        ///  The name of the CloudFormation stack. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string StackName { get; set; }

        /// <summary>
        /// Checks to see if the StackName property is set.
        /// </summary>
        internal bool IsSetStackName() => this.StackName != null;
    }
}
