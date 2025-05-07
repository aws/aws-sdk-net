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
 * Do not modify this file. This file is generated from the synthetics-2017-10-11.normal.json service model.
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
namespace Amazon.Synthetics.Model
{
    /// <summary>
    /// Returns the dry run configurations set for a canary.
    /// </summary>
    public partial class CanaryDryRunConfigOutput
    {
        private string _dryRunId;

        /// <summary>
        /// Gets and sets the property DryRunId. 
        /// <para>
        /// The DryRunId associated with an existing canary’s dry run. You can use this DryRunId
        /// to retrieve information about the dry run.
        /// </para>
        /// </summary>
        public string DryRunId
        {
            get { return this._dryRunId; }
            set { this._dryRunId = value; }
        }

        // Check to see if DryRunId property is set
        internal bool IsSetDryRunId()
        {
            return this._dryRunId != null;
        }

    }
}