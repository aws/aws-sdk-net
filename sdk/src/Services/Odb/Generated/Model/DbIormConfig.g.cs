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

namespace Amazon.Odb.Model
{
    /// <summary>
    /// The IORM configuration settings for the database.
    /// </summary>
    public partial class DbIormConfig
    {
        /// <summary>
        /// Gets and sets the property DbName. 
        /// <para>
        /// The database name. For the default DbPlan, the dbName is <c>default</c>.
        /// </para>
        /// </summary>
        public string DbName { get; set; }

        /// <summary>
        /// Checks to see if the DbName property is set.
        /// </summary>
        internal bool IsSetDbName() => this.DbName != null;

        /// <summary>
        /// Gets and sets the property FlashCacheLimit. 
        /// <para>
        /// The flash cache limit for this database. This value is internally configured based
        /// on the share value assigned to the database.
        /// </para>
        /// </summary>
        public string FlashCacheLimit { get; set; }

        /// <summary>
        /// Checks to see if the FlashCacheLimit property is set.
        /// </summary>
        internal bool IsSetFlashCacheLimit() => this.FlashCacheLimit != null;

        /// <summary>
        /// Gets and sets the property Share. 
        /// <para>
        /// The relative priority of this database.
        /// </para>
        /// </summary>
        public int? Share { get; set; }

        /// <summary>
        /// Checks to see if the Share property is set.
        /// </summary>
        internal bool IsSetShare() => this.Share.HasValue;
    }
}
