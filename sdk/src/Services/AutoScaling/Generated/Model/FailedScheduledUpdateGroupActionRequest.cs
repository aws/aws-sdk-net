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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
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
namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Describes a scheduled action that could not be created, updated, or deleted.
    /// </summary>
    public partial class FailedScheduledUpdateGroupActionRequest
    {
        private string _errorCode;
        private string _errorMessage;
        private string _scheduledActionName;

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// The error code.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ErrorCode
        {
            get { return this._errorCode; }
            set { this._errorCode = value; }
        }

        // Check to see if ErrorCode property is set
        internal bool IsSetErrorCode()
        {
            return this._errorCode != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// The error message accompanying the error code.
        /// </para>
        /// </summary>
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduledActionName. 
        /// <para>
        /// The name of the scheduled action.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string ScheduledActionName
        {
            get { return this._scheduledActionName; }
            set { this._scheduledActionName = value; }
        }

        // Check to see if ScheduledActionName property is set
        internal bool IsSetScheduledActionName()
        {
            return this._scheduledActionName != null;
        }

    }
}