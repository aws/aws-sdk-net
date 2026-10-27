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

namespace Amazon.ElementalInference.Model
{
    /// <summary>
    /// Describes the cause of a schedule action failure, including the failure type and a
    /// description of what went wrong.
    /// </summary>
    public partial class ScheduleActionError
    {
        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// The type of failure. Valid values are the following:
        /// </para>
        ///  <dl> <dt>INVALID_ACTION_TARGET</dt> <dd> 
        /// <para>
        /// The action referred to something that didn't exist or wasn't valid at the scheduled
        /// time, for example an output that you deleted. 
        /// </para>
        ///  </dd> <dt>INTERNAL_ERROR</dt> <dd> 
        /// <para>
        /// An unexpected error prevented the action from completing.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        [AWSProperty(Required = true)]
        public ScheduleActionErrorCode ErrorCode { get; set; }

        /// <summary>
        /// Checks to see if the ErrorCode property is set.
        /// </summary>
        internal bool IsSetErrorCode() => this.ErrorCode != null;

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// A description of the failure.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;
    }
}
