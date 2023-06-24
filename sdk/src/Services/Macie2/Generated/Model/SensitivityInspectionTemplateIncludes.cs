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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Specifies the allow lists, custom data identifiers, and managed data identifiers to
    /// include (use) when performing automated sensitive data discovery for an Amazon Macie
    /// account. The configuration must specify at least one custom data identifier or managed
    /// data identifier. For information about the managed data identifiers that Amazon Macie
    /// currently provides, see <a href="https://docs.aws.amazon.com/macie/latest/user/managed-data-identifiers.html">Using
    /// managed data identifiers</a> in the <i>Amazon Macie User Guide</i>.
    /// </summary>
    public partial class SensitivityInspectionTemplateIncludes
    {
        private List<string> _allowListIds = new List<string>();
        private List<string> _customDataIdentifierIds = new List<string>();
        private List<string> _managedDataIdentifierIds = new List<string>();

        /// <summary>
        /// Gets and sets the property AllowListIds. 
        /// <para>
        /// An array of unique identifiers, one for each allow list to include.
        /// </para>
        /// </summary>
        public List<string> AllowListIds
        {
            get { return this._allowListIds; }
            set { this._allowListIds = value; }
        }

        // Check to see if AllowListIds property is set
        internal bool IsSetAllowListIds()
        {
            return this._allowListIds != null && this._allowListIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CustomDataIdentifierIds. 
        /// <para>
        /// An array of unique identifiers, one for each custom data identifier to include.
        /// </para>
        /// </summary>
        public List<string> CustomDataIdentifierIds
        {
            get { return this._customDataIdentifierIds; }
            set { this._customDataIdentifierIds = value; }
        }

        // Check to see if CustomDataIdentifierIds property is set
        internal bool IsSetCustomDataIdentifierIds()
        {
            return this._customDataIdentifierIds != null && this._customDataIdentifierIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ManagedDataIdentifierIds. 
        /// <para>
        /// An array of unique identifiers, one for each managed data identifier to include.
        /// </para>
        ///  
        /// <para>
        /// Amazon Macie uses these managed data identifiers in addition to managed data identifiers
        /// that are subsequently released and recommended for automated sensitive data discovery.
        /// To retrieve a list of valid values for the managed data identifiers that are currently
        /// available, use the ListManagedDataIdentifiers operation.
        /// </para>
        ///  <para/>
        /// </summary>
        public List<string> ManagedDataIdentifierIds
        {
            get { return this._managedDataIdentifierIds; }
            set { this._managedDataIdentifierIds = value; }
        }

        // Check to see if ManagedDataIdentifierIds property is set
        internal bool IsSetManagedDataIdentifierIds()
        {
            return this._managedDataIdentifierIds != null && this._managedDataIdentifierIds.Count > 0; 
        }

    }
}