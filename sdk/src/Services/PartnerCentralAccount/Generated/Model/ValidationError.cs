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
 * Do not modify this file. This file is generated from the partnercentral-account-2025-04-04.normal.json service model.
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
namespace Amazon.PartnerCentralAccount.Model
{
    /// <summary>
    /// Contains information about a validation error, which can be either a field-level or
    /// business rule validation error.
    /// </summary>
    public partial class ValidationError
    {
        private BusinessValidationError _businessValidationError;
        private FieldValidationError _fieldValidationError;

        /// <summary>
        /// Gets and sets the property BusinessValidationError. 
        /// <para>
        /// Details about a business rule validation error, if applicable.
        /// </para>
        /// </summary>
        public BusinessValidationError BusinessValidationError
        {
            get { return this._businessValidationError; }
            set { this._businessValidationError = value; }
        }

        // Check to see if BusinessValidationError property is set
        internal bool IsSetBusinessValidationError()
        {
            return this._businessValidationError != null;
        }

        /// <summary>
        /// Gets and sets the property FieldValidationError. 
        /// <para>
        /// Details about a field-level validation error, if applicable.
        /// </para>
        /// </summary>
        public FieldValidationError FieldValidationError
        {
            get { return this._fieldValidationError; }
            set { this._fieldValidationError = value; }
        }

        // Check to see if FieldValidationError property is set
        internal bool IsSetFieldValidationError()
        {
            return this._fieldValidationError != null;
        }

    }
}