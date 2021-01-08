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
 * Do not modify this file. This file is generated from the elasticache-2015-02-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// This is the response object from the BatchApplyUpdateAction operation.
    /// </summary>
    public partial class BatchApplyUpdateActionResponse : AmazonWebServiceResponse
    {
        private List<ProcessedUpdateAction> _processedUpdateActions = new List<ProcessedUpdateAction>();
        private List<UnprocessedUpdateAction> _unprocessedUpdateActions = new List<UnprocessedUpdateAction>();

        /// <summary>
        /// Gets and sets the property ProcessedUpdateActions. 
        /// <para>
        /// Update actions that have been processed successfully
        /// </para>
        /// </summary>
        public List<ProcessedUpdateAction> ProcessedUpdateActions
        {
            get { return this._processedUpdateActions; }
            set { this._processedUpdateActions = value; }
        }

        // Check to see if ProcessedUpdateActions property is set
        internal bool IsSetProcessedUpdateActions()
        {
            return this._processedUpdateActions != null && this._processedUpdateActions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UnprocessedUpdateActions. 
        /// <para>
        /// Update actions that haven't been processed successfully
        /// </para>
        /// </summary>
        public List<UnprocessedUpdateAction> UnprocessedUpdateActions
        {
            get { return this._unprocessedUpdateActions; }
            set { this._unprocessedUpdateActions = value; }
        }

        // Check to see if UnprocessedUpdateActions property is set
        internal bool IsSetUnprocessedUpdateActions()
        {
            return this._unprocessedUpdateActions != null && this._unprocessedUpdateActions.Count > 0; 
        }

    }
}