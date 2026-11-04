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
    /// A specific property that is impacted by a warning.
    /// </summary>
    public partial class WarningProperty
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the property from the resource provider schema.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property PropertyPath. 
        /// <para>
        /// The path of the property. For example, if this is for the <c>S3Bucket</c> member of
        /// the <c>Code</c> property, the property path would be <c>Code/S3Bucket</c>.
        /// </para>
        /// </summary>
        public string PropertyPath { get; set; }

        /// <summary>
        /// Checks to see if the PropertyPath property is set.
        /// </summary>
        internal bool IsSetPropertyPath() => this.PropertyPath != null;

        /// <summary>
        /// Gets and sets the property Required. 
        /// <para>
        /// If <c>true</c>, the specified property is required.
        /// </para>
        /// </summary>
        public bool? Required { get; set; }

        /// <summary>
        /// Checks to see if the Required property is set.
        /// </summary>
        internal bool IsSetRequired() => this.Required.HasValue;
    }
}
