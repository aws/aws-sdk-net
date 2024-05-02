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
 * Do not modify this file. This file is generated from the dynamodb-2012-08-10.normal.json service model.
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
namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// Contains details of the table class.
    /// </summary>
    public partial class TableClassSummary
    {
        private DateTime? _lastUpdateDateTime;
        private TableClass _tableClass;

        /// <summary>
        /// Gets and sets the property LastUpdateDateTime. 
        /// <para>
        /// The date and time at which the table class was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdateDateTime
        {
            get { return this._lastUpdateDateTime; }
            set { this._lastUpdateDateTime = value; }
        }

        // Check to see if LastUpdateDateTime property is set
        internal bool IsSetLastUpdateDateTime()
        {
            return this._lastUpdateDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TableClass. 
        /// <para>
        /// The table class of the specified table. Valid values are <c>STANDARD</c> and <c>STANDARD_INFREQUENT_ACCESS</c>.
        /// </para>
        /// </summary>
        public TableClass TableClass
        {
            get { return this._tableClass; }
            set { this._tableClass = value; }
        }

        // Check to see if TableClass property is set
        internal bool IsSetTableClass()
        {
            return this._tableClass != null;
        }

    }
}