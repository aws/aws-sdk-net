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
    /// Details about an Amazon CloudWatch datasource.
    /// </summary>
    public partial class CloudWatchConfig
    {
        private BackTestConfiguration _backTestConfiguration;
        private string _roleArn;

        /// <summary>
        /// Gets and sets the property BackTestConfiguration. 
        /// <para>
        /// Settings for backtest mode.
        /// </para>
        /// </summary>
        public BackTestConfiguration BackTestConfiguration
        {
            get { return this._backTestConfiguration; }
            set { this._backTestConfiguration = value; }
        }

        // Check to see if BackTestConfiguration property is set
        internal bool IsSetBackTestConfiguration()
        {
            return this._backTestConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// An IAM role that gives Amazon Lookout for Metrics permission to access data in Amazon
        /// CloudWatch.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

    }
}