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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
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
namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Defines the rules by which an image pipeline is automatically disabled when it fails.
    /// </summary>
    public partial class AutoDisablePolicy
    {
        private int? _failureCount;

        /// <summary>
        /// Gets and sets the property FailureCount. 
        /// <para>
        /// The number of consecutive scheduled image pipeline executions that must fail before
        /// Image Builder automatically disables the pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public int? FailureCount
        {
            get { return this._failureCount; }
            set { this._failureCount = value; }
        }

        // Check to see if FailureCount property is set
        internal bool IsSetFailureCount()
        {
            return this._failureCount.HasValue; 
        }

    }
}