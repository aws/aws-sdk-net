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

namespace Amazon.Organizations.Model
{
    /// <summary>
    /// Contains details about the validation errors that occurred when generating or enforcing
    /// an <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_effective.html">effective
    /// policy</a>, such as which policies contributed to the error and location of the error.
    /// </summary>
    public partial class EffectivePolicyValidationError
    {
        /// <summary>
        /// Gets and sets the property ContributingPolicies. 
        /// <para>
        /// The individual policies <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_inheritance_mgmt.html">inherited</a>
        /// and <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_policies_attach.html">attached</a>
        /// to the account which contributed to the validation error.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ContributingPolicies { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ContributingPolicies property is set.
        /// </summary>
        internal bool IsSetContributingPolicies() => this.ContributingPolicies != null && (this.ContributingPolicies.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// The error code for the validation error. For example, <c>ELEMENTS_TOO_MANY</c>.
        /// </para>
        /// </summary>
        public string ErrorCode { get; set; }

        /// <summary>
        /// Checks to see if the ErrorCode property is set.
        /// </summary>
        internal bool IsSetErrorCode() => this.ErrorCode != null;

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// The error message for the validation error.
        /// </para>
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;

        /// <summary>
        /// Gets and sets the property PathToError. 
        /// <para>
        /// The path within the effective policy where the validation error occurred.
        /// </para>
        /// </summary>
        public string PathToError { get; set; }

        /// <summary>
        /// Checks to see if the PathToError property is set.
        /// </summary>
        internal bool IsSetPathToError() => this.PathToError != null;
    }
}
