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
 * Do not modify this file. This file is generated from the dataexchange-2017-07-25.normal.json service model.
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
namespace Amazon.DataExchange.Model
{
    /// <summary>
    /// Extra details specific to the affected scope in this Redshift data set.
    /// </summary>
    public partial class RedshiftDataShareDetails
    {
        private string _arn;
        private string _database;
        private string _function;
        private string _schema;
        private string _table;
        private string _view;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the underlying Redshift data share that is being affected by this notification.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Database. 
        /// <para>
        /// The database name in the Redshift data share that is being affected by this notification.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Database
        {
            get { return this._database; }
            set { this._database = value; }
        }

        // Check to see if Database property is set
        internal bool IsSetDatabase()
        {
            return this._database != null;
        }

        /// <summary>
        /// Gets and sets the property Function. 
        /// <para>
        /// A function name in the Redshift database that is being affected by this notification.
        /// </para>
        /// </summary>
        public string Function
        {
            get { return this._function; }
            set { this._function = value; }
        }

        // Check to see if Function property is set
        internal bool IsSetFunction()
        {
            return this._function != null;
        }

        /// <summary>
        /// Gets and sets the property Schema. 
        /// <para>
        /// A schema name in the Redshift database that is being affected by this notification.
        /// </para>
        /// </summary>
        public string Schema
        {
            get { return this._schema; }
            set { this._schema = value; }
        }

        // Check to see if Schema property is set
        internal bool IsSetSchema()
        {
            return this._schema != null;
        }

        /// <summary>
        /// Gets and sets the property Table. 
        /// <para>
        /// A table name in the Redshift database that is being affected by this notification.
        /// </para>
        /// </summary>
        public string Table
        {
            get { return this._table; }
            set { this._table = value; }
        }

        // Check to see if Table property is set
        internal bool IsSetTable()
        {
            return this._table != null;
        }

        /// <summary>
        /// Gets and sets the property View. 
        /// <para>
        /// A view name in the Redshift database that is being affected by this notification.
        /// </para>
        /// </summary>
        public string View
        {
            get { return this._view; }
            set { this._view = value; }
        }

        // Check to see if View property is set
        internal bool IsSetView()
        {
            return this._view != null;
        }

    }
}