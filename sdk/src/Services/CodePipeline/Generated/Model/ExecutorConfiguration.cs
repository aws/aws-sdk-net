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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
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
namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// The action engine, or executor, related to the supported integration model used to
    /// create and update the action type. The available executor types are <c>Lambda</c>
    /// and <c>JobWorker</c>.
    /// </summary>
    public partial class ExecutorConfiguration
    {
        private JobWorkerExecutorConfiguration _jobWorkerExecutorConfiguration;
        private LambdaExecutorConfiguration _lambdaExecutorConfiguration;

        /// <summary>
        /// Gets and sets the property JobWorkerExecutorConfiguration. 
        /// <para>
        /// Details about the <c>JobWorker</c> executor of the action type.
        /// </para>
        /// </summary>
        public JobWorkerExecutorConfiguration JobWorkerExecutorConfiguration
        {
            get { return this._jobWorkerExecutorConfiguration; }
            set { this._jobWorkerExecutorConfiguration = value; }
        }

        // Check to see if JobWorkerExecutorConfiguration property is set
        internal bool IsSetJobWorkerExecutorConfiguration()
        {
            return this._jobWorkerExecutorConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property LambdaExecutorConfiguration. 
        /// <para>
        /// Details about the <c>Lambda</c> executor of the action type.
        /// </para>
        /// </summary>
        public LambdaExecutorConfiguration LambdaExecutorConfiguration
        {
            get { return this._lambdaExecutorConfiguration; }
            set { this._lambdaExecutorConfiguration = value; }
        }

        // Check to see if LambdaExecutorConfiguration property is set
        internal bool IsSetLambdaExecutorConfiguration()
        {
            return this._lambdaExecutorConfiguration != null;
        }

    }
}