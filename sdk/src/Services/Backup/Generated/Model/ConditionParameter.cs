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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Backup.Model
{
    /// <summary>
    /// Includes information about tags you define to assign tagged resources to a backup
    /// plan.
    /// </summary>
    public partial class ConditionParameter
    {
        private string _conditionKey;
        private string _conditionValue;

        /// <summary>
        /// Gets and sets the property ConditionKey. 
        /// <para>
        /// The key in a key-value pair. For example, in the tag <code>Department: Accounting</code>,
        /// <code>Department</code> is the key.
        /// </para>
        /// </summary>
        public string ConditionKey
        {
            get { return this._conditionKey; }
            set { this._conditionKey = value; }
        }

        // Check to see if ConditionKey property is set
        internal bool IsSetConditionKey()
        {
            return this._conditionKey != null;
        }

        /// <summary>
        /// Gets and sets the property ConditionValue. 
        /// <para>
        /// The value in a key-value pair. For example, in the tag <code>Department: Accounting</code>,
        /// <code>Accounting</code> is the value.
        /// </para>
        /// </summary>
        public string ConditionValue
        {
            get { return this._conditionValue; }
            set { this._conditionValue = value; }
        }

        // Check to see if ConditionValue property is set
        internal bool IsSetConditionValue()
        {
            return this._conditionValue != null;
        }

    }
}