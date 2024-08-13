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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Batch condition that must be met (specified number of events received or batch time
    /// window expired) before EventBridge event trigger fires.
    /// </summary>
    public partial class EventBatchingCondition
    {
        private int? _batchSize;
        private int? _batchWindow;

        /// <summary>
        /// Gets and sets the property BatchSize. 
        /// <para>
        /// Number of events that must be received from Amazon EventBridge before EventBridge
        /// event trigger fires.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
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
        /// Gets and sets the property BatchWindow. 
        /// <para>
        /// Window of time in seconds after which EventBridge event trigger fires. Window starts
        /// when first event is received.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=900)]
        public int? BatchWindow
        {
            get { return this._batchWindow; }
            set { this._batchWindow = value; }
        }

        // Check to see if BatchWindow property is set
        internal bool IsSetBatchWindow()
        {
            return this._batchWindow.HasValue; 
        }

    }
}