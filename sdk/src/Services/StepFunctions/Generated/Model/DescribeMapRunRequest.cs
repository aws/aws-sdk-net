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
 * Do not modify this file. This file is generated from the states-2016-11-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.StepFunctions.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeMapRun operation.
    /// Provides information about a Map Run's configuration, progress, and results. For more
    /// information, see <a href="https://docs.aws.amazon.com/step-functions/latest/dg/concepts-examine-map-run.html">Examining
    /// Map Run</a> in the <i>Step Functions Developer Guide</i>.
    /// </summary>
    public partial class DescribeMapRunRequest : AmazonStepFunctionsRequest
    {
        private string _mapRunArn;

        /// <summary>
        /// Gets and sets the property MapRunArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that identifies a Map Run.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2000)]
        public string MapRunArn
        {
            get { return this._mapRunArn; }
            set { this._mapRunArn = value; }
        }

        // Check to see if MapRunArn property is set
        internal bool IsSetMapRunArn()
        {
            return this._mapRunArn != null;
        }

    }
}