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
    /// One template field on an asset: the schema snapshot taken at instantiation plus the
    /// current value. The value is absent while the field is unfilled. Schema and value are
    /// one shape rather than two lists because a client rendering an edit form needs both
    /// together, and because the pin (design section 3.1) is what an update validates against
    /// — separating them would let values outlive the schema they were checked against. Addressed
    /// by the **DG** FieldId throughout. The delivery platform's own field-definition ids
    /// stay on the template record and are joined in at activation, so a vendor identifier
    /// never reaches an asset row or a response (DG-025 containment).
    /// </summary>
    public partial class CampaignAssetFieldValue
    {
        /// <summary>
        /// Gets and sets the property Field. The field schema (snapshot from the template).
        /// </summary>
        [AWSProperty(Required = true)]
        public CampaignAssetTemplateField Field { get; set; }

        /// <summary>
        /// Checks to see if the Field property is set.
        /// </summary>
        internal bool IsSetField() => this.Field != null;

        /// <summary>
        /// Gets and sets the property Value. The field's current value; the variant matches the
        /// field's type.
        /// </summary>
        public TemplateFieldValue Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
