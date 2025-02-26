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
 * Do not modify this file. This file is generated from the codeartifact-2018-09-22.normal.json service model.
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
namespace Amazon.CodeArtifact.Model
{
    /// <summary>
    /// This is the response object from the GetPackageVersionAsset operation.
    /// </summary>
    public partial class GetPackageVersionAssetResponse : AmazonWebServiceResponse, IDisposable
    {
        private Stream _asset;
        private string _assetName;
        private string _packageVersion;
        private string _packageVersionRevision;

        /// <summary>
        /// Gets and sets the property Asset. 
        /// <para>
        ///  The binary file, or asset, that is downloaded.
        /// </para>
        /// </summary>
        public Stream Asset
        {
            get { return this._asset; }
            set { this._asset = value; }
        }

        // Check to see if Asset property is set
        internal bool IsSetAsset()
        {
            return this._asset != null;
        }

        /// <summary>
        /// Gets and sets the property AssetName. 
        /// <para>
        ///  The name of the asset that is downloaded. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string AssetName
        {
            get { return this._assetName; }
            set { this._assetName = value; }
        }

        // Check to see if AssetName property is set
        internal bool IsSetAssetName()
        {
            return this._assetName != null;
        }

        /// <summary>
        /// Gets and sets the property PackageVersion. 
        /// <para>
        ///  A string that contains the package version (for example, <c>3.5.2</c>). 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string PackageVersion
        {
            get { return this._packageVersion; }
            set { this._packageVersion = value; }
        }

        // Check to see if PackageVersion property is set
        internal bool IsSetPackageVersion()
        {
            return this._packageVersion != null;
        }

        /// <summary>
        /// Gets and sets the property PackageVersionRevision. 
        /// <para>
        ///  The name of the package version revision that contains the downloaded asset. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public string PackageVersionRevision
        {
            get { return this._packageVersionRevision; }
            set { this._packageVersionRevision = value; }
        }

        // Check to see if PackageVersionRevision property is set
        internal bool IsSetPackageVersionRevision()
        {
            return this._packageVersionRevision != null;
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
                this._asset?.Dispose();
                this._asset = null;
            }

            this._disposed = true;
         }

         #endregion
    }
}