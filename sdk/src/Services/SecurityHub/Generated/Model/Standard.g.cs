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
    /// Provides information about a specific security standard.
    /// </summary>
    public partial class Standard
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the standard.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EnabledByDefault. 
        /// <para>
        /// Whether the standard is enabled by default. When Security Hub CSPM is enabled from
        /// the console, if a standard is enabled by default, the check box for that standard
        /// is selected by default.
        /// </para>
        ///  
        /// <para>
        /// When Security Hub CSPM is enabled using the <c>EnableSecurityHub</c> API operation,
        /// the standard is enabled by default unless <c>EnableDefaultStandards</c> is set to
        /// <c>false</c>.
        /// </para>
        /// </summary>
        public bool? EnabledByDefault { get; set; }

        /// <summary>
        /// Checks to see if the EnabledByDefault property is set.
        /// </summary>
        internal bool IsSetEnabledByDefault() => this.EnabledByDefault.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the standard.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Provider. 
        /// <para>
        /// The cloud provider whose resources the standard evaluates. For example, <c>AWS</c>
        /// or <c>Azure</c>.
        /// </para>
        /// </summary>
        public StandardsProvider Provider { get; set; }

        /// <summary>
        /// Checks to see if the Provider property is set.
        /// </summary>
        internal bool IsSetProvider() => this.Provider != null;

        /// <summary>
        /// Gets and sets the property StandardsArn. 
        /// <para>
        /// The ARN of the standard.
        /// </para>
        /// </summary>
        public string StandardsArn { get; set; }

        /// <summary>
        /// Checks to see if the StandardsArn property is set.
        /// </summary>
        internal bool IsSetStandardsArn() => this.StandardsArn != null;

        /// <summary>
        /// Gets and sets the property StandardsManagedBy. 
        /// <para>
        /// Provides details about the management of a standard. 
        /// </para>
        /// </summary>
        public StandardsManagedBy StandardsManagedBy { get; set; }

        /// <summary>
        /// Checks to see if the StandardsManagedBy property is set.
        /// </summary>
        internal bool IsSetStandardsManagedBy() => this.StandardsManagedBy != null;
    }
}
