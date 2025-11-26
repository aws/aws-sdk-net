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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains information about the incremental scan configuration.
    /// </summary>
    public partial class IncrementalScanDetails
    {
        private string _baselineResourceArn;

        /// <summary>
        /// Gets and sets the property BaselineResourceArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the baseline resource used for incremental scanning.
        /// The scan will only process changes since this baseline resource was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public string BaselineResourceArn
        {
            get { return this._baselineResourceArn; }
            set { this._baselineResourceArn = value; }
        }

        // Check to see if BaselineResourceArn property is set
        internal bool IsSetBaselineResourceArn()
        {
            return this._baselineResourceArn != null;
        }

    }
}