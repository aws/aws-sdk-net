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
 * Do not modify this file. This file is generated from the lakeformation-2017-03-31.normal.json service model.
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
namespace Amazon.LakeFormation.Model
{
    /// <summary>
    /// A structure for the output.
    /// </summary>
    public partial class GetWorkUnitResultsResponse : AmazonWebServiceResponse, IDisposable
    {
        private Stream _resultStream;

        /// <summary>
        /// Gets and sets the property ResultStream. 
        /// <para>
        /// Rows returned from the <c>GetWorkUnitResults</c> operation as a stream of Apache Arrow
        /// v1.0 messages.
        /// </para>
        /// </summary>
        public Stream ResultStream
        {
            get { return this._resultStream; }
            set { this._resultStream = value; }
        }

        // Check to see if ResultStream property is set
        internal bool IsSetResultStream()
        {
            return this._resultStream != null;
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
                this._resultStream?.Dispose();
                this._resultStream = null;
            }

            this._disposed = true;
         }

         #endregion
    }
}