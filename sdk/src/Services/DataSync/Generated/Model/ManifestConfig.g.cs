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

namespace Amazon.DataSync.Model
{
    /// <summary>
    /// Configures a manifest, which is a list of files or objects that you want DataSync
    /// to transfer. For more information and configuration examples, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/transferring-with-manifest.html">Specifying
    /// what DataSync transfers by using a manifest</a>.
    /// </summary>
    public partial class ManifestConfig
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// Specifies what DataSync uses the manifest for.
        /// </para>
        /// </summary>
        public ManifestAction Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// Specifies the file format of your manifest. For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/transferring-with-manifest.html#transferring-with-manifest-create">Creating
        /// a manifest</a>.
        /// </para>
        /// </summary>
        public ManifestFormat Format { get; set; }

        /// <summary>
        /// Checks to see if the Format property is set.
        /// </summary>
        internal bool IsSetFormat() => this.Format != null;

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// Specifies the manifest that you want DataSync to use and where it's hosted.
        /// </para>
        ///  <note> 
        /// <para>
        /// You must specify this parameter if you're configuring a new manifest on or after February
        /// 7, 2024.
        /// </para>
        ///  
        /// <para>
        /// If you don't, you'll get a 400 status code and <c>ValidationException</c> error stating
        /// that you're missing the IAM role for DataSync to access the S3 bucket where you're
        /// hosting your manifest. For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/transferring-with-manifest.html#transferring-with-manifest-access">Providing
        /// DataSync access to your manifest</a>.
        /// </para>
        ///  </note>
        /// </summary>
        public SourceManifestConfig Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;
    }
}
