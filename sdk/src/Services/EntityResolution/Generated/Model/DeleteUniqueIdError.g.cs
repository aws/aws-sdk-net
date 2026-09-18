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

namespace Amazon.EntityResolution.Model
{
    /// <summary>
    /// The error information provided when the delete unique ID operation doesn't complete.
    /// </summary>
    public partial class DeleteUniqueIdError
    {
        /// <summary>
        /// Gets and sets the property ErrorType. 
        /// <para>
        ///  The error type for the delete unique ID operation.
        /// </para>
        ///  
        /// <para>
        /// The <c>SERVICE_ERROR</c> value indicates that an internal service-side problem occurred
        /// during the deletion operation.
        /// </para>
        ///  
        /// <para>
        /// The <c>VALIDATION_ERROR</c> value indicates that the deletion operation couldn't complete
        /// because of invalid input parameters or data.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DeleteUniqueIdErrorType ErrorType { get; set; }

        /// <summary>
        /// Checks to see if the ErrorType property is set.
        /// </summary>
        internal bool IsSetErrorType() => this.ErrorType != null;

        /// <summary>
        /// Gets and sets the property UniqueId. 
        /// <para>
        /// The unique ID that couldn't be deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 780)]
        public string UniqueId { get; set; }

        /// <summary>
        /// Checks to see if the UniqueId property is set.
        /// </summary>
        internal bool IsSetUniqueId() => this.UniqueId != null;
    }
}
