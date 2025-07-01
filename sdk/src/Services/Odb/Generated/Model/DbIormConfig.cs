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
 * Do not modify this file. This file is generated from the odb-2024-08-20.normal.json service model.
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
        private string _dbName;
        private string _flashCacheLimit;
        private int? _share;

        /// <summary>
        /// Gets and sets the property DbName. 
        /// <para>
        /// The database name. For the default DbPlan, the dbName is <c>default</c>.
        /// </para>
        /// </summary>
        public string DbName
        {
            get { return this._dbName; }
            set { this._dbName = value; }
        }

        // Check to see if DbName property is set
        internal bool IsSetDbName()
        {
            return this._dbName != null;
        }

        /// <summary>
        /// Gets and sets the property FlashCacheLimit. 
        /// <para>
        /// The flash cache limit for this database. This value is internally configured based
        /// on the share value assigned to the database.
        /// </para>
        /// </summary>
        public string FlashCacheLimit
        {
            get { return this._flashCacheLimit; }
            set { this._flashCacheLimit = value; }
        }

        // Check to see if FlashCacheLimit property is set
        internal bool IsSetFlashCacheLimit()
        {
            return this._flashCacheLimit != null;
        }

        /// <summary>
        /// Gets and sets the property Share. 
        /// <para>
        /// The relative priority of this database.
        /// </para>
        /// </summary>
        public int? Share
        {
            get { return this._share; }
            set { this._share = value; }
        }

        // Check to see if Share property is set
        internal bool IsSetShare()
        {
            return this._share.HasValue; 
        }

    }
}