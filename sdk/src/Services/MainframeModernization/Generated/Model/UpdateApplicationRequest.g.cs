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

namespace Amazon.MainframeModernization.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateApplication operation. Updates an application
    /// and creates a new version.
    /// </summary>
    public partial class UpdateApplicationRequest : AmazonMainframeModernizationRequest
    {
        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The unique identifier of the application you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationId property is set.
        /// </summary>
        internal bool IsSetApplicationId() => this.ApplicationId != null;

        /// <summary>
        /// Gets and sets the property CurrentApplicationVersion. 
        /// <para>
        /// The current version of the application to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public int? CurrentApplicationVersion { get; set; }

        /// <summary>
        /// Checks to see if the CurrentApplicationVersion property is set.
        /// </summary>
        internal bool IsSetCurrentApplicationVersion() => this.CurrentApplicationVersion.HasValue;

        /// <summary>
        /// Gets and sets the property Definition. 
        /// <para>
        /// The application definition for this application. You can specify either inline JSON
        /// or an S3 bucket location.
        /// </para>
        /// </summary>
        public Definition Definition { get; set; }

        /// <summary>
        /// Checks to see if the Definition property is set.
        /// </summary>
        internal bool IsSetDefinition() => this.Definition != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the application to update.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 500)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;
    }
}
