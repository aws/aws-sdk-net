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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
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
namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteTransformer operation.
    /// Deletes the log transformer for the specified log group. As soon as you do this, the
    /// transformation of incoming log events according to that transformer stops. If this
    /// account has an account-level transformer that applies to this log group, the log group
    /// begins using that account-level transformer when this log-group level transformer
    /// is deleted.
    /// 
    ///  
    /// <para>
    /// After you delete a transformer, be sure to edit any metric filters or subscription
    /// filters that relied on the transformed versions of the log events.
    /// </para>
    /// </summary>
    public partial class DeleteTransformerRequest : AmazonCloudWatchLogsRequest
    {
        private string _logGroupIdentifier;

        /// <summary>
        /// Gets and sets the property LogGroupIdentifier. 
        /// <para>
        /// Specify either the name or ARN of the log group to delete the transformer for. If
        /// the log group is in a source account and you are using a monitoring account, you must
        /// use the log group ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string LogGroupIdentifier
        {
            get { return this._logGroupIdentifier; }
            set { this._logGroupIdentifier = value; }
        }

        // Check to see if LogGroupIdentifier property is set
        internal bool IsSetLogGroupIdentifier()
        {
            return this._logGroupIdentifier != null;
        }

    }
}