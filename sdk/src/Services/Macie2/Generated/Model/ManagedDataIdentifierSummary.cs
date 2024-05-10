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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Provides information about a managed data identifier. For additional information,
    /// see <a href="https://docs.aws.amazon.com/macie/latest/user/managed-data-identifiers.html">Using
    /// managed data identifiers</a> in the <i>Amazon Macie User Guide</i>.
    /// </summary>
    public partial class ManagedDataIdentifierSummary
    {
        private SensitiveDataItemCategory _category;
        private string _id;

        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// The category of sensitive data that the managed data identifier detects: CREDENTIALS,
        /// for credentials data such as private keys or Amazon Web Services secret access keys;
        /// FINANCIAL_INFORMATION, for financial data such as credit card numbers; or, PERSONAL_INFORMATION,
        /// for personal health information, such as health insurance identification numbers,
        /// or personally identifiable information, such as passport numbers.
        /// </para>
        /// </summary>
        public SensitiveDataItemCategory Category
        {
            get { return this._category; }
            set { this._category = value; }
        }

        // Check to see if Category property is set
        internal bool IsSetCategory()
        {
            return this._category != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier for the managed data identifier. This is a string that describes
        /// the type of sensitive data that the managed data identifier detects. For example:
        /// OPENSSH_PRIVATE_KEY for OpenSSH private keys, CREDIT_CARD_NUMBER for credit card numbers,
        /// or USA_PASSPORT_NUMBER for US passport numbers.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

    }
}