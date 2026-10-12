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

namespace Amazon.B2bi.Model
{
    /// <summary>
    /// Defines a validation rule that modifies the allowed code values for a specific X12
    /// element. This rule allows you to add or remove valid codes from an element's standard
    /// code list, providing flexibility to accommodate trading partner-specific requirements
    /// or industry variations. You can specify codes to add to expand the allowed values
    /// beyond the X12 standard, or codes to remove to restrict the allowed values for stricter
    /// validation.
    /// </summary>
    public partial class X12CodeListValidationRule
    {
        /// <summary>
        /// Gets and sets the property CodesToAdd. 
        /// <para>
        /// Specifies a list of code values to add to the element's allowed values. These codes
        /// will be considered valid for the specified element in addition to the standard codes
        /// defined by the X12 specification.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CodesToAdd { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the CodesToAdd property is set.
        /// </summary>
        internal bool IsSetCodesToAdd() => this.CodesToAdd != null && (this.CodesToAdd.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CodesToRemove. 
        /// <para>
        /// Specifies a list of code values to remove from the element's allowed values. These
        /// codes will be considered invalid for the specified element, even if they are part
        /// of the standard codes defined by the X12 specification.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CodesToRemove { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the CodesToRemove property is set.
        /// </summary>
        internal bool IsSetCodesToRemove() => this.CodesToRemove != null && (this.CodesToRemove.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ElementId. 
        /// <para>
        /// Specifies the four-digit element ID to which the code list modifications apply. This
        /// identifies which X12 element will have its allowed code values modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ElementId { get; set; }

        /// <summary>
        /// Checks to see if the ElementId property is set.
        /// </summary>
        internal bool IsSetElementId() => this.ElementId != null;
    }
}
