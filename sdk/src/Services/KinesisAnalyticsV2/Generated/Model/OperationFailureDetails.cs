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
    /// Provides a description of the operation failure.
    /// </summary>
    public partial class OperationFailureDetails
    {
        private ErrorInfo _errorInfo;
        private string _rollbackOperationId;

        /// <summary>
        /// Gets and sets the property ErrorInfo.
        /// </summary>
        public ErrorInfo ErrorInfo
        {
            get { return this._errorInfo; }
            set { this._errorInfo = value; }
        }

        // Check to see if ErrorInfo property is set
        internal bool IsSetErrorInfo()
        {
            return this._errorInfo != null;
        }

        /// <summary>
        /// Gets and sets the property RollbackOperationId. 
        /// <para>
        /// The rollback operation ID of the system-rollback operation that executed due to failure
        /// in the current operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string RollbackOperationId
        {
            get { return this._rollbackOperationId; }
            set { this._rollbackOperationId = value; }
        }

        // Check to see if RollbackOperationId property is set
        internal bool IsSetRollbackOperationId()
        {
            return this._rollbackOperationId != null;
        }

    }
}