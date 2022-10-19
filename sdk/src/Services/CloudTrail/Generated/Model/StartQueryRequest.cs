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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// Container for the parameters to the StartQuery operation.
    /// Starts a CloudTrail Lake query. The required <code>QueryStatement</code> parameter
    /// provides your SQL query, enclosed in single quotation marks. Use the optional <code>DeliveryS3Uri</code>
    /// parameter to deliver the query results to an S3 bucket.
    /// </summary>
    public partial class StartQueryRequest : AmazonCloudTrailRequest
    {
        private string _deliveryS3Uri;
        private string _queryStatement;

        /// <summary>
        /// Gets and sets the property DeliveryS3Uri. 
        /// <para>
        ///  The URI for the S3 bucket where CloudTrail delivers the query results. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string DeliveryS3Uri
        {
            get { return this._deliveryS3Uri; }
            set { this._deliveryS3Uri = value; }
        }

        // Check to see if DeliveryS3Uri property is set
        internal bool IsSetDeliveryS3Uri()
        {
            return this._deliveryS3Uri != null;
        }

        /// <summary>
        /// Gets and sets the property QueryStatement. 
        /// <para>
        /// The SQL code of your query.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10000)]
        public string QueryStatement
        {
            get { return this._queryStatement; }
            set { this._queryStatement = value; }
        }

        // Check to see if QueryStatement property is set
        internal bool IsSetQueryStatement()
        {
            return this._queryStatement != null;
        }

    }
}