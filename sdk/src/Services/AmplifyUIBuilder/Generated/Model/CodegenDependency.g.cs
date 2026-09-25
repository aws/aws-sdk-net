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

namespace Amazon.AmplifyUIBuilder.Model
{
    /// <summary>
    /// Dependency package that may be required for the project code to run.
    /// </summary>
    public partial class CodegenDependency
    {
        /// <summary>
        /// Gets and sets the property IsSemVer. 
        /// <para>
        /// Determines if the dependency package is using Semantic versioning. If set to true,
        /// it indicates that the dependency package uses Semantic versioning.
        /// </para>
        /// </summary>
        public bool? IsSemVer { get; set; }

        /// <summary>
        /// Checks to see if the IsSemVer property is set.
        /// </summary>
        internal bool IsSetIsSemVer() => this.IsSemVer.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name of the dependency package.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// Indicates the reason to include the dependency package in your project code.
        /// </para>
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// Checks to see if the Reason property is set.
        /// </summary>
        internal bool IsSetReason() => this.Reason != null;

        /// <summary>
        /// Gets and sets the property SupportedVersion. 
        /// <para>
        /// Indicates the version of the supported dependency package.
        /// </para>
        /// </summary>
        public string SupportedVersion { get; set; }

        /// <summary>
        /// Checks to see if the SupportedVersion property is set.
        /// </summary>
        internal bool IsSetSupportedVersion() => this.SupportedVersion != null;
    }
}
