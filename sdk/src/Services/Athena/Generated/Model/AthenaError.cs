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
 * Do not modify this file. This file is generated from the athena-2017-05-18.normal.json service model.
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
namespace Amazon.Athena.Model
{
    /// <summary>
    /// Provides information about an Athena query error. The <c>AthenaError</c> feature provides
    /// standardized error information to help you understand failed queries and take steps
    /// after a query failure occurs. <c>AthenaError</c> includes an <c>ErrorCategory</c>
    /// field that specifies whether the cause of the failed query is due to system error,
    /// user error, or other error.
    /// </summary>
    public partial class AthenaError
    {
        private int? _errorCategory;
        private string _errorMessage;
        private int? _errorType;
        private bool? _retryable;

        /// <summary>
        /// Gets and sets the property ErrorCategory. 
        /// <para>
        /// An integer value that specifies the category of a query failure error. The following
        /// list shows the category for each integer value.
        /// </para>
        ///  
        /// <para>
        ///  <b>1</b> - System
        /// </para>
        ///  
        /// <para>
        ///  <b>2</b> - User
        /// </para>
        ///  
        /// <para>
        ///  <b>3</b> - Other
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=3)]
        public int? ErrorCategory
        {
            get { return this._errorCategory; }
            set { this._errorCategory = value; }
        }

        // Check to see if ErrorCategory property is set
        internal bool IsSetErrorCategory()
        {
            return this._errorCategory.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// Contains a short description of the error that occurred.
        /// </para>
        /// </summary>
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorType. 
        /// <para>
        /// An integer value that provides specific information about an Athena query error. For
        /// the meaning of specific values, see the <a href="https://docs.aws.amazon.com/athena/latest/ug/error-reference.html#error-reference-error-type-reference">Error
        /// Type Reference</a> in the <i>Amazon Athena User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=9999)]
        public int? ErrorType
        {
            get { return this._errorType; }
            set { this._errorType = value; }
        }

        // Check to see if ErrorType property is set
        internal bool IsSetErrorType()
        {
            return this._errorType.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Retryable. 
        /// <para>
        /// True if the query might succeed if resubmitted.
        /// </para>
        /// </summary>
        public bool? Retryable
        {
            get { return this._retryable; }
            set { this._retryable = value; }
        }

        // Check to see if Retryable property is set
        internal bool IsSetRetryable()
        {
            return this._retryable.HasValue; 
        }

    }
}