/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateEventSourceMapping operation.
    /// You can update an event source mapping. This is useful if you want to change the parameters
    /// of the existing mapping without losing your position in the stream. You can change
    /// which function will receive the stream records, but to change the stream itself, you
    /// must create a new mapping.
    /// 
    ///  
    /// <para>
    /// If you disable the event source mapping, AWS Lambda stops polling. If you enable again,
    /// it will resume polling from the time it had stopped polling, so you don't lose processing
    /// of any records. However, if you delete event source mapping and create it again, it
    /// will reset.
    /// </para>
    ///  
    /// <para>
    /// This operation requires permission for the <code>lambda:UpdateEventSourceMapping</code>
    /// action.
    /// </para>
    /// </summary>
    public partial class UpdateEventSourceMappingRequest : AmazonLambdaRequest
    {
        private int? _batchSize;
        private bool? _enabled;
        private string _functionName;
        private string _uuid;

        /// <summary>
        /// Gets and sets the property BatchSize. 
        /// <para>
        /// The largest number of records that AWS Lambda will retrieve from your event source
        /// at the time of invoking your function. Your function receives an event with all the
        /// retrieved records.
        /// </para>
        /// </summary>
        public int BatchSize
        {
            get { return this._batchSize.GetValueOrDefault(); }
            set { this._batchSize = value; }
        }

        // Check to see if BatchSize property is set
        internal bool IsSetBatchSize()
        {
            return this._batchSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Specifies whether AWS Lambda should actively poll the stream or not. If disabled,
        /// AWS Lambda will not poll the stream.
        /// </para>
        /// </summary>
        public bool Enabled
        {
            get { return this._enabled.GetValueOrDefault(); }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FunctionName. 
        /// <para>
        /// The name of the lambda function.
        /// </para>
        ///  <p class="title"> <b>Name formats</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Function name</b> - <code>MyFunction</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Function ARN</b> - <code>arn:aws:lambda:us-west-2:123456789012:function:MyFunction</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Version or Alias ARN</b> - <code>arn:aws:lambda:us-west-2:123456789012:function:MyFunction:PROD</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Partial ARN</b> - <code>123456789012:function:MyFunction</code>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The length constraint applies only to the full ARN. If you specify only the function
        /// name, it is limited to 64 characters in length.
        /// </para>
        /// </summary>
        public string FunctionName
        {
            get { return this._functionName; }
            set { this._functionName = value; }
        }

        // Check to see if FunctionName property is set
        internal bool IsSetFunctionName()
        {
            return this._functionName != null;
        }

        /// <summary>
        /// Gets and sets the property UUID. 
        /// <para>
        /// The event source mapping identifier.
        /// </para>
        /// </summary>
        public string UUID
        {
            get { return this._uuid; }
            set { this._uuid = value; }
        }

        // Check to see if UUID property is set
        internal bool IsSetUUID()
        {
            return this._uuid != null;
        }

    }
}