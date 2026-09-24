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
    /// Extra details specific to this notification.
    /// </summary>
    public partial class NotificationDetails
    {
        /// <summary>
        /// Gets and sets the property DataUpdate. 
        /// <para>
        /// Extra details specific to a data update type notification.
        /// </para>
        /// </summary>
        public DataUpdateRequestDetails DataUpdate { get; set; }

        /// <summary>
        /// Checks to see if the DataUpdate property is set.
        /// </summary>
        internal bool IsSetDataUpdate() => this.DataUpdate != null;

        /// <summary>
        /// Gets and sets the property Deprecation. 
        /// <para>
        /// Extra details specific to a deprecation type notification.
        /// </para>
        /// </summary>
        public DeprecationRequestDetails Deprecation { get; set; }

        /// <summary>
        /// Checks to see if the Deprecation property is set.
        /// </summary>
        internal bool IsSetDeprecation() => this.Deprecation != null;

        /// <summary>
        /// Gets and sets the property SchemaChange. 
        /// <para>
        /// Extra details specific to a schema change type notification.
        /// </para>
        /// </summary>
        public SchemaChangeRequestDetails SchemaChange { get; set; }

        /// <summary>
        /// Checks to see if the SchemaChange property is set.
        /// </summary>
        internal bool IsSetSchemaChange() => this.SchemaChange != null;
    }
}
