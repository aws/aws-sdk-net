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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Container for the parameters to the StartRelationalDatabase operation.
    /// Starts a specific database from a stopped state in Amazon Lightsail. To restart a
    /// database, use the <code>reboot relational database</code> operation.
    /// 
    ///  
    /// <para>
    /// The <code>start relational database</code> operation supports tag-based access control
    /// via resource tags applied to the resource identified by relationalDatabaseName. For
    /// more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
    /// Dev Guide</a>.
    /// </para>
    /// </summary>
    public partial class StartRelationalDatabaseRequest : AmazonLightsailRequest
    {
        private string _relationalDatabaseName;

        /// <summary>
        /// Gets and sets the property RelationalDatabaseName. 
        /// <para>
        /// The name of your database to start.
        /// </para>
        /// </summary>
        public string RelationalDatabaseName
        {
            get { return this._relationalDatabaseName; }
            set { this._relationalDatabaseName = value; }
        }

        // Check to see if RelationalDatabaseName property is set
        internal bool IsSetRelationalDatabaseName()
        {
            return this._relationalDatabaseName != null;
        }

    }
}