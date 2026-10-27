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

namespace Amazon.ECS.Model
{
    /// <summary>
    /// A failed resource. For a list of common causes, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/api_failures_messages.html">API
    /// failure reasons</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
    /// </summary>
    public partial class Failure
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the failed resource.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property Detail. 
        /// <para>
        /// The details of the failure.
        /// </para>
        /// </summary>
        public string Detail { get; set; }

        /// <summary>
        /// Checks to see if the Detail property is set.
        /// </summary>
        internal bool IsSetDetail() => this.Detail != null;

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// The reason for the failure.
        /// </para>
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// Checks to see if the Reason property is set.
        /// </summary>
        internal bool IsSetReason() => this.Reason != null;
    }
}
