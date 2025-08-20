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
 * Do not modify this file. This file is generated from the kinesisanalyticsv2-2018-05-23.normal.json service model.
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
namespace Amazon.KinesisAnalyticsV2.Model
{
    /// <summary>
    /// Container for the parameters to the ListApplicationOperations operation.
    /// Lists all the operations performed for the specified application such as UpdateApplication,
    /// StartApplication etc. The response also includes a summary of the operation.
    /// 
    ///  
    /// <para>
    /// To get the complete description of a specific operation, invoke the <a>DescribeApplicationOperation</a>
    /// operation.
    /// </para>
    ///  <note> 
    /// <para>
    /// This operation is supported only for Managed Service for Apache Flink.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ListApplicationOperationsRequest : AmazonKinesisAnalyticsV2Request
    {
        private string _applicationName;
        private int? _limit;
        private string _nextToken;
        private string _operation;
        private OperationStatus _operationStatus;

        /// <summary>
        /// Gets and sets the property ApplicationName.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ApplicationName
        {
            get { return this._applicationName; }
            set { this._applicationName = value; }
        }

        // Check to see if ApplicationName property is set
        internal bool IsSetApplicationName()
        {
            return this._applicationName != null;
        }

        /// <summary>
        /// Gets and sets the property Limit.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public int? Limit
        {
            get { return this._limit; }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken.
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property Operation.
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string Operation
        {
            get { return this._operation; }
            set { this._operation = value; }
        }

        // Check to see if Operation property is set
        internal bool IsSetOperation()
        {
            return this._operation != null;
        }

        /// <summary>
        /// Gets and sets the property OperationStatus.
        /// </summary>
        public OperationStatus OperationStatus
        {
            get { return this._operationStatus; }
            set { this._operationStatus = value; }
        }

        // Check to see if OperationStatus property is set
        internal bool IsSetOperationStatus()
        {
            return this._operationStatus != null;
        }

    }
}