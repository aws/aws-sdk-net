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
    /// A union that defines what data to capture when the instrumentation point is hit. Specify
    /// <c>CodeCapture</c> for code-level capture settings.
    /// </summary>
    public partial class CaptureConfiguration
    {
        private CodeCaptureConfiguration _codeCapture;

        /// <summary>
        /// Gets and sets the property CodeCapture. 
        /// <para>
        /// Capture settings for code-level instrumentation, including arguments, return values,
        /// stack traces, local variables, and safety limits.
        /// </para>
        /// </summary>
        public CodeCaptureConfiguration CodeCapture
        {
            get { return this._codeCapture; }
            set { this._codeCapture = value; }
        }

        // Check to see if CodeCapture property is set
        internal bool IsSetCodeCapture()
        {
            return this._codeCapture != null;
        }

    }
}