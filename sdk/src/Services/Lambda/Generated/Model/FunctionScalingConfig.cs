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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
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
namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Configuration that defines the scaling behavior for a Lambda Managed Instances function,
    /// including the minimum and maximum number of execution environments that can be provisioned.
    /// </summary>
    public partial class FunctionScalingConfig
    {
        private int? _maxExecutionEnvironments;
        private int? _minExecutionEnvironments;

        /// <summary>
        /// Gets and sets the property MaxExecutionEnvironments. 
        /// <para>
        /// The maximum number of execution environments that can be provisioned for the function.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=15000)]
        public int MaxExecutionEnvironments
        {
            get { return this._maxExecutionEnvironments.GetValueOrDefault(); }
            set { this._maxExecutionEnvironments = value; }
        }

        // Check to see if MaxExecutionEnvironments property is set
        internal bool IsSetMaxExecutionEnvironments()
        {
            return this._maxExecutionEnvironments.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinExecutionEnvironments. 
        /// <para>
        /// The minimum number of execution environments to maintain for the function.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=15000)]
        public int MinExecutionEnvironments
        {
            get { return this._minExecutionEnvironments.GetValueOrDefault(); }
            set { this._minExecutionEnvironments = value; }
        }

        // Check to see if MinExecutionEnvironments property is set
        internal bool IsSetMinExecutionEnvironments()
        {
            return this._minExecutionEnvironments.HasValue; 
        }

    }
}