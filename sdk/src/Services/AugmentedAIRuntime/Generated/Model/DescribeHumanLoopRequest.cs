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
 * Do not modify this file. This file is generated from the sagemaker-a2i-runtime-2019-11-07.normal.json service model.
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
namespace Amazon.AugmentedAIRuntime.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeHumanLoop operation.
    /// Returns information about the specified human loop. If the human loop was deleted,
    /// this operation will return a <c>ResourceNotFoundException</c> error.
    /// </summary>
    public partial class DescribeHumanLoopRequest : AmazonAugmentedAIRuntimeRequest
    {
        private string _humanLoopName;

        /// <summary>
        /// Gets and sets the property HumanLoopName. 
        /// <para>
        /// The name of the human loop that you want information about.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string HumanLoopName
        {
            get { return this._humanLoopName; }
            set { this._humanLoopName = value; }
        }

        // Check to see if HumanLoopName property is set
        internal bool IsSetHumanLoopName()
        {
            return this._humanLoopName != null;
        }

    }
}