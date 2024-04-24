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
 * Do not modify this file. This file is generated from the workmailmessageflow-2019-05-01.normal.json service model.
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
namespace Amazon.WorkMailMessageFlow.Model
{
    /// <summary>
    /// This is the response object from the GetRawMessageContent operation.
    /// </summary>
    public partial class GetRawMessageContentResponse : AmazonWebServiceResponse, IDisposable
    {
        private Stream _messageContent;

        /// <summary>
        /// Gets and sets the property MessageContent. 
        /// <para>
        /// The raw content of the email message, in MIME format.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Stream MessageContent
        {
            get { return this._messageContent; }
            set { this._messageContent = value; }
        }

        // Check to see if MessageContent property is set
        internal bool IsSetMessageContent()
        {
            return this._messageContent != null;
        }

        #region Dispose Pattern

        private bool _disposed;

        /// <summary>
        /// Disposes of all managed and unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Disposes of all managed and unmanaged resources.
        /// </summary>
        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
            {
                this._messageContent?.Dispose();
                this._messageContent = null;
            }

            this._disposed = true;
         }

         #endregion
    }
}