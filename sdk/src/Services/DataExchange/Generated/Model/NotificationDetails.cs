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
    /// Extra details specific to this notification.
    /// </summary>
    public partial class NotificationDetails
    {
        private DataUpdateRequestDetails _dataUpdate;
        private DeprecationRequestDetails _deprecation;
        private SchemaChangeRequestDetails _schemaChange;

        /// <summary>
        /// Gets and sets the property DataUpdate. 
        /// <para>
        /// Extra details specific to a data update type notification.
        /// </para>
        /// </summary>
        public DataUpdateRequestDetails DataUpdate
        {
            get { return this._dataUpdate; }
            set { this._dataUpdate = value; }
        }

        // Check to see if DataUpdate property is set
        internal bool IsSetDataUpdate()
        {
            return this._dataUpdate != null;
        }

        /// <summary>
        /// Gets and sets the property Deprecation. 
        /// <para>
        /// Extra details specific to a deprecation type notification.
        /// </para>
        /// </summary>
        public DeprecationRequestDetails Deprecation
        {
            get { return this._deprecation; }
            set { this._deprecation = value; }
        }

        // Check to see if Deprecation property is set
        internal bool IsSetDeprecation()
        {
            return this._deprecation != null;
        }

        /// <summary>
        /// Gets and sets the property SchemaChange. 
        /// <para>
        /// Extra details specific to a schema change type notification.
        /// </para>
        /// </summary>
        public SchemaChangeRequestDetails SchemaChange
        {
            get { return this._schemaChange; }
            set { this._schemaChange = value; }
        }

        // Check to see if SchemaChange property is set
        internal bool IsSetSchemaChange()
        {
            return this._schemaChange != null;
        }

    }
}