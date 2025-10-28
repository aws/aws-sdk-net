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
 * Do not modify this file. This file is generated from the application-signals-2024-04-15.normal.json service model.
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
namespace Amazon.ApplicationSignals.Model
{
    /// <summary>
    /// Represents a CloudWatch Synthetics canary that can be audited for performance and
    /// configuration issues.
    /// </summary>
    public partial class CanaryEntity
    {
        private string _canaryName;

        /// <summary>
        /// Gets and sets the property CanaryName. 
        /// <para>
        /// The name of the CloudWatch Synthetics canary.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CanaryName
        {
            get { return this._canaryName; }
            set { this._canaryName = value; }
        }

        // Check to see if CanaryName property is set
        internal bool IsSetCanaryName()
        {
            return this._canaryName != null;
        }

    }
}