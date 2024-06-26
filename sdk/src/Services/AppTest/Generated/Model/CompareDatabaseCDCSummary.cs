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
 * Do not modify this file. This file is generated from the apptest-2022-12-06.normal.json service model.
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
namespace Amazon.AppTest.Model
{
    /// <summary>
    /// Compares the database CDC summary.
    /// </summary>
    public partial class CompareDatabaseCDCSummary
    {
        private CompareDatabaseCDCStepInput _stepInput;
        private CompareDatabaseCDCStepOutput _stepOutput;

        /// <summary>
        /// Gets and sets the property StepInput. 
        /// <para>
        /// The step input of the compare database CDC summary.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CompareDatabaseCDCStepInput StepInput
        {
            get { return this._stepInput; }
            set { this._stepInput = value; }
        }

        // Check to see if StepInput property is set
        internal bool IsSetStepInput()
        {
            return this._stepInput != null;
        }

        /// <summary>
        /// Gets and sets the property StepOutput. 
        /// <para>
        /// The step output of the compare database CDC summary.
        /// </para>
        /// </summary>
        public CompareDatabaseCDCStepOutput StepOutput
        {
            get { return this._stepOutput; }
            set { this._stepOutput = value; }
        }

        // Check to see if StepOutput property is set
        internal bool IsSetStepOutput()
        {
            return this._stepOutput != null;
        }

    }
}