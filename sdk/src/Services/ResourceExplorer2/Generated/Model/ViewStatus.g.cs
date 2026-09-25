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

namespace Amazon.ResourceExplorer2.Model
{
    /// <summary>
    /// Contains information about the status of a Resource Explorer view operation in a specific
    /// Region.
    /// </summary>
    public partial class ViewStatus
    {
        /// <summary>
        /// Gets and sets the property ErrorDetails. 
        /// <para>
        /// Details about any error that occurred during the view operation.
        /// </para>
        /// </summary>
        public ErrorDetails ErrorDetails { get; set; }

        /// <summary>
        /// Checks to see if the ErrorDetails property is set.
        /// </summary>
        internal bool IsSetErrorDetails() => this.ErrorDetails != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the view operation. Valid values are <c>SUCCEEDED</c>, <c>FAILED</c>,
        /// <c>IN_PROGRESS</c>, or <c>SKIPPED</c>.
        /// </para>
        /// </summary>
        public OperationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property View.
        /// </summary>
        public View View { get; set; }

        /// <summary>
        /// Checks to see if the View property is set.
        /// </summary>
        internal bool IsSetView() => this.View != null;
    }
}
