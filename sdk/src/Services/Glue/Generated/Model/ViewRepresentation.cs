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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// A structure that contains the dialect of the view, and the query that defines the
    /// view.
    /// </summary>
    public partial class ViewRepresentation
    {
        private ViewDialect _dialect;
        private string _dialectVersion;
        private bool? _isStale;
        private string _validationConnection;
        private string _viewExpandedText;
        private string _viewOriginalText;

        /// <summary>
        /// Gets and sets the property Dialect. 
        /// <para>
        /// The dialect of the query engine.
        /// </para>
        /// </summary>
        public ViewDialect Dialect
        {
            get { return this._dialect; }
            set { this._dialect = value; }
        }

        // Check to see if Dialect property is set
        internal bool IsSetDialect()
        {
            return this._dialect != null;
        }

        /// <summary>
        /// Gets and sets the property DialectVersion. 
        /// <para>
        /// The version of the dialect of the query engine. For example, 3.0.0.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string DialectVersion
        {
            get { return this._dialectVersion; }
            set { this._dialectVersion = value; }
        }

        // Check to see if DialectVersion property is set
        internal bool IsSetDialectVersion()
        {
            return this._dialectVersion != null;
        }

        /// <summary>
        /// Gets and sets the property IsStale. 
        /// <para>
        /// Dialects marked as stale are no longer valid and must be updated before they can be
        /// queried in their respective query engines.
        /// </para>
        /// </summary>
        public bool? IsStale
        {
            get { return this._isStale; }
            set { this._isStale = value; }
        }

        // Check to see if IsStale property is set
        internal bool IsSetIsStale()
        {
            return this._isStale.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ValidationConnection. 
        /// <para>
        /// The name of the connection to be used to validate the specific representation of the
        /// view.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string ValidationConnection
        {
            get { return this._validationConnection; }
            set { this._validationConnection = value; }
        }

        // Check to see if ValidationConnection property is set
        internal bool IsSetValidationConnection()
        {
            return this._validationConnection != null;
        }

        /// <summary>
        /// Gets and sets the property ViewExpandedText. 
        /// <para>
        /// The expanded SQL for the view. This SQL is used by engines while processing a query
        /// on a view. Engines may perform operations during view creation to transform <c>ViewOriginalText</c>
        /// to <c>ViewExpandedText</c>. For example:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Fully qualified identifiers: <c>SELECT * from table1 -&gt; SELECT * from db1.table1</c>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Max=409600)]
        public string ViewExpandedText
        {
            get { return this._viewExpandedText; }
            set { this._viewExpandedText = value; }
        }

        // Check to see if ViewExpandedText property is set
        internal bool IsSetViewExpandedText()
        {
            return this._viewExpandedText != null;
        }

        /// <summary>
        /// Gets and sets the property ViewOriginalText. 
        /// <para>
        /// The <c>SELECT</c> query provided by the customer during <c>CREATE VIEW DDL</c>. This
        /// SQL is not used during a query on a view (<c>ViewExpandedText</c> is used instead).
        /// <c>ViewOriginalText</c> is used for cases like <c>SHOW CREATE VIEW</c> where users
        /// want to see the original DDL command that created the view.
        /// </para>
        /// </summary>
        [AWSProperty(Max=409600)]
        public string ViewOriginalText
        {
            get { return this._viewOriginalText; }
            set { this._viewOriginalText = value; }
        }

        // Check to see if ViewOriginalText property is set
        internal bool IsSetViewOriginalText()
        {
            return this._viewOriginalText != null;
        }

    }
}