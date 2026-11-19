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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains details about an Lambda function.
    /// </summary>
    public partial class LambdaFunction
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the function.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property FunctionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the function.
        /// </para>
        /// </summary>
        public string FunctionArn { get; set; }

        /// <summary>
        /// Checks to see if the FunctionArn property is set.
        /// </summary>
        internal bool IsSetFunctionArn() => this.FunctionArn != null;

        /// <summary>
        /// Gets and sets the property FunctionName. 
        /// <para>
        /// The name of the function.
        /// </para>
        /// </summary>
        public string FunctionName { get; set; }

        /// <summary>
        /// Checks to see if the FunctionName property is set.
        /// </summary>
        internal bool IsSetFunctionName() => this.FunctionName != null;

        /// <summary>
        /// Gets and sets the property FunctionVersion. 
        /// <para>
        /// The version of the function.
        /// </para>
        /// </summary>
        public string FunctionVersion { get; set; }

        /// <summary>
        /// Checks to see if the FunctionVersion property is set.
        /// </summary>
        internal bool IsSetFunctionVersion() => this.FunctionVersion != null;

        /// <summary>
        /// Gets and sets the property RevisionId. 
        /// <para>
        /// The revision ID of the function version.
        /// </para>
        /// </summary>
        public string RevisionId { get; set; }

        /// <summary>
        /// Checks to see if the RevisionId property is set.
        /// </summary>
        internal bool IsSetRevisionId() => this.RevisionId != null;

        /// <summary>
        /// Gets and sets the property Role. 
        /// <para>
        /// The execution role of the function.
        /// </para>
        /// </summary>
        public string Role { get; set; }

        /// <summary>
        /// Checks to see if the Role property is set.
        /// </summary>
        internal bool IsSetRole() => this.Role != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp at which the function was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property VpcConfigurationSummary. 
        /// <para>
        /// A summary of the VPC configuration of the function, as a single string.
        /// </para>
        /// </summary>
        public string VpcConfigurationSummary { get; set; }

        /// <summary>
        /// Checks to see if the VpcConfigurationSummary property is set.
        /// </summary>
        internal bool IsSetVpcConfigurationSummary() => this.VpcConfigurationSummary != null;
    }
}
