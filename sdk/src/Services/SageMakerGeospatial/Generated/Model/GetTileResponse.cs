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
 * Do not modify this file. This file is generated from the sagemaker-geospatial-2020-05-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMakerGeospatial.Model
{
    /// <summary>
    /// This is the response object from the GetTile operation.
    /// </summary>
    public partial class GetTileResponse : AmazonWebServiceResponse, IDisposable
    {
        private Stream _binaryFile;

        /// <summary>
        /// Gets and sets the property BinaryFile. 
        /// <para>
        /// The output binary file.
        /// </para>
        /// </summary>
        public Stream BinaryFile
        {
            get { return this._binaryFile; }
            set { this._binaryFile = value; }
        }

        // Check to see if BinaryFile property is set
        internal bool IsSetBinaryFile()
        {
            return this._binaryFile != null;
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

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
            {
                this._binaryFile?.Dispose();
                this._binaryFile = null;
            }

            this._disposed = true;
         }

         #endregion
    }
}