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
 * Do not modify this file. This file is generated from the resiliencehubv2-2026-02-17.normal.json service model.
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
namespace Amazon.Resiliencehubv2.Model
{
    /// <summary>
    /// Describes a change from one string value to another.
    /// </summary>
    public partial class StringChange
    {
        private string _newValue;
        private string _oldValue;

        /// <summary>
        /// Gets and sets the property NewValue. 
        /// <para>
        /// The new value.
        /// </para>
        /// </summary>
        public string NewValue
        {
            get { return this._newValue; }
            set { this._newValue = value; }
        }

        // Check to see if NewValue property is set
        internal bool IsSetNewValue()
        {
            return this._newValue != null;
        }

        /// <summary>
        /// Gets and sets the property OldValue. 
        /// <para>
        /// The old value.
        /// </para>
        /// </summary>
        public string OldValue
        {
            get { return this._oldValue; }
            set { this._oldValue = value; }
        }

        // Check to see if OldValue property is set
        internal bool IsSetOldValue()
        {
            return this._oldValue != null;
        }

    }
}