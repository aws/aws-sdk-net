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
 * Do not modify this file. This file is generated from the securitylake-2018-05-10.normal.json service model.
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
namespace Amazon.SecurityLake.Model
{
    /// <summary>
    /// The attributes of a third-party custom source.
    /// </summary>
    public partial class CustomLogSourceAttributes
    {
        private string _crawlerArn;
        private string _databaseArn;
        private string _tableArn;

        /// <summary>
        /// Gets and sets the property CrawlerArn. 
        /// <para>
        /// The ARN of the Glue crawler.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1011)]
        public string CrawlerArn
        {
            get { return this._crawlerArn; }
            set { this._crawlerArn = value; }
        }

        // Check to see if CrawlerArn property is set
        internal bool IsSetCrawlerArn()
        {
            return this._crawlerArn != null;
        }

        /// <summary>
        /// Gets and sets the property DatabaseArn. 
        /// <para>
        /// The ARN of the Glue database where results are written, such as: <c>arn:aws:daylight:us-east-1::database/sometable/*</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1011)]
        public string DatabaseArn
        {
            get { return this._databaseArn; }
            set { this._databaseArn = value; }
        }

        // Check to see if DatabaseArn property is set
        internal bool IsSetDatabaseArn()
        {
            return this._databaseArn != null;
        }

        /// <summary>
        /// Gets and sets the property TableArn. 
        /// <para>
        /// The ARN of the Glue table.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1011)]
        public string TableArn
        {
            get { return this._tableArn; }
            set { this._tableArn = value; }
        }

        // Check to see if TableArn property is set
        internal bool IsSetTableArn()
        {
            return this._tableArn != null;
        }

    }
}