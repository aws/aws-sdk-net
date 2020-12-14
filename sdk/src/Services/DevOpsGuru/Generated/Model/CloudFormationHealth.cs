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
 * Do not modify this file. This file is generated from the devops-guru-2020-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DevOpsGuru.Model
{
    /// <summary>
    /// Information about the health of AWS resources in your account that are specified
    /// by an AWS CloudFormation stack.
    /// </summary>
    public partial class CloudFormationHealth
    {
        private InsightHealth _insight;
        private string _stackName;

        /// <summary>
        /// Gets and sets the property Insight. 
        /// <para>
        ///  Information about the health of the AWS resources in your account that are specified
        /// by an AWS CloudFormation stack, including the number of open proactive, open reactive
        /// insights, and the Mean Time to Recover (MTTR) of closed insights. 
        /// </para>
        /// </summary>
        public InsightHealth Insight
        {
            get { return this._insight; }
            set { this._insight = value; }
        }

        // Check to see if Insight property is set
        internal bool IsSetInsight()
        {
            return this._insight != null;
        }

        /// <summary>
        /// Gets and sets the property StackName. 
        /// <para>
        ///  The name of the CloudFormation stack. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string StackName
        {
            get { return this._stackName; }
            set { this._stackName = value; }
        }

        // Check to see if StackName property is set
        internal bool IsSetStackName()
        {
            return this._stackName != null;
        }

    }
}