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

namespace Amazon.AppIntegrationsService.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteApplication operation. Deletes an application.
    /// If the application has associations, you must delete them first. Alternatively, use
    /// the <c>force</c> option to delete the application and remove its associations.
    /// </summary>
    public partial class DeleteApplicationRequest : AmazonAppIntegrationsServiceRequest
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Application.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property Force. 
        /// <para>
        /// Specifies whether to delete the application even if it still has application associations.
        /// If <c>true</c>, the operation removes the application and its associations. If <c>false</c>
        /// or absent, the delete fails when associations exist.
        /// </para>
        ///  <important> 
        /// <para>
        /// Setting this parameter to <c>true</c> permanently removes all of the application's
        /// associations. Doing so might impact other resources that rely on and reference the
        /// application. This action can't be undone.
        /// </para>
        ///  </important>
        /// </summary>
        public bool? Force { get; set; }

        /// <summary>
        /// Checks to see if the Force property is set.
        /// </summary>
        internal bool IsSetForce() => this.Force.HasValue;
    }
}
