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
 * Do not modify this file. This file is generated from the sqs-2012-11-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SQS.Model
{
    /// <summary>
    /// For each message in the batch, the response contains a <code> <a>ChangeMessageVisibilityBatchResultEntry</a>
    /// </code> tag if the message succeeds or a <code> <a>BatchResultErrorEntry</a> </code>
    /// tag if the message fails.
    /// </summary>
    public partial class ChangeMessageVisibilityBatchResponse : AmazonWebServiceResponse
    {
        private List<BatchResultErrorEntry> _failed = new List<BatchResultErrorEntry>();
        private List<ChangeMessageVisibilityBatchResultEntry> _successful = new List<ChangeMessageVisibilityBatchResultEntry>();

        /// <summary>
        /// Gets and sets the property Failed. 
        /// <para>
        /// A list of <code> <a>BatchResultErrorEntry</a> </code> items.
        /// </para>
        /// </summary>
        public List<BatchResultErrorEntry> Failed
        {
            get { return this._failed; }
            set { this._failed = value; }
        }

        // Check to see if Failed property is set
        internal bool IsSetFailed()
        {
            return this._failed != null && this._failed.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Successful. 
        /// <para>
        /// A list of <code> <a>ChangeMessageVisibilityBatchResultEntry</a> </code> items.
        /// </para>
        /// </summary>
        public List<ChangeMessageVisibilityBatchResultEntry> Successful
        {
            get { return this._successful; }
            set { this._successful = value; }
        }

        // Check to see if Successful property is set
        internal bool IsSetSuccessful()
        {
            return this._successful != null && this._successful.Count > 0; 
        }

    }
}