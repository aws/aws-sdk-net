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
    /// A plain-text field's constraints and placeholder.
    /// </summary>
    public partial class TextFieldType
    {
        /// <summary>
        /// Gets and sets the property MaxLength. Maximum accepted length.
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? MaxLength { get; set; }

        /// <summary>
        /// Checks to see if the MaxLength property is set.
        /// </summary>
        internal bool IsSetMaxLength() => this.MaxLength.HasValue;

        /// <summary>
        /// Gets and sets the property MinLength. Minimum accepted length.
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? MinLength { get; set; }

        /// <summary>
        /// Checks to see if the MinLength property is set.
        /// </summary>
        internal bool IsSetMinLength() => this.MinLength.HasValue;

        /// <summary>
        /// Gets and sets the property Pattern. Regular expression the value must match — used
        /// for URL, email, phone and hex-colour fields.
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Pattern { get; set; }

        /// <summary>
        /// Checks to see if the Pattern property is set.
        /// </summary>
        internal bool IsSetPattern() => this.Pattern != null;

        /// <summary>
        /// Gets and sets the property Placeholder. Example text shown where the field is empty
        /// in a preview of the asset. Never the asset's value: it is not set on the asset at
        /// create, does not fill a required field, and is never published.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 100000)]
        public string Placeholder { get; set; }

        /// <summary>
        /// Checks to see if the Placeholder property is set.
        /// </summary>
        internal bool IsSetPlaceholder() => this.Placeholder != null;
    }
}
