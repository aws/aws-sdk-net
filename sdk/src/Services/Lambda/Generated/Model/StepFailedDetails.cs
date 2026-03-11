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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
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
namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Details about a step that failed.
    /// </summary>
    public partial class StepFailedDetails
    {
        private EventError _error;
        private RetryDetails _retryDetails;

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// Details about the step failure.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EventError Error
        {
            get { return this._error; }
            set { this._error = value; }
        }

        // Check to see if Error property is set
        internal bool IsSetError()
        {
            return this._error != null;
        }

        /// <summary>
        /// Gets and sets the property RetryDetails. 
        /// <para>
        /// Information about retry attempts for this step operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RetryDetails RetryDetails
        {
            get { return this._retryDetails; }
            set { this._retryDetails = value; }
        }

        // Check to see if RetryDetails property is set
        internal bool IsSetRetryDetails()
        {
            return this._retryDetails != null;
        }

    }
}