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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property Asset. 
        /// <para>
        ///  The binary file, or asset, that is downloaded.
        /// </para>
        /// </summary>
        public Stream Asset { get; set; }

        /// <summary>
        /// Checks to see if the Asset property is set.
        /// </summary>
        internal bool IsSetAsset() => this.Asset != null;

        /// <summary>
        /// Gets and sets the property AssetName. 
        /// <para>
        ///  The name of the asset that is downloaded. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string AssetName { get; set; }

        /// <summary>
        /// Checks to see if the AssetName property is set.
        /// </summary>
        internal bool IsSetAssetName() => this.AssetName != null;

        /// <summary>
        /// Gets and sets the property PackageVersion. 
        /// <para>
        ///  A string that contains the package version (for example, <c>3.5.2</c>). 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string PackageVersion { get; set; }

        /// <summary>
        /// Checks to see if the PackageVersion property is set.
        /// </summary>
        internal bool IsSetPackageVersion() => this.PackageVersion != null;

        /// <summary>
        /// Gets and sets the property PackageVersionRevision. 
        /// <para>
        ///  The name of the package version revision that contains the downloaded asset. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public string PackageVersionRevision { get; set; }

        /// <summary>
        /// Checks to see if the PackageVersionRevision property is set.
        /// </summary>
        internal bool IsSetPackageVersionRevision() => this.PackageVersionRevision != null;

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
            {
                return;
            }

            if (disposing)
            {
                this.Asset?.Dispose();
                this.Asset = null;
            }

            this._disposed = true;
        }

        #endregion
    }
}
