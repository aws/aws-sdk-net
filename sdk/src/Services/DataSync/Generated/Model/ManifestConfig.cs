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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
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
        private ManifestAction _action;
        private ManifestFormat _format;
        private SourceManifestConfig _source;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// Specifies what DataSync uses the manifest for.
        /// </para>
        /// </summary>
        public ManifestAction Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// Specifies the file format of your manifest. For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/transferring-with-manifest.html#transferring-with-manifest-create">Creating
        /// a manifest</a>.
        /// </para>
        /// </summary>
        public ManifestFormat Format
        {
            get { return this._format; }
            set { this._format = value; }
        }

        // Check to see if Format property is set
        internal bool IsSetFormat()
        {
            return this._format != null;
        }

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
        public SourceManifestConfig Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

    }
}