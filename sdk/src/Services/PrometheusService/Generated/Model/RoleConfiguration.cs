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
 * Do not modify this file. This file is generated from the amp-2020-08-01.normal.json service model.
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
    /// Use this structure to enable cross-account access, so that you can use a target account
    /// to access Prometheus metrics from source accounts.
    /// </summary>
    public partial class RoleConfiguration
    {
        private string _sourceRoleArn;
        private string _targetRoleArn;

        /// <summary>
        /// Gets and sets the property SourceRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the role used in the source account to enable cross-account
        /// scraping. For information about the contents of this policy, see <a href="https://docs.aws.amazon.com/prometheus/latest/userguide/AMP-collector-how-to.html#cross-account-remote-write">Cross-account
        /// setup</a>.
        /// </para>
        /// </summary>
        public string SourceRoleArn
        {
            get { return this._sourceRoleArn; }
            set { this._sourceRoleArn = value; }
        }

        // Check to see if SourceRoleArn property is set
        internal bool IsSetSourceRoleArn()
        {
            return this._sourceRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property TargetRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the role used in the target account to enable cross-account
        /// scraping. For information about the contents of this policy, see <a href="https://docs.aws.amazon.com/prometheus/latest/userguide/AMP-collector-how-to.html#cross-account-remote-write">Cross-account
        /// setup</a>.
        /// </para>
        /// </summary>
        public string TargetRoleArn
        {
            get { return this._targetRoleArn; }
            set { this._targetRoleArn = value; }
        }

        // Check to see if TargetRoleArn property is set
        internal bool IsSetTargetRoleArn()
        {
            return this._targetRoleArn != null;
        }

    }
}