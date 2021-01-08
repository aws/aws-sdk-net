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
 * Do not modify this file. This file is generated from the dynamodb-2012-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// This is the response object from the DescribeKinesisStreamingDestination operation.
    /// </summary>
    public partial class DescribeKinesisStreamingDestinationResponse : AmazonWebServiceResponse
    {
        private List<KinesisDataStreamDestination> _kinesisDataStreamDestinations = new List<KinesisDataStreamDestination>();
        private string _tableName;

        /// <summary>
        /// Gets and sets the property KinesisDataStreamDestinations. 
        /// <para>
        /// The list of replica structures for the table being described.
        /// </para>
        /// </summary>
        public List<KinesisDataStreamDestination> KinesisDataStreamDestinations
        {
            get { return this._kinesisDataStreamDestinations; }
            set { this._kinesisDataStreamDestinations = value; }
        }

        // Check to see if KinesisDataStreamDestinations property is set
        internal bool IsSetKinesisDataStreamDestinations()
        {
            return this._kinesisDataStreamDestinations != null && this._kinesisDataStreamDestinations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// The name of the table being described.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=255)]
        public string TableName
        {
            get { return this._tableName; }
            set { this._tableName = value; }
        }

        // Check to see if TableName property is set
        internal bool IsSetTableName()
        {
            return this._tableName != null;
        }

    }
}