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

namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// The status of the compute fleet.
    /// </summary>
    public partial class FleetStatus
    {
        /// <summary>
        /// Gets and sets the property Context. 
        /// <para>
        /// Additional information about a compute fleet. Valid values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CREATE_FAILED</c>: The compute fleet has failed to create.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPDATE_FAILED</c>: The compute fleet has failed to update.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public FleetContextCode Context { get; set; }

        /// <summary>
        /// Checks to see if the Context property is set.
        /// </summary>
        internal bool IsSetContext() => this.Context != null;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A message associated with the status of a compute fleet.
        /// </para>
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property StatusCode. 
        /// <para>
        /// The status code of the compute fleet. Valid values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CREATING</c>: The compute fleet is being created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPDATING</c>: The compute fleet is being updated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ROTATING</c>: The compute fleet is being rotated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PENDING_DELETION</c>: The compute fleet is pending deletion.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETING</c>: The compute fleet is being deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATE_FAILED</c>: The compute fleet has failed to create.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPDATE_ROLLBACK_FAILED</c>: The compute fleet has failed to update and could not
        /// rollback to previous state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACTIVE</c>: The compute fleet has succeeded and is active.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public FleetStatusCode StatusCode { get; set; }

        /// <summary>
        /// Checks to see if the StatusCode property is set.
        /// </summary>
        internal bool IsSetStatusCode() => this.StatusCode != null;
    }
}
