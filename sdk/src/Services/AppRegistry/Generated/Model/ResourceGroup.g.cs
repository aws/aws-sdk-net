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

namespace Amazon.AppRegistry.Model
{
    /// <summary>
    /// The information about the resource group integration.
    /// </summary>
    public partial class ResourceGroup
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon resource name (ARN) of the resource group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1600)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// The error message that generates when the propagation process for the resource group
        /// fails.
        /// </para>
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the propagation process for the resource group. The states includes:
        /// </para>
        ///  
        /// <para>
        ///  <c>CREATING </c>if the resource group is in the process of being created.
        /// </para>
        ///  
        /// <para>
        ///  <c>CREATE_COMPLETE</c> if the resource group was created successfully.
        /// </para>
        ///  
        /// <para>
        ///  <c>CREATE_FAILED</c> if the resource group failed to be created.
        /// </para>
        ///  
        /// <para>
        ///  <c>UPDATING</c> if the resource group is in the process of being updated.
        /// </para>
        ///  
        /// <para>
        ///  <c>UPDATE_COMPLETE</c> if the resource group updated successfully.
        /// </para>
        ///  
        /// <para>
        ///  <c>UPDATE_FAILED</c> if the resource group could not update successfully.
        /// </para>
        /// </summary>
        public ResourceGroupState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
