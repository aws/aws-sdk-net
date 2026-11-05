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

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// A summary of the progress of the template generation.
    /// </summary>
    public partial class TemplateProgress
    {
        /// <summary>
        /// Gets and sets the property ResourcesFailed. 
        /// <para>
        /// The number of resources that failed the template generation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? ResourcesFailed { get; set; }

        /// <summary>
        /// Checks to see if the ResourcesFailed property is set.
        /// </summary>
        internal bool IsSetResourcesFailed() => this.ResourcesFailed.HasValue;

        /// <summary>
        /// Gets and sets the property ResourcesPending. 
        /// <para>
        /// The number of resources that are still pending the template generation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? ResourcesPending { get; set; }

        /// <summary>
        /// Checks to see if the ResourcesPending property is set.
        /// </summary>
        internal bool IsSetResourcesPending() => this.ResourcesPending.HasValue;

        /// <summary>
        /// Gets and sets the property ResourcesProcessing. 
        /// <para>
        /// The number of resources that are in-process for the template generation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? ResourcesProcessing { get; set; }

        /// <summary>
        /// Checks to see if the ResourcesProcessing property is set.
        /// </summary>
        internal bool IsSetResourcesProcessing() => this.ResourcesProcessing.HasValue;

        /// <summary>
        /// Gets and sets the property ResourcesSucceeded. 
        /// <para>
        /// The number of resources that succeeded the template generation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? ResourcesSucceeded { get; set; }

        /// <summary>
        /// Checks to see if the ResourcesSucceeded property is set.
        /// </summary>
        internal bool IsSetResourcesSucceeded() => this.ResourcesSucceeded.HasValue;
    }
}
