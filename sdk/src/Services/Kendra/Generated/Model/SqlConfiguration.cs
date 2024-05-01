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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
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
namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Provides the configuration information to use a SQL database.
    /// </summary>
    public partial class SqlConfiguration
    {
        private QueryIdentifiersEnclosingOption _queryIdentifiersEnclosingOption;

        /// <summary>
        /// Gets and sets the property QueryIdentifiersEnclosingOption. 
        /// <para>
        /// Determines whether Amazon Kendra encloses SQL identifiers for tables and column names
        /// in double quotes (") when making a database query.
        /// </para>
        ///  
        /// <para>
        /// By default, Amazon Kendra passes SQL identifiers the way that they are entered into
        /// the data source configuration. It does not change the case of identifiers or enclose
        /// them in quotes.
        /// </para>
        ///  
        /// <para>
        /// PostgreSQL internally converts uppercase characters to lower case characters in identifiers
        /// unless they are quoted. Choosing this option encloses identifiers in quotes so that
        /// PostgreSQL does not convert the character's case.
        /// </para>
        ///  
        /// <para>
        /// For MySQL databases, you must enable the <c>ansi_quotes</c> option when you set this
        /// field to <c>DOUBLE_QUOTES</c>.
        /// </para>
        /// </summary>
        public QueryIdentifiersEnclosingOption QueryIdentifiersEnclosingOption
        {
            get { return this._queryIdentifiersEnclosingOption; }
            set { this._queryIdentifiersEnclosingOption = value; }
        }

        // Check to see if QueryIdentifiersEnclosingOption property is set
        internal bool IsSetQueryIdentifiersEnclosingOption()
        {
            return this._queryIdentifiersEnclosingOption != null;
        }

    }
}