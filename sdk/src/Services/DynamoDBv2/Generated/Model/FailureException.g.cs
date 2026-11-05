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

namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// Represents a failure a contributor insights operation.
    /// </summary>
    public partial class FailureException
    {
        /// <summary>
        /// Gets and sets the property ExceptionDescription. 
        /// <para>
        /// Description of the failure.
        /// </para>
        /// </summary>
        public string ExceptionDescription { get; set; }

        /// <summary>
        /// Checks to see if the ExceptionDescription property is set.
        /// </summary>
        internal bool IsSetExceptionDescription() => this.ExceptionDescription != null;

        /// <summary>
        /// Gets and sets the property ExceptionName. 
        /// <para>
        /// Exception name.
        /// </para>
        /// </summary>
        public string ExceptionName { get; set; }

        /// <summary>
        /// Checks to see if the ExceptionName property is set.
        /// </summary>
        internal bool IsSetExceptionName() => this.ExceptionName != null;
    }
}
