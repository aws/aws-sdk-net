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
 * Do not modify this file. This file is generated from the cleanroomsml-2023-09-06.normal.json service model.
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
namespace Amazon.CleanRoomsML.Model
{
    /// <summary>
    /// Defines information about the Glue data source that contains the training data.
    /// </summary>
    public partial class DataSource
    {
        private GlueDataSource _glueDataSource;

        /// <summary>
        /// Gets and sets the property GlueDataSource. 
        /// <para>
        /// A GlueDataSource object that defines the catalog ID, database name, and table name
        /// for the training data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public GlueDataSource GlueDataSource
        {
            get { return this._glueDataSource; }
            set { this._glueDataSource = value; }
        }

        // Check to see if GlueDataSource property is set
        internal bool IsSetGlueDataSource()
        {
            return this._glueDataSource != null;
        }

    }
}