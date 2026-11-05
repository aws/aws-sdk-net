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

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// An object that contains error information.
    /// </summary>
    public partial class ErrorObject
    {
        /// <summary>
        /// Gets and sets the property ErrorData. 
        /// <para>
        /// Machine-readable error data.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string ErrorData { get; set; }

        /// <summary>
        /// Checks to see if the ErrorData property is set.
        /// </summary>
        internal bool IsSetErrorData() => this.ErrorData != null;

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// A human-readable error message.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;

        /// <summary>
        /// Gets and sets the property ErrorType. 
        /// <para>
        /// The error type.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string ErrorType { get; set; }

        /// <summary>
        /// Checks to see if the ErrorType property is set.
        /// </summary>
        internal bool IsSetErrorType() => this.ErrorType != null;

        /// <summary>
        /// Gets and sets the property StackTrace. 
        /// <para>
        /// Stack trace information for the error.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> StackTrace { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the StackTrace property is set.
        /// </summary>
        internal bool IsSetStackTrace() => this.StackTrace != null && (this.StackTrace.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
