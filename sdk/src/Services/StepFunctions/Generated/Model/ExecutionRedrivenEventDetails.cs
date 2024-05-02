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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.StepFunctions.Model
{
    /// <summary>
    /// Contains details about a redriven execution.
    /// </summary>
    public partial class ExecutionRedrivenEventDetails
    {
        private int? _redriveCount;

        /// <summary>
        /// Gets and sets the property RedriveCount. 
        /// <para>
        /// The number of times you've redriven an execution. If you have not yet redriven an
        /// execution, the <c>redriveCount</c> is 0. This count is not updated for redrives that
        /// failed to start or are pending to be redriven.
        /// </para>
        /// </summary>
        public int? RedriveCount
        {
            get { return this._redriveCount; }
            set { this._redriveCount = value; }
        }

        // Check to see if RedriveCount property is set
        internal bool IsSetRedriveCount()
        {
            return this._redriveCount.HasValue; 
        }

    }
}