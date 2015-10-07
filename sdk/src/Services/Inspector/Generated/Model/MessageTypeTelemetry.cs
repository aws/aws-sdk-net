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
 * Do not modify this file. This file is generated from the inspector-2015-08-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Inspector.Model
{
    /// <summary>
    /// This data type is used in the <a>Telemetry</a> data type.
    /// 
    ///  
    /// <para>
    /// This is metadata about the behavioral data collected by the Inspector agent on your
    /// EC2 instances during an assessment and passed to the Inspector service for analysis.
    /// 
    /// </para>
    /// </summary>
    public partial class MessageTypeTelemetry
    {
        private long? _count;
        private long? _dataSize;
        private string _messageType;

        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// The number of times that the behavioral data is collected by the agent during an assessment.
        /// </para>
        /// </summary>
        public long Count
        {
            get { return this._count.GetValueOrDefault(); }
            set { this._count = value; }
        }

        // Check to see if Count property is set
        internal bool IsSetCount()
        {
            return this._count.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DataSize. 
        /// <para>
        /// The total size of the behavioral data that is collected by the agent during an assessment.
        /// </para>
        /// </summary>
        public long DataSize
        {
            get { return this._dataSize.GetValueOrDefault(); }
            set { this._dataSize = value; }
        }

        // Check to see if DataSize property is set
        internal bool IsSetDataSize()
        {
            return this._dataSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MessageType. 
        /// <para>
        /// A specific type of behavioral data that is collected by the agent.
        /// </para>
        /// </summary>
        public string MessageType
        {
            get { return this._messageType; }
            set { this._messageType = value; }
        }

        // Check to see if MessageType property is set
        internal bool IsSetMessageType()
        {
            return this._messageType != null;
        }

    }
}