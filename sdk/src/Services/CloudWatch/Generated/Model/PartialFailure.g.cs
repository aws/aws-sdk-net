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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// This array is empty if the API operation was successful for all the rules specified
    /// in the request. If the operation could not process one of the rules, the following
    /// data is returned for each of those rules.
    /// </summary>
    public partial class PartialFailure
    {
        /// <summary>
        /// Gets and sets the property ExceptionType. 
        /// <para>
        /// The type of error.
        /// </para>
        /// </summary>
        public string ExceptionType { get; set; }

        /// <summary>
        /// Checks to see if the ExceptionType property is set.
        /// </summary>
        internal bool IsSetExceptionType() => this.ExceptionType != null;

        /// <summary>
        /// Gets and sets the property FailureCode. 
        /// <para>
        /// The code of the error.
        /// </para>
        /// </summary>
        public string FailureCode { get; set; }

        /// <summary>
        /// Checks to see if the FailureCode property is set.
        /// </summary>
        internal bool IsSetFailureCode() => this.FailureCode != null;

        /// <summary>
        /// Gets and sets the property FailureDescription. 
        /// <para>
        /// A description of the error.
        /// </para>
        /// </summary>
        public string FailureDescription { get; set; }

        /// <summary>
        /// Checks to see if the FailureDescription property is set.
        /// </summary>
        internal bool IsSetFailureDescription() => this.FailureDescription != null;

        /// <summary>
        /// Gets and sets the property FailureResource. 
        /// <para>
        /// The specified rule that could not be deleted.
        /// </para>
        /// </summary>
        public string FailureResource { get; set; }

        /// <summary>
        /// Checks to see if the FailureResource property is set.
        /// </summary>
        internal bool IsSetFailureResource() => this.FailureResource != null;
    }
}
