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

namespace Amazon.PartnerCentralMarketing.Model
{
    /// <summary>
    /// A field that failed validation.
    /// </summary>
    public partial class ValidationExceptionField
    {
        /// <summary>
        /// Gets and sets the property Code. Why this field failed, as a value a client branches
        /// on. Read this rather than `Message`.
        /// </summary>
        public ValidationExceptionFieldCode Code { get; set; }

        /// <summary>
        /// Checks to see if the Code property is set.
        /// </summary>
        internal bool IsSetCode() => this.Code != null;

        /// <summary>
        /// Gets and sets the property FieldId. The template field that failed, when `Name` is
        /// `FieldValues`; absent otherwise.
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string FieldId { get; set; }

        /// <summary>
        /// Checks to see if the FieldId property is set.
        /// </summary>
        internal bool IsSetFieldId() => this.FieldId != null;

        /// <summary>
        /// Gets and sets the property Message. Why this field failed, in prose a partner can
        /// be shown directly.
        /// </summary>
        [AWSProperty(Required = true)]
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property Name. The member of the request that failed, as the request
        /// names it: `FieldValues` for a template field value, `Layout`, `EmailTarget`, `Identifier`,
        /// and so on. It is never a template field id: a template field is always `FieldValues`,
        /// with the field in `FieldId`.
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
