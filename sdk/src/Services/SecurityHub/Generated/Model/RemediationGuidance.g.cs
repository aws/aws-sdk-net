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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// A remediation guidebook outlining guidance in resolving the remediation target.
    /// </summary>
    public partial class RemediationGuidance
    {
        /// <summary>
        /// Gets and sets the property Context. 
        /// <para>
        /// The context behind the remediation target's existence and guidance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RemediationGuidanceContext Context { get; set; }

        /// <summary>
        /// Checks to see if the Context property is set.
        /// </summary>
        internal bool IsSetContext() => this.Context != null;

        /// <summary>
        /// Gets and sets the property Examples. 
        /// <para>
        /// Provided remediation guidance examples in different formats that can be run for remediating
        /// the target.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RemediationGuidanceExamples Examples { get; set; }

        /// <summary>
        /// Checks to see if the Examples property is set.
        /// </summary>
        internal bool IsSetExamples() => this.Examples != null;

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// The metadata of the remediation guidance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RemediationGuidanceMetadata Metadata { get; set; }

        /// <summary>
        /// Checks to see if the Metadata property is set.
        /// </summary>
        internal bool IsSetMetadata() => this.Metadata != null;

        /// <summary>
        /// Gets and sets the property Pattern. 
        /// <para>
        /// The remediation pattern of the remediation target.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Pattern { get; set; }

        /// <summary>
        /// Checks to see if the Pattern property is set.
        /// </summary>
        internal bool IsSetPattern() => this.Pattern != null;

        /// <summary>
        /// Gets and sets the property Specification. 
        /// <para>
        /// The specification of the remediation target guidance. This outlines required resource
        /// parameters and permissions, remediation steps, and the end state.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RemediationGuidanceSpecification Specification { get; set; }

        /// <summary>
        /// Checks to see if the Specification property is set.
        /// </summary>
        internal bool IsSetSpecification() => this.Specification != null;

        /// <summary>
        /// Gets and sets the property TargetTypeName. 
        /// <para>
        /// The name of the remediation target type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TargetTypeName { get; set; }

        /// <summary>
        /// Checks to see if the TargetTypeName property is set.
        /// </summary>
        internal bool IsSetTargetTypeName() => this.TargetTypeName != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The guidance version.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}
