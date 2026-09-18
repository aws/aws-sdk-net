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
    /// The record that didn't generate a Match ID.
    /// </summary>
    public partial class FailedRecord
    {
        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        ///  The error message for the record that didn't generate a Match ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;

        /// <summary>
        /// Gets and sets the property InputSourceARN. 
        /// <para>
        ///  The input source ARN of the record that didn't generate a Match ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string InputSourceARN { get; set; }

        /// <summary>
        /// Checks to see if the InputSourceARN property is set.
        /// </summary>
        internal bool IsSetInputSourceARN() => this.InputSourceARN != null;

        /// <summary>
        /// Gets and sets the property UniqueId. 
        /// <para>
        ///  The unique ID of the record that didn't generate a Match ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string UniqueId { get; set; }

        /// <summary>
        /// Checks to see if the UniqueId property is set.
        /// </summary>
        internal bool IsSetUniqueId() => this.UniqueId != null;
    }
}
