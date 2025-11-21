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
 * Do not modify this file. This file is generated from the healthlake-2017-07-01.normal.json service model.
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
namespace Amazon.HealthLake.Model
{
    /// <summary>
    /// The error information for <c>CreateFHIRDatastore</c> and <c>DeleteFHIRDatastore</c>
    /// actions.
    /// </summary>
    public partial class ErrorCause
    {
        private ErrorCategory _errorCategory;
        private string _errorMessage;

        /// <summary>
        /// Gets and sets the property ErrorCategory. 
        /// <para>
        /// The error category for <c>ErrorCause</c>.
        /// </para>
        /// </summary>
        public ErrorCategory ErrorCategory
        {
            get { return this._errorCategory; }
            set { this._errorCategory = value; }
        }

        // Check to see if ErrorCategory property is set
        internal bool IsSetErrorCategory()
        {
            return this._errorCategory != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// The error message text for <c>ErrorCause</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

    }
}