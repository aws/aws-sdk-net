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
 * Do not modify this file. This file is generated from the neptune-2018-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Neptune.Model
{
    /// <summary>
    /// Contains the name and values of a manual DB cluster snapshot attribute.
    /// 
    ///  
    /// <para>
    /// Manual DB cluster snapshot attributes are used to authorize other AWS accounts to
    /// restore a manual DB cluster snapshot. For more information, see the <a>ModifyDBClusterSnapshotAttribute</a>
    /// API action.
    /// </para>
    /// </summary>
    public partial class DBClusterSnapshotAttribute
    {
        private string _attributeName;
        private List<string> _attributeValues = new List<string>();

        /// <summary>
        /// Gets and sets the property AttributeName. 
        /// <para>
        /// The name of the manual DB cluster snapshot attribute.
        /// </para>
        ///  
        /// <para>
        /// The attribute named <code>restore</code> refers to the list of AWS accounts that have
        /// permission to copy or restore the manual DB cluster snapshot. For more information,
        /// see the <a>ModifyDBClusterSnapshotAttribute</a> API action.
        /// </para>
        /// </summary>
        public string AttributeName
        {
            get { return this._attributeName; }
            set { this._attributeName = value; }
        }

        // Check to see if AttributeName property is set
        internal bool IsSetAttributeName()
        {
            return this._attributeName != null;
        }

        /// <summary>
        /// Gets and sets the property AttributeValues. 
        /// <para>
        /// The value(s) for the manual DB cluster snapshot attribute.
        /// </para>
        ///  
        /// <para>
        /// If the <code>AttributeName</code> field is set to <code>restore</code>, then this
        /// element returns a list of IDs of the AWS accounts that are authorized to copy or restore
        /// the manual DB cluster snapshot. If a value of <code>all</code> is in the list, then
        /// the manual DB cluster snapshot is public and available for any AWS account to copy
        /// or restore.
        /// </para>
        /// </summary>
        public List<string> AttributeValues
        {
            get { return this._attributeValues; }
            set { this._attributeValues = value; }
        }

        // Check to see if AttributeValues property is set
        internal bool IsSetAttributeValues()
        {
            return this._attributeValues != null && this._attributeValues.Count > 0; 
        }

    }
}