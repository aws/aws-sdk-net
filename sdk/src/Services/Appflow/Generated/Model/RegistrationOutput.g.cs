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

namespace Amazon.Appflow.Model
{
    /// <summary>
    /// Describes the status of an attempt from Amazon AppFlow to register a resource.
    /// 
    ///  
    /// <para>
    /// When you run a flow that you've configured to use a metadata catalog, Amazon AppFlow
    /// registers a metadata table and data partitions with that catalog. This operation provides
    /// the status of that registration attempt. The operation also indicates how many related
    /// resources Amazon AppFlow created or updated.
    /// </para>
    /// </summary>
    public partial class RegistrationOutput
    {
        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// Explains the status of the registration attempt from Amazon AppFlow. If the attempt
        /// fails, the message explains why.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property Result. 
        /// <para>
        /// Indicates the number of resources that Amazon AppFlow created or updated. Possible
        /// resources include metadata tables and data partitions.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string Result { get; set; }

        /// <summary>
        /// Checks to see if the Result property is set.
        /// </summary>
        internal bool IsSetResult() => this.Result != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Indicates the status of the registration attempt from Amazon AppFlow.
        /// </para>
        /// </summary>
        public ExecutionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
