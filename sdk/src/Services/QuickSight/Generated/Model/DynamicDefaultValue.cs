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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Defines different defaults to the users or groups based on mapping.
    /// </summary>
    public partial class DynamicDefaultValue
    {
        private ColumnIdentifier _defaultValueColumn;
        private ColumnIdentifier _groupNameColumn;
        private ColumnIdentifier _userNameColumn;

        /// <summary>
        /// Gets and sets the property DefaultValueColumn. 
        /// <para>
        /// The column that contains the default value of each user or group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ColumnIdentifier DefaultValueColumn
        {
            get { return this._defaultValueColumn; }
            set { this._defaultValueColumn = value; }
        }

        // Check to see if DefaultValueColumn property is set
        internal bool IsSetDefaultValueColumn()
        {
            return this._defaultValueColumn != null;
        }

        /// <summary>
        /// Gets and sets the property GroupNameColumn. 
        /// <para>
        /// The column that contains the group name.
        /// </para>
        /// </summary>
        public ColumnIdentifier GroupNameColumn
        {
            get { return this._groupNameColumn; }
            set { this._groupNameColumn = value; }
        }

        // Check to see if GroupNameColumn property is set
        internal bool IsSetGroupNameColumn()
        {
            return this._groupNameColumn != null;
        }

        /// <summary>
        /// Gets and sets the property UserNameColumn. 
        /// <para>
        /// The column that contains the username.
        /// </para>
        /// </summary>
        public ColumnIdentifier UserNameColumn
        {
            get { return this._userNameColumn; }
            set { this._userNameColumn = value; }
        }

        // Check to see if UserNameColumn property is set
        internal bool IsSetUserNameColumn()
        {
            return this._userNameColumn != null;
        }

    }
}