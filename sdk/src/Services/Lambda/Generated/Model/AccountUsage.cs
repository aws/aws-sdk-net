/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Provides code size usage and function count associated with the current account and
    /// region.
    /// </summary>
    public partial class AccountUsage
    {
        private long? _functionCount;
        private long? _totalCodeSize;

        /// <summary>
        /// Gets and sets the property FunctionCount. 
        /// <para>
        /// The number of your account's existing functions per region.
        /// </para>
        /// </summary>
        public long FunctionCount
        {
            get { return this._functionCount.GetValueOrDefault(); }
            set { this._functionCount = value; }
        }

        // Check to see if FunctionCount property is set
        internal bool IsSetFunctionCount()
        {
            return this._functionCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalCodeSize. 
        /// <para>
        /// Total size, in megabytes, of the account's deployment packages per region.
        /// </para>
        /// </summary>
        public long TotalCodeSize
        {
            get { return this._totalCodeSize.GetValueOrDefault(); }
            set { this._totalCodeSize = value; }
        }

        // Check to see if TotalCodeSize property is set
        internal bool IsSetTotalCodeSize()
        {
            return this._totalCodeSize.HasValue; 
        }

    }
}