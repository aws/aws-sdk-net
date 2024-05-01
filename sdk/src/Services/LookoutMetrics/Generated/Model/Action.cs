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
 * Do not modify this file. This file is generated from the lookoutmetrics-2017-07-25.normal.json service model.
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
namespace Amazon.LookoutMetrics.Model
{
    /// <summary>
    /// A configuration that specifies the action to perform when anomalies are detected.
    /// </summary>
    public partial class Action
    {
        private LambdaConfiguration _lambdaConfiguration;
        private SNSConfiguration _snsConfiguration;

        /// <summary>
        /// Gets and sets the property LambdaConfiguration. 
        /// <para>
        /// A configuration for an AWS Lambda channel.
        /// </para>
        /// </summary>
        public LambdaConfiguration LambdaConfiguration
        {
            get { return this._lambdaConfiguration; }
            set { this._lambdaConfiguration = value; }
        }

        // Check to see if LambdaConfiguration property is set
        internal bool IsSetLambdaConfiguration()
        {
            return this._lambdaConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property SNSConfiguration. 
        /// <para>
        /// A configuration for an Amazon SNS channel.
        /// </para>
        /// </summary>
        public SNSConfiguration SNSConfiguration
        {
            get { return this._snsConfiguration; }
            set { this._snsConfiguration = value; }
        }

        // Check to see if SNSConfiguration property is set
        internal bool IsSetSNSConfiguration()
        {
            return this._snsConfiguration != null;
        }

    }
}