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

namespace Amazon.Textract.Model
{
    /// <summary>
    /// Breakdown of detected information, seperated into the catagories Type, LabelDetection,
    /// and ValueDetection
    /// </summary>
    public partial class ExpenseField
    {
        /// <summary>
        /// Gets and sets the property Currency. 
        /// <para>
        /// Shows the kind of currency, both the code and confidence associated with any monatary
        /// value detected.
        /// </para>
        /// </summary>
        public ExpenseCurrency Currency { get; set; }

        /// <summary>
        /// Checks to see if the Currency property is set.
        /// </summary>
        internal bool IsSetCurrency() => this.Currency != null;

        /// <summary>
        /// Gets and sets the property GroupProperties. 
        /// <para>
        /// Shows which group a response object belongs to, such as whether an address line belongs
        /// to the vendor's address or the recipent's address.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ExpenseGroupProperty> GroupProperties { get; set; } = AWSConfigs.InitializeCollections ? new List<ExpenseGroupProperty>() : null;

        /// <summary>
        /// Checks to see if the GroupProperties property is set.
        /// </summary>
        internal bool IsSetGroupProperties() => this.GroupProperties != null && (this.GroupProperties.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LabelDetection. 
        /// <para>
        /// The explicitly stated label of a detected element.
        /// </para>
        /// </summary>
        public ExpenseDetection LabelDetection { get; set; }

        /// <summary>
        /// Checks to see if the LabelDetection property is set.
        /// </summary>
        internal bool IsSetLabelDetection() => this.LabelDetection != null;

        /// <summary>
        /// Gets and sets the property PageNumber. 
        /// <para>
        /// The page number the value was detected on.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// Checks to see if the PageNumber property is set.
        /// </summary>
        internal bool IsSetPageNumber() => this.PageNumber.HasValue;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The implied label of a detected element. Present alongside LabelDetection for explicit
        /// elements.
        /// </para>
        /// </summary>
        public ExpenseType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property ValueDetection. 
        /// <para>
        /// The value of a detected element. Present in explicit and implicit elements.
        /// </para>
        /// </summary>
        public ExpenseDetection ValueDetection { get; set; }

        /// <summary>
        /// Checks to see if the ValueDetection property is set.
        /// </summary>
        internal bool IsSetValueDetection() => this.ValueDetection != null;
    }
}
