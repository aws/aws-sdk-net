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

namespace Amazon.Athena.Model
{
    /// <summary>
    /// Provides information about an Athena query error. The <code>AthenaError</code> feature
    /// provides standardized error information to help you understand failed queries and
    /// take steps after a query failure occurs. <code>AthenaError</code> includes an <code>ErrorCategory</code>
    /// field that specifies whether the cause of the failed query is due to system error,
    /// user error, or unknown error.
    /// </summary>
    public partial class AthenaError
    {
        private int? _errorCategory;

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
        ///  <b>3</b> - Unknown
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=3)]
        public int ErrorCategory
        {
            get { return this._errorCategory.GetValueOrDefault(); }
            set { this._errorCategory = value; }
        }

        // Check to see if ErrorCategory property is set
        internal bool IsSetErrorCategory()
        {
            return this._errorCategory.HasValue; 
        }

    }
}