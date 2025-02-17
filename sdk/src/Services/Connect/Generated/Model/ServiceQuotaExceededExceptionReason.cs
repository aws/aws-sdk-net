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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// The reason for the exception.
    /// </summary>
    public partial class ServiceQuotaExceededExceptionReason
    {
        private AttachedFileServiceQuotaExceededExceptionReason _attachedFileServiceQuotaExceededExceptionReason;

        /// <summary>
        /// Gets and sets the property AttachedFileServiceQuotaExceededExceptionReason. 
        /// <para>
        /// Total file size of all files or total number of files exceeds the service quota
        /// </para>
        /// </summary>
        public AttachedFileServiceQuotaExceededExceptionReason AttachedFileServiceQuotaExceededExceptionReason
        {
            get { return this._attachedFileServiceQuotaExceededExceptionReason; }
            set { this._attachedFileServiceQuotaExceededExceptionReason = value; }
        }

        // Check to see if AttachedFileServiceQuotaExceededExceptionReason property is set
        internal bool IsSetAttachedFileServiceQuotaExceededExceptionReason()
        {
            return this._attachedFileServiceQuotaExceededExceptionReason != null;
        }

    }
}