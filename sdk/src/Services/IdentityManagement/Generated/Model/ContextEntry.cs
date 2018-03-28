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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Contains information about a condition context key. It includes the name of the key
    /// and specifies the value (or values, if the context key supports multiple values) to
    /// use in the simulation. This information is used when evaluating the <code>Condition</code>
    /// elements of the input policies.
    /// 
    ///  
    /// <para>
    /// This data type is used as an input parameter to <code> <a>SimulateCustomPolicy</a>
    /// </code> and <code> <a>SimulateCustomPolicy</a> </code>.
    /// </para>
    /// </summary>
    public partial class ContextEntry
    {
        private string _contextKeyName;
        private ContextKeyTypeEnum _contextKeyType;
        private List<string> _contextKeyValues = new List<string>();

        /// <summary>
        /// Gets and sets the property ContextKeyName. 
        /// <para>
        /// The full name of a condition context key, including the service prefix. For example,
        /// <code>aws:SourceIp</code> or <code>s3:VersionId</code>.
        /// </para>
        /// </summary>
        public string ContextKeyName
        {
            get { return this._contextKeyName; }
            set { this._contextKeyName = value; }
        }

        // Check to see if ContextKeyName property is set
        internal bool IsSetContextKeyName()
        {
            return this._contextKeyName != null;
        }

        /// <summary>
        /// Gets and sets the property ContextKeyType. 
        /// <para>
        /// The data type of the value (or values) specified in the <code>ContextKeyValues</code>
        /// parameter.
        /// </para>
        /// </summary>
        public ContextKeyTypeEnum ContextKeyType
        {
            get { return this._contextKeyType; }
            set { this._contextKeyType = value; }
        }

        // Check to see if ContextKeyType property is set
        internal bool IsSetContextKeyType()
        {
            return this._contextKeyType != null;
        }

        /// <summary>
        /// Gets and sets the property ContextKeyValues. 
        /// <para>
        /// The value (or values, if the condition context key supports multiple values) to provide
        /// to the simulation when the key is referenced by a <code>Condition</code> element in
        /// an input policy.
        /// </para>
        /// </summary>
        public List<string> ContextKeyValues
        {
            get { return this._contextKeyValues; }
            set { this._contextKeyValues = value; }
        }

        // Check to see if ContextKeyValues property is set
        internal bool IsSetContextKeyValues()
        {
            return this._contextKeyValues != null && this._contextKeyValues.Count > 0; 
        }

    }
}