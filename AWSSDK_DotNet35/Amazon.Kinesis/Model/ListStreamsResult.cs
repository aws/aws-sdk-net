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
 * Do not modify this file. This file is generated from the kinesis-2013-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kinesis.Model
{
    /// <summary>
    /// Represents the output for <code>ListStreams</code>.
    /// </summary>
    public partial class ListStreamsResult : AmazonWebServiceResponse
    {
        private bool? _hasMoreStreams;
        private List<string> _streamNames = new List<string>();

        /// <summary>
        /// Gets and sets the property HasMoreStreams. 
        /// <para>
        /// If set to <code>true</code>, there are more streams available to list.
        /// </para>
        /// </summary>
        public bool HasMoreStreams
        {
            get { return this._hasMoreStreams.GetValueOrDefault(); }
            set { this._hasMoreStreams = value; }
        }

        // Check to see if HasMoreStreams property is set
        internal bool IsSetHasMoreStreams()
        {
            return this._hasMoreStreams.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StreamNames. 
        /// <para>
        /// The names of the streams that are associated with the AWS account making the <code>ListStreams</code>
        /// request.
        /// </para>
        /// </summary>
        public List<string> StreamNames
        {
            get { return this._streamNames; }
            set { this._streamNames = value; }
        }

        // Check to see if StreamNames property is set
        internal bool IsSetStreamNames()
        {
            return this._streamNames != null && this._streamNames.Count > 0; 
        }

    }
}