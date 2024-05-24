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
 * Do not modify this file. This file is generated from the mailmanager-2023-10-17.normal.json service model.
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
namespace Amazon.MailManager.Model
{
    /// <summary>
    /// A filter condition used to include or exclude emails when exporting from or searching
    /// an archive.
    /// </summary>
    public partial class ArchiveFilterCondition
    {
        private ArchiveBooleanExpression _booleanExpression;
        private ArchiveStringExpression _stringExpression;

        /// <summary>
        /// Gets and sets the property BooleanExpression. 
        /// <para>
        /// A boolean expression to evaluate against email attributes.
        /// </para>
        /// </summary>
        public ArchiveBooleanExpression BooleanExpression
        {
            get { return this._booleanExpression; }
            set { this._booleanExpression = value; }
        }

        // Check to see if BooleanExpression property is set
        internal bool IsSetBooleanExpression()
        {
            return this._booleanExpression != null;
        }

        /// <summary>
        /// Gets and sets the property StringExpression. 
        /// <para>
        /// A string expression to evaluate against email attributes.
        /// </para>
        /// </summary>
        public ArchiveStringExpression StringExpression
        {
            get { return this._stringExpression; }
            set { this._stringExpression = value; }
        }

        // Check to see if StringExpression property is set
        internal bool IsSetStringExpression()
        {
            return this._stringExpression != null;
        }

    }
}