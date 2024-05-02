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
 * Do not modify this file. This file is generated from the iotanalytics-2017-11-27.normal.json service model.
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
namespace Amazon.IoTAnalytics.Model
{
    /// <summary>
    /// An activity that runs a Lambda function to modify the message.
    /// </summary>
    public partial class LambdaActivity
    {
        private int? _batchSize;
        private string _lambdaName;
        private string _name;
        private string _next;

        /// <summary>
        /// Gets and sets the property BatchSize. 
        /// <para>
        /// The number of messages passed to the Lambda function for processing.
        /// </para>
        ///  
        /// <para>
        /// The Lambda function must be able to process all of these messages within five minutes,
        /// which is the maximum timeout duration for Lambda functions.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1000)]
        public int? BatchSize
        {
            get { return this._batchSize; }
            set { this._batchSize = value; }
        }

        // Check to see if BatchSize property is set
        internal bool IsSetBatchSize()
        {
            return this._batchSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LambdaName. 
        /// <para>
        /// The name of the Lambda function that is run on the message.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string LambdaName
        {
            get { return this._lambdaName; }
            set { this._lambdaName = value; }
        }

        // Check to see if LambdaName property is set
        internal bool IsSetLambdaName()
        {
            return this._lambdaName != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the lambda activity.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Next. 
        /// <para>
        /// The next activity in the pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string Next
        {
            get { return this._next; }
            set { this._next = value; }
        }

        // Check to see if Next property is set
        internal bool IsSetNext()
        {
            return this._next != null;
        }

    }
}