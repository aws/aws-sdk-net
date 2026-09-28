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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the underlying Redshift data share that is being affected by this notification.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property Database. 
        /// <para>
        /// The database name in the Redshift data share that is being affected by this notification.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Database { get; set; }

        /// <summary>
        /// Checks to see if the Database property is set.
        /// </summary>
        internal bool IsSetDatabase() => this.Database != null;

        /// <summary>
        /// Gets and sets the property Function. 
        /// <para>
        /// A function name in the Redshift database that is being affected by this notification.
        /// </para>
        /// </summary>
        public string Function { get; set; }

        /// <summary>
        /// Checks to see if the Function property is set.
        /// </summary>
        internal bool IsSetFunction() => this.Function != null;

        /// <summary>
        /// Gets and sets the property Schema. 
        /// <para>
        /// A schema name in the Redshift database that is being affected by this notification.
        /// </para>
        /// </summary>
        public string Schema { get; set; }

        /// <summary>
        /// Checks to see if the Schema property is set.
        /// </summary>
        internal bool IsSetSchema() => this.Schema != null;

        /// <summary>
        /// Gets and sets the property Table. 
        /// <para>
        /// A table name in the Redshift database that is being affected by this notification.
        /// </para>
        /// </summary>
        public string Table { get; set; }

        /// <summary>
        /// Checks to see if the Table property is set.
        /// </summary>
        internal bool IsSetTable() => this.Table != null;

        /// <summary>
        /// Gets and sets the property View. 
        /// <para>
        /// A view name in the Redshift database that is being affected by this notification.
        /// </para>
        /// </summary>
        public string View { get; set; }

        /// <summary>
        /// Checks to see if the View property is set.
        /// </summary>
        internal bool IsSetView() => this.View != null;
    }
}
